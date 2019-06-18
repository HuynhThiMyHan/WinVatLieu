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
    public partial class frmQuyCach : Form
    {
        public frmQuyCach()
        {
            InitializeComponent();
        }
        QuyCach_BLL qc = new QuyCach_BLL();
        HangHoa_BLL hh = new HangHoa_BLL();
        int flagThem = 0;
        int flagXoa = 0;
        public void doDL(ComboBox cb, DataTable db, String dis,String value)
        {
            cb.DataSource = db;
            cb.DisplayMember = dis;
           cb.ValueMember = value;
        }
        private void frmQuyCach_Load(object sender, EventArgs e)
        {
            cbo_mahang.Enabled = txtdientich.Enabled = txtkichthuoc.Enabled = txtsoluong.Enabled = txttrongluong.Enabled = txtxuatxu.Enabled = false;
            gridControl1.DataSource = qc.loadQC();
            doDL(cbo_mahang, hh.loadDL(), "MAHANG","TENHANG");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            flagThem = 1;
            cbo_mahang.Enabled = txtdientich.Enabled = txtkichthuoc.Enabled = txtsoluong.Enabled = txttrongluong.Enabled = txtxuatxu.Enabled = true;
            cbo_mahang.ResetText();
            txtdientich.ResetText();
            txtkichthuoc.ResetText();
            txtsoluong.ResetText();
            txttrongluong.ResetText();
            txtxuatxu.ResetText();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (r == DialogResult.OK)
                this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (flagThem == 1)
            {
                try
                {
                    int t = qc.themQC(cbo_mahang.Text,txtkichthuoc.Text,int.Parse(txtdientich.Text),int.Parse(txtsoluong.Text),int.Parse(txttrongluong.Text),txtxuatxu.Text);
                    if (t == 1)
                        MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        gridControl1.DataSource = qc.loadQC();
                }
                catch
                {
                    MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            flagXoa = 1;
            
            try
            {
                DialogResult r = MessageBox.Show("Bạn có muốn XÓA ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    qc.xoaQC(cbo_mahang.Text, txtkichthuoc.Text, int.Parse(txtdientich.Text), int.Parse(txtsoluong.Text), int.Parse(txttrongluong.Text), txtxuatxu.Text);
                    gridControl1.DataSource = qc.loadQC();
                }
            }

            catch
            {
                MessageBox.Show("Xóa thất bại");
            }
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            cbo_mahang.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MAHH").ToString();
            txtkichthuoc.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "KICHTHUOC").ToString();
            txtdientich.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "DienTichTam").ToString();
            txtsoluong.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TamTrenHop").ToString();
            txttrongluong.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TrongLuong").ToString();
            txtxuatxu.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "XuatXu").ToString();
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

        private void btnSua_Click(object sender, EventArgs e)
        {
            doDL(cbo_mahang, hh.loadDL(), "MAHANG", "TENHANG");
        }

        private void txtsoluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void txtdientich_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void txttrongluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
    }
}
