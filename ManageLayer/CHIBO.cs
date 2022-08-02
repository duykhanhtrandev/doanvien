using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace ManageLayer
{
    public class CHIBO
    {
        QLDOANVIENEntities db = new QLDOANVIENEntities();

        public tb_CHIBO getItem(int id)
        {
            return db.tb_CHIBO.FirstOrDefault(x => x.IDCHIBO == id);
        }

        public List<tb_CHIBO> getList()
        {
            return db.tb_CHIBO.ToList();
        }

        public tb_CHIBO Add(tb_CHIBO cb)
        {
            try
            {
                db.tb_CHIBO.Add(cb);
                db.SaveChanges();
                return cb;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public tb_CHIBO Update(tb_CHIBO cb)
        {
            try
            {
                var _cb = db.tb_CHIBO.FirstOrDefault(x => x.IDCHIBO == cb.IDCHIBO);
                _cb.TENCHIBO = cb.TENCHIBO;
                db.SaveChanges();
                return cb;
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
                var _cb = db.tb_CHIBO.FirstOrDefault(x => x.IDCHIBO == id);
                db.tb_CHIBO.Remove(_cb);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
    }
}
