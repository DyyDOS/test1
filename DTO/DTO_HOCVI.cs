using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_HOCVI
    {
        private string _MAHV;

        public string MAHV
        {
            get { return _MAHV; }
            set { _MAHV = value; }
        }
        private string _HOCVI;

        public string HOCVI
        {
            get { return _HOCVI; }
            set { _HOCVI = value; }
        }
        public DTO_HOCVI(string _MAHV, string _HOCVI)
        {
            this.MAHV = _MAHV;
            this.HOCVI = _HOCVI;
        }

    }
}
