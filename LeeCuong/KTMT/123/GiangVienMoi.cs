using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _123
{
    public class GiangVienMG : ThongTin
    {
        private string chucDanh;
        private int donGia;
        private int soTiet;

        public GiangVienMG(string hoValue,string tenValue,string chucDanhvalue,int donGiavalue,int soTietvalue) : base(hoValue,tenValue)
        {
            ChucDanh = chucDanhvalue;
            DonGia = donGiavalue;
            SoTiet = soTietvalue;
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

        public int SoTiet
        {
            get
            {
                return soTiet;
            }
            set
            {
                if (value > 0)
                    soTiet = value;
            }
        }

        public override decimal Luong()
        {
            return SoTiet * DonGia;
            throw new System.NotImplementedException();
        }

        public override string ToString()
        {
            return "GiangVienMG: " + base.ToString();
            throw new System.NotImplementedException();
        }

        public override string Position()
        {
            return ChucDanh;
            throw new System.NotImplementedException();
        }
    }
}