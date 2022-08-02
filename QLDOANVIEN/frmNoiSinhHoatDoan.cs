using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer;
using ManageLayer;

namespace QLDOANVIEN
{
    public partial class frmNoiSinhHoatDoan : DevExpress.XtraEditors.XtraForm
    {
        public frmNoiSinhHoatDoan()
        {
            InitializeComponent();
        }

        NOISINHHOATDOAN _noisinhhoatdoan;
        bool _them;
        int _id;

        private void frmNoiSinhHoatDoan_Load(object sender, EventArgs e)
        {
            _them = false;
            _noisinhhoatdoan = new NOISINHHOATDOAN();
            _showHide(true);
            loadData();
        }

        void _showHide(bool kt) // Hieu ung mo dam cho chon 1 trong cac button
        {
            btnLuu.Enabled = !kt;
            btnHuy.Enabled = !kt;
            btnThem.Enabled = kt;
            btnSua.Enabled = kt;
            btnXoa.Enabled = kt;
            btnDong.Enabled = kt;
            btnIn.Enabled = kt;
            txtTen.Enabled = !kt;
            txtDiaChi.Enabled = !kt;
            txtEmail.Enabled = !kt;
            txtDienThoai.Enabled = !kt;
        }

        void loadData()
        {
            gcDanhSach.DataSource = _noisinhhoatdoan.getList();
            gvDanhSach.OptionsBehavior.Editable = false;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _showHide(false);
            _them = true;
            txtTen.Text = String.Empty;
            txtDiaChi.Text = String.Empty;
            txtEmail.Text = String.Empty;
            txtDienThoai.Text = String.Empty;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _them = false;
            _showHide(false);
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _noisinhhoatdoan.Delete(_id);
                loadData();
            }
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveData();
            loadData();
            _them = false;
            _showHide(true);
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _them = false;
            _showHide(true);
        }

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }


        void SaveData()
        {
            if (_them)
            {
                tb_NOISINHHOATDOAN nshd = new tb_NOISINHHOATDOAN();
                nshd.TENNOISINHHOATDOAN = txtTen.Text;
                nshd.EMAIL = txtEmail.Text;
                nshd.DIENTHOAI = txtDienThoai.Text;
                nshd.DIACHI = txtDiaChi.Text;
                _noisinhhoatdoan.Add(nshd);
            }
            else
            {
                var nshd = _noisinhhoatdoan.getItem(_id);
                nshd.TENNOISINHHOATDOAN = txtTen.Text;
                nshd.EMAIL = txtEmail.Text;
                nshd.DIENTHOAI = txtDienThoai.Text;
                nshd.DIACHI = txtDiaChi.Text;
                _noisinhhoatdoan.Update(nshd);
            }
        }

        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            _id = int.Parse(gvDanhSach.GetFocusedRowCellValue("MANOISINHHOATDOAN").ToString());
            txtTen.Text = gvDanhSach.GetFocusedRowCellValue("TENNOISINHHOATDOAN").ToString();
            txtDiaChi.Text = gvDanhSach.GetFocusedRowCellValue("DIACHI").ToString();
            txtEmail.Text = gvDanhSach.GetFocusedRowCellValue("EMAIL").ToString();
            txtDienThoai.Text = gvDanhSach.GetFocusedRowCellValue("DIENTHOAI").ToString();
        }
    }
}