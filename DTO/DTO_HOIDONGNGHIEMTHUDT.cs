using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_HOIDONGNGHIEMTHUDT
    {
        private string _MAHD;

        public string MAHD
        {
            get { return _MAHD; }
            set { _MAHD = value; }
        }
        private string _TENHD;

        public string TENHD
        {
            get { return _TENHD; }
            set { _TENHD = value; }
        }
        public DTO_HOIDONGNGHIEMTHUDT(string _MAHD, string _TENHD)
        {
            this.MAHD = _MAHD;
            this.TENHD = _TENHD;
        }

    }
}
