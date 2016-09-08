using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DTO
{
   public class DTO_BAOCAOTIENDO
    {
        private string _MADT; // dung phim tat ctrl+R+E
        public string MADT
        {
            get { return _MADT; }
            set { MADT = value; }
        }

        private string _SOLAN;
        public string SOLAN
        {
            get { return _SOLAN; }
            set { _SOLAN = value; }
        }

        private DateTime _NGAYBAOCAO;
        public DateTime NGAYBAOCAO
        {
            get { return _NGAYBAOCAO; }
            set { _NGAYBAOCAO = value; }
        }

        private string _PHANTRAMHOANTHANH;
        public string PHANTRAMHOANTHANH
        {
            get { return _PHANTRAMHOANTHANH; }
            set { _PHANTRAMHOANTHANH = value; }
        }

        private string _KHANANGTHUCHIEN;
        public string KHANANGTHUCHIEN
        {
            get { return _KHANANGTHUCHIEN; }
            set { _KHANANGTHUCHIEN = value; }
        }

        private string _NOIDUNGLAMDUOC;
        public string NOIDUNGLAMDUOC
        {
            get { return _NOIDUNGLAMDUOC; }
            set { _NOIDUNGLAMDUOC = value; }
        }

        private string _KEHOACHTIEPTHEO;
        public string KEHOACHTIEPTHEO
        {
            get { return _KEHOACHTIEPTHEO; }
            set { _KEHOACHTIEPTHEO = value; }
        }

        public DTO_BAOCAOTIENDO(string _MADT, string _SOLAN, DateTime _NGAYBAOCAO, string _PHANTRAMHOANTHANH, string _KHANANGTHUCHIEN, string _NOIDUNGLAMDUOC, string _KEHOACHTIEPTHEO)
        {
            this.MADT = _MADT;
            this.SOLAN = _SOLAN;
            this.KEHOACHTIEPTHEO = _KEHOACHTIEPTHEO;
            this.NGAYBAOCAO = _NGAYBAOCAO;
            this.PHANTRAMHOANTHANH = _PHANTRAMHOANTHANH;
            this.KHANANGTHUCHIEN = _KHANANGTHUCHIEN;
            this.NOIDUNGLAMDUOC = _NOIDUNGLAMDUOC;
            this.KEHOACHTIEPTHEO = _KEHOACHTIEPTHEO;
        }
    }

 
}
