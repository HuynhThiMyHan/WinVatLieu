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
    public partial class frmLoaiKH : Form
    {
        int flag_Them = 0;
        int flag_Xoa = 0;
        int flag_Sua = 0;
        LoaiKhachHang_BLL lkh = new LoaiKhachHang_BLL();
        public frmLoaiKH()
        {
            InitializeComponent();
        }
        
        
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (r == DialogResult.OK)
                this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            flag_Them = 1;
            khoaControl();
            txtmaloai.ResetText();
            txttenloai.ResetText();
            txtmucgiam.ResetText();
        }
        public void khoaControl()
        {
            btnLuu.Enabled = true;
            btnSua.Enabled = btnThem.Enabled = false;
            txtmaloai.Enabled = txttenloai.Enabled = txtmucgiam.Enabled = true ;
            btnThem.Enabled = true;
        }

        //public int kiemtra()
        //{
        //    if(txtmaloai.Text.Length==0||txttenloai.Text.Length==0||txtmucgiam.Text.Length==0)
        //    {
        //        MessageBox.Show("Nhập đầy đủ thông tin");
        //        return 0;
        //    }
        //    return 1;
        //}

        private void gridControl1_Click(object sender, EventArgs e)
        {
            txtmaloai.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MALOAI").ToString();
            txttenloai.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TENLOAN").ToString();
            txtmucgiam.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MUCGIAM").ToString();
        }

        private void frmLoaiKH_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = lkh.loadDl();
          
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            //    int KT = kiemtra();
            //    if (KT == 1)
            //    {
            if (flag_Them == 1)
                {
                    try
                    {
                        int t = lkh.themLKH(txtmaloai.Text, txttenloai.Text, float.Parse(txtmucgiam.Text));
                        if (t == 1)
                            MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    }
                }
            //}
            flag_Sua = flag_Them = 0;
            gridControl1.DataSource = lkh.loadDl();
            btnThem.Enabled = btnSua.Enabled = true;
            txtmaloai.Enabled = txttenloai.Enabled = txtmucgiam.Enabled  = false;
            
        }

    private void txtmucgiam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
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
                    lkh.xoaLKH(txtmaloai.Text, txttenloai.Text,float.Parse( txtmucgiam.Text));
                    gridControl1.DataSource = lkh.loadDl();
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
