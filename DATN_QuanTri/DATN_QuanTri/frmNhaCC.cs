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
    public partial class frmNhaCC : Form
    {

        int flag_Them = 0;
        int flag_Xoa = 0;
        int flag_Sua = 0;
        public frmNhaCC()
        {
            InitializeComponent();
        }
        NhaCungCap_BLL ncc = new NhaCungCap_BLL();

        public void khoaControl()
        {
            btnLuu.Enabled = true;
            btnSua.Enabled = btnThem.Enabled = false;
            txtMaNcc.Enabled = txtDiaChi.Enabled = txtSDT.Enabled = txtTenNCC.Enabled = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (r == DialogResult.OK)
                this.Close();
        }

        public int KT_Rong()
        {
            if (txtMaNcc.Text.Length == 0 || txtTenNCC.Text.Length == 0 || txtDiaChi.Text.Length == 0 || txtSDT.Text.Length == 0)
                return 1;
            return 0;
        }

        public int kiemTra()
        {
            if(KT_Rong()==1)
            {
                MessageBox.Show("Nhập đầy đủ thông tin nhà cung cấp !");
                return 0;
            }
            else
            {
                if (txtMaNcc.Text.Length == 0)
                {
                    MessageBox.Show("Chưa nhập mã nhà cung cấp");
                    return 0;
                }
                else
                {
                        if(txtSDT.Text.Length==0)
                        {
                            MessageBox.Show("Chưa nhập số điện thoại !");
                            return 0;
                        }
                        else
                        {
                            if(txtSDT.Text.Length>10)
                            {
                                MessageBox.Show("Số điện thoại không lớn hơn 10 kí tự !");
                                return 0;
                            }

                        }
                      
                    
                }
                return 1;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            flag_Them = 1;
            khoaControl();
            txtMaNcc.Enabled = false;
            txtTenNCC.ResetText();
            txtDiaChi.ResetText();
            txtSDT.ResetText();
        }
        string chuoikn = @"Data Source=DESKTOP-KAM5FCS\SQLEXPRESS;Initial Catalog=VATLIEULOTSAN;Integrated Security=True";
        public string tangmaTuDong()
        {
            string sql = "select * from NHACUNGCAP";
            SqlConnection con = new SqlConnection();
            con.ConnectionString = chuoikn;
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            string ma = "";
            if (dt.Rows.Count <= 0)
            {
                ma = "NCC001" + DateTime.Now.ToShortDateString();
            }
            else
            {
                int k;
                ma = "NCC";
                k = Convert.ToInt32(dt.Rows[dt.Rows.Count - 1][0].ToString().Substring(3,3));
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
        private void frmNhaCC_Load(object sender, EventArgs e)
        {
            gvNhaCC.DataSource = ncc.loadDulieu_NCC();
            btnLuu.Enabled = false;
            btnThem.Enabled = btnSua.Enabled = true;
            txtMaNcc.Enabled = txtDiaChi.Enabled = txtSDT.Enabled = txtTenNCC.Enabled = false;
            txtMaNcc.Text = tangmaTuDong();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            flag_Xoa = 1;
            khoaControl();
           try
            {
                DialogResult r = MessageBox.Show("Bạn có muốn XÓA ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    ncc.XoaNCC(txtMaNcc.Text, txtTenNCC.Text, txtDiaChi.Text, txtSDT.Text);
                    gvNhaCC.DataSource = ncc.loadDulieu_NCC();
                }
            }
           
            catch
            {
                MessageBox.Show("Xóa thất bại");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            flag_Sua = 1;
            khoaControl();
            txtMaNcc.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            int KT = kiemTra();
            if (KT == 1)
            {
                if (flag_Them == 1)
                {
                    try
                    {
                        int t = ncc.ThemNCC(txtMaNcc.Text, txtTenNCC.Text, txtSDT.Text, txtDiaChi.Text);
                        if (t == 1)
                            MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    }
                }
                //else if (flag_Sua == 1)
                //{
                //    try
                //    {
                //        int t = ncc.SuaNCC(txtMaNcc.Text, txtTenNCC.Text, txtSDT.Text, txtDiaChi.Text);
                //        if (t == 1)
                //            MessageBox.Show("Cập nhật thành công !", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                //    }
                //    catch
                //    {
                //        MessageBox.Show("Cập nhật thất bại", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                //    }
                //}
                flag_Sua = flag_Them = 0;
                gvNhaCC.DataSource = ncc.loadDulieu_NCC();
                btnThem.Enabled = btnSua.Enabled = true;
                txtMaNcc.Enabled = txtDiaChi.Enabled = txtSDT.Enabled = txtTenNCC.Enabled = false;
                txtMaNcc.Enabled = true;
            }
        }

        private void gvNCC_Click(object sender, EventArgs e)
        {
           
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void gvNhaCC_Click(object sender, EventArgs e)
        {
            try
            {
                txtMaNcc.Text = gvNCC.GetRowCellValue(gvNCC.FocusedRowHandle, "MANCC").ToString();
                txtTenNCC.Text = gvNCC.GetRowCellValue(gvNCC.FocusedRowHandle, "TENNCC").ToString();
                txtDiaChi.Text = gvNCC.GetRowCellValue(gvNCC.FocusedRowHandle, "DIACHI").ToString();
                txtSDT.Text = gvNCC.GetRowCellValue(gvNCC.FocusedRowHandle, "SODIENTHOAI").ToString();
            }
          catch
            {

            }
        }

        private void gvNCC_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
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
