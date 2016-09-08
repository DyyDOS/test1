using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_SINHVIEN
    {
        public DTO_SINHVIEN()
        {
            _Lop = new DTO_LOP();
        }
        private string _MASV;

        public string MASV
        {
            get { return _MASV; }
            set { _MASV = value; }
        }
        private string _TENSV;

        public string TENSV
        {
            get { return _TENSV; }
            set { _TENSV = value; }
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
        private string _GMAIL;

        public string GMAIL
        {
            get { return _GMAIL; }
            set { _GMAIL = value; }
        }
        private DTO_LOP _Lop;
        public DTO_LOP Lop
        {
            get { return _Lop; }
            set { _Lop = value; }
        }


        private float _DIEMTB;

        public float DIEMTB
        {
            get { return _DIEMTB; }
            set { _DIEMTB = value; }
        }
        private string _MALOP;

        public string MALOP
        {
            get { return _MALOP; }
            set { _MALOP = value; }
            }
        public DTO_SINHVIEN(string _MASV, string _TENSV, string _GIOITINH, string _DIENTHOAI, string _GMAIL,string _MALOP , float _DIEMTB)
        {
            this.MASV = _MASV;
            this.TENSV = _TENSV;
            this.GIOITINH = _GIOITINH;
            this.DIENTHOAI = _DIENTHOAI;
            this.GMAIL = _GMAIL;
            this.MALOP = _MALOP;
            this.DIEMTB = _DIEMTB;
        }

    }
}
