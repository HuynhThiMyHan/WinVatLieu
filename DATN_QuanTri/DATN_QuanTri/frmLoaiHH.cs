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
    public partial class frmLoaiHH : Form
    {
        public frmLoaiHH()
        {
            InitializeComponent();
        }
        int flag_Them = 0;
        int flag_Xoa = 0;
        LoaiHang_BLL lh = new LoaiHang_BLL();

        public int kt_rong()
        {
            if (txttenloai.Text.Length == 0 || txtmaloai.Text.Length==0)
            {
                return 1;
            }
            return 0;
        }

        public int kiemtra()
        {
            if(kt_rong()==1)
            {
                MessageBox.Show("Nhập đầy đủ thông tin");
                return 0;
            }
        
            return 1;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            txtmaloai.Enabled = false;
            flag_Them = 1;
            btnLuu.Enabled = true;
            txttenloai.ResetText();
            txttenloai.Enabled = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (r == DialogResult.OK)
                this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            int KT = kiemtra();
            if (KT == 1)
            {
                if (flag_Them == 1)
                {
                    try
                    {
                        int t = lh.themlh(txtmaloai.Text, txttenloai.Text);
                        if (t == 1)
                            MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    }
                }
            }
           
            gridControl1.DataSource = lh.loaddL();
            btnThem.Enabled = true;
            txtmaloai.Enabled = txttenloai.Enabled=false;
            txtmaloai.Enabled = true;
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            txtmaloai.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MALOAI").ToString();
            txttenloai.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TENLOAI").ToString();
        }
        string chuoikn = @"Data Source=DESKTOP-KAM5FCS\SQLEXPRESS;Initial Catalog=VATLIEULOTSAN;Integrated Security=True";
        public string tangmaTuDong()
        {
            string sql = "select * from LOAIHANG";
            SqlConnection con = new SqlConnection();
            con.ConnectionString = chuoikn;
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            string ma = "";
            if (dt.Rows.Count <= 0)
            {
                ma = "LH001" + DateTime.Now.ToShortDateString();
            }
            else
            {
                int k;
                ma = "LH";
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
        private void frmLoaiHH_Load(object sender, EventArgs e)
        {
            txtmaloai.Enabled = false;
            gridControl1.DataSource = lh.loaddL();
            btnLuu.Enabled = false;
            btnThem.Enabled =  true;
            txtmaloai.Enabled = txttenloai.Enabled =false;
            txtmaloai.Text = tangmaTuDong();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            flag_Xoa = 1;
            try
            {
                DialogResult r = MessageBox.Show("Bạn có muốn XÓA ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    lh.xoalh(txtmaloai.Text, txttenloai.Text);
                    gridControl1.DataSource = lh.loaddL();
                }
            }

            catch
            {
                MessageBox.Show("Xóa thất bại");
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
    }
}
