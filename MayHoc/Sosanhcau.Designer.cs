namespace MayHoc
{
    partial class Sosanhcau
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
            this.components = new System.ComponentModel.Container();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txtDuongDan = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.bttachtu = new DevComponents.DotNetBar.ButtonX();
            this.btchonfile = new DevComponents.DotNetBar.ButtonX();
            this.bttachcau = new DevComponents.DotNetBar.ButtonX();
            this.bthuy = new DevComponents.DotNetBar.ButtonX();
            this.txtContent = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.listViewEx1 = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.DSCau = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txtcau1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btcau1 = new DevComponents.DotNetBar.ButtonX();
            this.btcau2 = new DevComponents.DotNetBar.ButtonX();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbkequa1 = new DevComponents.DotNetBar.LabelX();
            this.buttonX3 = new DevComponents.DotNetBar.ButtonX();
            this.btnExit = new DevComponents.DotNetBar.ButtonX();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new DevComponents.DotNetBar.ButtonX();
            this.lbKetQua = new DevComponents.DotNetBar.LabelX();
            this.btsosanh = new DevComponents.DotNetBar.ButtonX();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtcau2 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.progressPanel1 = new DevExpress.XtraWaitForm.ProgressPanel();
            this.STT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightGray;
            this.groupBox2.Controls.Add(this.labelX1);
            this.groupBox2.Controls.Add(this.txtDuongDan);
            this.groupBox2.Controls.Add(this.bttachtu);
            this.groupBox2.Controls.Add(this.btchonfile);
            this.groupBox2.Controls.Add(this.bttachcau);
            this.groupBox2.Controls.Add(this.bthuy);
            this.groupBox2.Controls.Add(this.txtContent);
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(304, 493);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nhập vào văn bản";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelX1.Location = new System.Drawing.Point(6, 21);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(186, 23);
            this.labelX1.TabIndex = 4;
            this.labelX1.Text = "Chọn file từ máy";
            // 
            // txtDuongDan
            // 
            this.txtDuongDan.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtDuongDan.Border.Class = "TextBoxBorder";
            this.txtDuongDan.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDuongDan.DisabledBackColor = System.Drawing.Color.White;
            this.txtDuongDan.ForeColor = System.Drawing.Color.Black;
            this.txtDuongDan.Location = new System.Drawing.Point(5, 50);
            this.txtDuongDan.Name = "txtDuongDan";
            this.txtDuongDan.PreventEnterBeep = true;
            this.txtDuongDan.ReadOnly = true;
            this.txtDuongDan.Size = new System.Drawing.Size(246, 20);
            this.txtDuongDan.TabIndex = 0;
            // 
            // bttachtu
            // 
            this.bttachtu.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bttachtu.Location = new System.Drawing.Point(0, 0);
            this.bttachtu.Name = "bttachtu";
            this.bttachtu.Size = new System.Drawing.Size(0, 0);
            this.bttachtu.TabIndex = 5;
            // 
            // btchonfile
            // 
            this.btchonfile.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btchonfile.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btchonfile.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btchonfile.Image = global::MayHoc.Properties.Resources.folder;
            this.btchonfile.Location = new System.Drawing.Point(254, 40);
            this.btchonfile.Name = "btchonfile";
            this.btchonfile.Size = new System.Drawing.Size(40, 37);
            this.btchonfile.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btchonfile.TabIndex = 3;
            this.btchonfile.Click += new System.EventHandler(this.btchonfile_Click);
            // 
            // bttachcau
            // 
            this.bttachcau.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bttachcau.BackColor = System.Drawing.Color.Silver;
            this.bttachcau.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.bttachcau.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bttachcau.Image = global::MayHoc.Properties.Resources.accept;
            this.bttachcau.Location = new System.Drawing.Point(137, 448);
            this.bttachcau.Name = "bttachcau";
            this.bttachcau.Size = new System.Drawing.Size(114, 39);
            this.bttachcau.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bttachcau.TabIndex = 2;
            this.bttachcau.Text = "Tách câu";
            this.bttachcau.Click += new System.EventHandler(this.bttachcau_Click);
            // 
            // bthuy
            // 
            this.bthuy.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bthuy.BackColor = System.Drawing.Color.Silver;
            this.bthuy.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.bthuy.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bthuy.Image = global::MayHoc.Properties.Resources.delete;
            this.bthuy.Location = new System.Drawing.Point(25, 448);
            this.bthuy.Name = "bthuy";
            this.bthuy.Size = new System.Drawing.Size(106, 39);
            this.bthuy.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bthuy.TabIndex = 2;
            this.bthuy.Text = "Hủy";
            this.bthuy.Click += new System.EventHandler(this.bthuy_Click);
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
            this.txtContent.Location = new System.Drawing.Point(5, 76);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.PreventEnterBeep = true;
            this.txtContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtContent.Size = new System.Drawing.Size(292, 366);
            this.txtContent.TabIndex = 1;
            this.txtContent.WatermarkText = "Nhập vào văn bản...";
            // 
            // listViewEx1
            // 
            this.listViewEx1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.listViewEx1.Border.Class = "ListViewBorder";
            this.listViewEx1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.listViewEx1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.STT,
            this.DSCau});
            this.listViewEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.listViewEx1.ForeColor = System.Drawing.Color.Black;
            this.listViewEx1.FullRowSelect = true;
            this.listViewEx1.GridLines = true;
            this.listViewEx1.Location = new System.Drawing.Point(6, 19);
            this.listViewEx1.Name = "listViewEx1";
            this.listViewEx1.ShowGroups = false;
            this.listViewEx1.ShowItemToolTips = true;
            this.listViewEx1.Size = new System.Drawing.Size(608, 271);
            this.listViewEx1.TabIndex = 13;
            this.listViewEx1.UseCompatibleStateImageBehavior = false;
            this.listViewEx1.View = System.Windows.Forms.View.Details;
            // 
            // DSCau
            // 
            this.DSCau.Text = "Danh sách câu trong văn bản";
            this.DSCau.Width = 550;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelX2.Location = new System.Drawing.Point(17, 19);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(71, 23);
            this.labelX2.TabIndex = 12;
            this.labelX2.Text = "Câu thứ nhất";
            // 
            // txtcau1
            // 
            this.txtcau1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtcau1.Border.Class = "TextBoxBorder";
            this.txtcau1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtcau1.DisabledBackColor = System.Drawing.Color.White;
            this.txtcau1.ForeColor = System.Drawing.Color.Black;
            this.txtcau1.Location = new System.Drawing.Point(94, 19);
            this.txtcau1.Multiline = true;
            this.txtcau1.Name = "txtcau1";
            this.txtcau1.PreventEnterBeep = true;
            this.txtcau1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtcau1.Size = new System.Drawing.Size(512, 43);
            this.txtcau1.TabIndex = 11;
            this.txtcau1.WatermarkText = "Câu thứ nhất...";
            // 
            // btcau1
            // 
            this.btcau1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btcau1.BackColor = System.Drawing.Color.LightSlateGray;
            this.btcau1.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btcau1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btcau1.Location = new System.Drawing.Point(624, 174);
            this.btcau1.Name = "btcau1";
            this.btcau1.Size = new System.Drawing.Size(109, 39);
            this.btcau1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btcau1.Symbol = "";
            this.btcau1.TabIndex = 14;
            this.btcau1.Text = "Chọn làm câu thứ nhất";
            this.btcau1.TextColor = System.Drawing.Color.Black;
            this.btcau1.Click += new System.EventHandler(this.btcau1_Click);
            // 
            // btcau2
            // 
            this.btcau2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btcau2.BackColor = System.Drawing.Color.SlateGray;
            this.btcau2.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btcau2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btcau2.Location = new System.Drawing.Point(624, 240);
            this.btcau2.Name = "btcau2";
            this.btcau2.Size = new System.Drawing.Size(109, 39);
            this.btcau2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btcau2.Symbol = "";
            this.btcau2.SymbolColor = System.Drawing.Color.Black;
            this.btcau2.TabIndex = 15;
            this.btcau2.Text = "Chọn làm câu thứ hai";
            this.btcau2.TextColor = System.Drawing.Color.Black;
            this.btcau2.Click += new System.EventHandler(this.btcau2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightGray;
            this.groupBox1.Controls.Add(this.lbkequa1);
            this.groupBox1.Controls.Add(this.buttonX3);
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.btcau1);
            this.groupBox1.Controls.Add(this.btcau2);
            this.groupBox1.Controls.Add(this.listViewEx1);
            this.groupBox1.Location = new System.Drawing.Point(323, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(753, 493);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // lbkequa1
            // 
            // 
            // 
            // 
            this.lbkequa1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbkequa1.Location = new System.Drawing.Point(0, 0);
            this.lbkequa1.Name = "lbkequa1";
            this.lbkequa1.Size = new System.Drawing.Size(0, 0);
            this.lbkequa1.TabIndex = 0;
            // 
            // buttonX3
            // 
            this.buttonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX3.Location = new System.Drawing.Point(0, 0);
            this.buttonX3.Name = "buttonX3";
            this.buttonX3.Size = new System.Drawing.Size(0, 0);
            this.buttonX3.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnExit.Location = new System.Drawing.Point(647, 363);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(86, 47);
            this.btnExit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnExit.TabIndex = 22;
            this.btnExit.Text = "Thoát";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnRefresh);
            this.groupBox4.Controls.Add(this.lbKetQua);
            this.groupBox4.Controls.Add(this.btsosanh);
            this.groupBox4.Location = new System.Drawing.Point(6, 422);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(610, 65);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnRefresh.BackColor = System.Drawing.Color.SlateGray;
            this.btnRefresh.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnRefresh.Image = global::MayHoc.Properties.Resources._new;
            this.btnRefresh.Location = new System.Drawing.Point(29, 19);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(106, 40);
            this.btnRefresh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnRefresh.TabIndex = 23;
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click_1);
            // 
            // lbKetQua
            // 
            // 
            // 
            // 
            this.lbKetQua.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbKetQua.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.lbKetQua.ForeColor = System.Drawing.Color.Black;
            this.lbKetQua.Location = new System.Drawing.Point(336, 19);
            this.lbKetQua.Name = "lbKetQua";
            this.lbKetQua.Size = new System.Drawing.Size(272, 40);
            this.lbKetQua.TabIndex = 22;
            this.lbKetQua.Text = "Kết quả:";
            // 
            // btsosanh
            // 
            this.btsosanh.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btsosanh.BackColor = System.Drawing.Color.SlateGray;
            this.btsosanh.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btsosanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btsosanh.Image = global::MayHoc.Properties.Resources.refresh;
            this.btsosanh.Location = new System.Drawing.Point(181, 19);
            this.btsosanh.Name = "btsosanh";
            this.btsosanh.Size = new System.Drawing.Size(102, 40);
            this.btsosanh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btsosanh.TabIndex = 20;
            this.btsosanh.Text = "So sánh";
            this.btsosanh.Click += new System.EventHandler(this.btsosanh_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.labelX2);
            this.groupBox3.Controls.Add(this.txtcau2);
            this.groupBox3.Controls.Add(this.txtcau1);
            this.groupBox3.Controls.Add(this.labelX3);
            this.groupBox3.Location = new System.Drawing.Point(6, 296);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(612, 120);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            // 
            // txtcau2
            // 
            this.txtcau2.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtcau2.Border.Class = "TextBoxBorder";
            this.txtcau2.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtcau2.DisabledBackColor = System.Drawing.Color.White;
            this.txtcau2.ForeColor = System.Drawing.Color.Black;
            this.txtcau2.Location = new System.Drawing.Point(94, 68);
            this.txtcau2.Multiline = true;
            this.txtcau2.Name = "txtcau2";
            this.txtcau2.PreventEnterBeep = true;
            this.txtcau2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtcau2.Size = new System.Drawing.Size(512, 46);
            this.txtcau2.TabIndex = 16;
            this.txtcau2.WatermarkText = "Câu  thứ hai...";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelX3.Location = new System.Drawing.Point(17, 68);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(71, 23);
            this.labelX3.TabIndex = 17;
            this.labelX3.Text = "Câu thứ hai";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // progressPanel1
            // 
            this.progressPanel1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.progressPanel1.Appearance.Options.UseBackColor = true;
            this.progressPanel1.AppearanceCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.progressPanel1.AppearanceCaption.Options.UseFont = true;
            this.progressPanel1.AppearanceDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.progressPanel1.AppearanceDescription.Options.UseFont = true;
            this.progressPanel1.Description = "Đang tách câu. .  .";
            this.progressPanel1.Location = new System.Drawing.Point(569, 177);
            this.progressPanel1.Name = "progressPanel1";
            this.progressPanel1.Size = new System.Drawing.Size(164, 97);
            this.progressPanel1.TabIndex = 23;
            this.progressPanel1.Text = "progressPanel1";
            // 
            // STT
            // 
            this.STT.Text = global::MayHoc.Properties.Settings.Default.Chao;
            this.STT.Width = 54;
            // 
            // Sosanhcau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.progressPanel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Sosanhcau";
            this.Size = new System.Drawing.Size(1079, 512);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDuongDan;
        private DevComponents.DotNetBar.ButtonX btchonfile;
        private DevComponents.DotNetBar.ButtonX bttachcau;
        private DevComponents.DotNetBar.ButtonX bthuy;
        private DevComponents.DotNetBar.Controls.TextBoxX txtContent;
        protected internal DevComponents.DotNetBar.Controls.ListViewEx listViewEx1;
        private System.Windows.Forms.ColumnHeader STT;
        private System.Windows.Forms.ColumnHeader DSCau;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtcau1;
        private DevComponents.DotNetBar.ButtonX btcau1;
        private DevComponents.DotNetBar.ButtonX btcau2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevComponents.DotNetBar.Controls.TextBoxX txtcau2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DevComponents.DotNetBar.ButtonX btsosanh;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private DevComponents.DotNetBar.ButtonX btnExit;
        private DevComponents.DotNetBar.ButtonX bttachtu;
        private DevComponents.DotNetBar.ButtonX buttonX3;
        private DevComponents.DotNetBar.LabelX lbkequa1;
        private DevComponents.DotNetBar.LabelX lbKetQua;
        private DevComponents.DotNetBar.ButtonX btnRefresh;
        private DevExpress.XtraWaitForm.ProgressPanel progressPanel1;
    }
}
