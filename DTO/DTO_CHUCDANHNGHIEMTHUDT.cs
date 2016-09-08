using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class DTO_CHUCDANHNGHIEMTHUDT
    {
        private string _MACHUCDANH;

        public string MACHUCDANH
        {
            get { return _MACHUCDANH; }
            set { _MACHUCDANH = value; }
        }
        private string _TENCHUCDANH;

        public string TENCHUCDANH
        {
            get { return _TENCHUCDANH; }
            set { _TENCHUCDANH = value; }
        }
        public DTO_CHUCDANHNGHIEMTHUDT(string _MACHUCDANH, string _TENCHUCDANH)
        {
            this.MACHUCDANH = _MACHUCDANH;
            this.TENCHUCDANH = _TENCHUCDANH;
        }
    }
}
