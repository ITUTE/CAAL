using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _123
{
    public class GiangVienCH : ThongTin
    {
        private string chucDanh;
        private int donGia;
        private int heSo;
        private int phuCap;
        private int soTietChuan;
        private int soTietDay;

        public GiangVienCH(string hoValue, string tenValue, string chucDanhvalue, int donGiavalue,int heSovalue,int phuCapvalue, int soTietChuanvalue,int soTietDayvalue) : base(hoValue, tenValue)
        {
            ChucDanh = chucDanhvalue;
            DonGia = donGiavalue;
            HeSo = heSovalue;
            PhuCap = phuCapvalue;
            SoTietChuan = soTietChuanvalue;
            SoTietDay = soTietDayvalue;
        }

        public string ChucDanh
        {
            get
            {
                return chucDanh;
            }
            set
            {
                if (value != null)
                    chucDanh = value;
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

        public int SoTietDay
        {
            get
            {
                return soTietDay;
            }
            set
            {
                if (value > 0)
                    soTietDay = value;
            }
        }

        public int SoTietChuan
        {
            get
            {
                return soTietChuan;
            }
            set
            {
                if (value > 0)
                    soTietChuan = value;
            }
        }

        public override decimal Luong()
        {
            return HeSo * 1290000 + (SoTietDay - SoTietChuan) * DonGia + PhuCap;
            throw new System.NotImplementedException();
        }

        public override string ToString()
        {
            return "GiangVienCH: " + base.ToString();
            throw new System.NotImplementedException();
        }

        public override string Position()
        {
            return ChucDanh;
            throw new System.NotImplementedException();
        }
    }
}