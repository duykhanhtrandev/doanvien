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
    public partial class frmChiBo : DevExpress.XtraEditors.XtraForm
    {
        public frmChiBo()
        {
            InitializeComponent();
        }

        CHIBO _chibo;
        bool _them;
        int _id;

        private void frmChiBo_Load(object sender, EventArgs e)
        {
            _them = false;
            _chibo = new CHIBO();
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
            gcDanhSach.DataSource = _chibo.getList();
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
            if (MessageBox.Show("Bạn có chắc muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _chibo.Delete(_id);
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
                tb_CHIBO cb = new tb_CHIBO();
                cb.TENCHIBO = txtTen.Text;
                _chibo.Add(cb);
            }
            else
            {
                var cb = _chibo.getItem(_id);
                cb.TENCHIBO = txtTen.Text;
                _chibo.Update(cb);
            }
        }

        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            _id = int.Parse(gvDanhSach.GetFocusedRowCellValue("IDCHIBO").ToString());
            txtTen.Text = gvDanhSach.GetFocusedRowCellValue("TENCHIBO").ToString();
        }
    }
}