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
    public partial class frmHangHoa : Form
    {
        HangHoa_BLL hh = new HangHoa_BLL();
        int flag_Them = 0;
        int flag_Xoa = 0;
        int flag_Sua = 0;
        public frmHangHoa()
        {
            InitializeComponent();
        }
        public void khoaControl()
        {
            btnLuu.Enabled = true;
            btnSua.Enabled = btnThem.Enabled = false;
            txtMahang.Enabled = txttenhang.Enabled = txtgiaban.Enabled = txtgianhap.Enabled = txtluotxem.Enabled = cbomausac.Enabled = txtmota.Enabled = dateTimePicker2.Enabled = txtsoluong.Enabled = true;
            cbodvt.Enabled = cbomahang.Enabled = cbotinhtrang.Enabled =txthinh.Enabled=true;
        }
        private void simpleButton5_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (r == DialogResult.OK)
                this.Close();
        }
        MauSac_BLL ms = new MauSac_BLL();
        LoaiHang_BLL lh = new LoaiHang_BLL();
        public void doDL( ComboBox cb, DataTable db, String dis, String value)
        {
            cb.DataSource = db;
            cb.DisplayMember = dis;
            cb.ValueMember = value;
        }
        string chuoikn = @"Data Source=DESKTOP-KAM5FCS\SQLEXPRESS;Initial Catalog=VATLIEULOTSAN;Integrated Security=True";
        public string tangmaTuDong()
        {
            string sql = "select * from HANGHOA";
            SqlConnection con = new SqlConnection();
            con.ConnectionString = chuoikn;
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            string ma = "";
            if (dt.Rows.Count <= 0)
            {
                ma = "HH001" + DateTime.Now.ToShortDateString();
            }
            else
            {
                int k;
                ma = "HH";
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
        private void frmHangHoa_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = hh.loadDL();

            doDL(cbomausac, ms.loaddl(), "MAMAU", "TENMAU");
            doDL(cbomahang, lh.loaddL(), "MALOAI", "TENLOAI");

            btnLuu.Enabled = false;
            btnThem.Enabled = btnSua.Enabled = true;
            txtluotxem.Enabled=dateTimePicker2.Enabled=cbotinhtrang.Enabled= txthinh.Enabled = txtMahang.Enabled = txttenhang.Enabled = txtgiaban.Enabled = txtgianhap.Enabled = cbomausac.Enabled = txtmota.Enabled =  txtsoluong.Enabled = false;
            cbodvt.Enabled = cbomahang.Enabled =  false;
            txtMahang.Enabled = false;
            txtMahang.Text = tangmaTuDong();
          
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            flag_Them = 1;
            txtMahang.Enabled = false;
            khoaControl();
            txtgiaban.ResetText();
            txtgianhap.ResetText();
            cbomausac.ResetText();
            txtmota.ResetText();
            txtsoluong.ResetText();
            txttenhang.ResetText();
            cbodvt.ResetText();
            cbomahang.ResetText();
        // txthinh.Text= txtnoibat.Text= txtluotxem.Text = cbotinhtrang.Text = "0";
         //  txtluotxem.Enabled = txtnoibat.Enabled = txthinh.Enabled = cbotinhtrang.Enabled = false;
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
                     hh.xoaHH(txtMahang.Text,txttenhang.Text,cbomahang.Text,cbodvt.Text,txtmota.Text,txthinh.Text,cbomausac.Text,Double.Parse(txtgianhap.Text), Double.Parse(txtgiaban.Text),DateTime.Parse(dateTimePicker1.Text),int.Parse(txtsoluong.Text),dateTimePicker2.Text,int.Parse(txtluotxem.Text),cbotinhtrang.Text);
                    gridControl1.DataSource = hh.loadDL();
                }
            }

            catch
            {
                MessageBox.Show("Xóa thất bại");
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (flag_Them == 1)
            {
                try
                {
                    int t = hh.themHH(txtMahang.Text, txttenhang.Text, cbomahang.Text, cbodvt.Text, txtmota.Text,txthinh.Text, cbomausac.Text, Double.Parse(txtgianhap.Text), Double.Parse(txtgiaban.Text), DateTime.Parse(dateTimePicker1.Text),int.Parse( txtsoluong.Text), dateTimePicker2.Text,int.Parse(txtluotxem.Text), cbotinhtrang.Text);
                    if (t == 1)
                        MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
            }

            flag_Sua = flag_Them = 0;
            gridControl1.DataSource = hh.loadDL();
            btnThem.Enabled = btnSua.Enabled = true;
            txtMahang.Enabled = txttenhang.Enabled = cbomahang.Enabled = cbodvt.Enabled = txtmota.Enabled = txthinh.Enabled = cbomausac.Enabled = txtgianhap.Enabled = txtgiaban.Enabled = txtsoluong.Enabled = dateTimePicker2.Enabled = txtluotxem.Enabled = cbotinhtrang.Enabled = false; ;
            txtMahang.Enabled = true;
        }

        private void txtgianhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void txtgiaban_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void txtsoluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            txtMahang.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MAHANG").ToString();
            txttenhang.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TENHANG").ToString();
            cbomahang.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MALOAI").ToString();
            cbodvt.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "DONVITINH").ToString();
            txtmota.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MOTA").ToString();
            txthinh.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "HINH").ToString();
            cbomausac.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MAU").ToString();
            txtgianhap.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "GIANHAP").ToString();
            txtgiaban.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "GIABAN").ToString();
            dateTimePicker1.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "NGAYTAO").ToString();
            txtsoluong.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "SOLUONG").ToString();
            dateTimePicker2.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "NOIBAT").ToString();
            txtluotxem.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "LUOTXEM").ToString();
            cbotinhtrang.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TINHTRANG").ToString();
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
