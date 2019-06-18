using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DATN_QuanTri
{
    public partial class frmTrangChu : Form
    {
      
        public frmTrangChu()
        {

            InitializeComponent();
        }
        frmDangNhap dn = new frmDangNhap();
        
        

        public void ViewChildForm(Form _form)
        {

            if (!IsFormActived(_form))
            {
                _form.MdiParent = this;
                _form.Show();
            }
        }
        private bool IsFormActived(Form form)
        {
            bool IsOpend = false;
            if (MdiChildren.Count() > 0)
            {
                foreach (var item in MdiChildren)
                {
                    if (form.Name == item.Name)
                    {
                        xtraTabbedMdiManager1.Pages[item].MdiChild.Activate();
                        IsOpend = true;
                    }
                }
            }
            return IsOpend;
        }

        private void btnDangNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDangNhap dn = new frmDangNhap();
            dn.Name = "frmDangNhap";
            ViewChildForm(dn);
        }

        private void btnDoiMK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDoiMatKhau doimk = new frmDoiMatKhau();
            doimk.Name = "frmDoiMatKhau";
            ViewChildForm(doimk);
        }

        private void btnPhanQuyen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmPhanQuyen pq = new frmPhanQuyen();
            pq.Name = "frmPhanQuyen";
            ViewChildForm(pq);
        }

        private void btnThemNguoiDungVaoNhom_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmThemNguoiDungVaoNhomQuyen tnd = new frmThemNguoiDungVaoNhomQuyen();
            tnd.Name = "frmThemNguoiDungVaoNhom";
            ViewChildForm(tnd);   
        }

        private void btnQuanLyNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmNhanVien nv = new frmNhanVien();
            nv.Name = "frmNhanVien";
            ViewChildForm(nv);
        }

        private void btnQuanLyKhachHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmKhachHang kh = new frmKhachHang();
            kh.Name = "frmKhachHang";
            ViewChildForm(kh);
        }

        private void btnNCC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmNhaCC ncc = new frmNhaCC();
            ncc.Name = "frmNhaNCC";
            ViewChildForm(ncc);
        }

        private void btnQLHangHoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmHangHoa hh = new frmHangHoa();
            hh.Name = "frmHangHoa";
            ViewChildForm(hh);
        }

        private void btnKhuyenmai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmKhuyenMai km = new frmKhuyenMai();
            km.Name = "frmKhuyenMai";
            ViewChildForm(km);
        }

        private void btnHoaDon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmHoaDon hd = new frmHoaDon();
            hd.Name = "frmHoaDon";
            ViewChildForm(hd);
        }

        private void frmTrangChu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (r == DialogResult.Cancel)
                this.Close();   
            else
                e.Cancel = true;
        }

        private void frmTrangChu_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (r == DialogResult.Cancel)
                this.Close();
        }

        private void frmTrangChu_Load(object sender, EventArgs e)
        {

        }

        private void barButtonItem15_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmPhieuGiao pg = new frmPhieuGiao();
            pg.Name = "frmPhieuGiao";
            ViewChildForm(pg);
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmLoaiHH lh = new frmLoaiHH();
            lh.Name = "frmLoaiHH";
            ViewChildForm(lh);
        }

     
        private void btnDatHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDatHang dh = new frmDatHang();
            dh.Name = "frmDatHang";
            ViewChildForm(dh);
        }

        private void btnNhapHAng_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmNhapHang nh = new frmNhapHang();
            nh.Name = "frmNhapHang";
            ViewChildForm(nh);
        }

        private void btnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmTrangChu fm = new frmTrangChu();
            DialogResult r = MessageBox.Show("Bạn có muốn thoát", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (r == DialogResult.OK)
            {
                this.Close();
            }
            else
            {
               
                this.Hide();
                fm.ShowDialog();
            }

        }

        private void btnQuycach_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmQuyCach qc = new frmQuyCach();
            qc.Name = "frmQuyCach";
            ViewChildForm(qc);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnMausac_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmMauSac ms = new frmMauSac();
            ms.Name = "frmMauSac";
            ViewChildForm(ms);
        }
    }
}
