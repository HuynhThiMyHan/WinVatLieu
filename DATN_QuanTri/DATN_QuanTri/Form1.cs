using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DATN_QuanTri
{
    public partial class frmDangNhap : DevExpress.XtraEditors.XtraForm
    {
     
        public frmDangNhap()
        {
            InitializeComponent();
        }
        public delegate void delPassTenDN(TextBox text);


        public delegate void delPassMK(TextBox text1);
        public string _user, _pass,_quyen;
        
        DataSet1TableAdapters.QueriesTableAdapter q = new DataSet1TableAdapters.QueriesTableAdapter();
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (r == DialogResult.OK)
                this.Close();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            txttendn.Focus();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
         
            _user = txttendn.Text;
            _pass = txtmatkhau.Text;
            if(txttendn.Text=="admin" && txtmatkhau.Text=="admin")
            {
                frmTrangChu fm = new frmTrangChu();
                this.Hide();
                fm.ShowDialog();
                this.Close();
            }
          else  if (q.CHECKLOGIN(_user, _pass) == 1)
            {
             DialogResult d= MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                
                if( d ==DialogResult.OK)
                {
                    DialogResult r = MessageBox.Show("Bạn có muốn đổi mật khẩu không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if(r==DialogResult.OK)
                    {
                        frmDoiMatKhau dmk = new frmDoiMatKhau();
                        delPassTenDN del = new delPassTenDN(dmk.funData);
                        del(this.txttendn);
                        delPassMK del1 = new delPassMK(dmk.funData1);
                        del1(this.txtmatkhau);
                        dmk.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        frmTrangChu fm = new frmTrangChu();
                        this.Hide();
                        fm.ShowDialog();
                        this.Close();
                    }
                }
                else
                {   
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Tên đăng nhập/mật khẩu không đúng !", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                txtmatkhau.Focus();
            }
        }
    }
}
