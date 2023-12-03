using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _123
{
    public class NhanVienCN : ThongTin
    {
        private int soNgay;
        private int donGia;

        public NhanVienCN(string hoValue, string tenValue, int donGiavalue,int soNgayvalue) : base(hoValue, tenValue)
        {
            SoNgay = soNgayvalue;
            DonGia = donGiavalue;
        }

        public int SoNgay
        {
            get
            {
                return soNgay;
            }
            set
            {
                if (value > 0)
                    soNgay = value;
            }
        }

        public int DonGia
        {
            get
            {
                return donGia;
            }
            set
            {
                if (value > 0)
                    donGia = value;
            }
        }

        public override decimal Luong()
        {
            return SoNgay + DonGia;
            throw new System.NotImplementedException();
        }

        public override string ToString()
        {
            return "NhanVienCN: " + base.ToString();
            throw new System.NotImplementedException();
        }

        public override string Position()
        {
            return "";
            throw new System.NotImplementedException();
        }
    }
}