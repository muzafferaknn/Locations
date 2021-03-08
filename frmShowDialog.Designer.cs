namespace Locations
{
    partial class frmShowDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblAddressValue = new System.Windows.Forms.Label();
            this.lblNameValue = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblGsmValue = new System.Windows.Forms.Label();
            this.lblGsm = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAddress.ForeColor = System.Drawing.Color.Red;
            this.lblAddress.Location = new System.Drawing.Point(65, 44);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(75, 24);
            this.lblAddress.TabIndex = 0;
            this.lblAddress.Text = "Adres : ";
            // 
            // lblAddressValue
            // 
            this.lblAddressValue.AutoSize = true;
            this.lblAddressValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAddressValue.Location = new System.Drawing.Point(173, 44);
            this.lblAddressValue.Name = "lblAddressValue";
            this.lblAddressValue.Size = new System.Drawing.Size(20, 24);
            this.lblAddressValue.TabIndex = 1;
            this.lblAddressValue.Text = "0";
            // 
            // lblNameValue
            // 
            this.lblNameValue.AutoSize = true;
            this.lblNameValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNameValue.Location = new System.Drawing.Point(173, 79);
            this.lblNameValue.Name = "lblNameValue";
            this.lblNameValue.Size = new System.Drawing.Size(20, 24);
            this.lblNameValue.TabIndex = 3;
            this.lblNameValue.Text = "0";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblName.ForeColor = System.Drawing.Color.Red;
            this.lblName.Location = new System.Drawing.Point(65, 79);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(102, 24);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Ad Soyad :";
            // 
            // lblGsmValue
            // 
            this.lblGsmValue.AutoSize = true;
            this.lblGsmValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGsmValue.Location = new System.Drawing.Point(173, 115);
            this.lblGsmValue.Name = "lblGsmValue";
            this.lblGsmValue.Size = new System.Drawing.Size(20, 24);
            this.lblGsmValue.TabIndex = 5;
            this.lblGsmValue.Text = "0";
            // 
            // lblGsm
            // 
            this.lblGsm.AutoSize = true;
            this.lblGsm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGsm.ForeColor = System.Drawing.Color.Red;
            this.lblGsm.Location = new System.Drawing.Point(65, 115);
            this.lblGsm.Name = "lblGsm";
            this.lblGsm.Size = new System.Drawing.Size(64, 24);
            this.lblGsm.TabIndex = 4;
            this.lblGsm.Text = "Gsm : ";
            // 
            // frmShowDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 184);
            this.Controls.Add(this.lblGsmValue);
            this.Controls.Add(this.lblGsm);
            this.Controls.Add(this.lblNameValue);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblAddressValue);
            this.Controls.Add(this.lblAddress);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmShowDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İletişim Bilgileri";
            this.Load += new System.EventHandler(this.frmShowDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblAddressValue;
        private System.Windows.Forms.Label lblNameValue;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblGsmValue;
        private System.Windows.Forms.Label lblGsm;
    }
}