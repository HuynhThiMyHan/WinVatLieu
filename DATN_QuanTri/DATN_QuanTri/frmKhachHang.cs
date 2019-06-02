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
using BLL;
namespace DATN_QuanTri
{
    public partial class frmKhachHang : Form
    {
        public frmKhachHang()
        {
            InitializeComponent();
        }
        KhachHang_BLL kh = new KhachHang_BLL();

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (r == DialogResult.OK)
                this.Close();
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

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
        ketnoi kn = new ketnoi();
        private void frmKhachHang_Load(object sender, EventArgs e) 
        {
            try
            {
                gridControl1.DataSource = kh.loadKH();
            }
            catch
            { }
           
        }
       
        private void simpleButton4_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtkeyword.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập thông tin muốn tìm", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
                else
                {
                    gridControl1.DataSource = kn.laybang("SELECT * FROM KH WHERE TENKHACHHANG LIKE '%" + txtkeyword.Text + "%'");
                }
            }
           catch { }
        }



        private void simpleButton3_Click(object sender, EventArgs e)
        {
            try
            {
                txtkeyword.ResetText();
                gridControl1.DataSource = kh.loadKH();
            }
            catch { }
        }
    
        
    }
}
