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
using DevExpress.XtraReports.UI;
namespace DATN_QuanTri
{
    public partial class frmPhieuGiao : Form
    {
        public frmPhieuGiao()
        {
            InitializeComponent();
        }
       
        PhieuGiao_BLL pg = new PhieuGiao_BLL();
        CTPhieuGiao_BLL ctpg = new CTPhieuGiao_BLL();
        NhanVien_BLL nv = new NhanVien_BLL();
        HoaDon_BLL hd = new HoaDon_BLL();
        KhachHang_BLL kh = new KhachHang_BLL();
        HangHoa_BLL hh = new HangHoa_BLL();
        MauSac_BLL ms = new MauSac_BLL();

       int flag_Them=0;
        int flag_Themctpg = 0;
       int flag_Capnhat=0;
        int flag_capnhatctpg = 0;
        int flag_Luu = 0;
        int flag_luuctpg = 0;
        public void doDL(ComboBox cb, DataTable db, String dis, String value)
        {
            cb.DataSource = db;
            cb.DisplayMember = dis;
            cb.ValueMember = value;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

            DialogResult r = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (r == DialogResult.OK)
                this.Close();
        }
        string chuoikn = @"Data Source=DESKTOP-KAM5FCS\SQLEXPRESS;Initial Catalog=VATLIEULOTSAN;Integrated Security=True";
        public string tangmaTuDong()
        {
            string sql = "select * from NHANVIEN";
            SqlConnection con = new SqlConnection();
            con.ConnectionString = chuoikn;
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            string ma = "";
            if (dt.Rows.Count <= 0)
            {
                ma = "PG001" + DateTime.Now.ToShortDateString();
            }
            else
            {
                int k;
                ma = "PG";
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
        private void frmPhieuGiao_Load(object sender, EventArgs e)
        {

            txtmaphieugiao.Text = tangmaTuDong();
            gridControl1.DataSource = pg.loadPG();
            gridControl2.DataSource = ctpg.loadCTPG();

            doDL(cbomahd, hd.loadHD(), "MAHD", "MAKHACHHANG");
            doDL(cbonvgiao, nv.loadDL(), "TENNV", "MANV");
            doDL(cbomapg, pg.loadPG(), "MAPHIEUGIAO", "MAHD");
            doDL(cbomahang, hh.loadDL(), "MAHANG", "TENHANG");
            doDL(cbomamau, ms.loaddl(), "MAMAU", "TENMAU");
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            txtmaphieugiao.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MAPHIEUGIAO").ToString();
            cbomahd.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MAHD").ToString();
            date_ngaygiao.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "NGAYGIAO").ToString();
            txtdiachi.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "DIACHIGIAO").ToString();
            cbonvgiao.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TENNV").ToString();
            txtsdtnguoigiao.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "SDT").ToString();
            cbo_tinhtrang.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TINHTRANG").ToString();
            txtTennguoinhan.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "NGUOINHAN").ToString();
            txtsdtnguoinhan.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "SODIENTHOAI").ToString();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            txtmaphieugiao.Text = tangmaTuDong();
            txtmaphieugiao.Enabled = false;
            txtdiachi.ResetText();
            txtsdtnguoigiao.ResetText();
            txtsdtnguoinhan.ResetText();
            txtTennguoinhan.ResetText();
            cbomahd.ResetText();
            cbonvgiao.ResetText();
            cbo_tinhtrang.ResetText();
        }
       
  
        private void cbonvgiao_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = chuoikn;
            SqlCommand cmd = new SqlCommand("Select * from NHANVIEN WHERE MANV='" + cbonvgiao.SelectedValue.ToString() + "'", con);
            con.Open();
            SqlDataReader read = cmd.ExecuteReader();
            if (read.HasRows)
            {
                read.Read();
                txtsdtnguoigiao.Text = read.GetString(11).ToString();
            }
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

        private void gridControl2_Click(object sender, EventArgs e)
        {
            cbomapg.Text = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "MAPHIEUGIAO").ToString();
            cbomahang.Text = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "MAHANG").ToString();
            cbomamau.Text = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "MAMAU").ToString();
            txtdongia.Text = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "DONGIA").ToString();
            txtsoluong.Text = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "SOLUONG").ToString();
        }


        private void txtsoluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void txtdongia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void txtsdtnguoigiao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void txtsdtnguoinhan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            cbomapg.ResetText();
            cbomahang.ResetText();
            cbomamau.ResetText();
            txtsoluong.ResetText();
            txtdongia.ResetText();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            flag_luuctpg = 1;
            if (flag_Themctpg == 1)
            {
                try
                {
                    int t = ctpg.themctpg(cbomapg.Text, cbomahang.Text, cbomamau.Text, int.Parse(txtdongia.Text), int.Parse(txtsoluong.Text));
                    {
                        if (t == 1)
                        {
                            MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                            
                            
                            gridControl2.DataSource = ctpg.loadCTPG();
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
            }
        }

        private void cbomahd_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = chuoikn;
            SqlCommand cmd = new SqlCommand("Select * from HOADON WHERE MAHD = '" + cbomahd.SelectedValue.ToString() + "'", con);
            con.Open();
            SqlDataReader readhd = cmd.ExecuteReader();
            if (readhd.HasRows)
            {
                readhd.Read();
                txtTennguoinhan.Text = readhd.GetString(4).ToString();
                txtdiachi.Text = readhd.GetString(5).ToString();
                txtsdtnguoinhan.Text = readhd.GetString(6).ToString();
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            flag_Luu = 1;
             if (flag_Them == 1)
            {
                try
                {
                    int t = pg.themPG(txtmaphieugiao.Text, cbomahd.Text, date_ngaygiao.Text, txtdiachi.Text, cbonvgiao.Text, txtsdtnguoigiao.Text, cbo_tinhtrang.Text, txtTennguoinhan.Text, txtsdtnguoinhan.Text);
                    {
                        if (t == 1)
                        {
                            MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                            gridControl1.DataSource = pg.loadPG();
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            InPhieuGiao report = new InPhieuGiao();
            report.DataSource = pg.loadPG();
            report.ShowPreviewDialog();
        }

        private void gridView1_RowCellStyle_1(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
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
    }
}
