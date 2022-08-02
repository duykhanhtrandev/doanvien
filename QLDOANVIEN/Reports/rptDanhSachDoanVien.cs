using DevExpress.XtraReports.UI;
using ManageLayer.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;

namespace QLDOANVIEN.Reports
{
    public partial class rptDanhSachDoanVien : DevExpress.XtraReports.UI.XtraReport
    {
        public rptDanhSachDoanVien()
        {
            InitializeComponent();
        }

        List<DOANVIEN_DTO> _lstDV;

        public rptDanhSachDoanVien(List<DOANVIEN_DTO> lstDV)
        {
            InitializeComponent();
            this._lstDV = lstDV;
            this.DataSource = _lstDV;
            loadData();
        }

        void loadData()
        {
            lblMaDv.DataBindings.Add("Text", _lstDV,"MADOANVIEN");
            lblHoTen.DataBindings.Add("Text", _lstDV,"HOTEN");
            lblGioiTinh.DataBindings.Add("Text", _lstDV,"GIOITINH");
            lblNgaySinh.DataBindings.Add("Text", _lstDV,"NGAYSINH");
            lblDienThoai.DataBindings.Add("Text", _lstDV,"DIENTHOAI");
            lblCCCD.DataBindings.Add("Text", _lstDV,"CCCD");
            lblDiaChi.DataBindings.Add("Text", _lstDV,"DIACHI");
            lblNgayVaoDoan.DataBindings.Add("Text", _lstDV,"NGAYVAODOAN");
            lblNgayVaoDang.DataBindings.Add("Text", _lstDV,"NGAYVAODANG");
            lblPhiDoan.DataBindings.Add("Text", _lstDV,"PHIDOAN");
            lblChucVu.DataBindings.Add("Text", _lstDV,"TENCHUCVU");
            lblChiBo.DataBindings.Add("Text", _lstDV,"TENCHIBO");
            lblLop.DataBindings.Add("Text", _lstDV,"TENLOP");
            lblTrinhDo.DataBindings.Add("Text", _lstDV,"TENTRINHDO");
            lblTonGiao.DataBindings.Add("Text", _lstDV,"TENTONGIAO");
            lblDanToc.DataBindings.Add("Text", _lstDV,"TENDANTOC");
            lblNoiSinhHoatDoan.DataBindings.Add("Text", _lstDV, "TENNOISINHHOATDOAN");
        }

    }
}
