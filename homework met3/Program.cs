using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_met3
{
    class Program
    {
        enum Months {January = 1, February,March,April,May,June,July,August,September,October,November,December,}
        static void Main(string[] args)
        {
            
            Console.WriteLine("Введите год");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите день");
            int day = Convert.ToInt32(Console.ReadLine());
            if (day > 0 && day <= 366)
            {
                day--;
                DateTime date = new DateTime(year, 1, 1);
                date = date.AddDays(day);
                Console.WriteLine($"{date.Day}  {(Months)date.Month}  {date.Year}");
            }
            else
            {
                Console.WriteLine("Ошибка");
            }
        }
    }
}
