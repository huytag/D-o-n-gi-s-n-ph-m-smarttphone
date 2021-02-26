using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuBaoGiaDT
{
    public class DoiTuong
    {
        double _khoangCach;
        double _gia;

        public double KhoangCach { get => _khoangCach; set => _khoangCach = value; }
        public double Gia { get => _gia; set => _gia = value; }
        public DoiTuong(double khoangcach, double gia)
        {
            this.KhoangCach = khoangcach;
            this.Gia = gia;
        }
    }
}
