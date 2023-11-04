using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deMinhHoa_MN
{
    internal class CompareBySLMua : IComparer<KhachHang>
    {
        public int Compare(KhachHang x, KhachHang y)
        {
            return x.SLMua.CompareTo(y.SLMua);
        }
    }
}
