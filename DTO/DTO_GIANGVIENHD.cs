using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class DTO_GIANGVIENHD
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
        public DTO_GIANGVIENHD(string _MAGV, string _MADT)
        {
            this.MAGV = _MAGV;
            this.MADT = _MADT;
        }
    }
}
