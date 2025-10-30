using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai01
{
    internal class Calendar
    {
        public int year;
        public int month;
        public int day;
        public Calendar()
        {
            year = 1;
            month = 1;
            day = 1;
        }
        public Calendar(int y, int m)
        {
            year = y;
            month = m;
            day = 1;
        }
       

        public bool IsValidDate()
        {
            if (month < 1 || month > 12)
            {
                return false;
            }

            if (year < 1)
            {
                return false;
            }
            return true;
        }
        public void Nhap()
        {         
            Console.WriteLine("Nhap ngay thang nam:");
            string stry, strm;
            Console.Write("Nam: ");
            while (true)
            { 
                stry = Console.ReadLine();
                if (int.TryParse(stry, out year) && year > 0)
                    break;
                else
                    Console.Write("Nhap lai nam: ");
            }
            Console.Write("Thang: ");
            while (true)
            {
                strm = Console.ReadLine();
                if (int.TryParse(strm, out month) && month > 0 && month <13)
                    break;
                else
                    Console.Write("Nhap lai thang: ");
            }            
        }
        public bool IsLeapYear()
        {
            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int DaysInMonth()
        {
            int days;
            
            switch (month)
            {
                case 1: case 3: case 5: case 7: case 8: case 10: case 12:
                    days = 31;
                    break;
                case 4: case 6: case 9: case 11:
                    days = 30;
                    break;
                case 2:
                    if (IsLeapYear())
                    {
                        days = 29;
                    }
                    else
                    {
                        days = 28;
                    }
                    break;
                default:
                    days = 0;
                    break;
            }
            return days;
        }
        public int GetDayOfYear()
        {
            int[] monthDays = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if (IsLeapYear())
            {
                monthDays[2] = 29;
            }
            int dayOfYear = 0;
            for (int i = 1; i < month; i++)
            {
                dayOfYear += monthDays[i];
            }
            dayOfYear += day;
            return dayOfYear;
        }

        public int DayOfWeek()
        {
            int S = year + (year - 1) / 4 - (year - 1) / 100 + (year - 1) / 400 + GetDayOfYear();
            int dayOfWeek = S % 7;
           return dayOfWeek;
        }
        public void PrintCalendar()
        {
            day = 0;
            Console.WriteLine($"Calendar for {month}/{year}");
            Console.WriteLine("Su Mo Tu We Th Fr Sa");
            int daysInMonth = DaysInMonth();
            int firstDayOfWeek = DayOfWeek();
            //in ngay dau tien
            for (int i = 0; i < firstDayOfWeek; i++)
            {
                Console.Write("   ");
            }
            //in cac ngay con lai 
            for (int day = 1; day <= daysInMonth; day++)
            {
                Console.Write($"{day,2} ");
                if ((firstDayOfWeek + day) % 7 == 0)
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
        }
    }
}
