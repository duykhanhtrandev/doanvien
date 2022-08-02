using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using ManageLayer.DTO;

namespace ManageLayer
{
    public class KHENTHUONG_KYLUAT
    {
        QLDOANVIENEntities db = new QLDOANVIENEntities();

        public tb_KHENTHUONG_KYLUAT getItem(string soQD)
        {
            return db.tb_KHENTHUONG_KYLUAT.FirstOrDefault(x => x.SOQUYETDINH == soQD);
        }

        public List<tb_KHENTHUONG_KYLUAT> getList(int loai)
        {
            return db.tb_KHENTHUONG_KYLUAT.Where(x => x.LOAI == loai).ToList();
        }

        public List<KHENTHUONG_KYLUAT_DTO> getListFull(int loai)
        {
            List<tb_KHENTHUONG_KYLUAT> lstKT = db.tb_KHENTHUONG_KYLUAT.Where(x => x.LOAI == loai).ToList();
            List<KHENTHUONG_KYLUAT_DTO> lstDTO = new List<KHENTHUONG_KYLUAT_DTO>();
            KHENTHUONG_KYLUAT_DTO kt;
            foreach(var item in lstKT)
            {
                kt = new KHENTHUONG_KYLUAT_DTO();
                kt.SOQUYETDINH = item.SOQUYETDINH;
                kt.TUNGAY = item.TUNGAY;
                kt.DENNGAY = item.DENNGAY;
                kt.NOIDUNG = item.NOIDUNG;
                kt.LYDO = item.LYDO;
                kt.NGAY = item.NGAY;
                kt.LOAI = item.LOAI;
                kt.MADOANVIEN =item.MADOANVIEN;
                var dv = db.tb_DOANVIEN.FirstOrDefault(n => n.MADOANVIEN == item.MADOANVIEN);
                kt.HOTEN = dv.HOTEN;
                kt.CREATED_BY = item.CREATED_BY;
                kt.CREARTED_DATE = item.CREARTED_DATE;
                kt.UPDATED_BY = item.UPDATED_BY;
                kt.UPDATED_DATE = item.UPDATED_DATE;
                kt.DELETED_BY = item.DELETED_BY;
                kt.DELETED_DATE = item.DELETED_DATE;
                lstDTO.Add(kt);
            }    
            return lstDTO;
        }

        public tb_KHENTHUONG_KYLUAT Add(tb_KHENTHUONG_KYLUAT kt)
        {
            try
            {
                db.tb_KHENTHUONG_KYLUAT.Add(kt);
                db.SaveChanges();
                return kt;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: "+ex.Message);
            }
        }

        public tb_KHENTHUONG_KYLUAT Update(tb_KHENTHUONG_KYLUAT kt)
        {
            try
            {
                tb_KHENTHUONG_KYLUAT _kt = db.tb_KHENTHUONG_KYLUAT.FirstOrDefault(x => x.SOQUYETDINH == kt.SOQUYETDINH);
                _kt.NGAY = kt.NGAY;
                _kt.TUNGAY = kt.TUNGAY;
                _kt.DENNGAY = kt.DENNGAY;
                _kt.LYDO = kt.LYDO;
                _kt.NOIDUNG = kt.NOIDUNG;
                _kt.LOAI = kt.LOAI;
                _kt.MADOANVIEN = kt.MADOANVIEN;
                _kt.UPDATED_BY = kt.UPDATED_BY;
                _kt.UPDATED_DATE = kt.UPDATED_DATE;
                _kt.UPDATED_DATE = kt.UPDATED_DATE;
                db.SaveChanges();
                return kt;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public void Delete(string soQD, int maDV)
        {
            try
            {
                tb_KHENTHUONG_KYLUAT _kt = db.tb_KHENTHUONG_KYLUAT.FirstOrDefault(x => x.SOQUYETDINH == soQD);
                _kt.DELETED_BY = maDV;
                _kt.DELETED_DATE = DateTime.Now;
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public string MaxSoQuyetDinh(int loai)
        {
            var _qd = db.tb_KHENTHUONG_KYLUAT.Where(x => x.LOAI==loai).OrderByDescending(x => x.CREARTED_DATE).FirstOrDefault();
            if (_qd != null)
            {
                return _qd.SOQUYETDINH;
            }
            else
                return "00000";
        }
    }
}
