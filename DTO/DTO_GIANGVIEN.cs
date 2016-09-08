using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_GIANGVIEN
    {
        private string _MAGV;

        public string MAGV
        {
            get { return _MAGV; }
            set { _MAGV = value; }
        }
        private string _TENGV;

        public string TENGV
        {
            get { return _TENGV; }
            set { _TENGV = value; }
        }
        private string _GIOITINH;

        public string GIOITINH
        {
            get { return _GIOITINH; }
            set { _GIOITINH = value; }
        }
        private string _DIENTHOAI;

        public string DIENTHOAI
        {
            get { return _DIENTHOAI; }
            set { _DIENTHOAI = value; }
        }
        private string _EMAIL;

        public string EMAIL
        {
            get { return _EMAIL; }
            set { _EMAIL = value; }
        }
        private string _MAHH;

        public string MAHH
        {
            get { return _MAHH; }
            set { _MAHH = value; }
        }
        private string _MAHV;

        public string MAHV
        {
            get { return _MAHV; }
            set { _MAHV = value; }
        }
        private string _MABM;

        public string MABM
        {
            get { return _MABM; }
            set { _MABM = value; }
        }
        public DTO_GIANGVIEN(string _MAGV, string _TENGV, string _GIOITINH, string _DIENTHOAI, string _EMAIL, string _MAHH, string _MAHV, string _MABM )
        
        {
            this.MAGV = _MAGV;
            this.TENGV = _TENGV;
            this.GIOITINH = _GIOITINH;
            this.DIENTHOAI = _DIENTHOAI;
            this.EMAIL = _EMAIL;
            this.MAHH = _MAHH;
            this.MAHV = _MAHV;
            this.MABM = _MABM;
        }
       


    }
}
