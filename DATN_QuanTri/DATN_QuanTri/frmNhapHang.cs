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
using System.Data;
using System.Data.SqlClient;
namespace DATN_QuanTri
{
    public partial class frmNhapHang : Form
    {
        public frmNhapHang()
        {
            InitializeComponent();
        }

        int flag_Them, flag_Them_ctpn = 0;
        int flag_Sua, flag_Sua_ctpn = 0;
        CTPhieuNhap_BLL ctpn = new CTPhieuNhap_BLL();
        NhanVien_BLL nv = new NhanVien_BLL();
        NhaCungCap_BLL ncc = new NhaCungCap_BLL();
        HangHoa_BLL hh = new HangHoa_BLL();
        PhieuDat_BLL pd = new PhieuDat_BLL();
        MauSac_BLL ms = new MauSac_BLL();
        string chuoikn = @"Data Source=DESKTOP-KAM5FCS\SQLEXPRESS;Initial Catalog=VATLIEULOTSAN;Integrated Security=True";
        public string tangmaTuDong()
        {
            string sql = "select * from PHIEUDAT";
            SqlConnection con = new SqlConnection();
            con.ConnectionString = chuoikn;
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            string ma = "";
            if (dt.Rows.Count <= 0)
            {
                ma = "PD001" + DateTime.Now.ToShortDateString();
            }
            else
            {
                int k;
                ma = "PD";
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
        public void doDL(ComboBox cb, DataTable db, String dis, String value)
        {
            cb.DataSource = db;
            cb.DisplayMember = dis;
            cb.ValueMember = value;
        }
        private void btnThem_pn_Click(object sender, EventArgs e)
        {
            flag_Them = 1;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (r == DialogResult.OK)
                this.Close();
        }

        private void frmNhapHang_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = ctpn.loadCTPN();
            doDL(cbmanv_pn, nv.loadDL(), "MANV", "TENNV");
            doDL(cbomancc_pn, ncc.loadDulieu_NCC(), "MANCC", "TENNCC");
            doDL(cbomahang, hh.loadDL(), "MAHANG", "TENHANG");
            doDL(cbomausac_ctpn, ms.loaddl(), "MAMAU", "TENMAU");
            doDL(cbomaphieudat, pd.loadPD(), "MAPHIEUDAT", "MAHANG");
            

            cbo_phieunhap.Enabled = txtmapn_pn.Enabled = txtsoluong.Enabled = txttongtien_pn.Enabled = cbmanv_pn.Enabled = cbomahang.Enabled = cbomancc_pn.Enabled = cbomaphieudat.Enabled = cbomausac_ctpn.Enabled = cbotinhtrang_pn.Enabled = false;
        }

        private void btnLuu_pn_Click(object sender, EventArgs e)
        {
            int KT = kiemtra_pN();
            if (KT == 1)
            {
                if (flag_Them == 1)
                {
                    try
                    {
                        int t = pd.themPD(txtmapn_pn.Text, cbomancc_pn.Text, cbmanv_pn.Text,date_ngaynhap.Text , float.Parse(txttongtien_pn.Text), cbotinhtrang_pn.Text);
                        if (t == 1)
                            MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            cbo_phieunhap.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MAPHIEUNHAP").ToString();
            cbomaphieudat.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MAPHIEUDAT").ToString();
            cbomahang.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MAHANG").ToString();
            cbomausac_ctpn.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MAMAU").ToString();
            txtsoluong.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "SOLUONG").ToString();
        }

        private void btnThem_ctpn_Click(object sender, EventArgs e)
        {
            flag_Them_ctpn = 1;
        }

        private void btnLuu_ctpn_Click(object sender, EventArgs e)
        {
            int KT = kiemtra_ctpn();
            if (KT == 1)
            {
                if (flag_Them_ctpn == 1)
                {
                    try
                    {
                        int t = ctpn.themCTPN(cbo_phieunhap.Text, cbomaphieudat.Text, cbomahang.Text, cbomausac_ctpn.Text, int.Parse(txtsoluong.Text));
                        if (t == 1)
                            MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void txttongtien_pn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void txtsoluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void labelControl12_Click(object sender, EventArgs e)
        {

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
            cbo_phieunhap.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MAPHIEUNHAP").ToString();
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {

        }

        public int kiemtra_pN()
        {
            if (txtmapn_pn.Text.Length == 0 || cbomancc_pn.Text.Length == 0 || cbmanv_pn.Text.Length == 0 || date_ngaynhap.Text.Length == 0 || txttongtien_pn.Text.Length == 0 || cbotinhtrang_pn.Text.Length == 0)
            {

                MessageBox.Show("Nhập đầy đủ thông tin");
                return 0;
            }
            else
            {
                if (txtmapn_pn.Text.Length > 10)
                {
                    MessageBox.Show("Độ dài không quá 10 kí tự");
                    return 0;
                }
            }
            return 1;
        }

        public int kiemtra_ctpn()
        {
            if (cbo_phieunhap.Text.Length == 0 || cbomaphieudat.Text.Length == 0 || cbomahang.Text.Length == 0 || cbomausac_ctpn.Text.Length == 0 || txtsoluong.Text.Length == 0)
            {

                MessageBox.Show("Nhập đầy đủ thông tin");
                return 0;
            }
            return 1;
        }
    }
}
