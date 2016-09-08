using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class DTO_CHITIETHOIDONGNGHIEMTHU
    {
        private string _MACHUCDANH;

        public string MACHUCDANH
        {
            get { return _MACHUCDANH; }
            set { _MACHUCDANH = value; }
        }
        private string _MAHD;

        public string MAHD
        {
            get { return _MAHD; }
            set { _MAHD = value; }
        }
        private string _MAGV;

        public string MAGV
        {
            get { return _MAGV; }
            set { _MAGV = value; }
        }
        private float _DIEM;

        public float DIEM
        {
            get { return _DIEM; }
            set { _DIEM = value; }
        }
        private string _MADT;

        public string MADT
        {
            get { return _MADT; }
            set { _MADT = value; }
        }
        public DTO_CHITIETHOIDONGNGHIEMTHU(string _MACHUCDANH, string _MAHD, string _MAGV, float _DIEM, string _MADT)
        {
            this.MACHUCDANH = _MACHUCDANH;
            this.MAHD = _MAHD;
            this.MAGV = _MAGV;
            this.DIEM = _DIEM;
            this.MADT = _MADT;
        }
    }
}
