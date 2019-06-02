namespace DATN_QuanTri
{
    partial class frmDatHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDatHang));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cbomancc = new System.Windows.Forms.ComboBox();
            this.cboManv = new System.Windows.Forms.ComboBox();
            this.cbotinhtrang = new System.Windows.Forms.ComboBox();
            this.btnLuu_pd = new DevExpress.XtraEditors.SimpleButton();
            this.btnsua_pd = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem_pd = new DevExpress.XtraEditors.SimpleButton();
            this.txtmapd_pd = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txttongtien = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCapnhat = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cbomapd = new System.Windows.Forms.ComboBox();
            this.cbohanghoa = new System.Windows.Forms.ComboBox();
            this.cboMausac_ctpd = new System.Windows.Forms.ComboBox();
            this.btnLuu_ctpd = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua_ctpd = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem_ctpd = new DevExpress.XtraEditors.SimpleButton();
            this.txtgianhap_ctpd = new DevExpress.XtraEditors.TextEdit();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.txtsoluong_ctpd = new DevExpress.XtraEditors.TextEdit();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnTongtien = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmapd_pd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttongtien.Properties)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtgianhap_ctpd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsoluong_ctpd.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gridControl2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.cbomancc);
            this.groupBox1.Controls.Add(this.cboManv);
            this.groupBox1.Controls.Add(this.cbotinhtrang);
            this.groupBox1.Controls.Add(this.btnLuu_pd);
            this.groupBox1.Controls.Add(this.btnsua_pd);
            this.groupBox1.Controls.Add(this.btnThem_pd);
            this.groupBox1.Controls.Add(this.txtmapd_pd);
            this.groupBox1.Controls.Add(this.labelControl9);
            this.groupBox1.Controls.Add(this.labelControl4);
            this.groupBox1.Controls.Add(this.labelControl3);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(592, 416);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phiếu đặt";
            // 
            // gridControl2
            // 
            this.gridControl2.Location = new System.Drawing.Point(6, 162);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(573, 242);
            this.gridControl2.TabIndex = 34;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            this.gridControl2.Click += new System.EventHandler(this.gridControl2_Click);
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(439, 23);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(140, 22);
            this.dateTimePicker1.TabIndex = 18;
            // 
            // cbomancc
            // 
            this.cbomancc.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbomancc.FormattingEnabled = true;
            this.cbomancc.Location = new System.Drawing.Point(168, 84);
            this.cbomancc.Name = "cbomancc";
            this.cbomancc.Size = new System.Drawing.Size(140, 23);
            this.cbomancc.TabIndex = 3;
            // 
            // cboManv
            // 
            this.cboManv.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboManv.FormattingEnabled = true;
            this.cboManv.Location = new System.Drawing.Point(168, 51);
            this.cboManv.Name = "cboManv";
            this.cboManv.Size = new System.Drawing.Size(140, 23);
            this.cboManv.TabIndex = 2;
            // 
            // cbotinhtrang
            // 
            this.cbotinhtrang.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbotinhtrang.FormattingEnabled = true;
            this.cbotinhtrang.Items.AddRange(new object[] {
            "Mới",
            "Hoàn thành",
            "Đang xử lý",
            "Hết hàng"});
            this.cbotinhtrang.Location = new System.Drawing.Point(439, 52);
            this.cbotinhtrang.Name = "cbotinhtrang";
            this.cbotinhtrang.Size = new System.Drawing.Size(140, 23);
            this.cbotinhtrang.TabIndex = 5;
            // 
            // btnLuu_pd
            // 
            this.btnLuu_pd.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu_pd.Appearance.Options.UseFont = true;
            this.btnLuu_pd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu_pd.ImageOptions.Image")));
            this.btnLuu_pd.Location = new System.Drawing.Point(423, 119);
            this.btnLuu_pd.Name = "btnLuu_pd";
            this.btnLuu_pd.Size = new System.Drawing.Size(92, 37);
            this.btnLuu_pd.TabIndex = 9;
            this.btnLuu_pd.Text = "Lưu";
            this.btnLuu_pd.Click += new System.EventHandler(this.btnLuu_pd_Click);
            // 
            // btnsua_pd
            // 
            this.btnsua_pd.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsua_pd.Appearance.Options.UseFont = true;
            this.btnsua_pd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnsua_pd.ImageOptions.Image")));
            this.btnsua_pd.Location = new System.Drawing.Point(293, 118);
            this.btnsua_pd.Name = "btnsua_pd";
            this.btnsua_pd.Size = new System.Drawing.Size(92, 37);
            this.btnsua_pd.TabIndex = 8;
            this.btnsua_pd.Text = "Sửa";
            this.btnsua_pd.Click += new System.EventHandler(this.btnsua_pd_Click);
            // 
            // btnThem_pd
            // 
            this.btnThem_pd.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem_pd.Appearance.Options.UseFont = true;
            this.btnThem_pd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem_pd.ImageOptions.Image")));
            this.btnThem_pd.Location = new System.Drawing.Point(164, 118);
            this.btnThem_pd.Name = "btnThem_pd";
            this.btnThem_pd.Size = new System.Drawing.Size(92, 37);
            this.btnThem_pd.TabIndex = 7;
            this.btnThem_pd.Text = "Thêm";
            this.btnThem_pd.Click += new System.EventHandler(this.btnThem_pd_Click);
            // 
            // txtmapd_pd
            // 
            this.txtmapd_pd.Location = new System.Drawing.Point(168, 23);
            this.txtmapd_pd.Name = "txtmapd_pd";
            this.txtmapd_pd.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmapd_pd.Properties.Appearance.Options.UseFont = true;
            this.txtmapd_pd.Size = new System.Drawing.Size(140, 22);
            this.txtmapd_pd.TabIndex = 1;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(335, 57);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(78, 21);
            this.labelControl9.TabIndex = 8;
            this.labelControl9.Text = "Tình trạng";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(332, 31);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(67, 21);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Ngày đặt";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(22, 59);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(99, 21);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Mã nhân viên";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(22, 86);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(128, 21);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Mã nhà cung cấp";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(22, 32);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(97, 21);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mã phiếu đặt";
            // 
            // txttongtien
            // 
            this.txttongtien.Location = new System.Drawing.Point(128, 435);
            this.txttongtien.Name = "txttongtien";
            this.txttongtien.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttongtien.Properties.Appearance.Options.UseFont = true;
            this.txttongtien.Size = new System.Drawing.Size(140, 22);
            this.txttongtien.TabIndex = 6;
            this.txttongtien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttongtien_KeyPress);
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(25, 439);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(71, 21);
            this.labelControl10.TabIndex = 17;
            this.labelControl10.Text = "Tổng tiền";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCapnhat);
            this.groupBox2.Controls.Add(this.gridControl1);
            this.groupBox2.Controls.Add(this.cbomapd);
            this.groupBox2.Controls.Add(this.cbohanghoa);
            this.groupBox2.Controls.Add(this.cboMausac_ctpd);
            this.groupBox2.Controls.Add(this.btnLuu_ctpd);
            this.groupBox2.Controls.Add(this.btnSua_ctpd);
            this.groupBox2.Controls.Add(this.btnThem_ctpd);
            this.groupBox2.Controls.Add(this.txtgianhap_ctpd);
            this.groupBox2.Controls.Add(this.labelControl15);
            this.groupBox2.Controls.Add(this.txtsoluong_ctpd);
            this.groupBox2.Controls.Add(this.labelControl14);
            this.groupBox2.Controls.Add(this.labelControl13);
            this.groupBox2.Controls.Add(this.labelControl12);
            this.groupBox2.Controls.Add(this.labelControl11);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(610, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(489, 409);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết phiếu đặt";
            // 
            // btnCapnhat
            // 
            this.btnCapnhat.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapnhat.Appearance.Options.UseFont = true;
            this.btnCapnhat.ImageOptions.Image = global::DATN_QuanTri.Properties.Resources.refresh_32x32;
            this.btnCapnhat.Location = new System.Drawing.Point(125, 110);
            this.btnCapnhat.Name = "btnCapnhat";
            this.btnCapnhat.Size = new System.Drawing.Size(120, 37);
            this.btnCapnhat.TabIndex = 34;
            this.btnCapnhat.Text = "Cập nhật";
            this.btnCapnhat.Click += new System.EventHandler(this.btnCapnhat_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(5, 154);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(477, 242);
            this.gridControl1.TabIndex = 33;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click_1);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridView1_RowCellStyle);
            // 
            // cbomapd
            // 
            this.cbomapd.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbomapd.FormattingEnabled = true;
            this.cbomapd.Location = new System.Drawing.Point(125, 25);
            this.cbomapd.Name = "cbomapd";
            this.cbomapd.Size = new System.Drawing.Size(140, 23);
            this.cbomapd.TabIndex = 32;
            // 
            // cbohanghoa
            // 
            this.cbohanghoa.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbohanghoa.FormattingEnabled = true;
            this.cbohanghoa.Location = new System.Drawing.Point(125, 54);
            this.cbohanghoa.Name = "cbohanghoa";
            this.cbohanghoa.Size = new System.Drawing.Size(140, 23);
            this.cbohanghoa.TabIndex = 2;
            // 
            // cboMausac_ctpd
            // 
            this.cboMausac_ctpd.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMausac_ctpd.FormattingEnabled = true;
            this.cboMausac_ctpd.Location = new System.Drawing.Point(125, 82);
            this.cboMausac_ctpd.Name = "cboMausac_ctpd";
            this.cboMausac_ctpd.Size = new System.Drawing.Size(140, 23);
            this.cboMausac_ctpd.TabIndex = 3;
            // 
            // btnLuu_ctpd
            // 
            this.btnLuu_ctpd.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu_ctpd.Appearance.Options.UseFont = true;
            this.btnLuu_ctpd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu_ctpd.ImageOptions.Image")));
            this.btnLuu_ctpd.Location = new System.Drawing.Point(363, 108);
            this.btnLuu_ctpd.Name = "btnLuu_ctpd";
            this.btnLuu_ctpd.Size = new System.Drawing.Size(92, 37);
            this.btnLuu_ctpd.TabIndex = 8;
            this.btnLuu_ctpd.Text = "Lưu";
            this.btnLuu_ctpd.Click += new System.EventHandler(this.btnLuu_ctpd_Click);
            // 
            // btnSua_ctpd
            // 
            this.btnSua_ctpd.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua_ctpd.Appearance.Options.UseFont = true;
            this.btnSua_ctpd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua_ctpd.ImageOptions.Image")));
            this.btnSua_ctpd.Location = new System.Drawing.Point(259, 108);
            this.btnSua_ctpd.Name = "btnSua_ctpd";
            this.btnSua_ctpd.Size = new System.Drawing.Size(92, 37);
            this.btnSua_ctpd.TabIndex = 7;
            this.btnSua_ctpd.Text = "Sửa";
            this.btnSua_ctpd.Click += new System.EventHandler(this.btnSua_ctpd_Click_1);
            // 
            // btnThem_ctpd
            // 
            this.btnThem_ctpd.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem_ctpd.Appearance.Options.UseFont = true;
            this.btnThem_ctpd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem_ctpd.ImageOptions.Image")));
            this.btnThem_ctpd.Location = new System.Drawing.Point(22, 110);
            this.btnThem_ctpd.Name = "btnThem_ctpd";
            this.btnThem_ctpd.Size = new System.Drawing.Size(92, 37);
            this.btnThem_ctpd.TabIndex = 6;
            this.btnThem_ctpd.Text = "Thêm";
            this.btnThem_ctpd.Click += new System.EventHandler(this.btnThem_ctpd_Click);
            // 
            // txtgianhap_ctpd
            // 
            this.txtgianhap_ctpd.Location = new System.Drawing.Point(354, 51);
            this.txtgianhap_ctpd.Name = "txtgianhap_ctpd";
            this.txtgianhap_ctpd.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgianhap_ctpd.Properties.Appearance.Options.UseFont = true;
            this.txtgianhap_ctpd.Size = new System.Drawing.Size(120, 22);
            this.txtgianhap_ctpd.TabIndex = 5;
            this.txtgianhap_ctpd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtgianhap_ctpd_KeyPress);
            // 
            // labelControl15
            // 
            this.labelControl15.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl15.Appearance.Options.UseFont = true;
            this.labelControl15.Location = new System.Drawing.Point(271, 52);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(67, 21);
            this.labelControl15.TabIndex = 24;
            this.labelControl15.Text = "Giá nhập";
            // 
            // txtsoluong_ctpd
            // 
            this.txtsoluong_ctpd.Location = new System.Drawing.Point(354, 24);
            this.txtsoluong_ctpd.Name = "txtsoluong_ctpd";
            this.txtsoluong_ctpd.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsoluong_ctpd.Properties.Appearance.Options.UseFont = true;
            this.txtsoluong_ctpd.Size = new System.Drawing.Size(120, 22);
            this.txtsoluong_ctpd.TabIndex = 4;
            this.txtsoluong_ctpd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsoluong_ctpd_KeyPress);
            // 
            // labelControl14
            // 
            this.labelControl14.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl14.Appearance.Options.UseFont = true;
            this.labelControl14.Location = new System.Drawing.Point(271, 25);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(68, 21);
            this.labelControl14.TabIndex = 22;
            this.labelControl14.Text = "Số lượng";
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl13.Appearance.Options.UseFont = true;
            this.labelControl13.Location = new System.Drawing.Point(22, 83);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(63, 21);
            this.labelControl13.TabIndex = 20;
            this.labelControl13.Text = "Màu sắc";
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl12.Appearance.Options.UseFont = true;
            this.labelControl12.Location = new System.Drawing.Point(22, 56);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(97, 21);
            this.labelControl12.TabIndex = 3;
            this.labelControl12.Text = "Mã hàng hóa";
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(22, 29);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(97, 21);
            this.labelControl11.TabIndex = 1;
            this.labelControl11.Text = "Mã phiếu đặt";
            // 
            // btnThoat
            // 
            this.btnThoat.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Appearance.Options.UseFont = true;
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.Location = new System.Drawing.Point(989, 427);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(95, 36);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnTongtien
            // 
            this.btnTongtien.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTongtien.Appearance.Options.UseFont = true;
            this.btnTongtien.ImageOptions.Image = global::DATN_QuanTri.Properties.Resources.currency_32x32;
            this.btnTongtien.Location = new System.Drawing.Point(291, 427);
            this.btnTongtien.Name = "btnTongtien";
            this.btnTongtien.Size = new System.Drawing.Size(120, 37);
            this.btnTongtien.TabIndex = 32;
            this.btnTongtien.Text = "Tính tiền";
            this.btnTongtien.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // frmDatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1113, 477);
            this.Controls.Add(this.btnTongtien);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txttongtien);
            this.Controls.Add(this.labelControl10);
            this.Name = "frmDatHang";
            this.Text = "Đặt hàng nhà cung cấp";
            this.Load += new System.EventHandler(this.frmDatHang_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmapd_pd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttongtien.Properties)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtgianhap_ctpd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsoluong_ctpd.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit txtmapd_pd;
        private DevExpress.XtraEditors.TextEdit txttongtien;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.TextEdit txtgianhap_ctpd;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.TextEdit txtsoluong_ctpd;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.SimpleButton btnLuu_pd;
        private DevExpress.XtraEditors.SimpleButton btnsua_pd;
        private DevExpress.XtraEditors.SimpleButton btnThem_pd;
        private DevExpress.XtraEditors.SimpleButton btnLuu_ctpd;
        private DevExpress.XtraEditors.SimpleButton btnSua_ctpd;
        private DevExpress.XtraEditors.SimpleButton btnThem_ctpd;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private System.Windows.Forms.ComboBox cbotinhtrang;
        private System.Windows.Forms.ComboBox cbomancc;
        private System.Windows.Forms.ComboBox cboManv;
        private System.Windows.Forms.ComboBox cboMausac_ctpd;
        private System.Windows.Forms.ComboBox cbohanghoa;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cbomapd;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.SimpleButton btnCapnhat;
        private DevExpress.XtraEditors.SimpleButton btnTongtien;
    }
}