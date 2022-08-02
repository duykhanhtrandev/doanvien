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
using System.IO;
using QLDOANVIEN.Reports;
using ManageLayer.DTO;
using DevExpress.XtraReports.UI;

namespace QLDOANVIEN
{
    public partial class frmDoanVien : DevExpress.XtraEditors.XtraForm
    {
        public frmDoanVien()
        {
            InitializeComponent();
        }

        private CHIBO _chibo;
        private CHUCVU _chucvu;
        private DANTOC _dantoc;
        private DOANVIEN _doanvien;
        private LOP _lop;
        private NOISINHHOATDOAN _noisinhhoatdoan;
        private TONGIAO _tongiao;
        private TRINHDO _trinhdo;

        List<DOANVIEN_DTO> _lstDVDTO;

        bool _them;
        int _id;

        private void frmDoanVien_Load(object sender, EventArgs e)
        {
            _them = false;
            _chibo = new CHIBO();
            _chucvu = new CHUCVU();
            _dantoc = new DANTOC();
            _doanvien= new DOANVIEN();
            _lop = new LOP();
            _noisinhhoatdoan= new NOISINHHOATDOAN();
            _tongiao = new TONGIAO();
            _trinhdo = new TRINHDO();
            _showHide(true);
            loadData();
            loadCombo();
            splitContainer1.Panel1Collapsed = true; //Bật tắt panel1 cho thêm và chỉnh xửa
        }

        void loadCombo()
        {
            // Đưa dữ liệu ra combobox để thêm mới Đoàn Viên

            cboChiBo.DataSource = _chibo.getList();
            cboChiBo.DisplayMember = "TENCHIBO";
            cboChiBo.ValueMember = "IDCHIBO";

            cboLop.DataSource = _lop.getList();
            cboLop.DisplayMember = "TENLOP";
            cboLop.ValueMember = "IDLOP";

            cboChucVu.DataSource = _chucvu.getList();
            cboChucVu.DisplayMember = "TENCHUCVU";
            cboChucVu.ValueMember = "IDCHUCVU";

            cboTrinhDo.DataSource = _trinhdo.getList();
            cboTrinhDo.DisplayMember = "TENTRINHDO";
            cboTrinhDo.ValueMember = "IDTRINHDO";

            cboTonGiao.DataSource = _tongiao.getList();
            cboTonGiao.DisplayMember = "TENTONGIAO";
            cboTonGiao.ValueMember = "IDTONGIAO";


            cboDanToc.DataSource = _dantoc.getList();
            cboDanToc.DisplayMember = "TENDANTOC";
            cboDanToc.ValueMember = "IDDANTOC";

            cboNoiSinhHoatDoan.DataSource = _noisinhhoatdoan.getList();
            cboNoiSinhHoatDoan.DisplayMember = "TENNOISINHHOATDOAN";
            cboNoiSinhHoatDoan.ValueMember = "MANOISINHHOATDOAN";
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

            txtTen.Enabled = !kt;
            chkGioiTinh.Enabled = !kt;
            dtNgaySinh.Enabled = !kt;
            txtDienThoai.Enabled = !kt;
            txtCCCD.Enabled = !kt;
            txtDiaChi.Enabled = !kt;
            dtNgayVaoDoan1.Enabled = !kt;
            dtNgayVaoDang1.Enabled = !kt;
            txtPhiDoan.Enabled = !kt;
            //picHinhAnh.Enabled = Base64ToImage(dv.HINHANH);
            cboChiBo.Enabled = !kt;
            cboLop.Enabled = !kt;
            cboChucVu.Enabled = !kt;
            cboTrinhDo.Enabled = !kt;
            cboTonGiao.Enabled = !kt;
            cboDanToc.Enabled = !kt;
            btnHinhAnh.Enabled = !kt;
            cboNoiSinhHoatDoan.Enabled = !kt;
        }

        void _reset()
        {
            txtTen.Text = String.Empty;
            txtCCCD.Text = String.Empty;
            txtDienThoai.Text = String.Empty;
            txtDiaChi.Text = String.Empty;
            chkGioiTinh.Checked = false;
        }

