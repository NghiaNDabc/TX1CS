using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deMinhHoa_MN
{
    internal class KhachHangVIP : KhachHang
    {
        public KhachHangVIP() { }
        public KhachHangVIP(String MaKH):base(MaKH) { }

        public KhachHangVIP(String MaKH, String HoTen, int slMua, float DG)  : base(MaKH,HoTen, slMua, DG)
        {
        }
        public int QuaTang
        {
            get {
                if (TinhTongTien() < 1000) return  120;
                else if (TinhTongTien() >= 1000 && TinhTongTien() < 5000) return  200;
                else return 500;
            }

        }

        public override string ToString()
        {
            return string.Format("{0,20} {1,20} {2,20} {3,10} {4,15} {5,10}", MaKH, HoTen, SLMua, DonGia, TinhTongTien(), QuaTang);
        }
    }
}
