    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_DAIDOI
    {
        private string _MADD;

        public string MADD
        {
            get { return _MADD; }
            set { _MADD = value; }
        }
        private string _DIACHI;

        public string DIACHI
        {
            get { return _DIACHI; }
            set { _DIACHI = value; }
        }
        private string _TENDD;

        public string TENDD
        {
            get { return _TENDD; }
            set { _TENDD = value; }
        }
        private string _DIENTHOAI;

        public string DIENTHOAI
        {
            get { return _DIENTHOAI; }
            set { _DIENTHOAI = value; }
        }
        private string _MATD;

        public string MATD
        {
            get { return _MATD; }
            set { _MATD = value; }
        }
        public DTO_DAIDOI(string _MADD, string _DIACHI, string _TENDD, string _DIENTHOAI, string _MATD)
        {
            this.MADD = _MADD;
            this.DIACHI = _DIACHI;
            this.TENDD = _TENDD;
            this.DIENTHOAI = _DIENTHOAI;
            this.MATD = _MATD;

        }

        public DTO_DAIDOI()
        {
            // TODO: Complete member initialization
        }
    }
}
