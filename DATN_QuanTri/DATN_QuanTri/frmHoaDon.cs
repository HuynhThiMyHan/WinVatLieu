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
    public partial class frmHoaDon : Form
    {
        public frmHoaDon()
        {
            InitializeComponent();
        }
        HoaDon_BLL hd = new HoaDon_BLL();
        CTHoaDon_BLL cthd = new CTHoaDon_BLL();
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (r == DialogResult.OK)
                this.Close();
        }
        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = cthd.loadCTHD();
            gridControl2.DataSource = hd.loadHD();
      cbomahang.Enabled= date_ngaylap.Enabled=  cboTinhtrang.Enabled= txtSDT.Enabled=txttenkh.Enabled=txtdiachi.Enabled=txtTongtien.Enabled= txtmahd.Enabled = txtdongia.Enabled = txtgiamgia.Enabled = cbomahang.Enabled = txtmakh.Enabled = txtsoluong.Enabled = txtThanhtien.Enabled = date_ngaylap.Enabled =  false;
        }

     

        private void gridControl1_Click(object sender, EventArgs e)
        {
            cboMahd.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MAHD").ToString();
            cbomahang.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MAHANG").ToString();
            txtdongia.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "DONGIA").ToString();
            txtThanhtien.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "THANHTIEN").ToString();
            txtsoluong.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "SOLUONG").ToString();
        }

        private void gridControl2_Click(object sender, EventArgs e)
        {
            txtmahd.Text = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "MAHD").ToString();
            date_ngaylap.Text = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "NGAYLAP").ToString();
            txtgiamgia.Text = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "GIAMGIA").ToString();
            txtTongtien.Text = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "TONGTIEN").ToString();
            txtmakh.Text = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "MAKHACHHANG").ToString();
            cboTinhtrang.Text = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "TINHTRANG").ToString();
            txtdiachi.Text = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "DIACHI").ToString();
            txttenkh.Text = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "TENKHACHHANG").ToString();
            txtSDT.Text = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "SODIENTHOAI").ToString();
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

    
        string chuoikn = @"Data Source=DESKTOP-KAM5FCS\SQLEXPRESS;Initial Catalog=VATLIEULOTSAN;Integrated Security=True";
        private void cboMahd_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = chuoikn;
            SqlCommand cmd = new SqlCommand("Select * from CT_HOADON WHERE MAHD='" + cboMahd.SelectedValue.ToString() + "'", con);
            con.Open();
            SqlDataReader read = cmd.ExecuteReader();
            if (read.HasRows)
            {
                read.Read();
                cbomahang.Text = read.GetString(1).ToString();
                txtdongia.Text = read.GetString(2).ToString();
                txtThanhtien.Text = read.GetString(3).ToString();
                txtsoluong.Text = read.GetString(4).ToString();
            }
        }
    }
}
