namespace DATN_QuanTri
{
    partial class frmPhieuGiao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhieuGiao));
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.cbonvgiao = new System.Windows.Forms.ComboBox();
            this.cbomahd = new System.Windows.Forms.ComboBox();
            this.date_ngaygiao = new System.Windows.Forms.DateTimePicker();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtsdtnguoinhan = new DevExpress.XtraEditors.TextEdit();
            this.labelControl18 = new DevExpress.XtraEditors.LabelControl();
            this.txtTennguoinhan = new DevExpress.XtraEditors.TextEdit();
            this.labelControl17 = new DevExpress.XtraEditors.LabelControl();
            this.txtsdtnguoigiao = new DevExpress.XtraEditors.TextEdit();
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.btnLuu_pg = new DevExpress.XtraEditors.SimpleButton();
            this.txtdiachi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.cbo_tinhtrang = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtmaphieugiao = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsdtnguoinhan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTennguoinhan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsdtnguoigiao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdiachi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_tinhtrang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmaphieugiao.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Appearance.Options.UseFont = true;
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.Location = new System.Drawing.Point(537, 105);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(92, 37);
            this.btnThoat.TabIndex = 27;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.cbonvgiao);
            this.groupBox1.Controls.Add(this.cbomahd);
            this.groupBox1.Controls.Add(this.date_ngaygiao);
            this.groupBox1.Controls.Add(this.gridControl1);
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.txtsdtnguoinhan);
            this.groupBox1.Controls.Add(this.labelControl18);
            this.groupBox1.Controls.Add(this.txtTennguoinhan);
            this.groupBox1.Controls.Add(this.labelControl17);
            this.groupBox1.Controls.Add(this.txtsdtnguoigiao);
            this.groupBox1.Controls.Add(this.labelControl16);
            this.groupBox1.Controls.Add(this.btnLuu_pg);
            this.groupBox1.Controls.Add(this.txtdiachi);
            this.groupBox1.Controls.Add(this.labelControl10);
            this.groupBox1.Controls.Add(this.cbo_tinhtrang);
            this.groupBox1.Controls.Add(this.txtmaphieugiao);
            this.groupBox1.Controls.Add(this.labelControl9);
            this.groupBox1.Controls.Add(this.labelControl4);
            this.groupBox1.Controls.Add(this.labelControl3);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(8, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(895, 415);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phiếu giao";
            // 
            // btnThem
            // 
            this.btnThem.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Appearance.Options.UseFont = true;
            this.btnThem.ImageOptions.Image = global::DATN_QuanTri.Properties.Resources.add_32x321;
            this.btnThem.Location = new System.Drawing.Point(276, 105);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(92, 37);
            this.btnThem.TabIndex = 37;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // cbonvgiao
            // 
            this.cbonvgiao.FormattingEnabled = true;
            this.cbonvgiao.Location = new System.Drawing.Point(130, 44);
            this.cbonvgiao.Name = "cbonvgiao";
            this.cbonvgiao.Size = new System.Drawing.Size(140, 29);
            this.cbonvgiao.TabIndex = 36;
            this.cbonvgiao.SelectedIndexChanged += new System.EventHandler(this.cbonvgiao_SelectedIndexChanged);
            // 
            // cbomahd
            // 
            this.cbomahd.FormattingEnabled = true;
            this.cbomahd.Location = new System.Drawing.Point(130, 79);
            this.cbomahd.Name = "cbomahd";
            this.cbomahd.Size = new System.Drawing.Size(140, 29);
            this.cbomahd.TabIndex = 35;
            this.cbomahd.SelectedIndexChanged += new System.EventHandler(this.cbomahd_SelectedIndexChanged);
            // 
            // date_ngaygiao
            // 
            this.date_ngaygiao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_ngaygiao.Location = new System.Drawing.Point(418, 18);
            this.date_ngaygiao.Name = "date_ngaygiao";
            this.date_ngaygiao.Size = new System.Drawing.Size(140, 29);
            this.date_ngaygiao.TabIndex = 34;
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(22, 153);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(591, 256);
            this.gridControl1.TabIndex = 32;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridView1_RowCellStyle);
            // 
            // txtsdtnguoinhan
            // 
            this.txtsdtnguoinhan.Location = new System.Drawing.Point(735, 32);
            this.txtsdtnguoinhan.Name = "txtsdtnguoinhan";
            this.txtsdtnguoinhan.Size = new System.Drawing.Size(140, 20);
            this.txtsdtnguoinhan.TabIndex = 30;
            // 
            // labelControl18
            // 
            this.labelControl18.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl18.Appearance.Options.UseFont = true;
            this.labelControl18.Location = new System.Drawing.Point(593, 28);
            this.labelControl18.Name = "labelControl18";
            this.labelControl18.Size = new System.Drawing.Size(124, 21);
            this.labelControl18.TabIndex = 31;
            this.labelControl18.Text = "SĐT người nhận";
            // 
            // txtTennguoinhan
            // 
            this.txtTennguoinhan.Location = new System.Drawing.Point(735, 58);
            this.txtTennguoinhan.Name = "txtTennguoinhan";
            this.txtTennguoinhan.Size = new System.Drawing.Size(140, 20);
            this.txtTennguoinhan.TabIndex = 28;
            // 
            // labelControl17
            // 
            this.labelControl17.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl17.Appearance.Options.UseFont = true;
            this.labelControl17.Location = new System.Drawing.Point(593, 56);
            this.labelControl17.Name = "labelControl17";
            this.labelControl17.Size = new System.Drawing.Size(86, 21);
            this.labelControl17.TabIndex = 29;
            this.labelControl17.Text = "Người nhận";
            // 
            // txtsdtnguoigiao
            // 
            this.txtsdtnguoigiao.Location = new System.Drawing.Point(418, 79);
            this.txtsdtnguoigiao.Name = "txtsdtnguoigiao";
            this.txtsdtnguoigiao.Size = new System.Drawing.Size(140, 20);
            this.txtsdtnguoigiao.TabIndex = 26;
            // 
            // labelControl16
            // 
            this.labelControl16.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl16.Appearance.Options.UseFont = true;
            this.labelControl16.Location = new System.Drawing.Point(288, 79);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(103, 21);
            this.labelControl16.TabIndex = 27;
            this.labelControl16.Text = "Số điện thoại ";
            // 
            // btnLuu_pg
            // 
            this.btnLuu_pg.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu_pg.Appearance.Options.UseFont = true;
            this.btnLuu_pg.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu_pg.ImageOptions.Image")));
            this.btnLuu_pg.Location = new System.Drawing.Point(406, 105);
            this.btnLuu_pg.Name = "btnLuu_pg";
            this.btnLuu_pg.Size = new System.Drawing.Size(92, 37);
            this.btnLuu_pg.TabIndex = 14;
            this.btnLuu_pg.Text = "Lưu";
            this.btnLuu_pg.Click += new System.EventHandler(this.btnLuu_pg_Click);
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(735, 84);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(140, 20);
            this.txtdiachi.TabIndex = 10;
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(593, 82);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(91, 21);
            this.labelControl10.TabIndex = 17;
            this.labelControl10.Text = "Địa chỉ giao";
            // 
            // cbo_tinhtrang
            // 
            this.cbo_tinhtrang.Location = new System.Drawing.Point(418, 53);
            this.cbo_tinhtrang.Name = "cbo_tinhtrang";
            this.cbo_tinhtrang.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbo_tinhtrang.Size = new System.Drawing.Size(140, 20);
            this.cbo_tinhtrang.TabIndex = 9;
            // 
            // txtmaphieugiao
            // 
            this.txtmaphieugiao.Location = new System.Drawing.Point(130, 20);
            this.txtmaphieugiao.Name = "txtmaphieugiao";
            this.txtmaphieugiao.Size = new System.Drawing.Size(140, 20);
            this.txtmaphieugiao.TabIndex = 1;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(291, 56);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(78, 21);
            this.labelControl9.TabIndex = 8;
            this.labelControl9.Text = "Tình trạng";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(288, 27);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(75, 21);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Ngày giao";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(11, 55);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(104, 21);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Tên nhân viên";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(11, 82);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(90, 21);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Mã hóa đơn";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(11, 28);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(105, 21);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mã phiếu giao";
            // 
            // frmPhieuGiao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1087, 430);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPhieuGiao";
            this.Text = "Quản Lý Phiếu Giao";
            this.Load += new System.EventHandler(this.frmPhieuGiao_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsdtnguoinhan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTennguoinhan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsdtnguoigiao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdiachi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_tinhtrang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmaphieugiao.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SimpleButton btnLuu_pg;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.ComboBoxEdit cbo_tinhtrang;
        private DevExpress.XtraEditors.TextEdit txtmaphieugiao;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtsdtnguoigiao;
        private DevExpress.XtraEditors.LabelControl labelControl16;
        private DevExpress.XtraEditors.LabelControl labelControl17;
        private DevExpress.XtraEditors.LabelControl labelControl18;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.DateTimePicker date_ngaygiao;
        private System.Windows.Forms.ComboBox cbomahd;
        private System.Windows.Forms.ComboBox cbonvgiao;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.TextEdit txtsdtnguoinhan;
        private DevExpress.XtraEditors.TextEdit txtTennguoinhan;
        private DevExpress.XtraEditors.TextEdit txtdiachi;
    }
}