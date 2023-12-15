using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Задача 1. Используя двузначное случайное число, вывести на экран информацию о четности или нечетности этого числа с использованием тернарной операции.


            //Random rnd = new Random();
            //int number = rnd.Next(10, 99);
            //Console.WriteLine($"случайное число - {number}");
            //string str = (number % 2 == 0) ? "Четное число" : "Нечетное число";
            //Console.WriteLine($"Число {number} - {str}"); 


            //Задача 2. Используя случайное число в диапазоне от 1 до 7, вывести на экран название дня недели.


            //Random rnd = new Random();
            //int day = rnd.Next(1, 7);
            //Console.Write($"Число - {day} ");
            //switch (day)
            //{
            //    case 1: Console.WriteLine("Понеделник");break;
            //    case 2: Console.WriteLine("Вторник");break;
            //    case 3: Console.WriteLine("Среда");break;
            //    case 4: Console.WriteLine("Четверг");break;
            //    case 5: Console.WriteLine("Пятница");break;
            //    case 6: Console.WriteLine("Суббота");break;
            //    case 7: Console.WriteLine("Воскресенье");break;               
            //}


            //Задача 3. Даны три целых положительных числа. Если все они четные, каждое число уменьшить в 2 раза, если хотя бы одно из них четное, увеличить каждое число в 2 раза, если четных чисел нет, каждое число увеличить на 1.


            //Console.Write("Введеите первое число ");
            //int a = int.Parse(Console.ReadLine());

            //Console.Write("Введеите второе число ");
            //int b = int.Parse(Console.ReadLine());

            //Console.Write("Введеите третье число ");
            //int c = int.Parse(Console.ReadLine());

            //if (a % 2 == 0 && b % 2 == 0 && c % 2 == 0)
            //{
            //    //x = x / 2;
            //    //y = y / 2;
            //    //z = z / 2;
            //    a /= 2;
            //    b /= 2;
            //    c /= 2;
            //}
            //else if (a % 2 == 0 | b % 2 == 0 | c % 2 == 0)
            //{
            //    a *= 2; b *= 2; c *= 2;
            //}
            //else
            //{   a += 1;
            //    b += 1;
            //    c += 1;
            //}


            //Console.WriteLine($"Первое число = {a}\nВторое число = {b}\nТретье число = {c} ");



            //Задача 4. Проведен тест, оцениваемый в целочисленных баллах от нуля до ста. Вывести на экран оценку тестируемого в зависимости от набранного количества баллов: от 90 до 100 – «отлично», от 70 до 89 – «хорошо», от 50 до 69 – «удовлетворительно», менее 50 – «неудовлетворительно».



            //Console.WriteLine("Введите ваш балл");
            //int a = int.Parse(Console.ReadLine());

            //if (a >= 90)
            //{
            //    Console.WriteLine("Ваш балл - отлично");
            //}
            //if(a>=70 && a <= 89)
            //{
            //    Console.WriteLine("Ваш балл - хорошо");
            //}
            //if (a >= 50 && a <= 69)
            //{
            //    Console.WriteLine("Ваш балл - удовлетворительно ");
            //}
            //if (a < 50)
            //{
            //    Console.WriteLine("Ваш балл - неудовлетворительно");
            //}




            //Задача 5. Дан признак геометрической фигуры на плоскости: к – круг, п – прямоугольник, т - треугольник. Вывести на экран периметр и площадь заданной фигуры (данные, необходимые для расчетов, запросить у пользователя).


            //Console.WriteLine("Введите признак геометрической фигуры на плокости ");
            //string figure = Console.ReadLine();
            //switch (figure)
            //{
            //    case "К":
            //    case "к":
            //        Console.WriteLine("Введите радиус круга ");
            //        double radius = Convert.ToDouble(Console.ReadLine());
            //        double S = Math.PI * Math.Pow(radius, 2);
            //        double P = 2 * Math.PI * radius;
            //        Console.WriteLine($"Периметр круга - {P}\tПлощадь круга - {S}");
            //        break;
            //    case "П":
            //    case "п":
            //        Console.Write("Введите первую сторону прямоугольника ");
            //        int a = int.Parse(Console.ReadLine());
            //        Console.Write("Введите вторую сторону прямоугольника ");
            //        int b = int.Parse(Console.ReadLine());
            //        Console.WriteLine($"Площадь прямоугольника - {a * b}\tПериметр прямоугольника - {(a + b) * 2}");
            //        break;
            //    case "Т":
            //    case "т":
            //        Console.Write("Введите первую сторону треугольника");
            //        int x = int.Parse(Console.ReadLine());

            //        Console.Write("Введите вторую сторону треугольника");
            //        int y = int.Parse(Console.ReadLine());

            //        Console.Write("Введите третью сторону треугольника");
            //        int z = int.Parse(Console.ReadLine());

            //        int halfP = (x + y + z) / 2;

            //        Console.WriteLine($"Площадь треугольника = {Math.Sqrt(halfP * (halfP - x) * (halfP - y) * (halfP - z))} ");


            //        break;

            //    default: Console.WriteLine("Введите или прямоугольник, или круг, или треугольник"); break;
            //}



            //Задача 6. Написать приложение, которое позволяет вычислить сумму страхового взноса (SV) для автомобиля. Входные данные будут вводиться с клавиатуры:

            //Console.Write("Введите марку автомобиля: ");
            //string car = Console.ReadLine();

            //Console.Write("Введите срок страхования: ");
            //int Months = Convert.ToInt32(Console.ReadLine());

            //double Kt;

            //if (Months < 3)
            //{ 
            //    Kt = 10; 
            //}

            //else if (Months < 6)
            //{
            //    Kt = 8; 
            //}
            //else if (Months < 12)
            //{
            //    Kt = 5; 
            //}
            //else
            //    Kt = 0; 

            //double Sum = 50 * Months * (1 + Kt / 100);

            //Console.WriteLine($"Ваш автомобиль, {car}, был застрахован.");
            //Console.WriteLine($"Сумма страхового взноса составила {Sum} рублей");





            Console.ReadLine();
            
        }
    }
}
