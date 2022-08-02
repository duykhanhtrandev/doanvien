using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace ManageLayer
{
    public class DANTOC
    {
        QLDOANVIENEntities db = new QLDOANVIENEntities();

        public tb_DANTOC getItem(int id)
        {
            return db.tb_DANTOC.FirstOrDefault(x => x.IDDANTOC == id);
        }

        public List<tb_DANTOC> getList()
        {
            return db.tb_DANTOC.ToList();
        }

        public tb_DANTOC Add(tb_DANTOC dt)
        {
            try
            {
                db.tb_DANTOC.Add(dt);
                db.SaveChanges();
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: "+ex.Message);
            }
        }

        public tb_DANTOC Update(tb_DANTOC dt)
        {
            try
            {
                var _dt = db.tb_DANTOC.FirstOrDefault(x => x.IDDANTOC == dt.IDDANTOC);
                _dt.TENDANTOC = dt.TENDANTOC;
                db.SaveChanges();
                return dt;
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
                var _dt = db.tb_DANTOC.FirstOrDefault(x => x.IDDANTOC == id);
                db.tb_DANTOC.Remove(_dt);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
    }
}
