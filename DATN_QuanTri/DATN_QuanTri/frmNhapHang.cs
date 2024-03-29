﻿using System;
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
    public partial class frmNhapHang : Form
    {
        public frmNhapHang()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
        }

        int flag_Them, flag_Them_ctpn = 0;
        int flag_Sua, flag_Sua_ctpn = 0;
        PhieuNhap_BLL pn = new PhieuNhap_BLL();
        CTPhieuNhap_BLL ctpn = new CTPhieuNhap_BLL();
        NhanVien_BLL nv = new NhanVien_BLL();
        NhaCungCap_BLL ncc = new NhaCungCap_BLL();
        HangHoa_BLL hh = new HangHoa_BLL();
        PhieuDat_BLL pd = new PhieuDat_BLL();
        MauSac_BLL ms = new MauSac_BLL();
        CTPHIEUDAT_BLL ctpd = new CTPHIEUDAT_BLL();
        string chuoikn = @"Data Source=DESKTOP-KAM5FCS\SQLEXPRESS;Initial Catalog=VATLIEULOTSAN;Integrated Security=True";
        public string tangmaTuDong()
        {
            
                string sql = "select * from PHIEUNHAP";
                SqlConnection con = new SqlConnection();
                con.ConnectionString = chuoikn;
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                string ma = "";
                if (dt.Rows.Count <= 0)
                {
                    ma = "PN001" + DateTime.Now.ToShortDateString();
                }
                else
                {
                    int k;
                    ma = "PN";
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
        public void doDL(ComboBox cb, DataTable db, String dis, String value)
        {
            try
            {
                cb.DataSource = db;
                cb.DisplayMember = dis;
                cb.ValueMember = value;
            }
            catch
            { }
        }
        private void btnThem_pn_Click(object sender, EventArgs e)
        {
            txtmapn_pn.Text = tangmaTuDong();
            flag_Them = 1;
            txtmapn_pn.Enabled = false;
            dateTimePicker1.Enabled = cbmanv_pn.Enabled = cbomancc_pn.Enabled = cbomaphieudat.Enabled =cbotinhtrang_pn.Enabled = true;
            txttongtien_pn.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (r == DialogResult.OK)
                this.Close();
        }

        private void frmNhapHang_Load(object sender, EventArgs e)
        {
            try
            {
                txtmapn_pn.Text = tangmaTuDong();
                gridControl1.DataSource = ctpn.loadCTPN();
                gridControl2.DataSource = pn.loadPN();
                txttongtien_pn.Enabled = false;
                txtdongianhap.Enabled = dateTimePicker1.Enabled = cbo_phieunhap.Enabled = txtmapn_pn.Enabled = txtsoluong.Enabled = cbmanv_pn.Enabled = cbomahang.Enabled = cbomancc_pn.Enabled = cbomaphieudat.Enabled = cbomausac_ctpn.Enabled = cbotinhtrang_pn.Enabled = false;
                doDL(cbomaphieudat, pd.loadPD(), "MAPHIEUDAT", "MANCC");
                doDL(cbmanv_pn, nv.loadDL(), "MANV", "TENNV");
                doDL(cbomancc_pn, ncc.loadDulieu_NCC(), "MANCC", "TENNCC");
                doDL(cbo_phieunhap, pn.loadPN(), "MAPHIEUNHAP", "MAPHIEUDAT");
                doDL(cbomahang, hh.loadDL(), "MAHANG", "TENHANG");
                doDL(cbomausac_ctpn, ms.loaddl(), "MAMAU", "TENMAU");
            }
          catch
            {

            }

        }

        private void btnLuu_pn_Click(object sender, EventArgs e)
        {
                if (flag_Them == 1)
                {
                    try
                    {
                        int t=pn.themPN(txtmapn_pn.Text, cbomaphieudat.Text, cbomancc_pn.Text, cbmanv_pn.Text,DateTime.Parse(dateTimePicker1.Text),  cbotinhtrang_pn.Text);
                        if (t == 1)
                            MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    }
                }
            gridControl2.DataSource = pn.loadPN();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            cbo_phieunhap.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MAPHIEUNHAP").ToString();
            cbomahang.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MAHANG").ToString();
            cbomausac_ctpn.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MAMAU").ToString();
            txtsoluong.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "SOLUONG").ToString();
            txtdongianhap.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "DONGIANHAP").ToString();
        }

        private void btnThem_ctpn_Click(object sender, EventArgs e)
        {
            flag_Them_ctpn = 1;
           cbo_phieunhap.Enabled =  txtsoluong.Enabled =  cbomahang.Enabled =  cbomausac_ctpn.Enabled=txtdongianhap.Enabled =true;
        }

        private void btnLuu_ctpn_Click(object sender, EventArgs e)
        {
           if (flag_Them_ctpn == 1)
                {
                    try
                    {
                        int t = ctpn.themCTPN(cbo_phieunhap.Text,  cbomahang.Text, cbomausac_ctpn.Text, int.Parse(txtsoluong.Text),Double.Parse(txtdongianhap.Text));
                        if (t == 1)
                            MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                           
                    }
                    catch
                    {
                        MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    }
                }
            gridControl1.DataSource = ctpn.loadCTPN();
            //txttongtien_pn.Text = ctpn.tongtien(cbo_phieunhap.SelectedValue.ToString());
            //gridControl2.DataSource = pd.loadPD();
            //if (int.Parse(ctpn.demMaPN(cbo_phieunhap.SelectedValue.ToString())) < 1)
            //    txttongtien_pn.Text = "0";
            //try
            //{
            //    int cn = pd.Capnhat_thanhtienPD(cbo_phieunhap.SelectedValue.ToString(), Double.Parse(txttongtien_pn.Text));
            //}
            //catch
            //{
            //    MessageBox.Show("Cập nhật lại thành tiền thất bại");
            //}
        }

        private void txttongtien_pn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void txtsoluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void labelControl12_Click(object sender, EventArgs e)
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
        private void cbomaphieudat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gridView2_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            if(e.RowHandle >= 0)
            {
                if (e.RowHandle % 2 == 0)
                {
                    e.Appearance.BackColor = Color.CornflowerBlue;
                }
            }
        }

        private void gridView1_RowCellStyle_1(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            if(e.RowHandle >= 0)
            {
                if (e.RowHandle % 2 == 0)
                {
                    e.Appearance.BackColor = Color.CornflowerBlue;
                }
            }
        }

        private void gridView2_RowCellStyle_1(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                if (e.RowHandle % 2 == 0)
                {
                    e.Appearance.BackColor = Color.CornflowerBlue;
                }
            }
        }

        private void cbomahang_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = chuoikn;
            SqlCommand cmd = new SqlCommand("Select * from HANGHOA WHERE MAHANG='" + cbomahang.SelectedValue.ToString() + "'", con);
            con.Open();
            SqlDataReader read = cmd.ExecuteReader();
            if (read.HasRows)
            {
                read.Read();
                txtdongianhap.Text = read.GetString(7).ToString();
            }
        }

        private void gridControl1_Click_1(object sender, EventArgs e)
        {
            cbo_phieunhap.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MAPHIEUNHAP").ToString();
            cbomahang.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MAHANG").ToString();
            cbomausac_ctpn.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MAMAU").ToString();
            txtsoluong.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "SOLUONG").ToString();
            txtdongianhap.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "DONGIANHAP").ToString();
        }

        private void gridControl2_Click_1(object sender, EventArgs e)
        {
            txtmapn_pn.Text = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "MAPHIEUNHAP").ToString();
            cbomaphieudat.Text = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "MAPHIEUDAT").ToString();
            cbomancc_pn.Text = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "MANCC").ToString();
            cbmanv_pn.Text = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "MANV").ToString();
            dateTimePicker1.Text = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "NGAYNHAP").ToString();
            txttongtien_pn.Text = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "TONGTIEN").ToString();
            cbotinhtrang_pn.Text = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "TINHTRANG").ToString();
        }

        private void gridControl2_Click(object sender, EventArgs e)
        {
            txtmapn_pn.Text = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "MAPHIEUNHAP").ToString();
            cbomaphieudat.Text = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "MAPHIEUDAT").ToString();
            cbomancc_pn.Text = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "MANCC").ToString();
            cbmanv_pn.Text = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "MANV").ToString();
            dateTimePicker1.Text = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "NGAYNHAP").ToString();
            txttongtien_pn.Text = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "TONGTIEN").ToString();
            cbotinhtrang_pn.Text = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "TINHTRANG").ToString();
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            doDL(cbo_phieunhap, pn.loadPN(), "MAPHIEUNHAP", "MAPHIEUDAT");
        }
    }
}
