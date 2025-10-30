
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai05
{
    internal class BatDongSan
    {
        private string sDiaChi;
        private double dDienTich;
        private double dGia;
        public BatDongSan()
        {
            sDiaChi = "";
            dDienTich = 0;
            dGia = 0;
        }
        public BatDongSan(string diaChi, double dienTich, double gia)
        {
            sDiaChi = diaChi;
            dDienTich = dienTich;
            dGia = gia;
        }
        public virtual void Nhap()
        {
            Console.Write("Dia chi: ");
            sDiaChi = Console.ReadLine();
            while (true)
            {
                Console.Write("Dien tich (m2): ");
                if (double.TryParse(Console.ReadLine(), out dDienTich) && dDienTich > 0)
                    break;
                else
                    Console.WriteLine("Dien tich khong hop le! Vui long nhap lai!");
            }
            while (true)
            {
                Console.Write("Gia (VND): ");
                if (double.TryParse(Console.ReadLine(), out dGia) && dGia > 0)
                    break;
                else
                    Console.WriteLine("Gia khong hop le! Vui long nhap lai!");
            }
        }
        public virtual void Xuat()
        {
            Console.Write($"Dia chi: {sDiaChi}, Dien tich: {dDienTich} m2, Gia: {dGia} VND");
        }

        public virtual char GetcType()
        {
            return ' ';
        }

        public virtual double GetdGia()
        {   
            return dGia;
        }

        public virtual double GetdDienTich() {
            return dDienTich;
        }
        public virtual short GetsNamXayDung()
        {
            return -1;
        }
        public string GetsDiaChi()
        {
            return sDiaChi;
        }
    }
}
