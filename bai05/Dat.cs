using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bai05;

namespace bai05
{
    internal class Dat : BatDongSan
    {        
        public override void Nhap()
        {
            base.Nhap();
        }
        public override void Xuat()
        {
            base.Xuat();
        }
        public override char GetcType()
        {
            return 'd';
        }
        public override double GetdGia()
        {
            return base.GetdGia();
        }
    }
}
