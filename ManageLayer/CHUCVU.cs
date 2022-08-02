using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace ManageLayer
{
    public class CHUCVU
    {
        QLDOANVIENEntities db = new QLDOANVIENEntities();

        public tb_CHUCVU getItem(int id)
        {
            return db.tb_CHUCVU.FirstOrDefault(x => x.IDCHUCVU == id);
        }

        public List<tb_CHUCVU> getList()
        {
            return db.tb_CHUCVU.ToList();
        }

        public tb_CHUCVU Add(tb_CHUCVU cv)
        {
            try
            {
                db.tb_CHUCVU.Add(cv);
                db.SaveChanges();
                return cv;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public tb_CHUCVU Update(tb_CHUCVU cv)
        {
            try
            {
                var _cv = db.tb_CHUCVU.FirstOrDefault(x => x.IDCHUCVU == cv.IDCHUCVU);
                _cv.TENCHUCVU = cv.TENCHUCVU;
                db.SaveChanges();
                return cv;
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
                var _cv = db.tb_CHUCVU.FirstOrDefault(x => x.IDCHUCVU == id);
                db.tb_CHUCVU.Remove(_cv);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
    }
}
