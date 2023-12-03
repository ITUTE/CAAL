using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _123
{
    public class NhanVienCT : ThongTin
    {
        private int heSo;
        private int soNgay;
        private int donGia;
        private int phuCap;

        public NhanVienCT(string hoValue, string tenValue,int donGiavalue, int heSovalue, int phuCapvalue,int soNgayvalue) : base(hoValue, tenValue)
        {
            DonGia = donGiavalue;
            HeSo = heSovalue;
            PhuCap = phuCapvalue;
            SoNgay = soNgayvalue;
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

        public int HeSo
        {
            get
            {
                return heSo;
            }
            set
            {
                if (value > 0)
                    heSo = value;
            }
        }

        public int PhuCap
        {
            get
            {
                return phuCap;
            }
            set
            {
                if (value > 0)
                    phuCap = value;
            }
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

        public override decimal Luong()
        {
            return HeSo * 1290000 + (SoNgay - 24) * DonGia + PhuCap;
            throw new System.NotImplementedException();
        }

        public override string ToString()
        {
            return "NhanVienCT: " + base.ToString();
            throw new System.NotImplementedException();
        }

        public override string Position()
        {
            return "";
            throw new System.NotImplementedException();
        }
    }
}