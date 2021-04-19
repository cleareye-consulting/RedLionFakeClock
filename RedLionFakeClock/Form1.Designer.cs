
namespace RedLionFakeClock
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.yardageNumeric = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.clockAddressNumeric = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.comAddressNumeric = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.yardageNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clockAddressNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comAddressNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yardage to display";
            // 
            // yardageNumeric
            // 
            this.yardageNumeric.Location = new System.Drawing.Point(13, 242);
            this.yardageNumeric.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.yardageNumeric.Minimum = new decimal(new int[] {
            32768,
            0,
            0,
            -2147483648});
            this.yardageNumeric.Name = "yardageNumeric";
            this.yardageNumeric.Size = new System.Drawing.Size(120, 36);
            this.yardageNumeric.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Clock Address";
            // 
            // clockAddressNumeric
            // 
            this.clockAddressNumeric.Location = new System.Drawing.Point(13, 47);
            this.clockAddressNumeric.Name = "clockAddressNumeric";
            this.clockAddressNumeric.Size = new System.Drawing.Size(120, 36);
            this.clockAddressNumeric.TabIndex = 3;
            this.clockAddressNumeric.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.clockAddressNumeric.ValueChanged += new System.EventHandler(this.clockAddressNumeric_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "COM Address";
            // 
            // comAddressNumeric
            // 
            this.comAddressNumeric.Location = new System.Drawing.Point(13, 140);
            this.comAddressNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.comAddressNumeric.Name = "comAddressNumeric";
            this.comAddressNumeric.Size = new System.Drawing.Size(120, 36);
            this.comAddressNumeric.TabIndex = 5;
            this.comAddressNumeric.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.comAddressNumeric.ValueChanged += new System.EventHandler(this.comAddressNumeric_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(216, 311);
            this.Controls.Add(this.comAddressNumeric);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.clockAddressNumeric);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.yardageNumeric);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "RedLion Fake Clock";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.yardageNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clockAddressNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comAddressNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown yardageNumeric;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown clockAddressNumeric;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown comAddressNumeric;
    }
}

