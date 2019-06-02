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
           txtTongtien.Enabled= txtmahd.Enabled = txtdongia.Enabled = txtgiamgia.Enabled = txtmahd_cthd.Enabled = txtmakh.Enabled = txtsoluong.Enabled = txtThanhtien.Enabled = date_ngaylap.Enabled = lsv_mahang.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                int t = hd.capnhatHD(txtmahd.Text, DateTime.Parse(date_ngaylap.Text), Double.Parse(txtgiamgia.Text), Double.Parse(txtTongtien.Text), txtmakh.Text, cboTinhtrang.Text);
                {
                    if (t == 1)
                    {
                        MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Cập nhật thất bại", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }    
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            txtmahd_cthd.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MAHD").ToString();
            lsv_mahang.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MAHANG").ToString();
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
            txtmakh.Text = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "TENKHACHHANG").ToString();
            cboTinhtrang.Text = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "TINHTRANG").ToString();
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
    }
}
