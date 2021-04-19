using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RedLionFakeClock
{
    public partial class Form1 : Form
    {

        private ComConnector comConnector;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateConnector();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (comConnector != null)
            {
                comConnector.Dispose();
            }
        }

        private void clockAddressNumeric_ValueChanged(object sender, EventArgs e)
        {
            if (comConnector != null)
            {
                comConnector.Dispose();
            }
            CreateConnector();
        }

        private void comAddressNumeric_ValueChanged(object sender, EventArgs e)
        {
            if (comConnector != null)
            {
                comConnector.Dispose();
            }
            CreateConnector();
        }

        private void CreateConnector()
        {
            try
            {                
                Func<int> getYardage = () =>
                {
                    int? yardage = null;
                    Action populateYardage = () => yardage = (int)yardageNumeric.Value;
                    Invoke(populateYardage);
                    return yardage ?? throw new InvalidOperationException("Unable to get yardage");
                };
                    
                comConnector = new ComConnector((int)clockAddressNumeric.Value, (int)comAddressNumeric.Value, getYardage);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

    }
}
