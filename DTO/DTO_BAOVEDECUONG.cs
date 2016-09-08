using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class DTO_BAOVEDECUONG
    {
        private string _MADT;

        public string MADT
        {
            get { return _MADT; }
            set { _MADT = value; }
        }
        private string _KETQUA;

        public string KETQUA
        {
            get { return _KETQUA; }
            set { _KETQUA = value; }
        }
        private DateTime _NGAYBAOVE;

        public DateTime NGAYBAOVE
        {
            get { return _NGAYBAOVE; }
            set { _NGAYBAOVE = value; }
        }
        public DTO_BAOVEDECUONG(string _MADT, string _KETQUA,DateTime _NGAYBAOVE )
        {
            this.MADT = _MADT;
            this.KETQUA = _KETQUA;
            this.NGAYBAOVE = _NGAYBAOVE;
        }
    }
}
