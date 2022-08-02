using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace ManageLayer
{
    public class LOP
    {
        QLDOANVIENEntities db = new QLDOANVIENEntities();

        public tb_LOP getItem(int id)
        {
            return db.tb_LOP.FirstOrDefault(x => x.IDLOP == id);
        }

        public List<tb_LOP> getList()
        {
            return db.tb_LOP.ToList();
        }

        public tb_LOP Add(tb_LOP l)
        {
            try
            {
                db.tb_LOP.Add(l);
                db.SaveChanges();
                return l;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public tb_LOP Update(tb_LOP l)
        {
            try
            {
                var _l = db.tb_LOP.FirstOrDefault(x => x.IDLOP == l.IDLOP);
                _l.TENLOP = l.TENLOP;
                db.SaveChanges();
                return l;
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
                var _l = db.tb_LOP.FirstOrDefault(x => x.IDLOP == id);
                db.tb_LOP.Remove(_l);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
    }
}
