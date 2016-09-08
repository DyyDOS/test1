using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_LOP
    {
        private string _MALOP;

        public string MALOP
        {
            get { return _MALOP; }
            set { _MALOP = value; }
        }
        private string _TENLOP;

        public string TENLOP
        {
            get { return _TENLOP; }
            set { _TENLOP = value; }
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
        private string _MADD;
      
        public string MADD
        {
            get { return _MADD; }
            set { _MADD = value; }
        }
        public DTO_LOP(string _MALOP, string _TENLOP, string _DIACHI, string _MADD)
        {
            this.MALOP = _MALOP;
            this.TENLOP = _TENLOP;
            this.DIACHI = _DIACHI;
            this.MADD = _MADD;

        }

        public DTO_LOP()
        {
            // TODO: Complete member initialization
        }

       
        //public DTO_LOP(string p1, string p2, string p3, string p4)
        //{
        //    // TODO: Complete member initialization
        //    this.p1 = p1;
        //    this.p2 = p2;
        //    this.p3 = p3;
        //    this.p4 = p4;
        //}
    }
}
