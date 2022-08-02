using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace ManageLayer.DTO
{
    public class DOANVIEN_DTO
    {
        public int MADOANVIEN { get; set; }
        public string HOTEN { get; set; }
        public Nullable<bool> GIOITINH { get; set; }
        public Nullable<System.DateTime> NGAYSINH { get; set; }
        public string DIENTHOAI { get; set; }
        public string CCCD { get; set; }
        public string DIACHI { get; set; }
        public Nullable<System.DateTime> NGAYVAODOAN { get; set; }
        public Nullable<System.DateTime> NGAYVAODANG { get; set; }
        public string PHIDOAN { get; set; }
        public byte[] HINHANH { get; set; }
        public bool? KHAITRU { set; get; }

        public Nullable<int> IDCHIBO { get; set; }
        public string TENCHIBO { get; set; }

        public Nullable<int> IDLOP { get; set; }
        public string TENLOP { get; set; }

        public Nullable<int> IDCHUCVU { get; set; }
        public string TENCHUCVU { get; set; }

        public Nullable<int> IDTRINHDO { get; set; }
        public string TENTRINHDO { get; set; }

        public Nullable<bool> HOATDONG { get; set; }

        public Nullable<int> IDTONGIAO { get; set; }
        public string TENTONGIAO { get; set; }

        public Nullable<int> IDDANTOC { get; set; }
        public string TENDANTOC { get; set; }

        public Nullable<int> MANOISINHHOATDOAN { get; set; }
        public string TENNOISINHHOATDOAN { get; set; }
    }
}
