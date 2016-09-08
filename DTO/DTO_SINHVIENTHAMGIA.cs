using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_SINHVIENTHAMGIA
    {
        private string _MASV;

        public string MASV
        {
            get { return _MASV; }
            set { _MASV = value; }
        }
        private string _MADT;

        public string MADT
        {
            get { return _MADT; }
            set { _MADT = value; }
        }
        private string _VAITRO;

        public string VAITRO
        {
            get { return _VAITRO; }
            set { _VAITRO = value; }
        }
        public DTO_SINHVIENTHAMGIA(string _MASV, string _MADT, string _VAITRO)
        {
            this.MASV = _MASV;
            this.MADT = _MADT;
            this.VAITRO = _VAITRO;

        }
    }
}
