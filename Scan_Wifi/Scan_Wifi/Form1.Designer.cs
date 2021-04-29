namespace Scan_Wifi
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.imageSignalLevel = new System.Windows.Forms.ImageList(this.components);
            this.listView1 = new System.Windows.Forms.ListView();
            this.MAC_Address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SSID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Channel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Signal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Authentication = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Encryption = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RadioType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NetworkType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Speed = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnScan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // imageSignalLevel
            // 
            this.imageSignalLevel.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageSignalLevel.ImageStream")));
            this.imageSignalLevel.TransparentColor = System.Drawing.Color.Transparent;
            this.imageSignalLevel.Images.SetKeyName(0, "green16.bmp");
            this.imageSignalLevel.Images.SetKeyName(1, "yellow16.bmp");
            this.imageSignalLevel.Images.SetKeyName(2, "orange16.bmp");
            this.imageSignalLevel.Images.SetKeyName(3, "red16.bmp");
            this.imageSignalLevel.Images.SetKeyName(4, "darkred16.bmp");
            this.imageSignalLevel.Images.SetKeyName(5, "grey16.bmp");
            // 
            // listView1
            // 
            this.listView1.AllowColumnReorder = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MAC_Address,
            this.SSID,
            this.Channel,
            this.Signal,
            this.Authentication,
            this.Encryption,
            this.RadioType,
            this.NetworkType,
            this.Speed});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(1, 2);
            this.listView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1334, 442);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // MAC_Address
            // 
            this.MAC_Address.Text = "Địa chỉ MAC";
            this.MAC_Address.Width = 165;
            // 
            // SSID
            // 
            this.SSID.Text = "SSID-Tên wifi";
            this.SSID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SSID.Width = 178;
            // 
            // Channel
            // 
            this.Channel.Text = "Kênh";
            this.Channel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Signal
            // 
            this.Signal.Text = "Tín hiệu";
            this.Signal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Signal.Width = 75;
            // 
            // Authentication
            // 
            this.Authentication.Text = "Chứng thực";
            this.Authentication.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Authentication.Width = 105;
            // 
            // Encryption
            // 
            this.Encryption.Text = "Mã hóa";
            this.Encryption.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Encryption.Width = 135;
            // 
            // RadioType
            // 
            this.RadioType.Text = "Chuẩn kết nối wifi";
            this.RadioType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.RadioType.Width = 91;
            // 
            // NetworkType
            // 
            this.NetworkType.Text = "Loại mạng";
            this.NetworkType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NetworkType.Width = 142;
            // 
            // Speed
            // 
            this.Speed.Text = "Tốc độ";
            this.Speed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Speed.Width = 130;
            // 
            // btnScan
            // 
            this.btnScan.Location = new System.Drawing.Point(1235, 452);
            this.btnScan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(100, 28);
            this.btnScan.TabIndex = 2;
            this.btnScan.Text = "Dò tìm";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1342, 484);
            this.Controls.Add(this.btnScan);
            this.Controls.Add(this.listView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Quét Wifi lân cận";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ImageList imageSignalLevel;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader MAC_Address;
        private System.Windows.Forms.ColumnHeader SSID;
        private System.Windows.Forms.ColumnHeader Channel;
        private System.Windows.Forms.ColumnHeader Signal;
        private System.Windows.Forms.ColumnHeader Authentication;
        private System.Windows.Forms.ColumnHeader Encryption;
        private System.Windows.Forms.ColumnHeader RadioType;
        private System.Windows.Forms.ColumnHeader NetworkType;
        private System.Windows.Forms.ColumnHeader Speed;
        private System.Windows.Forms.Button btnScan;
    }
   
}

