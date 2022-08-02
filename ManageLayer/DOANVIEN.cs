using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using ManageLayer.DTO;

namespace ManageLayer
{
    public class DOANVIEN
    {
        QLDOANVIENEntities db = new QLDOANVIENEntities();

        public tb_DOANVIEN getItem(int id)
        {
            return db.tb_DOANVIEN.FirstOrDefault(x => x.MADOANVIEN == id);
        }

        public List<tb_DOANVIEN> getList()
        {
            return db.tb_DOANVIEN.ToList();
        }

        public List<DOANVIEN_DTO> getListFull()
        {
            var lstDV = db.tb_DOANVIEN.ToList();
            List<DOANVIEN_DTO> lstDVDTO = new List<DOANVIEN_DTO>();
            DOANVIEN_DTO dvDTO;
            foreach (var item in lstDV)
            {
                dvDTO = new DOANVIEN_DTO();
                dvDTO.MADOANVIEN = item.MADOANVIEN;
                dvDTO.HOTEN = item.HOTEN;
                dvDTO.GIOITINH = item.GIOITINH;
                dvDTO.NGAYSINH = item.NGAYSINH;
                dvDTO.DIENTHOAI = item.DIENTHOAI;
                dvDTO.CCCD =    item.CCCD;
                dvDTO.DIACHI = item.DIACHI;
                dvDTO.NGAYVAODOAN = item.NGAYVAODOAN;
                dvDTO.NGAYVAODANG = item.NGAYVAODANG;
                dvDTO.PHIDOAN = item.PHIDOAN;
                dvDTO.HINHANH = item.HINHANH;
                dvDTO.KHAITRU = item.DAKHAITRU;

                dvDTO.IDCHIBO = item.IDCHIBO;
                var cb = db.tb_CHIBO.FirstOrDefault(b => b.IDCHIBO == item.IDCHIBO);
                dvDTO.TENCHIBO = cb.TENCHIBO;

                dvDTO.IDLOP = item.IDLOP;
                var l = db.tb_LOP.FirstOrDefault(p => p.IDLOP == item.IDLOP);
                dvDTO.TENLOP = l.TENLOP;

                dvDTO.IDCHUCVU = item.IDCHUCVU;
                var cv = db.tb_CHUCVU.FirstOrDefault(k => k.IDCHUCVU == item.IDCHUCVU);
                dvDTO.TENCHUCVU = cv.TENCHUCVU;

                dvDTO.IDTRINHDO = item.IDTRINHDO;
                var td = db.tb_TRINHDO.FirstOrDefault(t => t.IDTRINHDO == item.IDTRINHDO);
                dvDTO.TENTRINHDO = td.TENTRINHDO;

                dvDTO.IDDANTOC = item.IDDANTOC;
                var dt = db.tb_DANTOC.FirstOrDefault(d => d.IDDANTOC == item.IDDANTOC);
                dvDTO.TENDANTOC = dt.TENDANTOC;

                dvDTO.IDTONGIAO = item.IDTONGIAO;
                var tg = db.tb_TONGIAO.FirstOrDefault(g => g.IDTONGIAO == item.IDTONGIAO);
                dvDTO.TENTONGIAO = tg.TENTONGIAO;

                dvDTO.MANOISINHHOATDOAN = item.MANOISINHHOATDOAN;
                var nshd = db.tb_NOISINHHOATDOAN.FirstOrDefault(h => h.MANOISINHHOATDOAN == item.MANOISINHHOATDOAN);
                dvDTO.TENNOISINHHOATDOAN = nshd.TENNOISINHHOATDOAN;

                lstDVDTO.Add(dvDTO);
            }
            return lstDVDTO;
        }

        public tb_DOANVIEN Add(tb_DOANVIEN dv)
        {
            try
            {
                db.tb_DOANVIEN.Add(dv);
                db.SaveChanges();
                return dv;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public tb_DOANVIEN Update(tb_DOANVIEN dv)
        {
            try
            {
                var _dv = db.tb_DOANVIEN.FirstOrDefault(x => x.MADOANVIEN == dv.MADOANVIEN);
                _dv.HOTEN = dv.HOTEN;
                _dv.GIOITINH = dv.GIOITINH;
                _dv.NGAYSINH = dv.NGAYSINH;
                _dv.DIENTHOAI = dv.DIENTHOAI;
                _dv.CCCD = dv.CCCD;
                _dv.DIACHI = dv.DIACHI;
                _dv.NGAYVAODOAN = dv.NGAYVAODOAN;
                _dv.NGAYVAODANG = dv.NGAYVAODANG;
                _dv.PHIDOAN = dv.PHIDOAN;
                _dv.HINHANH = dv.HINHANH;
                _dv.DAKHAITRU = dv.DAKHAITRU;
                _dv.IDCHIBO = dv.IDCHIBO;
                _dv.IDLOP = dv.IDLOP;
                _dv.IDCHUCVU = dv.IDCHUCVU;
                _dv.IDTRINHDO = dv.IDTRINHDO;
                _dv.IDTONGIAO = dv.IDTONGIAO;
                _dv.IDDANTOC = dv.IDDANTOC;
                _dv.MANOISINHHOATDOAN = dv.MANOISINHHOATDOAN;
                db.SaveChanges();
                return dv;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public void Delete(int id)
        {
            try
            {
                var _dv = db.tb_DOANVIEN.FirstOrDefault(x => x.MADOANVIEN == id);
                db.tb_DOANVIEN.Remove(_dv);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
    }
}
