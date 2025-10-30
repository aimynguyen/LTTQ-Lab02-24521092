using bai05;

class Program
{
    public static void Main()
    {
        DsDBS ds = new DsDBS();
        ds.NhapDS();

        //menu
        int choice=-1;
       

        while (choice != 5)
        {
            Console.WriteLine();
            Console.WriteLine("======MENU======");
            Console.WriteLine("1. Xuat danh sach bat dong san");
            Console.WriteLine("2. Tinh tong gia ban tung loai bat dong san");
            Console.WriteLine("3. Danh sach khu dat/nha pho theo yeu cau");
            Console.WriteLine("4. Danh sach bat dong san theo tieu chi");
            Console.WriteLine("5. Thoat");
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
            Console.WriteLine();
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Danh sach bat dong san vua nhap:");
                    ds.XuatDS();
                    break;
                case 2:
                    ds.TongGiaBanTungLoai();
                    break;
                case 3:
                    ds.TimNhaPhoTheoYeuCau();
                    ds.TimDatTheoYeuCau();
                    break;
                case 4:
                    ds.TimBDSTheoTieuChi();
                    break;
                case 5:
                    Console.WriteLine("Thoat chuong trinh.");
                    break;
            }
            Console.WriteLine();
        }

    }
}