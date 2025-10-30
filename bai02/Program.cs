using System;
using System.IO; // de dung DirectoryInfo va FileInfo

class Program
{
   public static void Main()
    {
        Console.Write("Nhap duong dan thu muc: ");
        string str=Console.ReadLine();

        while (string.IsNullOrWhiteSpace(str))
        {
            Console.Write("Duong dan khong duoc de trong. Vui long nhap lai: ");
            str = Console.ReadLine();
        }
        DirectoryInfo dir = new DirectoryInfo(str);

        if (!dir.Exists)
        {
            Console.WriteLine("Thu muc khong ton tai.");
            return;
        }

        Console.WriteLine($"Directory of {dir.FullName}");

        FileInfo[] files = dir.GetFiles(); //file trong thu muc
        DirectoryInfo[] subDirs = dir.GetDirectories(); //thu muc con

        long totalSize = 0;// de in dong cuoi
        int fileCount = 0;

        //in thu muc con 
        foreach (DirectoryInfo d in subDirs)
        {
            //<DIR> de biet la thu muc, in thoi gian sua/truy cap gan nhat
            Console.WriteLine($"{d.LastWriteTime:dd/MM/yyyy}  {d.LastWriteTime:hh:mm tt}    <DIR>          {d.Name}");
        }
        //in file
        foreach (FileInfo f in files)
        {
            Console.WriteLine($"{f.LastWriteTime:dd/MM/yyyy}  {f.LastWriteTime:hh:mm tt}    {f.Length,15:N0} {f.Name}");
            totalSize += f.Length;
            fileCount++;
        }

        //dong cuoi
        Console.WriteLine($"\n {fileCount} File(s) {totalSize:N0} bytes");
        Console.WriteLine($" {subDirs.Length} Dir(s) {DriveInfo.GetDrives()[0].AvailableFreeSpace:N0} bytes free");
    }

}