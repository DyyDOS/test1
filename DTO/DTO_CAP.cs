using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
	
	///vidu
    public class DTO_CAP
    {
        private string _MACAP;

        public string MACAP
        {
            get { return _MACAP; }
            set { _MACAP = value; }
        }
        private string _TENCAP;

        public string TENCAP
        {
            get { return _TENCAP; }
            set { _TENCAP = value; }
        }
        public DTO_CAP(string _MACAP, string _TENCAP)
        {
            this.MACAP = _MACAP;
            this.TENCAP = _TENCAP;
        }
    }
}
