namespace DATN_QuanTri
{
    partial class frmNhapHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhapHang));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtdongianhap = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.btnCapnhat = new DevExpress.XtraEditors.SimpleButton();
            this.cbo_phieunhap = new System.Windows.Forms.ComboBox();
            this.cbomausac_ctpn = new System.Windows.Forms.ComboBox();
            this.cbomahang = new System.Windows.Forms.ComboBox();
            this.btnLuu_ctpn = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua_ctpn = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem_ctpn = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.txtsoluong = new DevExpress.XtraEditors.TextEdit();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.cbomaphieudat = new System.Windows.Forms.ComboBox();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cbomancc_pn = new System.Windows.Forms.ComboBox();
            this.cbmanv_pn = new System.Windows.Forms.ComboBox();
            this.btnLuu_pn = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua_pn = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem_pn = new DevExpress.XtraEditors.SimpleButton();
            this.cbotinhtrang_pn = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtmapn_pn = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txttongtien_pn = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdongianhap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsoluong.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbotinhtrang_pn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmapn_pn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttongtien_pn.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gridControl1);
            this.groupBox2.Controls.Add(this.txtdongianhap);
            this.groupBox2.Controls.Add(this.labelControl5);
            this.groupBox2.Controls.Add(this.btnCapnhat);
            this.groupBox2.Controls.Add(this.cbo_phieunhap);
            this.groupBox2.Controls.Add(this.cbomausac_ctpn);
            this.groupBox2.Controls.Add(this.cbomahang);
            this.groupBox2.Controls.Add(this.btnLuu_ctpn);
            this.groupBox2.Controls.Add(this.btnSua_ctpn);
            this.groupBox2.Controls.Add(this.btnThem_ctpn);
            this.groupBox2.Controls.Add(this.labelControl15);
            this.groupBox2.Controls.Add(this.txtsoluong);
            this.groupBox2.Controls.Add(this.labelControl14);
            this.groupBox2.Controls.Add(this.labelControl13);
            this.groupBox2.Controls.Add(this.labelControl11);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(590, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(523, 365);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết phiếu nhập";
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(6, 147);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(514, 212);
            this.gridControl1.TabIndex = 38;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click_1);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridView1_RowCellStyle_1);
            // 
            // txtdongianhap
            // 
            this.txtdongianhap.Location = new System.Drawing.Point(400, 44);
            this.txtdongianhap.Name = "txtdongianhap";
            this.txtdongianhap.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdongianhap.Properties.Appearance.Options.UseFont = true;
            this.txtdongianhap.Size = new System.Drawing.Size(113, 22);
            this.txtdongianhap.TabIndex = 36;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(286, 49);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(100, 21);
            this.labelControl5.TabIndex = 37;
            this.labelControl5.Text = "Đơn giá nhập";
            // 
            // btnCapnhat
            // 
            this.btnCapnhat.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapnhat.Appearance.Options.UseFont = true;
            this.btnCapnhat.ImageOptions.Image = global::DATN_QuanTri.Properties.Resources.refresh_32x32;
            this.btnCapnhat.Location = new System.Drawing.Point(141, 104);
            this.btnCapnhat.Name = "btnCapnhat";
            this.btnCapnhat.Size = new System.Drawing.Size(120, 37);
            this.btnCapnhat.TabIndex = 35;
            this.btnCapnhat.Text = "Cập nhật";
            this.btnCapnhat.Click += new System.EventHandler(this.btnCapnhat_Click);
            // 
            // cbo_phieunhap
            // 
            this.cbo_phieunhap.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_phieunhap.FormattingEnabled = true;
            this.cbo_phieunhap.Location = new System.Drawing.Point(149, 16);
            this.cbo_phieunhap.Name = "cbo_phieunhap";
            this.cbo_phieunhap.Size = new System.Drawing.Size(125, 23);
            this.cbo_phieunhap.TabIndex = 20;
            // 
            // cbomausac_ctpn
            // 
            this.cbomausac_ctpn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbomausac_ctpn.FormattingEnabled = true;
            this.cbomausac_ctpn.Location = new System.Drawing.Point(149, 77);
            this.cbomausac_ctpn.Name = "cbomausac_ctpn";
            this.cbomausac_ctpn.Size = new System.Drawing.Size(127, 23);
            this.cbomausac_ctpn.TabIndex = 34;
            // 
            // cbomahang
            // 
            this.cbomahang.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbomahang.FormattingEnabled = true;
            this.cbomahang.Location = new System.Drawing.Point(149, 48);
            this.cbomahang.Name = "cbomahang";
            this.cbomahang.Size = new System.Drawing.Size(125, 23);
            this.cbomahang.TabIndex = 33;
            this.cbomahang.SelectedIndexChanged += new System.EventHandler(this.cbomahang_SelectedIndexChanged);
            // 
            // btnLuu_ctpn
            // 
            this.btnLuu_ctpn.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu_ctpn.Appearance.Options.UseFont = true;
            this.btnLuu_ctpn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu_ctpn.ImageOptions.Image")));
            this.btnLuu_ctpn.Location = new System.Drawing.Point(400, 104);
            this.btnLuu_ctpn.Name = "btnLuu_ctpn";
            this.btnLuu_ctpn.Size = new System.Drawing.Size(92, 37);
            this.btnLuu_ctpn.TabIndex = 23;
            this.btnLuu_ctpn.Text = "Lưu";
            this.btnLuu_ctpn.Click += new System.EventHandler(this.btnLuu_ctpn_Click);
            // 
            // btnSua_ctpn
            // 
            this.btnSua_ctpn.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua_ctpn.Appearance.Options.UseFont = true;
            this.btnSua_ctpn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua_ctpn.ImageOptions.Image")));
            this.btnSua_ctpn.Location = new System.Drawing.Point(286, 104);
            this.btnSua_ctpn.Name = "btnSua_ctpn";
            this.btnSua_ctpn.Size = new System.Drawing.Size(92, 37);
            this.btnSua_ctpn.TabIndex = 22;
            this.btnSua_ctpn.Text = "Sửa";
            // 
            // btnThem_ctpn
            // 
            this.btnThem_ctpn.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem_ctpn.Appearance.Options.UseFont = true;
            this.btnThem_ctpn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem_ctpn.ImageOptions.Image")));
            this.btnThem_ctpn.Location = new System.Drawing.Point(31, 104);
            this.btnThem_ctpn.Name = "btnThem_ctpn";
            this.btnThem_ctpn.Size = new System.Drawing.Size(92, 37);
            this.btnThem_ctpn.TabIndex = 20;
            this.btnThem_ctpn.Text = "Thêm";
            this.btnThem_ctpn.Click += new System.EventHandler(this.btnThem_ctpn_Click);
            // 
            // labelControl15
            // 
            this.labelControl15.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl15.Appearance.Options.UseFont = true;
            this.labelControl15.Location = new System.Drawing.Point(22, 76);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(63, 21);
            this.labelControl15.TabIndex = 24;
            this.labelControl15.Text = "Màu sắc";
            // 
            // txtsoluong
            // 
            this.txtsoluong.Location = new System.Drawing.Point(400, 14);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsoluong.Properties.Appearance.Options.UseFont = true;
            this.txtsoluong.Size = new System.Drawing.Size(113, 22);
            this.txtsoluong.TabIndex = 18;
            this.txtsoluong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsoluong_KeyPress);
            // 
            // labelControl14
            // 
            this.labelControl14.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl14.Appearance.Options.UseFont = true;
            this.labelControl14.Location = new System.Drawing.Point(286, 19);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(68, 21);
            this.labelControl14.TabIndex = 22;
            this.labelControl14.Text = "Số lượng";
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl13.Appearance.Options.UseFont = true;
            this.labelControl13.Location = new System.Drawing.Point(21, 48);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(72, 21);
            this.labelControl13.TabIndex = 20;
            this.labelControl13.Text = "Hàng hóa";
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(21, 22);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(110, 21);
            this.labelControl11.TabIndex = 1;
            this.labelControl11.Text = "Mã phiếu nhập";
            // 
            // cbomaphieudat
            // 
            this.cbomaphieudat.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbomaphieudat.FormattingEnabled = true;
            this.cbomaphieudat.Location = new System.Drawing.Point(137, 47);
            this.cbomaphieudat.Name = "cbomaphieudat";
            this.cbomaphieudat.Size = new System.Drawing.Size(138, 23);
            this.cbomaphieudat.TabIndex = 20;
            this.cbomaphieudat.SelectedIndexChanged += new System.EventHandler(this.cbomaphieudat_SelectedIndexChanged);
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl12.Appearance.Options.UseFont = true;
            this.labelControl12.Location = new System.Drawing.Point(21, 53);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(69, 21);
            this.labelControl12.TabIndex = 3;
            this.labelControl12.Text = "Phiếu đặt";
            this.labelControl12.Click += new System.EventHandler(this.labelControl12_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gridControl2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.cbomancc_pn);
            this.groupBox1.Controls.Add(this.cbmanv_pn);
            this.groupBox1.Controls.Add(this.btnLuu_pn);
            this.groupBox1.Controls.Add(this.cbomaphieudat);
            this.groupBox1.Controls.Add(this.btnSua_pn);
            this.groupBox1.Controls.Add(this.btnThem_pn);
            this.groupBox1.Controls.Add(this.cbotinhtrang_pn);
            this.groupBox1.Controls.Add(this.txtmapn_pn);
            this.groupBox1.Controls.Add(this.labelControl9);
            this.groupBox1.Controls.Add(this.labelControl12);
            this.groupBox1.Controls.Add(this.labelControl4);
            this.groupBox1.Controls.Add(this.labelControl3);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(9, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(575, 405);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phiếu nhập";
            // 
            // gridControl2
            // 
            this.gridControl2.Location = new System.Drawing.Point(11, 146);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(558, 253);
            this.gridControl2.TabIndex = 37;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            this.gridControl2.Click += new System.EventHandler(this.gridControl2_Click_1);
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridView2_RowCellStyle_1);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(417, 45);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(136, 29);
            this.dateTimePicker1.TabIndex = 36;
            // 
            // cbomancc_pn
            // 
            this.cbomancc_pn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbomancc_pn.FormattingEnabled = true;
            this.cbomancc_pn.Location = new System.Drawing.Point(417, 19);
            this.cbomancc_pn.Name = "cbomancc_pn";
            this.cbomancc_pn.Size = new System.Drawing.Size(136, 23);
            this.cbomancc_pn.TabIndex = 19;
            // 
            // cbmanv_pn
            // 
            this.cbmanv_pn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbmanv_pn.FormattingEnabled = true;
            this.cbmanv_pn.Location = new System.Drawing.Point(137, 76);
            this.cbmanv_pn.Name = "cbmanv_pn";
            this.cbmanv_pn.Size = new System.Drawing.Size(138, 23);
            this.cbmanv_pn.TabIndex = 18;
            // 
            // btnLuu_pn
            // 
            this.btnLuu_pn.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu_pn.Appearance.Options.UseFont = true;
            this.btnLuu_pn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu_pn.ImageOptions.Image")));
            this.btnLuu_pn.Location = new System.Drawing.Point(390, 107);
            this.btnLuu_pn.Name = "btnLuu_pn";
            this.btnLuu_pn.Size = new System.Drawing.Size(92, 34);
            this.btnLuu_pn.TabIndex = 14;
            this.btnLuu_pn.Text = "Lưu";
            this.btnLuu_pn.Click += new System.EventHandler(this.btnLuu_pn_Click);
            // 
            // btnSua_pn
            // 
            this.btnSua_pn.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua_pn.Appearance.Options.UseFont = true;
            this.btnSua_pn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua_pn.ImageOptions.Image")));
            this.btnSua_pn.Location = new System.Drawing.Point(260, 106);
            this.btnSua_pn.Name = "btnSua_pn";
            this.btnSua_pn.Size = new System.Drawing.Size(92, 34);
            this.btnSua_pn.TabIndex = 13;
            this.btnSua_pn.Text = "Sửa";
            // 
            // btnThem_pn
            // 
            this.btnThem_pn.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem_pn.Appearance.Options.UseFont = true;
            this.btnThem_pn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem_pn.ImageOptions.Image")));
            this.btnThem_pn.Location = new System.Drawing.Point(130, 107);
            this.btnThem_pn.Name = "btnThem_pn";
            this.btnThem_pn.Size = new System.Drawing.Size(92, 34);
            this.btnThem_pn.TabIndex = 11;
            this.btnThem_pn.Text = "Thêm";
            this.btnThem_pn.Click += new System.EventHandler(this.btnThem_pn_Click);
            // 
            // cbotinhtrang_pn
            // 
            this.cbotinhtrang_pn.Location = new System.Drawing.Point(417, 79);
            this.cbotinhtrang_pn.Name = "cbotinhtrang_pn";
            this.cbotinhtrang_pn.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbotinhtrang_pn.Properties.Appearance.Options.UseFont = true;
            this.cbotinhtrang_pn.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbotinhtrang_pn.Properties.Items.AddRange(new object[] {
            "Mới ",
            "Đang xử lý",
            "Hoàn thành"});
            this.cbotinhtrang_pn.Size = new System.Drawing.Size(136, 22);
            this.cbotinhtrang_pn.TabIndex = 9;
            // 
            // txtmapn_pn
            // 
            this.txtmapn_pn.Location = new System.Drawing.Point(137, 19);
            this.txtmapn_pn.Name = "txtmapn_pn";
            this.txtmapn_pn.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmapn_pn.Properties.Appearance.Options.UseFont = true;
            this.txtmapn_pn.Size = new System.Drawing.Size(140, 22);
            this.txtmapn_pn.TabIndex = 1;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(281, 80);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(78, 21);
            this.labelControl9.TabIndex = 8;
            this.labelControl9.Text = "Tình trạng";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(283, 49);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(80, 21);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Ngày nhập";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(21, 81);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(74, 21);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Nhân viên";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(283, 21);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(103, 21);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Nhà cung cấp";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(21, 28);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(110, 21);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mã phiếu nhập";
            // 
            // txttongtien_pn
            // 
            this.txttongtien_pn.Location = new System.Drawing.Point(686, 389);
            this.txttongtien_pn.Name = "txttongtien_pn";
            this.txttongtien_pn.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttongtien_pn.Properties.Appearance.Options.UseFont = true;
            this.txttongtien_pn.Size = new System.Drawing.Size(140, 22);
            this.txttongtien_pn.TabIndex = 10;
            this.txttongtien_pn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttongtien_pn_KeyPress);
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(598, 388);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(71, 21);
            this.labelControl10.TabIndex = 17;
            this.labelControl10.Text = "Tổng tiền";
            // 
            // btnThoat
            // 
            this.btnThoat.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Appearance.Options.UseFont = true;
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.Location = new System.Drawing.Point(1021, 378);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(92, 37);
            this.btnThoat.TabIndex = 24;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1122, 423);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txttongtien_pn);
            this.Controls.Add(this.labelControl10);
            this.Name = "frmNhapHang";
            this.Text = "Quản Lý Nhập Hàng";
            this.Load += new System.EventHandler(this.frmNhapHang_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdongianhap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsoluong.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbotinhtrang_pn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmapn_pn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttongtien_pn.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.SimpleButton btnLuu_ctpn;
        private DevExpress.XtraEditors.SimpleButton btnSua_ctpn;
        private DevExpress.XtraEditors.SimpleButton btnThem_ctpn;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.TextEdit txtsoluong;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SimpleButton btnLuu_pn;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.SimpleButton btnSua_pn;
        private DevExpress.XtraEditors.SimpleButton btnThem_pn;
        private DevExpress.XtraEditors.TextEdit txttongtien_pn;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.ComboBoxEdit cbotinhtrang_pn;
        private DevExpress.XtraEditors.TextEdit txtmapn_pn;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.ComboBox cbmanv_pn;
        private System.Windows.Forms.ComboBox cbomahang;
        private System.Windows.Forms.ComboBox cbomausac_ctpn;
        private System.Windows.Forms.ComboBox cbo_phieunhap;
        private DevExpress.XtraEditors.SimpleButton btnCapnhat;
        private System.Windows.Forms.ComboBox cbomaphieudat;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.TextEdit txtdongianhap;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.ComboBox cbomancc_pn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
    }
}