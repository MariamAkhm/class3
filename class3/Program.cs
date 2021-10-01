using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class3
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("classwork 1");
             Console.WriteLine("Введите трехзначное число");
             int number = Convert.ToInt32(Console.ReadLine());

             if (number>99 && number<1000)
             {
                 if (number%10 == number / 100)
                 {
                     Console.WriteLine("Число палиндром!");
                 }
                 else
                 {
                     Console.WriteLine("Число не является палиндромом!");
                 }
             }
             else
             {
                 Console.WriteLine("Это не трехзначное число!");
             }

             Console.WriteLine("classwork 2");
             Console.WriteLine("Введите длину");
             double lenght = Convert.ToDouble(Console.ReadLine());
             Console.WriteLine("Введите ширину");
             double width = Convert.ToDouble(Console.ReadLine());
             Console.WriteLine("Каков диаметр головы Васи?");
             double diameter = Convert.ToDouble(Console.ReadLine());
             if (width-diameter>=2 && lenght - diameter >= 2)
             {
                 Console.WriteLine("Вася пролез!");
             }
             else
             {
                Console.WriteLine("Не пролез!");
             }

            Console.WriteLine("classwork 3");
            byte dayOfWeek = Convert.ToByte(Console.ReadLine());                    
            switch (dayOfWeek)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Нет такого дня недели!");
                    break;
            }

            Console.WriteLine("classwork 4");
            try
            {
                number = Convert.ToInt32(Console.ReadLine());
                switch (number)
                {
                    case 6:
                        Console.WriteLine("Шестерка");
                        break;
                    case 7:
                        Console.WriteLine("Семерка");
                        break;
                    case 8:
                        Console.WriteLine("Восьмерка");
                        break;
                    case 9:
                        Console.WriteLine("Девятка");
                        break;
                    case 10:
                        Console.WriteLine("Валет");
                        break;
                    case 11:
                        Console.WriteLine("Десятка");
                        break;
                    case 12:
                        Console.WriteLine("Валет");
                        break;
                    case 13:
                        Console.WriteLine("Дама");
                        break;
                    case 14:
                        Console.WriteLine("Туз");
                        break;
                    default:
                        Console.WriteLine("Нет такой карты!");
                        break;

                }
            }
            catch (Exception)
            {
                Console.WriteLine("Ошибка");              
            }
            finally
            {
                Console.WriteLine("Нет такой карты");
            }
            Console.ReadLine();

            Console.WriteLine("classwork 5");
            int radius = 6370;
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine($"Расстояние равно = {Math.Sqrt((radius + i)*(radius+i)-(radius*radius))} км") ;
            }

            Console.WriteLine("classwork 6");
            double n = Convert.ToDouble(Console.ReadLine());
            for (int i = 1; i <=9; i++)
            {
                Console.WriteLine($"{n}*{i} = {n*i}");//таблица умножения на число n
            }

            Console.WriteLine("classwork 7");
            int summ = 0;
            int count = 0;
            double result = 0 ;
            try
            {
                Console.WriteLine("Введите число (отрицательное число завершает программу)");
                number = Convert.ToInt32(Console.ReadLine());
                while (number>=0)
                {
                    count++;
                    summ += number;
                    number = Convert.ToInt32(Console.ReadLine());
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Ошибка");
            }
            finally
            {
                if (count != 0)
                {
                    result = (double)summ / count;
                    Console.WriteLine(result);
                }
                else
                {
                    Console.WriteLine("Нулевая последовательность!");
                }
            }

            Console.WriteLine("classwork 8");
            int [] numbers = new int[10];
            bool isProgressed = true;
            Console.WriteLine("Введите 10 чисел");
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < numbers.Length-1; i++)
            {
                
                if(numbers[i]>numbers[i+1])
                {
                    Console.WriteLine($"индекс элемента который нарушает возрастание {i+1}, а сам элемент равен {numbers[i+1]}");
                    isProgressed = false;
                    break;
                }

            }
            if (isProgressed)
            {
                Console.WriteLine("Возрастающая последовательность!");
            }
            Console.WriteLine("classwork 9");
            summ = 0;
            count = 1;
            bool conclusion = true;
            Console.WriteLine("Введите целое число (число 0 завершает программу");
            while (conclusion)
            {
                number = Convert.ToInt32(Console.ReadLine());
                if(number==0)
                {
                    conclusion = false;
                    continue;
                }
                if (count%3==0)
                {
                    summ += number;
                }
                count++;
            }
            Console.WriteLine(summ);

            Console.WriteLine("classwork 10");
            summ = 0;
            count = 0;
            conclusion = true;
            Console.WriteLine("Введите последовательность (число 0 завершает программу");
            while(conclusion)
            {
                number = Convert.ToInt32(Console.ReadLine());
                if(number==0)
                {
                    conclusion=false;
                    goto PrintSum;
                }
                else
                {
                    summ += number;
                }
                count++;
            }
        PrintSum:
            { 
                Console.WriteLine(summ); 
            }
        }
    }
}
