using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bai05;

namespace bai05
{
    internal class ChungCu : BatDongSan
    {
        private int iTang;
        public ChungCu()
        {
            iTang = 0;
        }
        public ChungCu(int tang)
        {
            iTang = tang;
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Tang: ");
            string input;
            while (true)
            {
                input = Console.ReadLine();
                if (int.TryParse(input, out iTang) && iTang > 0)
                    break;
                else
                    Console.Write("Tang khong hop le! Vui long nhap lai: ");
            }
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.Write($", Tang: {iTang}");
        }        
        public override char GetcType()
        {
            return 'c';
        }
        public override double GetdGia()
        {
            return base.GetdGia();
        }
    }
}
