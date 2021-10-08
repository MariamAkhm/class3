using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_file3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.1");
            Console.WriteLine("Введите число");
            double number = Convert.ToDouble(Console.ReadLine());
            if(number>0)
            {
                Console.WriteLine("Это число= "+number);//неполный условный оператор
            }
            if(number<0)
            {
                Console.WriteLine("Это число= "+(-number));
            }
            
            Console.WriteLine("1.2");
            Console.WriteLine("Введите первое число");
            double number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            double number2 = Convert.ToInt32(Console.ReadLine());
            if(Math.Abs(number1)>Math.Abs(number2))
            {
                Console.WriteLine(number1/2);
            }

            Console.WriteLine("1.3");
            Console.WriteLine("Введите название животного, которого встретила лягушка");
            string mouthSize = "wide";
            string animal = Console.ReadLine();
            if (animal.ToLower().Contains("аллигатор"))
            {
                mouthSize = "small";
            }
            Console.WriteLine(mouthSize);

            Console.WriteLine("1.4");
            Console.WriteLine("Введите посетителя");
            string person = Console.ReadLine();
            string drink = "beer";

            if (person.ToLower()=="jabroni")
            {
                drink="Patron Tequila";
            }
            Console.WriteLine(drink);
            if (person.ToLower()=="school counselor")
            {
                drink = "Anuthing with Alcohol";
            }
            Console.WriteLine(drink);
            if (person.ToLower()=="programmer")
            {
                drink = "Hipster Craft Beer";
            }
            Console.WriteLine(drink);
            if(person.ToLower()=="bike gang member")
            {
                drink = "Moonshine";
            }
            Console.WriteLine(drink);
            if(person.ToLower()=="politician")
            {
                drink = "Your tax dollars";
            }
            Console.WriteLine(drink);
            if(person.ToLower()=="rapper")
            {
                drink = "Cristal";
            }
            Console.WriteLine($"Такой напиток заказал посетитель {drink}");

            Console.WriteLine("1.5");
            Console.WriteLine("Введите строку");
            string content = Console.ReadLine();//содержание строки
            bool english = content.ToLower().Contains("english");
            Console.WriteLine(english);
            
            Console.WriteLine("2.1");
            double summ = 0;
            number = 1;
            for (int i = 0; i < 8; i++)
            {
                summ += number;
                number *= (double)1/ 3;               
            }
            Console.WriteLine(summ);

            Console.WriteLine("2.2");
            
            bool forward = true;
            double currentPosition = 0;
            summ = 0;
            for (int i = 0; i < 100; i++)
            {
                double distance = 1;
                if (forward)
                {
                    
                    distance = distance / (i + 1);
                    summ += distance;
                    currentPosition += distance;                  
                    forward = false;//муж шел обратно домой
                }
                else
                {
                    
                    distance = distance / (i + 1);
                    summ += distance;
                    currentPosition -= distance;
                    forward = true;
                }
            }
            Console.WriteLine($"{summ}  {currentPosition}");
            
            Console.WriteLine("2.3");
            int[] precipitation = new int[31];//количество осдков
            Random r = new Random();
            summ = 0;
            for (int i = 0; i < precipitation.Length; i++)//January
            {
                precipitation[i] = r.Next(0, 900);
                summ += precipitation[i];
            }
            Console.WriteLine(summ / precipitation.Length);
            summ = 0;
            for (int i = 0; i < precipitation.Length; i++) //March
            {
                precipitation[i] = r.Next(0, 1500);
                summ += precipitation[i];
            }
            Console.WriteLine(summ/precipitation.Length);
            Console.WriteLine("Введите ежедневное количество осадков в январе");

            Console.WriteLine("3.1");
            int numerator1 = 1;
            int denomenator1 = 1;
            int numerator2 = 2;
            int denomenator2 = 1;
            int numerator3;
            int denomenator3;

            while (Math.Abs(((double)numerator1 / denomenator1) - ((double)numerator2 / denomenator2))> 0.001)
            {
                numerator3 = numerator2 + numerator1;
                denomenator3 = denomenator2 + denomenator1;
                numerator1 = numerator2;
                denomenator1 = denomenator2;
                numerator2 = numerator3;
                denomenator2 = denomenator3;                        
            }
            Console.WriteLine($"{numerator1}/{denomenator1} {numerator2}/{denomenator2}");
            
            
            Console.WriteLine("3.2");
            Console.WriteLine("Введите число n");
            number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < number; i++)
            {
                if(i*i>number)
                {
                    Console.WriteLine("Первое число, превосходящее n "+i*i);
                    break;
                }
            }

            Console.WriteLine("3.3a");
            number = 100;
            while (number > 79)
            {
                Console.WriteLine(number);
                number--;
            }
            number = 100;
            do
            {
                Console.WriteLine(number);
                number--;
            } while (number>79);

            Console.WriteLine("3.4");
            for (int i = 5000; i > 0; i--)
            {
                if(i%39==0)
                {
                    Console.WriteLine("Максимальное число, которое не превосходит 5000 и делится на 39 :"+i);
                    break;
                }
            }

            Console.WriteLine("3.5a");
            int count = 1;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < count; j++)
                {
                    Console.Write("5");
                }
                Console.WriteLine();
                count++;
            }
            Console.WriteLine("3.5b");
            count = 5;
            for (int i = 0; i < 6; i++)
            {
                for (int j = count; j >0; j--)
                {
                    Console.Write("1");
                }
                Console.WriteLine();
                count--;
            }

            Console.WriteLine("Dopka a)");
            Console.WriteLine("Введите номер вертикали, где находится ладья");
            byte a = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Введите номер горизонтали, где находится ладья");
            byte b = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Введите номер вертикали, куда переместится ладья");
            byte c = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Введите номер горизонтали, куда переместится ладья");
            byte d = Convert.ToByte(Console.ReadLine());
            if (a > 0 && a <= 8 && b>0 && b<=8 && c > 0 && c <=8 && d > 0 && d <= 8)
            {
                if (a == c || b == d)
                {
                    Console.WriteLine("Такой ход возможен");
                }
                else
                {
                    Console.WriteLine("Такой ход невозможен");
                }
            }
            else
            {
                Console.WriteLine("Ошибка");
            }

            Console.WriteLine("Dopka b)");
            Console.WriteLine("Введите номер вертикали, где находится слон");
            a = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Введите номер горизонтали, где находится слон");
            b = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Введите номер вертикали, куда переместится слон");
            c = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Введите номер горизонтали, куда переместится слон");
            d = Convert.ToByte(Console.ReadLine());
            if (a > 0 && a <= 8 && b > 0 && b <= 8 && c > 0 && c <= 8 && d > 0 && d <= 8)
            {
                if (Math.Abs(c - a) == Math.Abs(d - b))
                {
                    Console.WriteLine("Такой ход возможен");
                }
                else
                {
                    Console.WriteLine("Такой ход невозможен");
                }
            }
            else
            {
                Console.WriteLine("Ошибка");
            }

            Console.WriteLine("Dopka с)");
            Console.WriteLine("Введите номер вертикали, где находится король");
            a = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Введите номер горизонтали, где находится король");
            b = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Введите номер вертикали, куда переместится король");
            c = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Введите номер горизонтали, куда переместится король");
            d = Convert.ToByte(Console.ReadLine());
            if (a > 0 && a <= 8 && b > 0 && b <= 8 && c > 0 && c <= 8 && d > 0 && d <= 8)
            {
                if (Math.Abs(c - a) <= 1 && Math.Abs(d - b) <= 1)
                {
                    Console.WriteLine("Такой ход возможен");
                }
                else
                {
                    Console.WriteLine("Такой ход невозможен");
                }
            }
            else
            {
                Console.WriteLine("Ошибка");
            }


            Console.WriteLine("Dopka с)");
            Console.WriteLine("Введите номер вертикали, где находится ферзь");
            a = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Введите номер горизонтали, где находится ферзь");
            b = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Введите номер вертикали, куда переместится ферзь");
            c = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Введите номер горизонтали, куда переместится ферзь");
            d = Convert.ToByte(Console.ReadLine());
            if (a > 0 && a <= 8 && b > 0 && b <= 8 && c > 0 && c <= 8 && d > 0 && d <= 8)
            {
                if ((a == c) || (b == d) || (Math.Abs(c - a)) == (Math.Abs(d - b)))
                {
                    Console.WriteLine("Такой ход возможен");
                }
                else
                {
                    Console.WriteLine("Такой ход невозможен");
                }
            }
            else
            {
                Console.WriteLine("Ошибка");
            }

            Console.WriteLine("Dopka d)");
            Console.WriteLine("Введите номер вертикали, где находится белая пешка");
            a = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Введите номер горизонтали, где находится белая пешка");
            b = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Введите номер вертикали, куда переместится белая пешка");
            c = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Введите номер горизонтали, куда переместится белая пешка");
            d = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Бьет ли фигуру соперника?");
            bool isEmpty = bool.Parse(Console.ReadLine());
            if (a > 0 && a <= 8 && b > 0 && b <= 8 && c > 0 && c <= 8 && d > 0 && d <= 8)
            {
                if ((c - a == 1 && d - b == 0) || (isEmpty && c - a == 1 && d - b == 1))
                {
                    Console.WriteLine("Такой ход возможен!");
                }
                else
                {
                    Console.WriteLine("Такой ход невозможен!");
                }
            }
            else
            {
                Console.WriteLine("Ошибка");
            }

            Console.WriteLine("Dopka e)");
            Console.WriteLine("Введите номер вертикали, где находится черная пешка");
            a = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Введите номер горизонтали, где находится черная пешка");
            b = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Введите номер вертикали, куда переместится черная пешка");
            c = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Введите номер горизонтали, куда переместится черная пешка");
            d = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Бьет ли фигуру соперника?");
            isEmpty = bool.Parse(Console.ReadLine());
            if (a > 0 && a <= 8 && b > 0 && b <= 8 && c > 0 && c <= 8 && d > 0 && d <= 8)
            {
                if ((a - c == 1 && b - d == 0) || (isEmpty && a - c == 1 && b - d == 1))
                {
                    Console.WriteLine("Такой ход возможен!");
                }
                else
                {
                    Console.WriteLine("Такой ход невозможен!");
                }
            }
            else
            {
                Console.WriteLine("Ошибка");
            }

            Console.WriteLine("Dopka j)");
            Console.WriteLine("Введите номер вертикали, где находится черная пешка");
            a = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Введите номер горизонтали, где находится черная пешка");
            b = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Введите номер вертикали, куда переместится черная пешка");
            c = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Введите номер горизонтали, куда переместится черная пешка");
            d = Convert.ToByte(Console.ReadLine());
            if (a > 0 && a <= 8 && b > 0 && b <= 8 && c > 0 && c <= 8 && d > 0 && d <= 8)
            {
                if ((Math.Abs(c - a) == 2 && Math.Abs(d - b) == 1) || (Math.Abs(d - b) == 2 && Math.Abs(c - a) == 1))
                {
                    Console.WriteLine("Такой ход возможен!");
                }
                else
                {
                    Console.WriteLine("Такой ход невозможен!");
                }
            }
            else
            {
                Console.WriteLine("Ошибка");
            }
        }
    }
}
