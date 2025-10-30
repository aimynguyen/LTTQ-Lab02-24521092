using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bai05;

namespace bai05
{
    internal class NhaPho : BatDongSan
    {
        private int iSoTang;
        private short sNamXayDung;
        public NhaPho()
        {
            iSoTang = 0;
            sNamXayDung = 0;
        }
        public NhaPho(int soTang, short namXay)
        {
            iSoTang = soTang;
            sNamXayDung = namXay;
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("So tang: ");
            string input;
            while (true)
            {
                input = Console.ReadLine();
                if (int.TryParse(input, out iSoTang) && iSoTang > 0)
                    break;
                else
                    Console.Write("So tang khong hop le! Vui long nhap lai: ");
            }
            Console.Write("Nam xay dung: ");
            while (true)
            {
                input = Console.ReadLine();
                if (short.TryParse(input, out sNamXayDung) && sNamXayDung > 0)
                    break;
                else
                    Console.Write("Nam xay dung khong hop le! Vui long nhap lai: ");
            }
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.Write($", So tang: {iSoTang}, Nam xay dung: {sNamXayDung}");
        }
        public override char GetcType()
        {
            return 'n';
        }
        public override double GetdGia()
        {
            return base.GetdGia();
        }
        public override double GetdDienTich()
        {
            return base.GetdDienTich();
        }
        public override short GetsNamXayDung()
        {
            return sNamXayDung;
        }
    }
}
