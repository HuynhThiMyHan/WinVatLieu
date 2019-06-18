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
    public partial class frmDatHang : Form
    {
        public frmDatHang()
        {
            InitializeComponent();
        }

        int flag_Them, flag_Them_ctpd = 0;
        int flag_Sua, flag_Sua_ctpd = 0;
        PhieuDat_BLL pd = new PhieuDat_BLL();
        NhanVien_BLL nv = new NhanVien_BLL();
        NhaCungCap_BLL ncc = new NhaCungCap_BLL();
        HangHoa_BLL hh = new HangHoa_BLL();
        MauSac_BLL ms = new MauSac_BLL();
        CTPHIEUDAT_BLL ctpd = new CTPHIEUDAT_BLL();
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
        public int tongtien()
        {
            int thanhtien = 0;
            int tongtien = 0;
         int sl  = int.Parse(txtsoluong_ctpd.Text);
            int dg = int.Parse(txtgianhap_ctpd.Text);
            thanhtien = sl * dg;
            tongtien += thanhtien;
            return tongtien;
        }
        private void frmDatHang_Load(object sender, EventArgs e)
        {
            try
            {
                txtmapd_pd.Text = tangmaTuDong();
                gridControl1.DataSource = ctpd.loadCTPD();
                gridControl2.DataSource = pd.loadPD();
                doDL(cboManv, nv.loadDL(), "MANV", "TENNV");
                doDL(cbomancc, ncc.loadDulieu_NCC(), "MANCC", "TENNCC");
                doDL(cbohanghoa, hh.loadDL(), "MAHANG", "TENHANG");
                doDL(cboMausac_ctpd, ms.loaddl(), "MAMAU", "TENMAU");
                doDL(cbomapd, pd.loadPD(), "MAPHIEUDAT", "MANCC");
                dateTimePicker1.Enabled = txtgianhap_ctpd.Enabled = cbomapd.Enabled = txtmapd_pd.Enabled = txtsoluong_ctpd.Enabled = txttongtien.Enabled = cbohanghoa.Enabled = cbomancc.Enabled = cboManv.Enabled = cboMausac_ctpd.Enabled = cbotinhtrang.Enabled = false;
            }
            catch
            {

            }
            }

        public void doDL(ComboBox cb, DataTable db, String dis, String value)
        {
            cb.DataSource = db;
            cb.DisplayMember = dis;
            cb.ValueMember = value;
        }


        public int kiemtra_pd()
        {
            if (txtmapd_pd.Text.Length == 0 || cboManv.Text.Length == 0 || cbomancc.Text.Length == 0 || dateTimePicker1.Text.Length == 0 || cbotinhtrang.Text.Length == 0||txttongtien.Text.Length==0)
            {

                MessageBox.Show("Nhập đầy đủ thông tin");
                return 0;
            }
         
            return 1;
        }

        public int kiemtra_ctpd()
        {
            if (cbomapd.Text.Length == 0 || cbohanghoa.Text.Length == 0 || cboMausac_ctpd.Text.Length == 0 || txtsoluong_ctpd.Text.Length == 0 || txtgianhap_ctpd.Text.Length ==0)
            {

                MessageBox.Show("Nhập đầy đủ thông tin");
                return 0;
            }
            return 1;
        }
        private void btnLuu_pd_Click(object sender, EventArgs e)
        {
            int KT = kiemtra_pd();
            if (KT == 1)
            {
                if (flag_Them == 1)
                {
                    try
                    {
                        txttongtien.Enabled = false;

                        int t = pd.themPD(txtmapd_pd.Text, cbomancc.Text, cboManv.Text, dateTimePicker1.Text,  cbotinhtrang.Text);
                        if (t == 1)
                            MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        gridControl2.DataSource = pd.loadPD();
                    }
                    catch
                    {
                        MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    }
                }
            }
            flag_Sua = flag_Them = 0;
            txtmapd_pd.Enabled = cbomancc.Enabled = cboManv.Enabled = dateTimePicker1.Enabled =cbotinhtrang.Enabled=txttongtien.Enabled= false;
            
           
        }


        private void btnThem_ctpd_Click(object sender, EventArgs e)
        {
            flag_Them_ctpd = 1;      
            txtgianhap_ctpd.ResetText();
            txtsoluong_ctpd.ResetText();
            txttongtien.ResetText();
            cbohanghoa.ResetText();
            cboMausac_ctpd.ResetText();
          
           txtgianhap_ctpd.Enabled = cbomapd.Enabled = txtsoluong_ctpd.Enabled = cbohanghoa.Enabled =  cboMausac_ctpd.Enabled = true;
        }

        private void btnLuu_ctpd_Click(object sender, EventArgs e)
        {
            int KT = kiemtra_ctpd();
            if (KT == 1)
            {
                if (flag_Them_ctpd == 1)
                {
                    try
                    {
                        int t = ctpd.themctpd(cbomapd.Text, cbohanghoa.Text, cboMausac_ctpd.Text,int.Parse(txtsoluong_ctpd.Text),Double.Parse(txtgianhap_ctpd.Text));
                        if (t == 1)
                            MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                           gridControl1.DataSource = ctpd.loadCTPD();

                    }
                    catch
                    {
                        MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    }
                }
            }
       //     txttongtien.Text = ctpd.tongthanhtien(cbomapd.SelectedValue.ToString());
       ////     gridControl2.DataSource = pd.loadPD();
       //     if (int.Parse(ctpd.demPD(cbomapd.SelectedValue.ToString())) < 1)
       //         txttongtien.Text = "0";
       //     try
       //     {
       //         int cn = pd.Capnhat_thanhtienPD(cbomapd.SelectedValue.ToString(), Double.Parse(txttongtien.Text));
       //     }
       //     catch
       //     {
       //         MessageBox.Show("Cập nhật lại thành tiền thất bại");
       //     }
        }

        private void txttongtien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void txtsoluong_ctpd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void txtgianhap_ctpd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (r == DialogResult.OK)
                this.Close();

        }

        private void btnsua_pd_Click(object sender, EventArgs e)
        {
            flag_Sua = 1;
            txtmapd_pd.Enabled = false;
        }

        private void btnSua_ctpd_Click(object sender, EventArgs e)
        {
            flag_Sua_ctpd = 1;

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
            txtmapd_pd.Text = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "MAPHIEUDAT").ToString();
            cbomancc.Text = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "MANCC").ToString();
            dateTimePicker1.Text = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "NGAYDAT").ToString();
            txttongtien.Text = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "TONGTIEN").ToString();
            cbotinhtrang.Text = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "TINHTRANG").ToString();
        }

        private void btnSua_ctpd_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            doDL(cbomapd, pd.loadPD(), "MAPD", "MANCC");
        }

        private void btnTinhtien_Click(object sender, EventArgs e)
        {
           
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

        private void gridControl1_Click_1(object sender, EventArgs e)
        {
            cbomapd.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MAPHIEUDAT").ToString();
            cbohanghoa.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MAHANG").ToString();
            cboMausac_ctpd.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MAMAU").ToString();
            txtsoluong_ctpd.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "SOLUONG").ToString();
            txtgianhap_ctpd.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "DONGIANHAP").ToString();
        }

        private void btnThem_pd_Click(object sender, EventArgs e)
        {
            txtmapd_pd.Text = tangmaTuDong();
            txttongtien.Text = "0.0";
            txttongtien.Enabled = false;
            flag_Them = 1;
            txtmapd_pd.Enabled = false;
            dateTimePicker1.ResetText();
            cbotinhtrang.ResetText();
            cboManv.ResetText();
            cbomancc.ResetText();

          txtmapd_pd.Enabled= dateTimePicker1.Enabled = cbomancc.Enabled = cboManv.Enabled = cbotinhtrang.Enabled = true;
        }
    }
}
