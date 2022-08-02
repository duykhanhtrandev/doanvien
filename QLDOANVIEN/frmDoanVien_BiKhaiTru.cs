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
    public partial class frmDoanVien_BiKhaiTru : DevExpress.XtraEditors.XtraForm
    {
        public frmDoanVien_BiKhaiTru()
        {
            InitializeComponent();
        }

        //Biến toàn cục
        bool _them;
        string _soQD;
        DOANVIEN_BIKHAITRU _dvbkt;
        DOANVIEN _doanvien;

        private void frmDoanVien_BiKhaiTru_Load(object sender, EventArgs e)
        {
            _dvbkt = new DOANVIEN_BIKHAITRU();
            _doanvien = new DOANVIEN();
            _them = false;
            _showHide(true);
            loadDoanVien();
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
            gcDanhSach2.Enabled = kt;
            txtSoQD.Enabled = !kt;
            txtGhiChu.Enabled = !kt;
            txtLyDo.Enabled = !kt;
            //txtTen.Enabled = !kt;
            slkDoanVien.Enabled = !kt;
            dtNgayKhaiTru.Enabled = !kt;
        }
        
        private void _reset()
        {
            txtSoQD.Text = String.Empty;
            txtLyDo.Text = String.Empty;
            txtGhiChu.Text = String.Empty;
        }

        void loadDoanVien()
        {
            slkDoanVien.Properties.DataSource = _doanvien.getListFull();
            slkDoanVien.Properties.ValueMember = "MADOANVIEN";
            slkDoanVien.Properties.DisplayMember = "HOTEN";
        }

        void loadData()
        {
            gcDanhSach2.DataSource = _dvbkt.getListFull();
            gvDanhSach2.OptionsBehavior.Editable = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

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
            gcDanhSach2.Enabled = true;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _dvbkt.Delete(_soQD, 1);
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
            tb_DOANVIEN_BIKHAITRU bkt;
            if (_them)
            {
                // Số QĐ có dạng: 00001/2022/SQĐ
                var maxSoQD = _dvbkt.MaxSoQuyetDinh();
                int so = int.Parse(maxSoQD.Substring(0, 5)) + 1;
                bkt = new tb_DOANVIEN_BIKHAITRU();
                bkt.SOQD = so.ToString("00000") + @"/" + DateTime.Now.Year.ToString() + @"/QĐKT";
                bkt.LYDO = txtLyDo.Text;
                bkt.NGAYKHAITRU = dtNgayKhaiTru.Value;
                bkt.GHICHU = txtGhiChu.Text;
                bkt.MADOANVIEN = int.Parse(slkDoanVien.EditValue.ToString());
                bkt.CREATED_BY = 1;
                bkt.CREATED_DATE = DateTime.Now;
                _dvbkt.Add(bkt);
            }
            else
            {
                bkt = _dvbkt.getItem(_soQD);
                bkt.LYDO = txtLyDo.Text;
                bkt.NGAYKHAITRU = dtNgayKhaiTru.Value;
                bkt.GHICHU = txtGhiChu.Text;
                bkt.MADOANVIEN = int.Parse(slkDoanVien.EditValue.ToString());
                bkt.UPDATED_BY = 1;
                bkt.UPDATED_DATE = DateTime.Now;
                _dvbkt.Update(bkt);
            }
            var dv = _doanvien.getItem(bkt.MADOANVIEN.Value);
            dv.DAKHAITRU = true;
            _doanvien.Update(dv);

        }

        private void gvDanhSach2_Click(object sender, EventArgs e)
        {
            if (gvDanhSach2.RowCount > 0)
            {
                _soQD = gvDanhSach2.GetFocusedRowCellValue("SOQD").ToString();
                var kt = _dvbkt.getItem(_soQD);
                txtSoQD.Text = _soQD;
                dtNgayKhaiTru.Value = kt.NGAYKHAITRU.Value;
                slkDoanVien.EditValue = kt.MADOANVIEN;
                txtGhiChu.Text = kt.GHICHU;
                txtLyDo.Text = kt.LYDO;
            }
        }

        private void gvDanhSach2_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            //if(e.Column.Name == "DELETED_BY" && e.CellValue != null)
            //{
            //    Image img = Properties.Resources;
            //    e.Graphics.DrawImage(img, e.Bounds.X, e.Bounds.Y);
            //    e.Handled = true;
            //}    
        }

        private void dtNgayKhaiTru_ValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}