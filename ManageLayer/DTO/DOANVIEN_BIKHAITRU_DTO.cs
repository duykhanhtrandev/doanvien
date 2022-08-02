using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageLayer.DTO
{
    public class DOANVIEN_BIKHAITRU_DTO
    {
        public string SOQD { get; set; }
        public Nullable<int> MADOANVIEN { get; set; }
        public string HOTEN { set; get; }
        public Nullable<System.DateTime> NGAYKHAITRU { get; set; }
        public string LYDO { get; set; }
        public string GHICHU { get; set; }
        public Nullable<int> CREATED_BY { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public Nullable<int> UPDATED_BY { get; set; }
        public Nullable<System.DateTime> UPDATED_DATE { get; set; }
        public Nullable<int> DELETED_BY { get; set; }
        public Nullable<System.DateTime> DELETED_DATE { get; set; }
    }
}
