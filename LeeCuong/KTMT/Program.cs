/*
Bài tập tổng hợp phần hướng đối tượng:
Làm bài 9 và bài 1 trong file bai tap HDT (mo rong).DOC
=========================================================================
Bài tập 9: Viết chương trình thực hiện nhân chia, cộng trừ hai đa thức. 
Các đa thức được nhập và in ra theo format sau: 
ví dụ x2 – 2x + 3 sẽ được biểu diễn dưới dạng một xâu: 1*x^2–2*x^1+3
=========================================================================
Bài tập 1: Viết chương trình cài đặt thư viện số nguyên lớn 
với các phép tính số học thông thường cộng, trừ, nhân, chia, luỹ thừa, mod, div. 
Sau đó sử dụng lớp số nguyên đó để tính 100!
Yêu cầu:
-	Chương trình tối thiểu phải tính được 100!
-	Chương trình có thể làm việc với các số có ít nhất là 100 chữ số
-	Chương trình có khả năng kiểm tra một số nguyên (cỡ vài chục số hạng) 
    có là số nguyên tố hay không.
=========================================================================
Ngày viết: 19 Oct 2018
Cập nhật lần cuối: 19 Oct 2018
Người viết: Nguyễn Trần Thi Văn
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;            //nhập xuất file

namespace Tuan08_LopT6_BTTongHop
{
    //Khai báo lớp
    public class PhanSo
    {
        //Thuộc tính
        private int ts;
        private int ms;
        //Phương thức
        //1. Kiểm tra ràng buộc
        public bool KiemTraMauSo(int m)
        {
            return (m != 0);
        }
        //2. Khởi tạo
        //2.1 Khởi tạo phân số có giá trị là 0/1
        public void KhoiTao()
        {
            ts = 0;
            ms = 1;
        }
        //2.2 Khởi tạo phân số có tử và mẫu cho trước
        public void KhoiTao(int t, int m)
        {
            if (KiemTraMauSo(m))
            {
                ts = t;
                ms = m;
            }
            else
            {
                ts = 0;
                ms = 1;
            }
        }
        //2.3 Khởi tạo phân số bằng với 1 phân số đã có
        public void KhoiTao(PhanSo p)
        {
            ts = p.ts;
            ms = p.ms;      //ko cần ktra vì p đã là 1 phân số hợp lệ rồi
        }

        //Phương thức thiết lập / hàm tạo / constructors
        public PhanSo()     //hàm tạo không đối số, khởi gán phân số bằng 0/1
        {
            ts = 0;
            ms = 1;
        }

        public PhanSo(int t, int m)
        {
            if (KiemTraMauSo(m))
            {
                ts = t;
                ms = m;
            }
            else
            {
                ts = 0;
                ms = 1;
            }
        }
        //copy constructor
        public PhanSo(PhanSo p)
        {
            ts = p.ts;
            ms = p.ms;
        }

        //3. Cập nhật thông tin
        public void GanTuSo(int t)
        {
            ts = t;
        }
        public void GanMauSo(int m)
        {
            if (KiemTraMauSo(m))
                ms = m;
        }
        //4. Xử lý tính toán
        public void Nhap()
        {
            Console.Write("Nhap tu so:");
            ts = int.Parse(Console.ReadLine());
            do
            {
                Console.Write("Nhap mau so (khac 0):");
                ms = int.Parse(Console.ReadLine());
            } while (ms == 0);
        }
        public void Xuat()
        {
            Console.Write(ts + "/" + ms);
        }
        //Bài tập
        //1. Tìm uscln của 2 số nguyên 
        private int uscln(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            if (a == 0 && b == 0) return 0;         //lỗi
            if (b == 0) return a;
            //đến vị trí này thì b chắc chắn khác 0
            int r = a % b;
            while (r != 0)
            {
                a = b;
                b = r;
                r = a % b;
            }
            return b;
        }
        //2. Tối giản phân số hiện tại
        public void ToiGian()
        {
            int u = uscln(ts, ms);
            ts /= u;
            ms /= u;
        }
        //3. Tìm phân số tối giản ứng với phân số hiện tại
        public PhanSo TimToiGian()
        {
            PhanSo kq = new PhanSo();
            kq.ts = ts;
            kq.ms = ms;
            kq.ToiGian();
            return kq;
        }
        //4. Tính giá trị thực của phân số hiện tại
        public double TinhGiaTri()
        {
            return (double)ts / ms;
        }
        //5. Nghịch đảo phân số hiện tại (nếu được)
        public bool NghichDao()
        {
            if (ts == 0) return false;
            ts = ts + ms;
            ms = ts - ms;
            ts = ts - ms;
            return true;
        }
        //6. Tìm phân số nghịch đảo của phân số hiện tại
        public bool TimNghichDao(out PhanSo kq)
        {
            kq = new PhanSo();
            kq.ts = 0;
            kq.ms = 1;
            return true;
        }
        //7.1 Nhân phân số hiện tại với 1 phân số p cho trước
        public PhanSo Nhan(PhanSo p)
        {
            PhanSo kq = new PhanSo();
            kq.ts = ts * p.ts;
            kq.ms = ms * p.ms;
            kq.ToiGian();           //rút gọn kết quả
            return kq;
        }
        //7.2 Cộng phân số hiện tại với 1 phân số p cho trước
        public PhanSo Cong(PhanSo p)
        {
            PhanSo kq = new PhanSo();
            kq.ts = ts * p.ms + ms * p.ts;
            kq.ms = ms * p.ms;
            kq.ToiGian();
            return kq;
        }
        //7.3 Trừ phân số hiện tại với 1 phân số p cho trước
        public PhanSo Tru(PhanSo p)
        {
            PhanSo kq = new PhanSo();
            return kq;
        }
        //7.4 Chia phân số hiện tại với 1 phân số p cho trước
        public PhanSo Chia(PhanSo p)
        {
            PhanSo kq = new PhanSo();
            return kq;
        }
        //5. Cung cấp thông tin
        public int DocTuSo() { return ts; }
        public int DocMauSo() { return ms; }

        //6. Property get/set
        public int Ts
        {
            get { return ts; }
            set { ts = value; }             //value là giá trị được gán từ bên ngoài
        }
        public int Ms
        {
            get { return ms; }
            set
            {
                if (KiemTraMauSo(value))    //kiểm tra ràng buộc trước khi gán
                    ms = value;
            }
        }
        public double GiaTri
        {
            get { return (double)ts / ms; } //giá trị chỉ cho đọc, ko cho sửa
        }

        //Định nghĩa các phép toán trên kiểu Phân Số
        public static PhanSo operator +(PhanSo a, PhanSo b)
        {
            PhanSo kq = new PhanSo();
            kq.ts = a.ts * b.ms + a.ms * b.ts;
            kq.ms = a.ms * b.ms;
            kq.ToiGian();
            return kq;
        }
        //Phép so sánh 2 phân số (so sánh bằng)
        public static bool operator ==(PhanSo a, PhanSo b)
        {
            return (a.GiaTri == b.GiaTri);
        }
        public static bool operator !=(PhanSo a, PhanSo b)
        {
            return (a.GiaTri != b.GiaTri);
        }
        //Định nghĩa lại phương thức ToString để có thể xuất được bằng WriteLine
        public override string ToString()
        {
            string s = ts.ToString() + "/" + ms.ToString();
            return s;
        }
    }

    class Program
    {
        static void GhiFile(string filename, PhanSo[] arr, int n)
        {
            StreamWriter sw = new StreamWriter(filename);   //mở tập tin để ghi
            
            //Ghi dữ liệu
            sw.WriteLine(n);        //số lượng phân số cần ghi
            
            //lần lượt ghi từng phân số, tử mẫu cách nhau 1 kt trắng
            for (int i = 0; i < n; i++)     
                sw.WriteLine(arr[i].Ts + " " +arr[i].Ms);
            
            //Đóng tập tin lại
            sw.Close();
        }

        static void DocFile(string filename, out PhanSo[] arr, out int n)
        {
            StreamReader sw = new StreamReader(filename);   //mở tập tin
            //Đọc dữ liệu từ tập tin
            n = int.Parse(sw.ReadLine());       //đọc số lượng phân số ở dòng đầu
            arr = new PhanSo[n];                //tạo mảng gồm n phân số
            for (int i = 0; i < n; i++)         //lần lượt đọc từng dòng của tập tin
            {
                string s = sw.ReadLine();
                string[] words = s.Split(' ');  //tách ra thành 2 phần
                arr[i] = new PhanSo();          //tạo từng phân số mới
                arr[i].Ts = int.Parse(words[0]);//parse tử số
                arr[i].Ms = int.Parse(words[1]);//parse mẫu số
            }
            //Đóng tập tin lại
            sw.Close();
        }

        static void Main(string[] args)
        {
            PhanSo[] arr;
            int n;
            DocFile("F:/PHANSO.TXT", out arr, out n);
            foreach (PhanSo p in arr)
            {
                p.Xuat();
                Console.WriteLine();
            }
            GhiFile("F:/PHANSO2.TXT", arr, n);
        }
    }
}
