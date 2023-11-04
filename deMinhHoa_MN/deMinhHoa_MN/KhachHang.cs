using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace deMinhHoa_MN
{
    internal class KhachHang : IComparable<KhachHang>
    {
        private String _MaKH;
        private String _HoTen;
        private int _SLMua;
        private float _DonGia;

        public String MaKH
        {
            get { return _MaKH; }
            set { _MaKH = value; }
        }

        public String HoTen
        {
            get { return _HoTen; }
            set { _HoTen = value; }
        }
        public int SLMua
        {
            get { return _SLMua; }
            set { _SLMua = value; }
        }

        public float DonGia
        {
            get { return _DonGia; }
            set
            {
                _DonGia = value;
            }
        }
        public KhachHang(){
        }
        public KhachHang(String MaKH)
        {
            this._MaKH = MaKH;
        }
        public KhachHang(String MaKH, String HoTen, int slMua, float DG)
        {
            _MaKH = MaKH;
            _HoTen = HoTen;
            _SLMua = slMua;
            _DonGia = DG;
        }
        public float TinhTongTien()
        {
            return SLMua * DonGia;
        }

        public virtual void NhapThonTin()
        {
            Console.Write("Nhap ten KH: ");
            _HoTen = Console.ReadLine();
            Console.Write("Nhap sl mua: ");
            _SLMua = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap don gia: ");
            _DonGia = Convert.ToSingle(Console.ReadLine());
        }

        public override string ToString()
        {
            return string.Format("{0,20} {1,20} {2,20} {3,10} {4,15} ", MaKH, HoTen, SLMua, DonGia, TinhTongTien());
        }

        public override bool Equals(object obj)
        {
            return MaKH.Equals((obj as  KhachHang)._MaKH);
        }
        public override int GetHashCode()
        {
            return MaKH.GetHashCode();
        }

        public int CompareTo(KhachHang other)
        {
            return SLMua.CompareTo(other._SLMua);
        }
    }
}
