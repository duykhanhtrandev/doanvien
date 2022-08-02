using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLDOANVIEN
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        void openForm(Type typeForm)
        {
            foreach (var frm in MdiChildren)
            {
                if(frm.GetType()==typeForm)
                {
                    frm.Activate();
                    return;
                }
            }
            Form f = (Form) Activator.CreateInstance(typeForm);
            f.MdiParent = this;
            f.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ribbonControl1.SelectedPage = ribbonPage2; // Mo tad Doan Vien khi khoi dong
        }

        private void btnDanToc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(typeof(frmDanToc));
        }

        private void btnTonGiao_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(typeof(frmTonGiao));
        }

        private void btnTrinhDo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(typeof(frmTrinhDo));
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(typeof(frmChiBo));
        }

        private void btnNoiSinhHoatDoan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(typeof(frmNoiSinhHoatDoan));
        }

        private void btnLop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(typeof(frmLOP));
        }

        private void btnChucVu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(typeof(frmChucVu));
        }

        private void btnDoanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(typeof(frmDoanVien));
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn đăng xuất không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LoginForm f = new LoginForm();
                f.Show();
                this.Hide();
            }
        }

        private void btnKhenThuong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(typeof(frmKhenThuong));
        }

        private void btnKhaiTru_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(typeof(frmDoanVien_BiKhaiTru));
        }
    }
}
