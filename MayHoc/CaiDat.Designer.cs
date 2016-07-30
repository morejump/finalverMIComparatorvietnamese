namespace MayHoc
{
    partial class CaiDat
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtChonFile = new DevComponents.DotNetBar.ButtonX();
            this.txtTuDung = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.groupbox2 = new System.Windows.Forms.GroupBox();
            this.txtContent = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btOK = new DevComponents.DotNetBar.ButtonX();
            this.btHuy = new DevComponents.DotNetBar.ButtonX();
            this.groupBox1.SuspendLayout();
            this.groupbox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightGray;
            this.groupBox1.Controls.Add(this.txtTuDung);
            this.groupBox1.Controls.Add(this.BtChonFile);
            this.groupBox1.Location = new System.Drawing.Point(210, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(615, 148);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn thư viện file từ dừng:";
            // 
            // BtChonFile
            // 
            this.BtChonFile.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BtChonFile.BackColor = System.Drawing.Color.LightGray;
            this.BtChonFile.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BtChonFile.Image = global::MayHoc.Properties.Resources.folder;
            this.BtChonFile.Location = new System.Drawing.Point(556, 25);
            this.BtChonFile.Name = "BtChonFile";
            this.BtChonFile.Size = new System.Drawing.Size(40, 40);
            this.BtChonFile.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BtChonFile.TabIndex = 2;
            this.BtChonFile.Click += new System.EventHandler(this.buttonX2_Click);
            // 
            // txtTuDung
            // 
            this.txtTuDung.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtTuDung.Border.Class = "TextBoxBorder";
            this.txtTuDung.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTuDung.DisabledBackColor = System.Drawing.Color.White;
            this.txtTuDung.ForeColor = System.Drawing.Color.Black;
            this.txtTuDung.Location = new System.Drawing.Point(18, 36);
            this.txtTuDung.Name = "txtTuDung";
            this.txtTuDung.PreventEnterBeep = true;
            this.txtTuDung.Size = new System.Drawing.Size(532, 26);
            this.txtTuDung.TabIndex = 3;
            // 
            // groupbox2
            // 
            this.groupbox2.BackColor = System.Drawing.Color.White;
            this.groupbox2.Controls.Add(this.btHuy);
            this.groupbox2.Controls.Add(this.btOK);
            this.groupbox2.Controls.Add(this.txtContent);
            this.groupbox2.Location = new System.Drawing.Point(269, 12);
            this.groupbox2.Name = "groupbox2";
            this.groupbox2.Size = new System.Drawing.Size(460, 462);
            this.groupbox2.TabIndex = 1;
            this.groupbox2.TabStop = false;
            this.groupbox2.Text = "File: ";
            // 
            // txtContent
            // 
            this.txtContent.AllowDrop = true;
            this.txtContent.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtContent.Border.Class = "TextBoxBorder";
            this.txtContent.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtContent.DisabledBackColor = System.Drawing.Color.White;
            this.txtContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContent.ForeColor = System.Drawing.Color.Black;
            this.txtContent.Location = new System.Drawing.Point(27, 43);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.PreventEnterBeep = true;
            this.txtContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtContent.Size = new System.Drawing.Size(427, 338);
            this.txtContent.TabIndex = 2;
            this.txtContent.WatermarkText = "Nhập vào văn bản...";
            // 
            // btOK
            // 
            this.btOK.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btOK.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btOK.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btOK.Image = global::MayHoc.Properties.Resources.accept;
            this.btOK.Location = new System.Drawing.Point(82, 403);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(97, 40);
            this.btOK.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btOK.TabIndex = 3;
            this.btOK.Text = "OK";
            this.btOK.Click += new System.EventHandler(this.buttonX1_Click_2);
            // 
            // btHuy
            // 
            this.btHuy.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btHuy.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btHuy.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btHuy.Image = global::MayHoc.Properties.Resources.delete;
            this.btHuy.Location = new System.Drawing.Point(281, 403);
            this.btHuy.Name = "btHuy";
            this.btHuy.Size = new System.Drawing.Size(107, 40);
            this.btHuy.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btHuy.TabIndex = 4;
            this.btHuy.Text = "Hủy";
            this.btHuy.Click += new System.EventHandler(this.buttonX3_Click);
            // 
            // CaiDat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(this.groupbox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CaiDat";
            this.Size = new System.Drawing.Size(1079, 512);
            this.Load += new System.EventHandler(this.CaiDat_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupbox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.ButtonX BtChonFile;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTuDung;
        private System.Windows.Forms.GroupBox groupbox2;
        private DevComponents.DotNetBar.ButtonX btOK;
        private DevComponents.DotNetBar.Controls.TextBoxX txtContent;
        private DevComponents.DotNetBar.ButtonX btHuy;
    }
}
