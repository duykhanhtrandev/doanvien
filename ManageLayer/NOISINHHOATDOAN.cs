using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace ManageLayer
{
    public class NOISINHHOATDOAN
    {
        QLDOANVIENEntities db = new QLDOANVIENEntities();

        public tb_NOISINHHOATDOAN getItem(int id)
        {
            return db.tb_NOISINHHOATDOAN.FirstOrDefault(x => x.MANOISINHHOATDOAN == id);
        }

        public List<tb_NOISINHHOATDOAN> getList()
        {
            return db.tb_NOISINHHOATDOAN.ToList();
        }

        public tb_NOISINHHOATDOAN Add(tb_NOISINHHOATDOAN nshd)
        {
            try
            {
                db.tb_NOISINHHOATDOAN.Add(nshd);
                db.SaveChanges();
                return nshd;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public tb_NOISINHHOATDOAN Update(tb_NOISINHHOATDOAN nshd)
        {
            try
            {
                var _nshd = db.tb_NOISINHHOATDOAN.FirstOrDefault(x => x.MANOISINHHOATDOAN == nshd.MANOISINHHOATDOAN);
                _nshd.TENNOISINHHOATDOAN = nshd.TENNOISINHHOATDOAN;
                _nshd.DIENTHOAI = nshd.DIENTHOAI;
                _nshd.EMAIL = nshd.EMAIL;
                _nshd.DIACHI = nshd.DIACHI;
                db.SaveChanges();
                return nshd;
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
                var _nshd = db.tb_NOISINHHOATDOAN.FirstOrDefault(x => x.MANOISINHHOATDOAN == id);
                db.tb_NOISINHHOATDOAN.Remove(_nshd);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
    }
}
