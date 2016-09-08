using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_KETQUADETAI
    {
        private string _MADT; //ctr r; ctr e

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
        private string _NOIDUNGDANHGIA;

        public string NOIDUNGDANHGIA
        {
            get { return _NOIDUNGDANHGIA; }
            set { _NOIDUNGDANHGIA = value; }
        }

        private string _KETQUA;

        public string KETQUA
        {
            get { return _KETQUA; }
            set { _KETQUA = value; }
        }
        private string _XEPLOAI;

        public string XEPLOAI
        {
            get { return _XEPLOAI; }
            set { _XEPLOAI = value; }
        }
        private string _MAPHIEUKQ;
        public string MAPHIEUKQ
        {
            get { return _MAPHIEUKQ; }
            set { _MAPHIEUKQ = value; }
        }
        public DTO_KETQUADETAI(string _MADT,DateTime _NGAYBAOVE,string _NOIDUNGDANHGIA,string _KETQUA,string _XEPLOAI,string _MAPHIEUKQ)
        {
            this.MADT = _MADT;
            this.NGAYBAOVE = _NGAYBAOVE;
            this.NOIDUNGDANHGIA = _NOIDUNGDANHGIA;
            this.KETQUA = _KETQUA;
            this.XEPLOAI = _XEPLOAI;
            this.MAPHIEUKQ = _MAPHIEUKQ;
        }
    }
}
