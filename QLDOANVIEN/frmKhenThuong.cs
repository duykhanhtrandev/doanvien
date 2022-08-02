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
    public partial class frmKhenThuong : DevExpress.XtraEditors.XtraForm
    {
        public frmKhenThuong()
        {
            InitializeComponent();
        }
        bool _them;
        string _soQD;
        KHENTHUONG_KYLUAT _ktkl;
        DOANVIEN _doanvien;

        private void frmKhenThuong_Load(object sender, EventArgs e)
        {
            _ktkl = new KHENTHUONG_KYLUAT();
            _doanvien = new DOANVIEN();
            _them = false;
            _showHide(true);
            loadDoanVien();
            loadData();

            splitContainer1.Panel1Collapsed = true;
        }

        private void _showHide(bool kt)
        {
            btnLuu.Enabled = !kt;
            btnHuy.Enabled = !kt;
            btnThem.Enabled = kt;
            btnSua.Enabled = kt;
            btnXoa.Enabled = kt;
            btnDong.Enabled = kt;
            btnIn.Enabled = kt;
            gcDanhSach.Enabled = kt;
            txtSoQD.Enabled = !kt;
            txtNoiDung.Enabled = !kt;
            txtLyDo.Enabled = !kt;
            //dtNgayBatDau.Enabled = !kt;
            //dtNgayKetThuc.Enabled = !kt;
            slkDoanVien.Enabled = !kt;
        }

        private void _reset()
        {
            txtSoQD.Text = String.Empty;
            txtLyDo.Text = String.Empty;
            txtNoiDung.Text = String.Empty;
            //dtNgayBatDau.Value = DateTime.Now;
            //dtNgayBatDau.Value = dtNgayBatDau.Value.AddMonths(6);
        }

        private void loadDoanVien()
        {
            slkDoanVien.Properties.DataSource = _doanvien.getList();
            slkDoanVien.Properties.ValueMember = "MADOANVIEN";
            slkDoanVien.Properties.DisplayMember = "HOTEN";
        }

        private void loadData()
        {
            gcDanhSach.DataSource = _ktkl.getListFull(1);
            gvDanhSach.OptionsBehavior.Editable = false;

        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _showHide(false);
            _them = true;
            _reset();
            splitContainer1.Panel1Collapsed = false;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _them = false;
            _showHide(false);
            splitContainer1.Panel1Collapsed = false;
            gcDanhSach.Enabled = true;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _ktkl.Delete(_soQD, 1);
                loadData();
            }    
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveData();
            loadData();
            _them = false;
            _showHide(true);
            splitContainer1.Panel1Collapsed = true;
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _them = false;
            _showHide(true);
            splitContainer1.Panel1Collapsed = true;
        }

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        public void SaveData()
        {
            if(_them)
            {
                // Số QĐ có dạng: 00001/2022/SQĐ
                var maxSoQD = _ktkl.MaxSoQuyetDinh(1);
                int so = int.Parse(maxSoQD.Substring(0, 5)) + 1;

                tb_KHENTHUONG_KYLUAT kt = new tb_KHENTHUONG_KYLUAT();
                kt.SOQUYETDINH = so.ToString("00000") + @"/2022/QDKT";
                //
                //
                kt.LYDO = txtLyDo.Text;
                kt.NGAY = dtNgay.Value;
                kt.NOIDUNG = txtNoiDung.Text;
                kt.MADOANVIEN = int.Parse(slkDoanVien.EditValue.ToString());
                kt.LOAI = 1;
                kt.CREATED_BY = 1;
                kt.CREARTED_DATE = DateTime.Now;
                _ktkl.Add(kt);
            }
            else
            {
                var kt = _ktkl.getItem(_soQD);
                //
                //
                kt.LYDO = txtLyDo.Text;
                kt.NGAY = dtNgay.Value;
                kt.NOIDUNG = txtNoiDung.Text;
                kt.MADOANVIEN = int.Parse(slkDoanVien.EditValue.ToString());
                kt.UPDATED_BY = 1;
                kt.UPDATED_DATE = DateTime.Now;
                _ktkl.Update(kt);
            }
        }

        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            if(gvDanhSach.RowCount > 0)
            {
                _soQD = gvDanhSach.GetFocusedRowCellValue("SOQUYETDINH").ToString();
                var kt = _ktkl.getItem(_soQD);
                txtSoQD.Text = _soQD;
                dtNgay.Value = kt.NGAY.Value;
                slkDoanVien.EditValue = kt.MADOANVIEN;
                txtNoiDung.Text = kt.NOIDUNG;
                txtLyDo.Text = kt.LYDO;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}