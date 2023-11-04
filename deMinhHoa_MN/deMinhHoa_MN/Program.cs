using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deMinhHoa_MN
{
    internal class Program
    {
        static List<KhachHang> listKH = new List<KhachHang>();
        static int choose()
        {
            int number = 0;
            do
            {
                try
                {
                    Console.Write("\tNhap lua chon: ");
                    number = Convert.ToInt32(Console.ReadLine());
                    return number;
                }
                catch (Exception)
                {
                    Console.WriteLine("Nhap sai kieu du lieu. Nhap lai.");
                }
            }while (true);
        }
        static void TieuDe()
        {
            Console.WriteLine(string.Format("{0,20} {1,20} {2,20} {3,10} {4,15} {5,10} ", "MaKH", "HoTen", "SLMua", "DonGia", "TongTien", "Qua Tang"));

        }
        static void NhapKhachHang()
        {
            int choose1;
            Console.WriteLine("\t1.KhachHang");
            Console.WriteLine("\t2.KhachHangVIP");
            choose1 = choose();   
            bool check = false;
            String MaKH;
            do
            {
                Console.Write("Nhap ma Kh: ");
                MaKH = Console.ReadLine();
                KhachHang k = listKH.Find(kh => kh.MaKH .Equals(MaKH));
                if (k != null)
                {
                    Console.WriteLine("Nhap trung  ma khach hang. Nhap lai!");
                    check = true;
                }
                else check = false;
               
            }while (check == true);

            switch (choose1)
                {
                    case 1:
                        KhachHang a = new KhachHang(MaKH);
                        a.NhapThonTin();
                        listKH.Add(a);
                        break;
                    case 2:
                        KhachHangVIP b = new KhachHangVIP(MaKH);
                        b.NhapThonTin();
                        listKH.Add(b);
                        break;
                    default: Console.WriteLine("Nhap sai."); break;
                }
        }

         static void XuatDS()
        {
            TieuDe();
            foreach (KhachHang kh in listKH)
            {
                Console.WriteLine(kh.ToString());   
            }
        }

        static void findMaxSLMua()
        {
            
            
            //var query = listKH.AsQueryable();
            //int max = query.Max(p => p.SLMua);
            //Console.WriteLine(max);
            TieuDe();
            //foreach (KhachHang kh in listKH)
            //{
            //    if (kh.SLMua == max) Console.WriteLine(kh.ToString());
            //}
            var listKhMax = listKH.Where(kh => kh.SLMua == listKH.Max(k => k.SLMua)).ToList();
            foreach(var kh in listKhMax)
            {
                Console.WriteLine(kh.ToString());
            }
            IEnumerable<int> sapXepKh = 
                from kh in listKH
                where kh.SLMua == listKH.Max(k =>k.SLMua)
                orderby kh.HoTen descending
                select kh.SLMua;
            foreach(var sap in sapXepKh)
            {
                Console.WriteLine(sap.ToString());
            }
            //Console.WriteLine(sapXepKh.First().ToString()); 


        }
        static void fakeData()
        {
            listKH.Add(new KhachHang("Ma1", "ten1",10, 1.1f));
            listKH.Add(new KhachHang("Ma2", "ten2", 50, 2.1f));
            listKH.Add(new KhachHang("Ma4", "ten3", 50, 5.1f));
            listKH.Add(new KhachHang("Ma3", "ten4", 40, 4.1f));
        }
      
        
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            fakeData();
            XuatDS();
            Console.WriteLine();
            //CompareBySLMua c = new CompareBySLMua();
            //listKH.Sort(c);
            //XuatDS();
            bool check = true;
            do
            {
                Console.WriteLine("1 Nhập thông tin");
                Console.WriteLine("2 Hiển thị danh sách");
                Console.WriteLine("3 Tìm Max SL Mua");
                Console.WriteLine("4 Thoát");

                switch (choose())
                {
                    case 1: NhapKhachHang(); break;
                    case 2: XuatDS(); break;
                    case 3: findMaxSLMua(); break;
                    case 4: check = false; break;
                    default: Console.WriteLine("Nhap sai."); break;
                }


            } while (check);
            Console.ReadLine();

        }
    }
}
