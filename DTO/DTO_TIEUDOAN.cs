using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_TIEUDOAN
    {
        private string _MATD;

        public string MATD
        {
            get { return _MATD; }
            set { _MATD = value; }
        }
        private string _TENTD;

        public string TENTD
        {
            get { return _TENTD; }
            set { _TENTD = value; }
        }
        private string _DIACHI;

        public string DIACHI
        {
            get { return _DIACHI; }
            set { _DIACHI = value; }
        }
        private string _DIENTHOAI;

        public string DIENTHOAI
        {
            get { return _DIENTHOAI; }
            set { _DIENTHOAI = value; }
        }
        public DTO_TIEUDOAN(string _MATD, string _TENTD, string _DIACHI, string _DIENTHOAI )
        {
            this.MATD = _MATD;
            this.TENTD = _TENTD;
            this.DIACHI = _DIACHI;
            this.DIENTHOAI = _DIENTHOAI;
        }

        public DTO_TIEUDOAN()
        {
            // TODO: Complete member initialization
        }

    }
}
