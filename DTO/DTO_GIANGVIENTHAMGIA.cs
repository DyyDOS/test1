using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_GIANGVIENTHAMGIA
    {
        private string _MAGV;

        public string MAGV
        {
            get { return _MAGV; }
            set { _MAGV = value; }
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
        public DTO_GIANGVIENTHAMGIA(string _MAGV, string _MADT, string _VAITRO)
        {
            this.MAGV = _MAGV;
            this.MADT = _MADT;
            this.VAITRO = _VAITRO;
        }
    }
}
