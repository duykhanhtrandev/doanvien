using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using ManageLayer.DTO;

namespace ManageLayer
{
    public class DOANVIEN_BIKHAITRU
    {
        QLDOANVIENEntities db = new QLDOANVIENEntities();
        public tb_DOANVIEN_BIKHAITRU getItem(string soqd)
        {
            return db.tb_DOANVIEN_BIKHAITRU.FirstOrDefault(x => x.SOQD == soqd);
        }

        public List<tb_DOANVIEN_BIKHAITRU> getList()
        {
            return db.tb_DOANVIEN_BIKHAITRU.ToList();
        }

        public List<DOANVIEN_BIKHAITRU_DTO> getListFull()
        {
            var lstDC = db.tb_DOANVIEN_BIKHAITRU.ToList();
            List<DOANVIEN_BIKHAITRU_DTO> lstDTO = new List<DOANVIEN_BIKHAITRU_DTO>();
            DOANVIEN_BIKHAITRU_DTO dvDTO;
            foreach(var item in lstDC)
            {
                dvDTO = new DOANVIEN_BIKHAITRU_DTO();
                dvDTO.SOQD = item.SOQD;
                dvDTO.NGAYKHAITRU = item.NGAYKHAITRU;
                dvDTO.MADOANVIEN = item.MADOANVIEN;
                var dv = db.tb_DOANVIEN.FirstOrDefault(n => n.MADOANVIEN == item.MADOANVIEN);
                dvDTO.HOTEN = dv.HOTEN;
                dvDTO.LYDO = item.LYDO;
                dvDTO.GHICHU = item.GHICHU;
                dvDTO.CREATED_BY = item.CREATED_BY;
                dvDTO.CREATED_DATE = item.CREATED_DATE;
                dvDTO.UPDATED_BY = item.UPDATED_BY;
                dvDTO.UPDATED_DATE = item.UPDATED_DATE;
                dvDTO.DELETED_BY = item.DELETED_BY;
                dvDTO.DELETED_DATE = item.DELETED_DATE;
                lstDTO.Add(dvDTO);
            }    
            return lstDTO;
        }

        public tb_DOANVIEN_BIKHAITRU Add(tb_DOANVIEN_BIKHAITRU kt)
        {
            try
            {
                db.tb_DOANVIEN_BIKHAITRU.Add(kt);
                db.SaveChanges();
                return kt;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi" + ex.Message);
            }
        }

        public tb_DOANVIEN_BIKHAITRU Update(tb_DOANVIEN_BIKHAITRU kt)
        {
            try
            {
                var _kt = db.tb_DOANVIEN_BIKHAITRU.FirstOrDefault(x => x.SOQD == kt.SOQD);
                _kt.NGAYKHAITRU = kt.NGAYKHAITRU;
                _kt.MADOANVIEN = kt.MADOANVIEN;
                _kt.LYDO = kt.LYDO;
                _kt.GHICHU = kt.GHICHU;
                _kt.UPDATED_BY = kt.UPDATED_BY;
                _kt.UPDATED_DATE = kt.UPDATED_DATE;
                db.SaveChanges();
                return kt;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi" + ex.Message);
            }
        }

        public void Delete(string soqd, int iduser)
        {
            try
            {
                var _kt = db.tb_DOANVIEN_BIKHAITRU.FirstOrDefault(x => x.SOQD == soqd);
                _kt.DELETED_BY = iduser;
                _kt.UPDATED_DATE = DateTime.Now;
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi" + ex.Message);
            }
        }

        public string MaxSoQuyetDinh()
        {
            var _hd = db.tb_DOANVIEN_BIKHAITRU.OrderByDescending(x => x.CREATED_DATE).FirstOrDefault();
            if (_hd != null)
            {
                return _hd.SOQD;
            }
            else
                return "00000";
        }
    }
}
