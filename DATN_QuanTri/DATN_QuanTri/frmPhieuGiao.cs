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
    public partial class frmPhieuGiao : Form
    {
        public frmPhieuGiao()
        {
            InitializeComponent();
        }
       
        PhieuGiao_BLL pg = new PhieuGiao_BLL();
        NhanVien_BLL nv = new NhanVien_BLL();
        HoaDon_BLL hd = new HoaDon_BLL();
        KhachHang_BLL kh = new KhachHang_BLL();
       int flag_Them=0;
       int flag_Capnhat=0;
        public void doDL(ComboBox cb, DataTable db, String dis, String value)
        {
            cb.DataSource = db;
            cb.DisplayMember = dis;
            cb.ValueMember = value;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

            DialogResult r = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (r == DialogResult.OK)
                this.Close();
        }

        private void frmPhieuGiao_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = pg.loadPG();
            doDL(cbomahd, hd.loadHD(), "MAHD", "NGAYLAP");
            doDL(cbonvgiao, nv.loadDL(), "TENNV", "MANV");

        }

        private void btnLuu_pg_Click(object sender, EventArgs e)
        {
            if (flag_Capnhat == 1)
            {
                try
                {
                    int cn = pg.capnhatPG(txtmaphieugiao.Text, cbomahd.Text, date_ngaygiao.Text, txtdiachi.Text, cbonvgiao.Text, txtsdtnguoigiao.Text, cbo_tinhtrang.Text, txtTennguoinhan.Text, txtsdtnguoinhan.Text);
                    {
                        if (cn == 1)
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
            else if(flag_Them==1)
            {
                try
                {
                    int t = pg.themPG(txtmaphieugiao.Text, cbomahd.Text, date_ngaygiao.Text, txtdiachi.Text, cbonvgiao.Text, txtsdtnguoigiao.Text, cbo_tinhtrang.Text, txtTennguoinhan.Text, txtsdtnguoinhan.Text);
                    {
                        if (t == 1)
                        {
                            MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
            }
            
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            txtmaphieugiao.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MAPHIEUGIAO").ToString();
            cbomahd.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MAHD").ToString();
            date_ngaygiao.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "NGAYGIAO").ToString();
            txtdiachi.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "DIACHIGIAO").ToString();
            cbonvgiao.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TENNV").ToString();
            txtsdtnguoigiao.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "SDT").ToString();
            cbo_tinhtrang.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TINHTRANG").ToString();
            txtTennguoinhan.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "NGUOINHAN").ToString();
            txtsdtnguoinhan.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "SODIENTHOAI").ToString();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            txtmaphieugiao.ResetText();
            txtdiachi.ResetText();
            txtsdtnguoigiao.ResetText();
            txtsdtnguoinhan.ResetText();
            txtTennguoinhan.ResetText();
            cbomahd.ResetText();
            cbonvgiao.ResetText();
            cbo_tinhtrang.ResetText();
        }

        private void cbomahd_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTennguoinhan.Text = hd.loadHD().Columns[4].ToString();

        }

        private void cbonvgiao_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtsdtnguoigiao.Text = nv.loadDL().Columns[8].ToString();
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
