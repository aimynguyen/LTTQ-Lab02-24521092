using bai04;
using System;
using System.Numerics;

public  class dsPhanSo
{
    private List<PhanSo> listPs = new List<PhanSo>();
    public void Nhap()
    {
        listPs.Clear();
        int n;
        while (true) 
        { 
        Console.Write("Nhap so luong phan so cua day: ");
        string str=Console.ReadLine();
            if (int.TryParse(str, out n) && n > 0)
            {
                break;
            }
            Console.WriteLine("Nhap so luong phan so hop le! So luong phan so phai lon hon 0 va la so nguyen!");
        }
        Console.WriteLine();
        for (int i = 0; i < n; i++)
        {
            PhanSo p = new PhanSo();
            p.Nhap();
            listPs.Add(p);
            Console.WriteLine();
        }
    }

    public void Xuat()
    {
        for (int i = 0; i < listPs.Count; i++)
        {
            listPs[i].Xuat();
        }
        Console.WriteLine();
    }

    public void TimPhanSoLonNhat()
    {
        double maxVal=listPs[0].GetValue();
        for (int i = 1; i < listPs.Count; i++)
        {
            if(maxVal< listPs[i].GetValue())
            {
                maxVal = listPs[i].GetValue();
            }
        }

        bool exist = false;
        for (int i=0; i < listPs.Count; i++)
        {
            if(listPs[i].GetValue() == maxVal)
            {
                if(exist == false)
                    Console.Write("Phan so lon nhat la: ");
                exist = true;                
                listPs[i].Xuat();
                Console.Write(" ");
            }
        }
        Console.WriteLine();
    }
      
    public void Sort()
    {
        listPs.Sort();
    }
}
public class Program
{
    public void TinhToan()
    {
        PhanSo ps1 = new PhanSo();
        PhanSo ps2 = new PhanSo();

        
        Console.WriteLine("\nNhap phan so thu nhat");
        ps1.Nhap();

        Console.WriteLine("\nNhap phan so thu hai");
        ps2.Nhap();

        PhanSo pskq;

        Console.Write("Tong hai phan so: ");
        pskq = ps1 + ps2;
        pskq.Print();

        Console.Write("\nHieu hai phan so: ");
        pskq = ps1 - ps2;
        pskq.Print();

        Console.Write("\nTich hai phan so: ");
        pskq = ps1 * ps2;
        pskq.Print();

        Console.Write("\nThuong hai phan so: ");
        try
        {
            pskq = ps1 / ps2;
            pskq.Print();
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine($"Loi: {ex.Message}");
        }

    }

    public static void Main()
    {
        dsPhanSo dsPhanSo = new dsPhanSo();
        dsPhanSo.Nhap();

        int choice = -1;
        while (choice != 0)
        {
            Console.WriteLine("\n======== Menu ========");
            Console.WriteLine("1. Xuat danh sach phan so");
            Console.WriteLine("2. Tim phan so lon nhat");
            Console.WriteLine("3. Sap xep tang dan");
            Console.WriteLine("4. Nhap lai danh sach phan so");
            Console.WriteLine("5. Tinh toan voi hai phan so");
            Console.WriteLine("0. Thoat");
            Console.Write("Nhap lua chon: ");
            string input;
            while (true)
            {
                input = Console.ReadLine();
                if (int.TryParse(input, out choice) && choice >= 0 && choice <= 5)
                    break;
                else
                    Console.Write("Lua chon khong hop le! Nhap lai: ");
            }

            switch (choice)
            {
                case 1:
                    Console.Write("Danh sach phan so: ");
                    dsPhanSo.Xuat();
                    break;
                case 2:
                    dsPhanSo.TimPhanSoLonNhat();
                    break;
                case 3:
                    dsPhanSo.Sort();
                    Console.Write("Danh sach sau khi sap xep tang dan: ");
                    dsPhanSo.Xuat();
                    break;
                case 4:
                    dsPhanSo.Nhap();
                    break;
                case 5:
                    Program program = new Program();
                    program.TinhToan();
                    break;
                case 0:
                    Console.WriteLine("Thoat chuong trinh...");
                    break;
                default:
                    Console.WriteLine("Lua chon khong hop le!");
                    break;
            }
        }
    }

}