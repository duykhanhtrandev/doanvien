using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace ManageLayer
{
    public class TONGIAO
    {
        QLDOANVIENEntities db = new QLDOANVIENEntities();

        public tb_TONGIAO getItem(int id)
        {
            return db.tb_TONGIAO.FirstOrDefault(x => x.IDTONGIAO == id);
        }

        public List<tb_TONGIAO> getList()
        {
            return db.tb_TONGIAO.ToList();
        }

        public tb_TONGIAO Add(tb_TONGIAO tg)
        {
            try
            {
                db.tb_TONGIAO.Add(tg);
                db.SaveChanges();
                return tg;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public tb_TONGIAO Update(tb_TONGIAO tg)
        {
            try
            {
                var _tg = db.tb_TONGIAO.FirstOrDefault(x => x.IDTONGIAO == tg.IDTONGIAO);
                _tg.TENTONGIAO = tg.TENTONGIAO;
                db.SaveChanges();
                return tg;
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
                var _tg = db.tb_TONGIAO.FirstOrDefault(x => x.IDTONGIAO == id);
                db.tb_TONGIAO.Remove(_tg);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
    }
}
