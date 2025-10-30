using System;
using bai03;
public class Program 
{
    public static void Main(string[] args)
    {
        Matrix matrix = new Matrix(0, 0);
        matrix.Nhap();

        int choice = -1;
        while (choice != 0)
        {
            Console.WriteLine();
            Console.WriteLine("=========Menu==========");
            Console.WriteLine("1. Xuat ma tran");
            Console.WriteLine("2. Tim kiem phan tu");
            Console.WriteLine("3. Xuat cac phan tu la so nguyen to");
            Console.WriteLine("4. Tim dong co nhieu so nguyen to nhat");
            Console.WriteLine("5. Nhap lai ma tran");
            Console.WriteLine("0. Thoat");
            Console.Write("Nhap lua chon cua ban: ");
            string input;
            while (true)
            {
                input = Console.ReadLine();
                if (int.TryParse(input, out choice) && choice > 0 && choice <= 5)
                    break;
                else
                    Console.Write("Lua chon khong hop le! Nhap lai: ");
            }
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Ma tran vua nhap:");
                    matrix.Xuat();
                    break;
                case 2:
                    Console.Write("Nhap phan tu can tim: ");
                    int x = int.Parse(Console.ReadLine());
                    matrix.TimKiem(x);
                    break;
                case 3:
                    matrix.XuatPhanTuLaSoNguyenTo();
                    break;
                case 4:
                    matrix.TimDongCoNhieuSoNguyenToNhat();
                    break;
                case 5:
                    matrix.Nhap();
                    break;
                case 0:
                    Console.WriteLine("Thoat chuong trinh.");
                    break;
                default:
                    Console.WriteLine("Lua chon khong hop le!");
                    break;
            }
        }
    }    
}