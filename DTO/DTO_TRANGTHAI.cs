using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class DTO_TRANGTHAI
    {
        private string _MATT;

        public string MATT
        {
            get { return _MATT; }
            set { _MATT = value; }
        }
        private string _TENTT;

        public string TENTT
        {
            get { return _TENTT; }
            set { _TENTT = value; }
        }
        public DTO_TRANGTHAI(string _MATT, string _TENTT)
        {
            this.MATT = _MATT;
            this.TENTT = _TENTT;
        }
    }
}
