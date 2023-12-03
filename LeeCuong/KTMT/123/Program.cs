using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _123
{
    class Program
    {
        static void Main(string[] args)
        {
            NhanVienCT CT1 = new NhanVienCT("Bui Viet", "Duy", 90, 21, 34, 24);
            NhanVienCT CT2 = new NhanVienCT("Tran Thi Le", "Xuan", 3700, 4300, 7000, 50);
            NhanVienCT CT3 = new NhanVienCT("Xuan", "Ngao", 700, 300, 700, 25);
            GiangVienCH GV1 = new GiangVienCH("Bui Viet", "Duy", "Tien Si", 1900, 300, 450, 24, 90);
            GiangVienCH GV2 = new GiangVienCH("Tran Thi Le", "Xuan", "Lao Cong", 19, 30, 45, 24, 90);
            GiangVienCH GV3 = new GiangVienCH("Xuan", "Ngao", "Tien Si", 100, 40, 450, 24, 90);
            ThongTin thongtin1 = CT1;
            ThongTin thongtin2 = CT2;
           // string output = GetString(CT1);
//-----------------Cau B----------------------
            List<int> luongNV = new List<int>();
            luongNV.Add(CT1.HeSo * 1290000 + (CT1.SoNgay - 24) * CT1.DonGia + CT1.PhuCap);
            luongNV.Add(CT2.HeSo * 1290000 + (CT2.SoNgay - 24) * CT2.DonGia + CT2.PhuCap);
            luongNV.Add(CT3.HeSo * 1290000 + (CT3.SoNgay - 24) * CT3.DonGia + CT3.PhuCap);
            luongNV.Sort();
            luongNV.Reverse();
            foreach (int item in luongNV)
            {
                if (item == CT1.HeSo * 1290000 + (CT1.SoNgay - 24) * CT1.DonGia + CT1.PhuCap)
                {
                    string output = GetString(CT1);
                    Console.WriteLine(output);
                    //MessageBox.Show(output, "Thong Tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (item == CT2.HeSo * 1290000 + (CT2.SoNgay - 24) * CT2.DonGia + CT2.PhuCap)
                {
                    string output = GetString(CT2);
                    Console.WriteLine(output);
                    //MessageBox.Show(output, "Thong tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (item == CT3.HeSo * 1290000 + (CT3.SoNgay - 24) * CT3.DonGia + CT3.PhuCap)
                {
                    string output = GetString(CT3);
                    Console.WriteLine(output);
                    //MessageBox.Show(output, "Thong tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            //-------------------Cau C---------------
            List<int> LuongGV = new List<int>();
            LuongGV.Add(GV1.HeSo * 1290000 + (GV1.SoTietDay - GV1.SoTietChuan) * GV1.DonGia + GV1.PhuCap);
            LuongGV.Add(GV2.HeSo * 1290000 + (GV2.SoTietDay - GV2.SoTietChuan) * GV2.DonGia + GV2.PhuCap);
            LuongGV.Add(GV3.HeSo * 1290000 + (GV3.SoTietDay - GV3.SoTietChuan) * GV3.DonGia + GV3.PhuCap);
            int max = GV3.HeSo * 1290000 + (GV3.SoTietDay - GV3.SoTietChuan) * GV3.DonGia + GV3.PhuCap;
            foreach (int item in LuongGV)
            {
                if (item > max)
                    max = item;
            }
            if(max == GV1.HeSo * 1290000 + (GV1.SoTietDay - GV1.SoTietChuan) * GV1.DonGia + GV1.PhuCap)
            {
                string output = GetString(GV1);
                Console.WriteLine(output);
            }
            if (max == GV2.HeSo * 1290000 + (GV2.SoTietDay - GV2.SoTietChuan) * GV2.DonGia + GV2.PhuCap)
            {
                string output = GetString(GV2);
                Console.WriteLine(output);
            }
            if (max == GV3.HeSo * 1290000 + (GV3.SoTietDay - GV3.SoTietChuan) * GV3.DonGia + GV3.PhuCap)
            {
                string output = GetString(GV3);
                Console.WriteLine(output);
            }
            // MessageBox.Show(output, "Demonstrating Polymorphism", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static string GetString(ThongTin CN)
        {
            if (CN.Position() != "")
            {
                return CN.ToString() + " Co Luong " + CN.Luong().ToString("C") + " Chuc Danh " + CN.Position() + "\n";
            }
            else
            {
                return CN.ToString() + " Co Luong " + CN.Luong().ToString("C") + "\n";
            }
            throw new System.NotImplementedException();
        }
    }
}
