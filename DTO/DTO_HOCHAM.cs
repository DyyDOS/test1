using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_HOCHAM
    {
        private string _MAHH;

        public string MAHH
        {
            get { return _MAHH; }
            set { _MAHH = value; }
        }
        private string _HOCHAM;

        public string HOCHAM
        {
            get { return _HOCHAM; }
            set { _HOCHAM = value; }
        }
        public DTO_HOCHAM(string _MAHH, string _HOCHAM)
        {
            this.MAHH = _MAHH;
            this.HOCHAM = _HOCHAM;
        }
    }
}
