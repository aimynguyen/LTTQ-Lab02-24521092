using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace bai04
{
    internal class PhanSo : IComparable<PhanSo>
    {
        private int iTuSo;
        private int iMauSo;
        public PhanSo()
        {
            iTuSo = 0;
            iMauSo = 1;
        }
        public PhanSo(int ts, int ms)
        {
            iTuSo = ts;
            iMauSo = ms;
        }
        public void Nhap()
        {
           while (true)
            {
                Console.Write("tu so: ");
                if (int.TryParse(Console.ReadLine(), out iTuSo))
                    break;
                else
                    Console.WriteLine("Gia tri khong hop le! Vui long nhap lai!");
            }
            while (true)
            {
                Console.Write("mau so: ");
                if (int.TryParse(Console.ReadLine(), out iMauSo) && iMauSo != 0)
                    break;
                else
                    Console.WriteLine("Mau so khong hop le! Vui long nhap lai (yeu cau mau khac 0!)");
            }          

        }

        public void Xuat()
        {
            RutGon();
            Console.Write($"{iTuSo}/{iMauSo} ");
        }

        public static int UCLN(int a, int b)
        {
            a=Math.Abs(a);
            b=Math.Abs(b);
            while (b != 0)
            {
                int temp= b;
                b = a % b;
                a = temp;
            }
            return a;
        }
        public void RutGon()
        {
            int ucln=UCLN(iTuSo,iMauSo);
            iMauSo /=ucln;
            iTuSo /= ucln;

            //th mau am
            if (iMauSo < 0)
            {
                iMauSo = -iMauSo;
                iTuSo = -iTuSo;
            }
        }
        public void Print()
        {
            
            if (iTuSo == 0)
            {
                Console.WriteLine("0");
                return;
            }
            if (iMauSo == 1)
            {
                Console.WriteLine(iTuSo);
                return;
            }
            if (iMauSo == -1)
            {
                Console.WriteLine(-iTuSo);
                return;
            }
            Xuat();
        }

        public static PhanSo operator + (PhanSo a, PhanSo b)
        {
            int niMauSo = a.iMauSo * b.iMauSo;
            int niTuSo = a.iTuSo * b.iMauSo + b.iTuSo * a.iMauSo;
            PhanSo kq = new PhanSo(niTuSo, niMauSo);
            kq.RutGon();
            return kq;
        }

        public static PhanSo operator -(PhanSo a, PhanSo b)
        {
            int niMauSo = a.iMauSo * b.iMauSo;
            int niTuSo = a.iTuSo * b.iMauSo - b.iTuSo * a.iMauSo;
            PhanSo kq = new PhanSo(niTuSo, niMauSo);
            kq.RutGon();
            return kq;
        }

        public static PhanSo operator *(PhanSo a, PhanSo b)
        {
            int niMauSo = a.iMauSo * b.iMauSo;
            int niTuSo = a.iTuSo *b.iTuSo;
            PhanSo kq = new PhanSo(niTuSo, niMauSo);
            kq.RutGon();
            return kq;
        }

        public static PhanSo operator /(PhanSo a, PhanSo b)
        {
            if (b.iTuSo == 0)
            {
                throw new DivideByZeroException("Khong the chia cho phan so bang 0 (tu so bang 0)");
            }

            int niTuSo = a.iTuSo * b.iMauSo;
            int niMauSo = a.iMauSo * b.iTuSo;
            PhanSo kq = new PhanSo(niTuSo, niMauSo);
            kq.RutGon();
            return kq;
        }


        public double GetValue()
        {
            return iTuSo*1.0 / iMauSo;
        }

        public int CompareTo(PhanSo other)
        {
            if(GetValue() < other.GetValue())
                return -1;
            else if (GetValue() > other.GetValue())
                return 1;
            else
                return 0;
        }
    }
}
