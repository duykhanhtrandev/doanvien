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
    public partial class frmDanToc : DevExpress.XtraEditors.XtraForm
    {
        public frmDanToc()
        {
            InitializeComponent();
        }

        DANTOC _dantoc;
        bool _them;
        int _id;

        private void frmDanToc_Load(object sender, EventArgs e)
        {
            _them = false;
            _dantoc = new DANTOC();
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
        }

        void loadData()
        {
            gcDanhSach.DataSource = _dantoc.getList();
            gvDanhSach.OptionsBehavior.Editable = false;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _showHide(false);
            _them = true;
            txtTen.Text = String.Empty;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _them = false;
            _showHide(false);
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc muốn xóa không?", "Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _dantoc.Delete(_id);
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
                tb_DANTOC dt = new tb_DANTOC();
                dt.TENDANTOC = txtTen.Text;
                _dantoc.Add(dt);
            }
            else
            {
                var dt = _dantoc.getItem(_id);
                dt.TENDANTOC = txtTen.Text;
                _dantoc.Update(dt);
            }
        }

        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            _id = int.Parse(gvDanhSach.GetFocusedRowCellValue("IDDANTOC").ToString());
            txtTen.Text = gvDanhSach.GetFocusedRowCellValue("TENDANTOC").ToString();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtTen_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}