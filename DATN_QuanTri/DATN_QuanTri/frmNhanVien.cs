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
using System.IO;
namespace DATN_QuanTri
{
    public partial class frmNhanVien : Form
    {
        XuLyAnh xla = new XuLyAnh();
        int flag_Them = 0;
        int flag_Xoa = 0;
        int flag_Sua = 0;
        NhanVien_BLL nv = new NhanVien_BLL();
        public frmNhanVien()
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
            txtmanv.Text = tangmaTuDong();
            pic_hinhanh.Enabled=txtmatkhau.Enabled= txttennv.Enabled = txt_cmnd.Enabled = txt_diachi.Enabled = txt_email.Enabled = txt_sdt.Enabled = true;
            date_ngaysinh.Enabled = true;
            cbo_gt.Enabled = true;
            cbo_quyen.Enabled = true ;
            flag_Them = 1;
            txttennv.ResetText();
            txt_cmnd.ResetText();
            txt_diachi.ResetText();
            txt_email.ResetText();
            txt_sdt.ResetText();
            date_ngaysinh.ResetText();
            cbo_gt.ResetText();
            cbo_quyen.ResetText();
            txtHinh.ResetText();
            dateTimePicker1.ResetText();
            txtmatkhau.ResetText();
        }

        public int kiemtra()
        {
            if(txtmanv.Text.Length==0 || txttennv.Text.Length==0||txt_cmnd.Text.Length==0||txt_diachi.Text.Length==0||txt_email.Text.Length==0||txt_sdt.Text.Length==0||date_ngaysinh.Text.Length==0||cbo_gt.Text.Length==0||cbo_quyen.Text.Length==0)
            {
                MessageBox.Show("Nhập đầy đủ thông tin");
                return 0;
            }
         
            return 1;
        }
        string chuoikn = @"Data Source=DESKTOP-KAM5FCS\SQLEXPRESS;Initial Catalog=VATLIEULOTSAN;Integrated Security=True";
        public string tangmaTuDong()
        {
            string sql = "select * from NHANVIEN";
            SqlConnection con = new SqlConnection();
            con.ConnectionString = chuoikn;
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            string ma = "";
            if (dt.Rows.Count <= 0)
            {
                ma = "NV001" + DateTime.Now.ToString("ddMMyyyy");
            }
            else
            {
                int k;
                ma = "NV";
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
        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            txtHinh.Enabled=txtmatkhau.Enabled = txttennv.Enabled = txt_cmnd.Enabled = txt_diachi.Enabled = txt_email.Enabled = txt_sdt.Enabled = false;
            date_ngaysinh.Enabled = false;
            cbo_gt.Enabled = false;
            cbo_quyen.Enabled = false;
            gridControl1.DataSource = nv.loadDL();  
            txtmanv.Enabled = false;
            txtmanv.Text = tangmaTuDong();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            txtmanv.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MANV").ToString();
            txttennv.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TENNV").ToString();
            date_ngaysinh.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "NGAYSINH").ToString();
            cbo_quyen.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "QUYEN").ToString();
            cbo_gt.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "GIOITINH").ToString();
            txtHinh.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "HINH").ToString();
            txt_diachi.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "DIACHI").ToString();
            txt_cmnd.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "CMND").ToString();
            txt_email.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Email").ToString();
            dateTimePicker1.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "NGAYTAO").ToString();
            txt_sdt.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "SODIENTHOAI").ToString();
            txtmatkhau.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MATKHAU").ToString();
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
                        int t = nv.themNV(txtmanv.Text,txttennv.Text,date_ngaysinh.Text,cbo_quyen.Text,cbo_gt.Text,txtHinh.Text,txt_diachi.Text,txt_cmnd.Text,txt_email.Text,DateTime.Parse(dateTimePicker1.Text),txt_sdt.Text,txtmatkhau.Text);
                        if (t == 1)
                            MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        txttennv.ResetText();
                        txt_cmnd.ResetText();
                        txt_diachi.ResetText();
                        txt_email.ResetText();
                        txt_sdt.ResetText();
                        date_ngaysinh.ResetText();
                        cbo_gt.ResetText();
                        cbo_quyen.ResetText();
                        pic_hinhanh.ResetText();
                        dateTimePicker1.ResetText();
                        txtmatkhau.ResetText();
                    }
                    catch
                    {
                        MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    }
                }
                else if(flag_Sua==1)
                {

                }
            }
            flag_Sua = flag_Them = 0;
            gridControl1.DataSource = nv.loadDL();
            btnThem.Enabled = btnSua.Enabled = true;
         txttennv.Enabled = txt_cmnd.Enabled = txt_diachi.Enabled = txt_email.Enabled = txt_sdt.Enabled = false;
            date_ngaysinh.Enabled = false;
            cbo_gt.Enabled = false;
            cbo_quyen.Enabled = false;
            txtmanv.Enabled = true;
        }

        private void txt_sdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void txt_cmnd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            flag_Xoa = 1;
            try
            {
                DialogResult r = MessageBox.Show("Bạn có muốn XÓA ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    nv.xoaNV(txtmanv.Text, txttennv.Text, date_ngaysinh.Text, cbo_quyen.Text, cbo_gt.Text, txtHinh.Text, txt_diachi.Text, txt_cmnd.Text, txt_email.Text, DateTime.Parse(dateTimePicker1.Text), txt_sdt.Text,txtmatkhau.Text);
                    MessageBox.Show("Xóa thành công");
                    gridControl1.DataSource = nv.loadDL();
                }
            }

            catch
            {
                MessageBox.Show("Xóa thất bại");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

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

        private void btnChonhinh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Browse Text Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "txt",
                Filter = "Windows Bitmap|*.bmp|JPEG Image|*.jpg|All Files|*.*",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtHinh.Text = openFileDialog1.FileName;
                Image img = Image.FromFile(openFileDialog1.FileName);
                pic_hinhanh.SizeMode = PictureBoxSizeMode.Zoom;
                pic_hinhanh.Image = img;


            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }
    }
}
