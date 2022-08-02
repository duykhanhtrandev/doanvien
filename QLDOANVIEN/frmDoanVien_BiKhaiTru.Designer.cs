namespace QLDOANVIEN
{
    partial class frmDoanVien_BiKhaiTru
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDoanVien_BiKhaiTru));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtTen = new DevExpress.XtraEditors.TextEdit();
            this.gvDanhSach = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IDCHUCVU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENCHUCVU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcDanhSach = new DevExpress.XtraGrid.GridControl();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnLuu = new DevExpress.XtraBars.BarButtonItem();
            this.btnHuy = new DevExpress.XtraBars.BarButtonItem();
            this.btnIn = new DevExpress.XtraBars.BarButtonItem();
            this.btnDong = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.slkDoanVien = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtSoQD = new DevExpress.XtraEditors.TextEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLyDo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtNgayKhaiTru = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.gcDanhSach2 = new DevExpress.XtraGrid.GridControl();
            this.gvDanhSach2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.DELETED_BY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SOQD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HOTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGAYKHAITRU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MADOANVIEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LYDO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GHICHU = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slkDoanVien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoQD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSach2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSach2)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(9, 13);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(22, 16);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Tên";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(37, 10);
            this.txtTen.Name = "txtTen";
            this.txtTen.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.Properties.Appearance.Options.UseFont = true;
            this.txtTen.Size = new System.Drawing.Size(161, 22);
            this.txtTen.TabIndex = 3;
            // 
            // gvDanhSach
            // 
            this.gvDanhSach.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IDCHUCVU,
            this.TENCHUCVU});
            this.gvDanhSach.GridControl = this.gcDanhSach;
            this.gvDanhSach.Name = "gvDanhSach";
            this.gvDanhSach.OptionsView.ShowGroupPanel = false;
            // 
            // IDCHUCVU
            // 
            this.IDCHUCVU.Caption = "ID";
            this.IDCHUCVU.FieldName = "IDCHUCVU";
            this.IDCHUCVU.MaxWidth = 30;
            this.IDCHUCVU.MinWidth = 30;
            this.IDCHUCVU.Name = "IDCHUCVU";
            this.IDCHUCVU.Visible = true;
            this.IDCHUCVU.VisibleIndex = 0;
            this.IDCHUCVU.Width = 30;
            // 
            // TENCHUCVU
            // 
            this.TENCHUCVU.Caption = "TÊN CHỨC VỤ";
            this.TENCHUCVU.FieldName = "TENCHUCVU";
            this.TENCHUCVU.Name = "TENCHUCVU";
            this.TENCHUCVU.Visible = true;
            this.TENCHUCVU.VisibleIndex = 1;
            // 
            // gcDanhSach
            // 
            this.gcDanhSach.Location = new System.Drawing.Point(0, 0);
            this.gcDanhSach.MainView = this.gvDanhSach;
            this.gcDanhSach.Name = "gcDanhSach";
            this.gcDanhSach.Size = new System.Drawing.Size(713, 288);
            this.gcDanhSach.TabIndex = 2;
            this.gcDanhSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDanhSach});
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnSua,
            this.btnXoa,
            this.btnLuu,
            this.btnHuy,
            this.btnDong,
            this.btnIn});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 7;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSua, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLuu, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnHuy, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnIn, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnDong, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThem.ImageOptions.SvgImage")));
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sửa";
            this.btnSua.Id = 1;
            this.btnSua.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSua.ImageOptions.SvgImage")));
            this.btnSua.Name = "btnSua";
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 2;
            this.btnXoa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXoa.ImageOptions.SvgImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnLuu
            // 
            this.btnLuu.Caption = "Lưu";
            this.btnLuu.Id = 3;
            this.btnLuu.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLuu.ImageOptions.SvgImage")));
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLuu_ItemClick);
            // 
            // btnHuy
            // 
            this.btnHuy.Caption = "Hủy";
            this.btnHuy.Id = 4;
            this.btnHuy.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnHuy.ImageOptions.SvgImage")));
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHuy_ItemClick);
            // 
            // btnIn
            // 
            this.btnIn.Caption = "In";
            this.btnIn.Id = 6;
            this.btnIn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnIn.ImageOptions.SvgImage")));
            this.btnIn.Name = "btnIn";
            this.btnIn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnIn_ItemClick);
            // 
            // btnDong
            // 
            this.btnDong.Caption = "Đóng";
            this.btnDong.Id = 5;
            this.btnDong.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDong.ImageOptions.SvgImage")));
            this.btnDong.Name = "btnDong";
            this.btnDong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDong_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(868, 27);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 372);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(868, 19);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 27);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 345);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(868, 27);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 345);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 27);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.splitContainer1.Panel1.Controls.Add(this.slkDoanVien);
            this.splitContainer1.Panel1.Controls.Add(this.txtSoQD);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.txtGhiChu);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.txtLyDo);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.dtNgayKhaiTru);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gcDanhSach2);
            this.splitContainer1.Size = new System.Drawing.Size(868, 345);
            this.splitContainer1.SplitterDistance = 110;
            this.splitContainer1.TabIndex = 5;
            // 
            // slkDoanVien
            // 
            this.slkDoanVien.EditValue = "[EditValue is null]";
            this.slkDoanVien.Location = new System.Drawing.Point(334, 13);
            this.slkDoanVien.MenuManager = this.barManager1;
            this.slkDoanVien.Name = "slkDoanVien";
            this.slkDoanVien.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.slkDoanVien.Properties.PopupView = this.searchLookUpEdit1View;
            this.slkDoanVien.Size = new System.Drawing.Size(161, 20);
            this.slkDoanVien.TabIndex = 19;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // txtSoQD
            // 
            this.txtSoQD.Location = new System.Drawing.Point(95, 14);
            this.txtSoQD.MenuManager = this.barManager1;
            this.txtSoQD.Name = "txtSoQD";
            this.txtSoQD.Size = new System.Drawing.Size(161, 20);
            this.txtSoQD.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(272, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Đoàn Viên";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(95, 66);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(659, 21);
            this.txtGhiChu.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(39, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Ghi Chú";
            // 
            // txtLyDo
            // 
            this.txtLyDo.Location = new System.Drawing.Point(95, 39);
            this.txtLyDo.Name = "txtLyDo";
            this.txtLyDo.Size = new System.Drawing.Size(659, 21);
            this.txtLyDo.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(55, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Lý Do";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(510, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Ngày Khai Trừ";
            // 
            // dtNgayKhaiTru
            // 
            this.dtNgayKhaiTru.CustomFormat = "dd/MM/yyyy";
            this.dtNgayKhaiTru.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.dtNgayKhaiTru.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayKhaiTru.Location = new System.Drawing.Point(593, 10);
            this.dtNgayKhaiTru.Name = "dtNgayKhaiTru";
            this.dtNgayKhaiTru.Size = new System.Drawing.Size(161, 23);
            this.dtNgayKhaiTru.TabIndex = 10;
            this.dtNgayKhaiTru.Value = new System.DateTime(2022, 5, 26, 4, 8, 5, 0);
            this.dtNgayKhaiTru.ValueChanged += new System.EventHandler(this.dtNgayKhaiTru_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số Quyết Định";
            // 
            // gcDanhSach2
            // 
            this.gcDanhSach2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDanhSach2.Location = new System.Drawing.Point(0, 0);
            this.gcDanhSach2.MainView = this.gvDanhSach2;
            this.gcDanhSach2.Name = "gcDanhSach2";
            this.gcDanhSach2.Size = new System.Drawing.Size(868, 231);
            this.gcDanhSach2.TabIndex = 3;
            this.gcDanhSach2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDanhSach2});
            // 
            // gvDanhSach2
            // 
            this.gvDanhSach2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.DELETED_BY,
            this.SOQD,
            this.HOTEN,
            this.NGAYKHAITRU,
            this.MADOANVIEN,
            this.LYDO,
            this.GHICHU});
            this.gvDanhSach2.GridControl = this.gcDanhSach2;
            this.gvDanhSach2.Name = "gvDanhSach2";
            this.gvDanhSach2.OptionsView.ShowGroupPanel = false;
            this.gvDanhSach2.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gvDanhSach2_CustomDrawCell);
            this.gvDanhSach2.Click += new System.EventHandler(this.gvDanhSach2_Click);
            // 
            // DELETED_BY
            // 
            this.DELETED_BY.Caption = "DELETED_BY";
            this.DELETED_BY.FieldName = "DELETED_BY";
            this.DELETED_BY.Name = "DELETED_BY";
            this.DELETED_BY.Visible = true;
            this.DELETED_BY.VisibleIndex = 5;
            this.DELETED_BY.Width = 50;
            // 
            // SOQD
            // 
            this.SOQD.Caption = "SỐ QUYẾT ĐỊNH";
            this.SOQD.FieldName = "SOQD";
            this.SOQD.Name = "SOQD";
            this.SOQD.Visible = true;
            this.SOQD.VisibleIndex = 0;
            this.SOQD.Width = 95;
            // 
            // HOTEN
            // 
            this.HOTEN.Caption = "HỌ TÊN";
            this.HOTEN.FieldName = "HOTEN";
            this.HOTEN.Name = "HOTEN";
            this.HOTEN.Visible = true;
            this.HOTEN.VisibleIndex = 1;
            this.HOTEN.Width = 154;
            // 
            // NGAYKHAITRU
            // 
            this.NGAYKHAITRU.Caption = "NGÀY KHAI TRỪ";
            this.NGAYKHAITRU.FieldName = "NGAYKHAITRU";
            this.NGAYKHAITRU.Name = "NGAYKHAITRU";
            this.NGAYKHAITRU.Visible = true;
            this.NGAYKHAITRU.VisibleIndex = 2;
            this.NGAYKHAITRU.Width = 161;
            // 
            // MADOANVIEN
            // 
            this.MADOANVIEN.Caption = "MÃ ĐOÀN VIÊN";
            this.MADOANVIEN.FieldName = "MADOANVIEN";
            this.MADOANVIEN.Name = "MADOANVIEN";
            // 
            // LYDO
            // 
            this.LYDO.Caption = "LÝ DO";
            this.LYDO.FieldName = "LYDO";
            this.LYDO.Name = "LYDO";
            this.LYDO.Visible = true;
            this.LYDO.VisibleIndex = 3;
            this.LYDO.Width = 196;
            // 
            // GHICHU
            // 
            this.GHICHU.Caption = "GHI CHÚ";
            this.GHICHU.FieldName = "GHICHU";
            this.GHICHU.Name = "GHICHU";
            this.GHICHU.Visible = true;
            this.GHICHU.VisibleIndex = 4;
            this.GHICHU.Width = 187;
            // 
            // frmDoanVien_BiKhaiTru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 391);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmDoanVien_BiKhaiTru";
            this.Text = "Danh Sách Đoàn Viên Bị Khai Trừ";
            this.Load += new System.EventHandler(this.frmDoanVien_BiKhaiTru_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.slkDoanVien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoQD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSach2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSach2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtTen;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDanhSach;
        private DevExpress.XtraGrid.Columns.GridColumn IDCHUCVU;
        private DevExpress.XtraGrid.Columns.GridColumn TENCHUCVU;
        private DevExpress.XtraGrid.GridControl gcDanhSach;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnLuu;
        private DevExpress.XtraBars.BarButtonItem btnHuy;
        private DevExpress.XtraBars.BarButtonItem btnIn;
        private DevExpress.XtraBars.BarButtonItem btnDong;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraEditors.SearchLookUpEdit slkDoanVien;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.TextEdit txtSoQD;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLyDo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtNgayKhaiTru;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl gcDanhSach2;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDanhSach2;
        private DevExpress.XtraGrid.Columns.GridColumn SOQD;
        private DevExpress.XtraGrid.Columns.GridColumn NGAYKHAITRU;
        private DevExpress.XtraGrid.Columns.GridColumn MADOANVIEN;
        private DevExpress.XtraGrid.Columns.GridColumn LYDO;
        private DevExpress.XtraGrid.Columns.GridColumn GHICHU;
        private DevExpress.XtraGrid.Columns.GridColumn HOTEN;
        private DevExpress.XtraGrid.Columns.GridColumn DELETED_BY;
    }
}