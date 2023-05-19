using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swith
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 10 чтобы узнать информацию о всех заданиях");
            
            int number_mission = Convert.ToInt32(Console.ReadLine());
            switch (number_mission)
            {
                case 10:
                    Console.WriteLine("1-е задание: Число +-5"); 
                    Console.WriteLine("2-е задание: Макс число из 3");
                    Console.WriteLine("3-е задание: Сумма только положительных чисел");
                    Console.WriteLine("4-е задание: Удвоить x, если x больше 10");
                    Console.WriteLine("5-е задание: День недели в зависимости от числа");
                    Console.WriteLine("6-е задание: Минимальное число большее 200 и делится на 17");
                    Console.WriteLine("7-е задание: 20км на какой день и 100км");
                    Console.WriteLine("8-е задание: Факториал");
                    Console.WriteLine("9-е задание: Натуральное число и его наименьший делитель отличный от 1");
                    break;
            }
            Console.WriteLine("Введите номер задания чтобы выполнить его");
            int number = int.Parse(Console.ReadLine());

            switch (number)
            {
                case 1: Console.WriteLine("Введите число");
                    int first_number = int.Parse(Console.ReadLine());
                    if (first_number > 0)
                    {
                        Console.WriteLine(first_number + 5);
                    }
                    else
                    {
                        Console.WriteLine(first_number - 5);
                    }
                    break;
                case 2:
                    Console.WriteLine("Введите первое число");
                    int num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите второе число");
                    int num2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите третье число");
                    int num3 = int.Parse(Console.ReadLine());
                    int max = num1;

                    if (num2 > max)
                    {
                        max = num2;
                    }
                    if (num3 > max)
                    {
                        max = num3;
                    }
                    Console.WriteLine("наибольшее число" + max);
                    break;

                case 3:

                    Console.WriteLine("Введите первое число:"); int num_1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите второе число:");
                    int num_2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите третье число:"); int num_3 = int.Parse(Console.ReadLine());
                    int sum = 0; if (num_1 > 0)
                    {
                        Console.WriteLine(sum += num_1);
                    }
                    if (num_2 > 0)
                    {
                        Console.WriteLine(sum += num_2);
                    }
                    if (num_3 > 0)
                    {
                        Console.WriteLine(sum += num_3);
                    }
                    else
                    {
                        Console.WriteLine("Все числа отрицательные");
                    }
                    break;

                case 4:
                    Console.WriteLine("введите х");
                    int x = int.Parse(Console.ReadLine());
                    if (x > 10)
                    {
                        Console.WriteLine($"Удвоенное значение { x * 2}");
                    }
                    else
                    {
                        Console.WriteLine(x);
                    }
                    break;
                case 5:
                    Console.WriteLine("Введите день недели");
                    int day_of_week = int.Parse(Console.ReadLine());

                    switch (day_of_week)
                    {
                        case 1:
                            Console.WriteLine("Понедельник");
                            break;
                        case 2:
                            Console.WriteLine("Вторник");
                            break;
                        case 3:
                            Console.WriteLine("Среда");
                            break;
                        case 4:
                            Console.WriteLine("Четверг");
                            break;
                        case 5:
                            Console.WriteLine("Пятница");
                            break;
                        case 6:
                            Console.WriteLine("Суббота");
                            break;
                        case 7:
                            Console.WriteLine("Воскресенье");
                            break;

                    }
                    break;

                case 6:
                    Console.WriteLine("вывести минимальное число больше 200 которое нацело делится на 17");
                    int chislo = 200;
                    int delitel = 17;
                    while (true)
                    {
                        if (chislo % delitel == 0)
                            break;
                        ++chislo;
                    }
                    Console.WriteLine(chislo);
                    break;

                case 7:
                    double distance_first = 10;
                    int days = 1;
                    double dlinna = 10;
                    while (distance_first<20)
                    {
                        distance_first *= 1.05;
                        days++;
                    }

                    Console.WriteLine($"Через {days}-й день человек пробежит {distance_first:F2} km");
                    
                    while (dlinna >= 100)
                    {
                        dlinna += distance_first ;
                        
                    }
                    Console.WriteLine($"На {dlinna}-й день человек достигнет общей дистанции 100 km");

                    break;

                case 8:
                    Console.WriteLine("введите число факториал которого вы хотите вывести");
                    int numer = int.Parse(Console.ReadLine());
                    int factorial = 1;
                    for (int i = 1; i <= numer; i++)
                    {
                        factorial *= i;
                    }
                    Console.WriteLine($"Факториал числа {numer} = {factorial}");
                    break;

                case 9:
                    Console.WriteLine("Ввести натуральное число");
                    int natural_number = int.Parse(Console.ReadLine());
                    int minimal_delitel = 0;
                    for(int i = 2; i<=natural_number; i++)
                    {
                        if (natural_number % i == 0)
                        {
                            minimal_delitel = i;
                            break;
                        }
                    }
                    Console.WriteLine($"Наименьший делитель числа {natural_number} отличный от 1 равен {minimal_delitel}");
                    break;
            }
            Console.ReadKey();
         
        }
    }
}
