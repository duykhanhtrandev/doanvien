namespace QLDOANVIEN
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnDanToc = new DevExpress.XtraBars.BarButtonItem();
            this.btnTonGiao = new DevExpress.XtraBars.BarButtonItem();
            this.btnTrinhDo = new DevExpress.XtraBars.BarButtonItem();
            this.btnDoanVien = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnKhenThuong = new DevExpress.XtraBars.BarButtonItem();
            this.btnDieuChuyen = new DevExpress.XtraBars.BarButtonItem();
            this.btnKhaiTru = new DevExpress.XtraBars.BarButtonItem();
            this.btnDoiMatKhau = new DevExpress.XtraBars.BarButtonItem();
            this.btnBackup = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhucHoiDuLieu = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.btnNoiSinhHoatDoan = new DevExpress.XtraBars.BarButtonItem();
            this.btnLop = new DevExpress.XtraBars.BarButtonItem();
            this.btnChucVu = new DevExpress.XtraBars.BarButtonItem();
            this.btnKyLuat = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage4 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.documentManager1 = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.tabbedView1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.btnDanToc,
            this.btnTonGiao,
            this.btnTrinhDo,
            this.btnDoanVien,
            this.barButtonItem1,
            this.btnKhenThuong,
            this.btnDieuChuyen,
            this.btnKhaiTru,
            this.btnDoiMatKhau,
            this.btnBackup,
            this.btnPhucHoiDuLieu,
            this.btnThoat,
            this.btnNoiSinhHoatDoan,
            this.btnLop,
            this.btnChucVu,
            this.btnKyLuat});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 17;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2,
            this.ribbonPage4});
            this.ribbonControl1.Size = new System.Drawing.Size(922, 158);
            // 
            // btnDanToc
            // 
            this.btnDanToc.Caption = "Dân tộc";
            this.btnDanToc.Id = 1;
            this.btnDanToc.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDanToc.ImageOptions.SvgImage")));
            this.btnDanToc.Name = "btnDanToc";
            this.btnDanToc.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnDanToc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDanToc_ItemClick);
            // 
            // btnTonGiao
            // 
            this.btnTonGiao.Caption = "Tôn giáo";
            this.btnTonGiao.Id = 2;
            this.btnTonGiao.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnTonGiao.ImageOptions.SvgImage")));
            this.btnTonGiao.Name = "btnTonGiao";
            this.btnTonGiao.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnTonGiao.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTonGiao_ItemClick);
            // 
            // btnTrinhDo
            // 
            this.btnTrinhDo.Caption = "Trình độ";
            this.btnTrinhDo.Id = 3;
            this.btnTrinhDo.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnTrinhDo.ImageOptions.SvgImage")));
            this.btnTrinhDo.Name = "btnTrinhDo";
            this.btnTrinhDo.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnTrinhDo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTrinhDo_ItemClick);
            // 
            // btnDoanVien
            // 
            this.btnDoanVien.Caption = "Đoàn Viên";
            this.btnDoanVien.Id = 4;
            this.btnDoanVien.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDoanVien.ImageOptions.SvgImage")));
            this.btnDoanVien.Name = "btnDoanVien";
            this.btnDoanVien.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnDoanVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDoanVien_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Chi Bộ";
            this.barButtonItem1.Id = 5;
            this.barButtonItem1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem1.ImageOptions.SvgImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // btnKhenThuong
            // 
            this.btnKhenThuong.Caption = "Khen Thưởng, Kỷ Luật";
            this.btnKhenThuong.Id = 6;
            this.btnKhenThuong.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnKhenThuong.ImageOptions.SvgImage")));
            this.btnKhenThuong.Name = "btnKhenThuong";
            this.btnKhenThuong.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnKhenThuong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKhenThuong_ItemClick);
            // 
            // btnDieuChuyen
            // 
            this.btnDieuChuyen.Caption = "Điều Chuyển";
            this.btnDieuChuyen.Id = 7;
            this.btnDieuChuyen.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDieuChuyen.ImageOptions.SvgImage")));
            this.btnDieuChuyen.Name = "btnDieuChuyen";
            this.btnDieuChuyen.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnKhaiTru
            // 
            this.btnKhaiTru.Caption = "Khai Trừ";
            this.btnKhaiTru.Id = 8;
            this.btnKhaiTru.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnKhaiTru.ImageOptions.SvgImage")));
            this.btnKhaiTru.Name = "btnKhaiTru";
            this.btnKhaiTru.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnKhaiTru.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKhaiTru_ItemClick);
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.Caption = "Đổi Mật Khẩu";
            this.btnDoiMatKhau.Id = 9;
            this.btnDoiMatKhau.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDoiMatKhau.ImageOptions.SvgImage")));
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            this.btnDoiMatKhau.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnBackup
            // 
            this.btnBackup.Caption = "Sao Lưu Dữ Liệu";
            this.btnBackup.Id = 10;
            this.btnBackup.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnBackup.ImageOptions.SvgImage")));
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnPhucHoiDuLieu
            // 
            this.btnPhucHoiDuLieu.Caption = "Phục Hồi Dữ Liệu";
            this.btnPhucHoiDuLieu.Id = 11;
            this.btnPhucHoiDuLieu.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPhucHoiDuLieu.ImageOptions.SvgImage")));
            this.btnPhucHoiDuLieu.Name = "btnPhucHoiDuLieu";
            this.btnPhucHoiDuLieu.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Đăng Xuất";
            this.btnThoat.Id = 12;
            this.btnThoat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThoat.ImageOptions.SvgImage")));
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // btnNoiSinhHoatDoan
            // 
            this.btnNoiSinhHoatDoan.Caption = "Nơi Sinh Hoạt Đoàn";
            this.btnNoiSinhHoatDoan.Id = 13;
            this.btnNoiSinhHoatDoan.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnNoiSinhHoatDoan.ImageOptions.SvgImage")));
            this.btnNoiSinhHoatDoan.Name = "btnNoiSinhHoatDoan";
            this.btnNoiSinhHoatDoan.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnNoiSinhHoatDoan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNoiSinhHoatDoan_ItemClick);
            // 
            // btnLop
            // 
            this.btnLop.Caption = "Lớp Quản Lý";
            this.btnLop.Id = 14;
            this.btnLop.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLop.ImageOptions.SvgImage")));
            this.btnLop.Name = "btnLop";
            this.btnLop.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLop_ItemClick);
            // 
            // btnChucVu
            // 
            this.btnChucVu.Caption = "Chức Vụ";
            this.btnChucVu.Id = 15;
            this.btnChucVu.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnChucVu.ImageOptions.SvgImage")));
            this.btnChucVu.Name = "btnChucVu";
            this.btnChucVu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnChucVu_ItemClick);
            // 
            // btnKyLuat
            // 
            this.btnKyLuat.Caption = "Kỷ Luật";
            this.btnKyLuat.Id = 16;
            this.btnKyLuat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnKyLuat.ImageOptions.SvgImage")));
            this.btnKyLuat.Name = "btnKyLuat";
            this.btnKyLuat.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Hệ thống";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDoiMatKhau);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnThoat, true);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Hệ thống";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Đoàn Viên";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnDanToc);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnTonGiao, true);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnTrinhDo, true);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnNoiSinhHoatDoan, true);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem1, true);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnLop, true);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnDoanVien, true);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnChucVu, true);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Danh mục chung";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnKhenThuong, true);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnDieuChuyen, true);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnKhaiTru, true);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Hoạt động";
            // 
            // ribbonPage4
            // 
            this.ribbonPage4.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup5});
            this.ribbonPage4.Name = "ribbonPage4";
            this.ribbonPage4.Text = "Báo cáo";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "ribbonPageGroup5";
            // 
            // documentManager1
            // 
            this.documentManager1.MdiParent = this;
            this.documentManager1.MenuManager = this.ribbonControl1;
            this.documentManager1.View = this.tabbedView1;
            this.documentManager1.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabbedView1});
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 398);
            this.Controls.Add(this.ribbonControl1);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("MainForm.IconOptions.Image")));
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Phần mềm quản lý Đoàn Viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem btnDanToc;
        private DevExpress.XtraBars.BarButtonItem btnTonGiao;
        private DevExpress.XtraBars.BarButtonItem btnTrinhDo;
        private DevExpress.XtraBars.BarButtonItem btnDoanVien;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem btnKhenThuong;
        private DevExpress.XtraBars.BarButtonItem btnDieuChuyen;
        private DevExpress.XtraBars.BarButtonItem btnKhaiTru;
        private DevExpress.XtraBars.BarButtonItem btnDoiMatKhau;
        private DevExpress.XtraBars.BarButtonItem btnBackup;
        private DevExpress.XtraBars.BarButtonItem btnPhucHoiDuLieu;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager1;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView1;
        private DevExpress.XtraBars.BarButtonItem btnNoiSinhHoatDoan;
        private DevExpress.XtraBars.BarButtonItem btnLop;
        private DevExpress.XtraBars.BarButtonItem btnChucVu;
        private DevExpress.XtraBars.BarButtonItem btnKyLuat;
    }
}

