using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_DETAI
    {
        private string _MADT;

        public string MADT
        {
            get { return _MADT; }
            set { _MADT = value; }
        }
        private string _TENDT;

        public string TENDT
        {
            get { return _TENDT; }
            set { _TENDT = value; }
        }
        private string _KINHPHI;

        public string KINHPHI
        {
            get { return _KINHPHI; }
            set { _KINHPHI = value; }
        }
        private string _NOIDUNG;

        public string NOIDUNG
        {
            get { return _NOIDUNG; }
            set { _NOIDUNG = value; }
        }
        private DateTime _NGAYBD;

        public DateTime NGAYBD
        {
            get { return _NGAYBD; }
            set { _NGAYBD = value; }
        }
        private DateTime _NGAYKT;

        public DateTime NGAYKT
        {
            get { return _NGAYKT; }
            set { _NGAYKT = value; }
        }
        private string _MABM;

        public string MABM
        {
            get { return _MABM; }
            set { _MABM = value; }
        }


        private string _MACAP;

        public string MACAP
        {
            get { return _MACAP; }
            set { _MACAP = value; }
        }
        private string _MATT;

        public string MATT
        {
            get { return _MATT; }
            set { _MATT = value; }
        }
        private string _MALOAI;    

        public string MALOAI
    {
            get { return _MALOAI; }
            set { _MALOAI = value; }
    }
        public DTO_DETAI(string _MADT, string _TENDT, string _KINHPHI, string _NOIDUNG, DateTime _NGAYBD, DateTime _NGAYKT, string _MABM, string _MACAP, string _MATT, string _MALOAI)
        {
            this.MADT = _MADT;
            this.TENDT = _TENDT;
            this.KINHPHI = _KINHPHI;
            this.NOIDUNG = _NOIDUNG;
            this.NGAYBD = _NGAYBD;
            this.NGAYKT = _NGAYKT;
            this.MABM = _MABM;
            this.MACAP = _MACAP;
            this.MATT = _MATT;
            this.MALOAI = _MALOAI;  
        }
}
}