        void loadData()
        {
            gcDanhSach.DataSource = _doanvien.getListFull();
            gvDanhSach.OptionsBehavior.Editable = false;
            _lstDVDTO = _doanvien.getListFull();
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
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _doanvien.Delete(_id);
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
            rptDanhSachDoanVien rpt = new rptDanhSachDoanVien(_lstDVDTO);
            rpt.ShowPreview();
        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        void SaveData()
        {
            if (_them)
            {
                tb_DOANVIEN dv = new tb_DOANVIEN();
                dv.HOTEN = txtTen.Text;
                dv.GIOITINH = chkGioiTinh.Checked;
                dv.NGAYSINH = dtNgaySinh.Value;
                dv.DIENTHOAI = txtDienThoai.Text;
                dv.CCCD = txtCCCD.Text;
                dv.DIACHI = txtDiaChi.Text;
                dv.NGAYVAODOAN = dtNgayVaoDoan1.Value;
                dv.NGAYVAODANG = dtNgayVaoDang1.Value;
                dv.PHIDOAN = txtPhiDoan.Text;
                dv.HINHANH = ImageToBase64(picHinhAnh.Image, picHinhAnh.Image.RawFormat);
                dv.IDCHIBO = int.Parse(cboChiBo.SelectedValue.ToString());
                dv.IDLOP = int.Parse(cboLop.SelectedValue.ToString());
                dv.IDCHUCVU = int.Parse(cboChucVu.SelectedValue.ToString());
                dv.IDTRINHDO = int.Parse(cboTrinhDo.SelectedValue.ToString());
                dv.IDTONGIAO = int.Parse(cboTonGiao.SelectedValue.ToString());
                dv.IDDANTOC = int.Parse(cboDanToc.SelectedValue.ToString());
                dv.MANOISINHHOATDOAN = int.Parse(cboNoiSinhHoatDoan.SelectedValue.ToString());
                _doanvien.Add(dv);
            }
            else
            {
                var dv = _doanvien.getItem(_id);
                dv.HOTEN = txtTen.Text;
                dv.GIOITINH = chkGioiTinh.Checked;
                dv.NGAYSINH = dtNgaySinh.Value;
                dv.DIENTHOAI = txtDienThoai.Text;
                dv.CCCD = txtCCCD.Text;
                dv.DIACHI = txtDiaChi.Text;
                dv.NGAYVAODOAN = dtNgayVaoDoan1.Value;
                dv.NGAYVAODANG = dtNgayVaoDang1.Value;
                dv.PHIDOAN = txtPhiDoan.Text;
                dv.HINHANH = ImageToBase64(picHinhAnh.Image, picHinhAnh.Image.RawFormat);
                dv.IDCHIBO = int.Parse(cboChiBo.SelectedValue.ToString());
                dv.IDLOP = int.Parse(cboLop.SelectedValue.ToString());
                dv.IDCHUCVU = int.Parse(cboChucVu.SelectedValue.ToString());
                dv.IDTRINHDO = int.Parse(cboTrinhDo.SelectedValue.ToString());
                dv.IDTONGIAO = int.Parse(cboTonGiao.SelectedValue.ToString());
                dv.IDDANTOC = int.Parse(cboDanToc.SelectedValue.ToString());
                dv.MANOISINHHOATDOAN = int.Parse(cboNoiSinhHoatDoan.SelectedValue.ToString());
                _doanvien.Update(dv);
            }
        }

        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            _id = int.Parse(gvDanhSach.GetFocusedRowCellValue("MADOANVIEN").ToString());
            var dv = _doanvien.getItem(_id);
            txtTen.Text = gvDanhSach.GetFocusedRowCellValue("HOTEN").ToString();
            chkGioiTinh.Checked = dv.GIOITINH.Value;
            dtNgaySinh.Value = dv.NGAYSINH.Value;
            txtDienThoai.Text = dv.DIENTHOAI;
            txtCCCD.Text = dv.CCCD;
            txtDiaChi.Text = dv.DIACHI;
            dtNgayVaoDoan1.Value = dv.NGAYVAODOAN.Value;
            dtNgayVaoDang1.Value = dv.NGAYVAODANG.Value;
            txtPhiDoan.Text = dv.PHIDOAN;
            picHinhAnh.Image = Base64ToImage(dv.HINHANH);
            cboChiBo.SelectedValue = dv.IDCHIBO;
            cboLop.SelectedValue = dv.IDLOP;
            cboChucVu.SelectedValue = dv.IDCHUCVU;
            cboTrinhDo.SelectedValue = dv.IDTRINHDO;
            cboTonGiao.SelectedValue = dv.IDTONGIAO;
            cboDanToc.SelectedValue = dv.IDDANTOC;
            cboNoiSinhHoatDoan.SelectedValue = dv.MANOISINHHOATDOAN;
        }

        //Ham su ly hinh anh Stack Overflow
        public byte[] ImageToBase64(Image image, System.Drawing.Imaging.ImageFormat format)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, format);
                byte[] imageBytes = ms.ToArray();

                return imageBytes;
            }
        }

        public Image Base64ToImage(byte[] imageBytes)
        {
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image image = Image.FromStream(ms, true);
            return image;
        }

        private void btnHinhAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Picture file (.png, .jpg)|*.png;*.jpg";
            openFile.Title = "Chọn hình ảnh";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                picHinhAnh.Image = Image.FromFile(openFile.FileName);
                picHinhAnh.SizeMode = PictureBoxSizeMode.StretchImage;
            }    
        }
    }
}