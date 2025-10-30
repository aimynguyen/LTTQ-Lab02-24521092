using System;
using bai01;

class Program
{
    static void Main(string[] args)
    {
        Calendar date = new Calendar();
        date.Nhap();
        
        int daysInMonth = date.DaysInMonth();
        
        int dayOfWeek = date.DayOfWeek();
        Console.WriteLine();
        date.PrintCalendar();

    }
}