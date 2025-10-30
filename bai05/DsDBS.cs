using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bai05;

namespace bai05
{
    internal class DsDBS
    {
        private List<BatDongSan> listBDS=new List<BatDongSan>();
        
        public void NhapDS()
        {
            int n;
            string str;
            Console.Write("Nhap so luong bat dong san: ");
            while(true)
            {
                str=Console.ReadLine();
                if (int.TryParse(str, out n) && n > 0)
                {
                    break;
                }
                Console.Write("Nhap so luong bat dong san hop le! So luong phai lon hon 0 va la so nguyen: ");
            }
            n=int.Parse(str);
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nNhap thong tin bat dong san thu {i+1}:");
                Console.Write("Chon loai bat dong san (1 - Nha Pho, 2 - Chung Cu, 3 - Khu Dat): ");
                int choice;
                while (true)
                {
                    string str1 = Console.ReadLine();
                    if((int.TryParse(str1,out choice) && (choice==1 || choice==2 || choice ==3)))
                    {
                        break;  
                    }
                    Console.Write("Lua chon khong hop le! Vui long chon lai (1 - Nha Pho, 2 - Chung Cu, 3 - Khu Dat): ");
                }
                BatDongSan bds;

                bool validChoice = false;

                switch (choice)
                {
                    case 1:
                    {
                        bds = new NhaPho();
                        break;
                    }
                    case 2:
                    {
                        bds = new ChungCu();
                        break;
                    }  
                    default:
                    {
                        bds = new Dat();
                        break;
                    }
                }

                bds.Nhap();
                listBDS.Add(bds);
            }
            Console.WriteLine();
        }

        public void XuatDS()
        {
            for(int i=0; i<listBDS.Count; i++)
            {
                Console.WriteLine($"Bat dong san thu {i+1}:");
                listBDS[i].Xuat();
                Console.WriteLine();
            }
        }

        public void TongGiaBanTungLoai()
        {
            double  tongDat = 0;
            double  tongNhaPho = 0;
            double  tongChungCu = 0;
            for(int i=0; i<listBDS.Count; i++)
            {
                if(listBDS[i].GetcType()=='d')
                {
                    tongDat += (double)listBDS[i].GetdGia();
                }
                else if(listBDS[i].GetcType()=='n')
                {
                    tongNhaPho += (double)listBDS[i].GetdGia();
                }
                else
                {
                    tongChungCu += (double)listBDS[i].GetdGia();
                }
            }
            Console.WriteLine($"Tong gia ban bat dong san loai Dat: {tongDat}");
            Console.WriteLine($"Tong gia ban bat dong san loai Nha Pho: {tongNhaPho}");
            Console.WriteLine($"Tong gia ban bat dong san loai Chung Cu: {tongChungCu}");
            Console.WriteLine($"Tong gia ban tat ca bat dong san: {tongDat + tongNhaPho + tongChungCu}");
        }

        public void TimDatTheoYeuCau()
        {
            bool found= false;

            for(int i=0; i<listBDS.Count; i++)
            {
                if(listBDS[i].GetcType()=='d' && listBDS[i].GetdDienTich()>100)
                {
                    if(found==false)
                        Console.WriteLine("\nCac khu dat co dien tich tren 100m2:");
                    listBDS[i].Xuat();
                    found= true;
                }
            }

            if (found==false)
            {
                Console.WriteLine("\nKhong tim thay khu dat nao theo yeu cau da cho.");
            }
        }

        public void TimNhaPhoTheoYeuCau()
        {
            bool found = false;
            
            for(int i=0; i<listBDS.Count; i++)
            {
                // if(listBDS[i].GetcType()=='n')
                if (listBDS[i] is NhaPho)
                {
                   if(listBDS[i].GetdDienTich()>60 && listBDS[i].GetsNamXayDung()>=2019)
                   {
                        if(found==false)
                            Console.WriteLine("Cac nha pho co dien tich > 60 m2 va xay dung tu nam 2019 ve sau:");
                        listBDS[i].Xuat();
                        found= true;
                    }
                }
            }
            if (found==false)
            {
                Console.WriteLine("Khong tim thay nha pho nao theo yeu cau da cho.");
            }
        }

        public void TimBDSTheoTieuChi()
        {
            Console.Write("Nhap dia chi can tim: ");
            string diaChiTim = Console.ReadLine();
            diaChiTim = diaChiTim.ToUpper();
            Console.Write("Nhap gia toi da: ");
            double giaToiDa = double.Parse(Console.ReadLine());
            Console.Write("Nhap dien tich toi thieu: ");
            double dienTichToiThieu = double.Parse(Console.ReadLine());

            bool found = false;
            

            for(int i=0; i<listBDS.Count; i++)
            {
                if(listBDS[i].GetdGia()<=giaToiDa && listBDS[i].GetdDienTich()>=dienTichToiThieu && listBDS[i].GetsDiaChi().ToUpper().Contains(diaChiTim))
                {
                   if (found==false)
                        Console.WriteLine("Cac bat dong san tim duoc:");
                    listBDS[i].Xuat();
                    found = true;                    
                }
            }
            if (found==false)
            {
                Console.WriteLine("Khong tim thay bat dong san nao theo tieu chi da cho.");
            }

            Console.WriteLine();
        }

    }
}
