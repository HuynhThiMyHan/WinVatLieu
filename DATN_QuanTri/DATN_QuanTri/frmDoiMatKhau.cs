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
    public partial class frmDoiMatKhau : Form
    {

        public void funData(TextBox txtDN)
        {
            txtTendn.Text = txtDN.Text;
        
        }

        public void funData1(TextBox txtMKCU)
        {
            txtmatkhaucu.Text = txtMKCU.Text;
        }

        public frmDoiMatKhau()
        {
            InitializeComponent();
        }


        string sql = @"Data Source=DESKTOP-KAM5FCS\SQLEXPRESS;Initial Catalog=VATLIEULOTSAN;Integrated Security=True";
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (r == DialogResult.OK)
                this.Close();
        }

        private void frmDoiMatKhau_FormClosing(object sender, FormClosingEventArgs e)
        {
          
        }
       // DataSet1TableAdapters.QueriesTableAdapter q = new DataSet1TableAdapters.QueriesTableAdapter();

        private void btnDongy_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtmatkhaucu.Text == string.Empty) MessageBox.Show("Chưa nhập mật khẩu cũ");

                else if (txtmatkhaumoi.Text == string.Empty) MessageBox.Show("Chưa nhập mật khẩu mới");

                else if (xacnhanmkmoi.Text == string.Empty) MessageBox.Show("Chưa nhập lại mật khẩu mới");

                else if (txtmatkhaumoi.Text != xacnhanmkmoi.Text) MessageBox.Show("Mật khẩu nhập lại không trùng khớp");

                else if (txtmatkhaumoi.Text == xacnhanmkmoi.Text)
                {
                    //string sql = @"Data Source=DESKTOP-KAM5FCS\\SQLEXPRESS;Initial Catalog=VATLIEULOTSAN;Integrated Security=True";
                    //SqlConnection conn = new SqlConnection(sql);
                    //conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    //cmd.Connection = conn;
                    string doimk = "update NHANVIEN set MATKHAU='" + txtmatkhaumoi.Text + "'where MANV='" + txtTendn.Text + "'";
                    cmd.CommandText = doimk;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Cập nhật thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDongy_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txtmatkhaucu.Text == string.Empty) MessageBox.Show("Chưa nhập mật khẩu cũ");

                else if (txtmatkhaumoi.Text == string.Empty) MessageBox.Show("Chưa nhập mật khẩu mới");

                else if (xacnhanmkmoi.Text == string.Empty) MessageBox.Show("Chưa nhập lại mật khẩu mới");

                else if (txtmatkhaumoi.Text != xacnhanmkmoi.Text) MessageBox.Show("Mật khẩu nhập lại không trùng khớp");

                else if (txtmatkhaumoi.Text == txtmatkhaucu.Text) MessageBox.Show("Mật khẩu mới trùng mật khẩu cũ ");

                else if (txtmatkhaumoi.Text == xacnhanmkmoi.Text)
                {

                    SqlConnection conn = new SqlConnection(sql);
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    string doimk = "UPDATE NHANVIEN SET MATKHAU='" + txtmatkhaumoi.Text + "'WHERE MANV='" + txtTendn.Text + "'";
                    cmd.CommandText = doimk;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmTrangChu tc = new frmTrangChu();
                    tc.ShowDialog();

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Cập nhật thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {  
            txtTendn.Enabled = false;
            txtmatkhaucu.Enabled = false;
        }
    }
}
