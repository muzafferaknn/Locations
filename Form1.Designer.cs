namespace Locations
{
    partial class Form1
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
            this.map = new GMap.NET.WindowsForms.GMapControl();
            this.btnAddress = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lbl23 = new System.Windows.Forms.Label();
            this.txtCurrentAddress = new System.Windows.Forms.TextBox();
            this.btnSaveStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReturnAddress = new System.Windows.Forms.Button();
            this.lblReturnStatus = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // map
            // 
            this.map.Bearing = 0F;
            this.map.CanDragMap = true;
            this.map.EmptyTileColor = System.Drawing.Color.Navy;
            this.map.GrayScaleMode = false;
            this.map.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.map.LevelsKeepInMemmory = 5;
            this.map.Location = new System.Drawing.Point(12, 12);
            this.map.MarkersEnabled = true;
            this.map.MaxZoom = 2;
            this.map.MinZoom = 2;
            this.map.MouseWheelZoomEnabled = true;
            this.map.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.map.Name = "map";
            this.map.NegativeMode = false;
            this.map.PolygonsEnabled = false;
            this.map.RetryLoadTile = 0;
            this.map.RoutesEnabled = true;
            this.map.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.map.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.map.ShowTileGridLines = false;
            this.map.Size = new System.Drawing.Size(726, 572);
            this.map.TabIndex = 0;
            this.map.Zoom = 0D;
            // 
            // btnAddress
            // 
            this.btnAddress.Location = new System.Drawing.Point(780, 226);
            this.btnAddress.Name = "btnAddress";
            this.btnAddress.Size = new System.Drawing.Size(112, 38);
            this.btnAddress.TabIndex = 20;
            this.btnAddress.Text = "Adres Ekle";
            this.btnAddress.UseVisualStyleBackColor = true;
            this.btnAddress.Click += new System.EventHandler(this.btnAddress_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 28;
            this.listBox1.Location = new System.Drawing.Point(903, 153);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(379, 172);
            this.listBox1.TabIndex = 19;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lbl23
            // 
            this.lbl23.AutoSize = true;
            this.lbl23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl23.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl23.Location = new System.Drawing.Point(780, 153);
            this.lbl23.Name = "lbl23";
            this.lbl23.Size = new System.Drawing.Size(112, 20);
            this.lbl23.TabIndex = 18;
            this.lbl23.Text = "Dağıtım Listesi";
            // 
            // txtCurrentAddress
            // 
            this.txtCurrentAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCurrentAddress.Location = new System.Drawing.Point(903, 22);
            this.txtCurrentAddress.Multiline = true;
            this.txtCurrentAddress.Name = "txtCurrentAddress";
            this.txtCurrentAddress.Size = new System.Drawing.Size(379, 81);
            this.txtCurrentAddress.TabIndex = 17;
            // 
            // btnSaveStart
            // 
            this.btnSaveStart.Location = new System.Drawing.Point(1183, 109);
            this.btnSaveStart.Name = "btnSaveStart";
            this.btnSaveStart.Size = new System.Drawing.Size(99, 38);
            this.btnSaveStart.TabIndex = 16;
            this.btnSaveStart.Text = "Kaydet";
            this.btnSaveStart.UseVisualStyleBackColor = true;
            this.btnSaveStart.Click += new System.EventHandler(this.btnSaveStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(770, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Başlangıç Adresi";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(898, 534);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(112, 38);
            this.btnCalculate.TabIndex = 23;
            this.btnCalculate.Text = "Hesapla";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStatus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblStatus.Location = new System.Drawing.Point(744, 286);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(104, 20);
            this.lblStatus.TabIndex = 24;
            this.lblStatus.Text = "toplam 34 km";
            this.lblStatus.Visible = false;
            // 
            // listBox2
            // 
            this.listBox2.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 28;
            this.listBox2.Location = new System.Drawing.Point(898, 342);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(379, 172);
            this.listBox2.TabIndex = 25;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(776, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Toplama Listesi";
            // 
            // btnReturnAddress
            // 
            this.btnReturnAddress.Location = new System.Drawing.Point(780, 407);
            this.btnReturnAddress.Name = "btnReturnAddress";
            this.btnReturnAddress.Size = new System.Drawing.Size(112, 38);
            this.btnReturnAddress.TabIndex = 27;
            this.btnReturnAddress.Text = "Adres Ekle";
            this.btnReturnAddress.UseVisualStyleBackColor = true;
            this.btnReturnAddress.Click += new System.EventHandler(this.btnReturnAddress_Click);
            // 
            // lblReturnStatus
            // 
            this.lblReturnStatus.AutoSize = true;
            this.lblReturnStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblReturnStatus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblReturnStatus.Location = new System.Drawing.Point(744, 494);
            this.lblReturnStatus.Name = "lblReturnStatus";
            this.lblReturnStatus.Size = new System.Drawing.Size(104, 20);
            this.lblReturnStatus.TabIndex = 28;
            this.lblReturnStatus.Text = "toplam 34 km";
            this.lblReturnStatus.Visible = false;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(1165, 534);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(112, 38);
            this.btnExport.TabIndex = 29;
            this.btnExport.Text = "Çıktı Al";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(1294, 596);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.lblReturnStatus);
            this.Controls.Add(this.btnReturnAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnAddress);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lbl23);
            this.Controls.Add(this.txtCurrentAddress);
            this.Controls.Add(this.btnSaveStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.map);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yol Hesaplama";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl map;
        private System.Windows.Forms.Button btnAddress;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lbl23;
        private System.Windows.Forms.TextBox txtCurrentAddress;
        private System.Windows.Forms.Button btnSaveStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnReturnAddress;
        private System.Windows.Forms.Label lblReturnStatus;
        private System.Windows.Forms.Button btnExport;
    }
}

