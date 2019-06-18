using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using System.Data.SqlClient;
namespace DATN_QuanTri
{
    public partial class frmKhuyenMai : Form
    {
        public frmKhuyenMai()
        {
            InitializeComponent();
        }
        int flag_Them, flag_Them_ctkm = 0;
        int Luu_ctkm,flag_Sua_ctkm = 0;
        KhuyenMai_BLL km = new KhuyenMai_BLL();
        HangHoa_BLL hh = new HangHoa_BLL();
        MauSac_BLL ms = new MauSac_BLL();

        CTKhuyenMai_BLL ctkm = new CTKhuyenMai_BLL();
        string chuoikn = @"Data Source=DESKTOP-KAM5FCS\SQLEXPRESS;Initial Catalog=VATLIEULOTSAN;Integrated Security=True";
        public string tangmaTuDong()
        {
            string sql = "select * from KHUYENMAI";
            SqlConnection con = new SqlConnection();
            con.ConnectionString = chuoikn;
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            string ma = "";
            if (dt.Rows.Count <= 0)
            {
                ma = "KM001" + DateTime.Now.ToShortDateString();
            }
            else
            {
                int k;
                ma = "KM";
                k = Convert.ToInt32(dt.Rows[dt.Rows.Count - 1][0].ToString().Substring(2, 3));
                k = k + 1;
                if (k < 10)
                {
                    ma = ma + "00";
                }
                else if (k < 100)
                {
                    ma = ma + "0";
                }
                ma = ma + k.ToString() + DateTime.Now.ToShortDateString();
            }
            return ma;
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (r == DialogResult.OK)
                this.Close();
        }
        public void doDL(ComboBox cb, DataTable db, String dis, String value)
        {
            cb.DataSource = db;
            cb.DisplayMember = dis;
            cb.ValueMember = value;
        }
        private void frmKhuyenMai_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = km.loadDL();
            txtmakm.Text = tangmaTuDong();
            btnLuu.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnThem_ctkm.Enabled=btnSua_ctkm.Enabled=true;
            txtmakm.Enabled = txttenkm.Enabled = cboloaikm.Enabled = date_ngaybd.Enabled = date_ngaykt.Enabled = false;
            txtgiagiam.Enabled = comboBox1.Enabled = txtsoluong.Enabled = cbohang.Enabled = cboHangtang.Enabled = cbomau.Enabled = false;
            btnLuu_ctkm.Enabled = true;
            gridControl2.DataSource = ctkm.loadDL();
            doDL(comboBox1, km.loadDL(), "MAKM", "TENKM");
            doDL(cbohang, hh.loadDL(), "MAHANG", "TENHANG");
            doDL(cbomau, ms.loaddl(), "MAMAU", "TENMAU");
            doDL(cboHangtang, hh.loadDL(), "MAHANG", "TENHANG");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtmakm.Text = tangmaTuDong();
            flag_Them = 1;
            txttenkm.ResetText();
            cboloaikm.ResetText();
            date_ngaybd.ResetText();
            date_ngaykt.ResetText();
            txtmakm.Enabled = txttenkm.Enabled = cboloaikm.Enabled = date_ngaybd.Enabled = date_ngaykt.Enabled = true;
            txtmakm.Enabled = false;
        }
    

        public int kiemtra_km()
        {
            if (txtmakm.Text.Length == 0 || txttenkm.Text.Length==0||cboloaikm.Text.Length==0||date_ngaybd.Text.Length==0||date_ngaykt.Text.Length==0 )
            {

                MessageBox.Show("Nhập đầy đủ thông tin");
                return 0;
            }
          
            return 1;
        }
        public int kiemtra_ctkm()
        {
            if(comboBox1.Text.Length == 0 || txtgiagiam.Text.Length == 0 || txtsoluong.Text.Length == 0 || cbohang.Text.Length == 0 || cbohang.Text.Length == 0 || cbomau.Text.Length == 0)
            {

                MessageBox.Show("Nhập đầy đủ thông tin");
                return 0;
            }
          
            return 1;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            int KT = kiemtra_km();
            if (KT == 1)
            {
                if (flag_Them == 1)
                {
                    try
                    {
                        int t = km.themKM(txtmakm.Text, txttenkm.Text,DateTime.Parse( date_ngaybd.Text),DateTime.Parse(date_ngaykt.Text),cboloaikm.Text);
                        if (t == 1)
                            MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    }
                }
            }
             flag_Them = 0;
            gridControl1.DataSource = km.loadDL();
            btnThem.Enabled = btnSua.Enabled = true;
            txtmakm.Enabled = txttenkm.Enabled =cboloaikm.Enabled=date_ngaybd.Enabled=date_ngaykt.Enabled   = false;
            txtmakm.Enabled = true;
        }


        private void gridControl2_Click(object sender, EventArgs e)
        {
            comboBox1.Text = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "MAKM").ToString();
            cbohang.Text = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "MAHANG").ToString();
            cbomau.Text = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "MAMAU").ToString();
            cboHangtang.Text = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "SANPHAMTANG").ToString();
            txtsoluong.Text = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "SOLUONG").ToString();
            txtgiagiam.Text = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "GIABANGIAM").ToString();
        }

        private void gridView1_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                if (e.RowHandle % 2 == 0)
                {
                    e.Appearance.BackColor = Color.CornflowerBlue;
                }
            }
        }

        private void gridView2_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                if (e.RowHandle % 2 == 0)
                {
                    e.Appearance.BackColor = Color.CornflowerBlue;
                }
            }
        }

        private void txtsoluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            doDL(comboBox1, km.loadDL(), "MAKM", "TENKM");
        }
        private void btnLuu_ctkm_Click(object sender, EventArgs e)
        {
            Luu_ctkm = 1;
            int KT = kiemtra_ctkm();
            if (KT == 1)
            {
                if (flag_Them_ctkm == 1)
                {
                    try
                    {
                        int t = ctkm.themCTKM(comboBox1.Text, cbohang.Text, cbomau.Text, cboHangtang.Text, int.Parse(txtsoluong.Text), txtgiagiam.Text);
                        if (t == 1)
                            MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    }
                    catch
                    {
                     MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    }
                }
            }

            flag_Sua_ctkm = flag_Them_ctkm = 0;
            gridControl2.DataSource = ctkm.loadDL();
            btnThem_ctkm.Enabled = btnSua_ctkm.Enabled = true;
            txtgiagiam.Enabled = comboBox1.Enabled = txtsoluong.Enabled = cbohang.Enabled = cboHangtang.Enabled = cbomau.Enabled = false;
        }

        private void btnSua_ctkm_Click(object sender, EventArgs e)
        {

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            txtmakm.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MAKM").ToString();
            txttenkm.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TENKM").ToString();
            date_ngaybd.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "NGAYBATDAU").ToString();
            date_ngaykt.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "NGAYKETTHUC").ToString();
            cboloaikm.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "HINHTHUCKM").ToString();
        }

        private void btnThem_ctkm_Click(object sender, EventArgs e)
        {
            flag_Sua_ctkm = 1;
            comboBox1.Enabled = false;
            txtgiagiam.Enabled = comboBox1.Enabled = txtsoluong.Enabled = cbohang.Enabled = cboHangtang.Enabled = cbomau.Enabled = true;
            txtgiagiam.ResetText();
            txtsoluong.ResetText();
            cbohang.ResetText();
            cboHangtang.ResetText();
            cbomau.ResetText();
        }
    }
}
