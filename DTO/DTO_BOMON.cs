using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_BOMON
    {
        private string _MABM;

        public string MABM
        {
            get { return _MABM; }
            set { _MABM = value; }
        }
        private string _TENBM;

        public string TENBM
        {
            get { return _TENBM; }
            set { _TENBM = value; }
        }
        private string _DIACHI;

        public string DIACHI
        {
            get { return _DIACHI; }
            set { _DIACHI = value; }
        }
        private string _DIENTHOAI;

        public string DIENTHOAI
        {
            get { return _DIENTHOAI; }
            set { _DIENTHOAI = value; }
        }
        private string _MAKHOA;

        public string MAKHOA
        {
            get { return _MAKHOA; }
            set { _MAKHOA = value; }
        }
        private string _MATBM;

        public string MATBM
        {
            get { return _MATBM; }
            set { _MATBM = value; }
        }
        public DTO_BOMON(string _MABM, string _TENBM, string _DIACHI, string _DIENTHOAI, string _MAKHOA, string _MATBM)
        {
            this.MABM = _MABM;
            this.TENBM = _TENBM;
            this.DIACHI = _DIACHI;
            this.DIENTHOAI = _DIENTHOAI;
            this.MAKHOA = _MAKHOA;
            this.MATBM = _MATBM;

        }
   
    }
}
