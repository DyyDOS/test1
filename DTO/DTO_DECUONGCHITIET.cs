using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_DECUONGCHITIET
    {
        private string _MADC;
        public string MADC
        {
            get { return _MADC; }
            set { _MADC = value; }
        }

        private string _MADT;
        public string MADT
        {
            get { return _MADT; }
            set { _MADT = value; }
        }

        private DateTime _NGAYBAOVE;
        public DateTime NGAYBAOVE
        {
            get { return _NGAYBAOVE; }
            set { _NGAYBAOVE = value; }
        }

        private string _NOIDUNG;
        public string NOIDUNG
        {
            get { return _NOIDUNG; }
            set { _NOIDUNG = value; }
        }

        public DTO_DECUONGCHITIET (string _MADC, DateTime _NGAYBAOVE, string _NOIDUNG, string _MADT)
        {
            this.MADC = _MADC;
            this.NGAYBAOVE = _NGAYBAOVE;
            this.NOIDUNG = _NOIDUNG;
            this.MADT = _MADT;
        }
    }
}
