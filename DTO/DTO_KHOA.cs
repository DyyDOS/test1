using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_KHOA
    {
        private string _MAKHOA;

        public string MAKHOA
        {
            get { return _MAKHOA; }
            set { _MAKHOA = value; }
        }
        private string _DIENTHOAI;

        public string DIENTHOAI
        {
            get { return _DIENTHOAI; }
            set { _DIENTHOAI = value; }
        }
        private string _TENKH;

        public string TENKH
        {
            get { return _TENKH; }
            set { _TENKH = value; }
        }
        private string _DIACHI;

        public string DIACHI
        {
            get { return _DIACHI; }
            set { _DIACHI = value; }
        }
        private string _MATK;

        public string MATK
        {
            get { return _MATK; }
            set { _MATK = value; }
        }
        public DTO_KHOA(string _MAKHOA, string _TENKH, string _DIACHI,string _DIENTHOAI, string _MATK)
        {
            this.MAKHOA = _MAKHOA;
            this.TENKH = _TENKH;
            this.DIACHI = _DIACHI;
            this.DIENTHOAI=_DIENTHOAI;
            this.MATK = _MATK;
        }
    }
}
