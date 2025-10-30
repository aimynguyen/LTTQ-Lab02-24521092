using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai03
{
    internal class Matrix
    {
        private int rows;
        private int cols;
        private int[,] data;
        public Matrix(int rows, int cols)
        {
            this.rows = rows;
            this.cols = cols;
            data = new int[rows, cols];
        }
        
        public void Nhap()
        {
            string sm, sn;
            while (true)
            {
                Console.Write("Nhap so hang cua ma tran: ");
                sm = Console.ReadLine();

                if (int.TryParse(sm, out int m) && m > 0)
                {
                    break;
                }
                Console.WriteLine("So hang khong hop le! Vui long nhap lai!");
            }

            while (true)
            {
                Console.Write("Nhap so cot cua ma tran: ");
                sn = Console.ReadLine();
                if (int.TryParse(sn, out int n) && n > 0)
                {
                    break;
                }
                Console.WriteLine("So cot khong hop le! Vui long nhap lai!");
            }
            rows= int.Parse(sm);
            cols= int.Parse(sn);

            data = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"Nhap phan tu [{i},{j}]: ");
                    data[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }
        public void Xuat()
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(data[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        public void TimKiem(int x)
        {
            bool found = false;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (data[i, j] == x)
                    {
                        Console.WriteLine($"Phan tu can tim o hang {i+1}, cot {j+1}");
                        found = true;
                    }
                }
            }
            if (!found)
                Console.WriteLine("Khong tim thay phan tu trong ma tran.");
        }

        bool IsPrime(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }

        public void XuatPhanTuLaSoNguyenTo()
        {
            List<int> primes = new List<int>();
           
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (IsPrime(data[i, j]))
                    {
                        primes.Add(data[i,j]);
                    }
                }
            }

            if (primes.Count == 0)
            {
                Console.WriteLine("Khong co so nguyen to trong ma tran.");
                return;
            }
            else
            {
                Console.Write("Cac phan tu la so nguyen to trong ma tran:");
                foreach (var prime in primes)
                {
                    Console.Write(prime + " ");
                }
            }
            Console.WriteLine();
        }

        public void TimDongCoNhieuSoNguyenToNhat()
        {
            int maxCount = 0;
            List<int> rowIndices = new List<int>();

            for (int i = 0; i < rows; i++)
            {
                int count = 0;
                for (int j = 0; j < cols; j++)
                {
                    if (IsPrime(data[i, j]))
                    {
                        count++;
                    }
                }

                if (count > maxCount)
                {
                    maxCount = count;
                    rowIndices.Clear();
                    rowIndices.Add(i); 
                }
                else if (count == maxCount && count > 0)
                {
                    rowIndices.Add(i);
                }
            }

            if (rowIndices.Count > 0)
            {
                Console.WriteLine($"(Dong co nhieu so nguyen to nhat (voi {maxCount} so nguyen to):");
                foreach (int index in rowIndices)
                {
                    Console.WriteLine($"- Dong {index + 1}");
                }
            }
            else
            {
                Console.WriteLine("Khong co so nguyen to trong ma tran.");
            }
        }

    }
}
