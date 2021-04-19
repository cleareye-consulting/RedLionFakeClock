using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RedLionFakeClock
{
    internal class ComConnector : IDisposable
    {
        private readonly SerialPort port;
        private readonly int clockAddress;
        private readonly Func<int> getYardage;

        internal ComConnector(int clockAddress, int portNumber, Func<int> getYardage)
        {
            port = new SerialPort($"COM{portNumber}");
            port.Open();
            port.DataReceived += Port_DataReceived;
            this.clockAddress = clockAddress;
            this.getYardage = getYardage;
        }

        private static readonly Regex dataPattern = new Regex(@"^N(?<clockAddress>\d{2})(?<message>[^*]+)\*$");

        private void Port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            var buffer = new byte[port.BytesToRead];
            port.Read(buffer, 0, port.BytesToRead);
            var match = dataPattern.Match(Encoding.ASCII.GetString(buffer));
            if (!match.Success)
            {
                return;
            }
            var requestedClockAddress = int.Parse(match.Groups["clockAddress"].Value);
            if (requestedClockAddress != clockAddress)
            {
                return;
            }
            var requestMessage = match.Groups["message"].Value;
            if (requestMessage != "TC")
            {
                return;
            }
            var yardage = getYardage();
            string response = $"{clockAddress:D2}  CNT  {(yardage < 0 ? '-' : ' ')} {Math.Abs(yardage):D6}\r\n";
            port.Write(response);
        }

        public void Dispose()
        {
            ((IDisposable)port).Dispose();
        }
    }
}
