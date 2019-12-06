using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            do
            {

                {
                    Console.Write("Меню:\n1) Задание №1 \n2) Задание №2 \n3) Задание №3 \n4)  Задание №4 \n5)  Задание №5 \n6)  Задание №6 \n7) Задание №7 \n8) Задание №8 \n9)  Задание №9 \n10)  Задание №10 \n11)  Задание №11\n12) Задание №12 \n13) Задание №13 \n14)  Задание №14 \n15)  Задание №15 \n16)  Задание №16 \n\nВаше решение: ");
                    i = int.Parse(Console.ReadLine());
                    switch (i)
                    {
                        case 1:
                            Console.Write("Введите два числа для сравнения: ");
                            int a1 = Convert.ToInt32(Console.ReadLine());
                            int a2 = Convert.ToInt32(Console.ReadLine());
                            if (a1 > a2)
                            {
                                Console.WriteLine($"Большее число {a1}");
                            }
                            else if (a1 < a2)
                            {
                                Console.WriteLine($"Большее число {a2}");
                            }
                            else 
                            {
                                Console.WriteLine("Числа равны");
                            }
                            
                            
                            break;
                        case 2:
                            Console.Write("Введите тип общения животного: ");
                            string catdog = Console.ReadLine();
                            if (catdog == "мяу")
                            {
                                Console.WriteLine("Покорми кота!!!");
                            }
                            else if (catdog == "гав")
                            {
                                Console.WriteLine("Погуляй с собакой!!!");
                            }
                            else
                            {
                                Console.WriteLine("Не корми кота и не гуляй с собакой!!!");
                            }
                            
                            break;
                        case 3:
                            Console.Write("Введите номер месяца: ");
                            int month = Convert.ToInt32(Console.ReadLine());
                            if (month == 1 || month == 2 || month == 12)
                            {
                                Console.WriteLine("Зима");
                            }
                            else if (month == 3 || month == 4 || month == 5)
                            {
                                Console.WriteLine("Весна");
                            }
                            else if (month == 6 || month == 7 || month == 8)
                            {
                                Console.WriteLine("Лето");
                            }
                            else if (month == 9 || month == 10 || month == 11)
                            {
                                Console.WriteLine("Осень");
                            }
                            else
                            {
                                Console.WriteLine("На этой планете такого месяца нет");
                            }
                            
                            break;
                        case 4:
                            Console.Write("Введите 0 или 1: ");
                            int intNum = Convert.ToInt32(Console.ReadLine()); ;
                            bool boolNum = Convert.ToBoolean(intNum);
                            if (!boolNum)
                            {
                                Console.WriteLine("Плохо");
                            }
                            else if (boolNum)
                            {
                                Console.WriteLine("Хорошо");
                            }
                            break;
                        case 5:
                            Console.Write("Введите номер недели: ");
                            int day = Convert.ToInt32(Console.ReadLine());
                            switch (day)
                            {
                                case 1: Console.WriteLine("Понедельник"); break;
                                case 2: Console.WriteLine("Вторник"); break;
                                case 3: Console.WriteLine("Среда"); break;
                                case 4: Console.WriteLine("Четверг"); break;
                                case 5: Console.WriteLine("Пятница"); break;
                                case 6: Console.WriteLine("Суббота"); break;
                                case 7: Console.WriteLine("Воскресенье"); break;
                                default: Console.WriteLine("Такого дня недели нет..."); break;

                            }

                            break;
                        case 6:
                            Console.Write("Введите количество км для таксиста: ");
                            int km = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Введите количество минут простоя такси: ");
                            int minut = Convert.ToInt32(Console.ReadLine());
                            int price, j, k;
                            if (km <= 0 || minut < 0)
                            {
                                Console.WriteLine("Ошибка");
                                break;
                            }
                            else
                            {
                                price = 20;
                                for (j = 5; j < km; j++)
                                {
                                    price += 3;
                                }
                                for (k = 0; k < minut; k++)
                                {
                                    price += 1;
                                }
                                Console.WriteLine($"Цена поездки {price}");
                            }
                            
                            break;
                        case 7:
                            Console.Write("Введите число ");
                            int n = Convert.ToInt32(Console.ReadLine());
                            bool z=true;
                            if (n > 1)
                            {
                                for (var g = 2u; g < n; g++)
                            {

                                if (n % g == 0)
                                    {
                                    z = true; 
                                     break;      
                                    }

                                    else
                                    {
                                    z = false;
                                    break;   
                                    }
                            }
                            if (z)
                            {
                                Console.WriteLine("Число не простое");

                            }

                            else
                            {
                               Console.WriteLine("Число простое");

                            }
                            }
                            else
                            {
                                Console.WriteLine("Ошибка");

                            }
                            
                            break;
                        case 8:
                            int stavka=0, many=0;
                            int cubik;
                            do
                            {
                                Console.Write("Введите ставку для игры и 0 для выхода: ");
                                stavka = Convert.ToInt32(Console.ReadLine());
                                if (stavka == 0) { continue; }
                                else
                                {
                                    Random rnd = new Random();
                                    cubik = rnd.Next(1, 12);
                                    Console.WriteLine($"На кубике {cubik}");
                                    if (cubik == 1 || cubik == 2 || cubik == 3 || cubik == 4 || cubik == 5)
                                    {
                                        Console.WriteLine("Вы проиграли");
                                        many = many - stavka;
                                    }
                                    else if (cubik == 6 || cubik == 7 || cubik == 8)
                                    {
                                        many += stavka;
                                        Console.WriteLine($"Ваш текущий выигрыш составлил {stavka}");
                                    }
                                    else if (cubik == 9 || cubik == 10 || cubik == 11)
                                    {
                                        stavka *= 2;
                                        many += stavka;
                                        Console.WriteLine($"Ваш текущий выигрыш составлил {stavka}");
                                    }
                                    else if (cubik == 12)
                                    {
                                        stavka *= 10;
                                        many += stavka;
                                    }
                                    else
                                    {
                                        Console.WriteLine("На этом кубике такого числа нет");
                                    }
                                }
                            } while (stavka != 0);
                            Console.WriteLine($"Ваш выигрыш составлил { many}");
                            break;
                        case 9:
                            double res=0;
                            Console.Write("Введите вашу сумму : ");
                            double value = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Введите тип валюты: 1) UAH, 2) USD, 3)EUR ");
                            int type = Convert.ToInt32(Console.ReadLine());
                            if (type == 1)
                            {
                                res=value / 23.85; Console.WriteLine($"UAH/USD Перевод составил = { res:f2} USD");
                                res=value / 26.25; Console.WriteLine($"UAH/EUR Перевод составил = { res:f2} EUR");
                            }
                            else if (type == 2)
                            {
                                res = value* 23.72; Console.WriteLine($"USD/UAH Перевод составил = { res:f2} USD");
                                res = value * 0.90; Console.WriteLine($"USD/EUR Перевод составил = { res:f2} EUR");
                            }
                            else if (type == 3)
                            {
                                res = value * 1.11; Console.WriteLine($"EUR/UAH Перевод составил = { res:f2} USD");
                                res = value * 26.22; Console.WriteLine($"EUR/USD Перевод составил = { res:f2} EUR");
                            }
                                                        
                            break;
                        case 10:
                            int c,raz = 0;
                            Console.WriteLine("Введите число на которое умножить");
                            int N = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Ответ");
                            for (i = 1; i <= 20; i++)
                            {
                                c = N * i;
                                while ((c /= 10) > 0) { raz++; }
                                Console.WriteLine($"{N}*{i} = {N * i} разрядов  {raz+1}");

                            }
                            
                            break;
                        case 11:
                            Console.WriteLine("Задание 11");
                            Random rn = new Random();
                            int num = rn.Next(1, 146);
                            Console.Write("Мы загадали число, выбирите число->: ");
                            int user;
                            do
                            {
                                user = Convert.ToInt32(Console.ReadLine());
                                if (user == num)
                                {
                                    Console.Write("Вы угадали: ");
                                    continue;
                                }
                                else if (user < num)
                                {
                                    Console.Write("Наше число больше, выбирите число->: ");
                                }
                                else
                                {
                                    Console.Write("Наше число меньше, выбирите число->: ");
                                }
                            } while (user != num);
                            break;
                        case 12:
                            Console.Write("Число->: ");
                            int count = Convert.ToInt32(Console.ReadLine());
                            double gh = 1;
                            while(Math.Pow(gh, 2)<count)
                            { 
                                Console.WriteLine($"Числа = { gh} Квадраты чисел = { Math.Pow(gh, 2)} ");
                                gh++;
                            }
                            
                            break;
                        case 13:
                            Console.Write("Введите 5 чисел ");
                            int input;
                            int sum = 0;
                            int count1 = 0;
                            
                            do
                            {
                                input = int.Parse(Console.ReadLine());
                                sum += input;
                                ++count1;
                            } while (count1 != 5);

                            if (count1 > 0)
                            {
                                Console.WriteLine((double)sum / count1);
                            }
                            
                            break;
                        case 14:
                            int input1;
                            int sum1 = 0;
                            int count11 = 0;
                            Random rng = new Random();
                            do
                            {
                                input1 = rng.Next(1, 6);
                                Console.WriteLine(input1);
                                sum1 += input1;
                                ++count11;
                            } while (count11 != 5);

                            if (count11 > 0)
                            {
                                Console.WriteLine($"Среднее арифметическое = {(double)sum1 / count11}");
                            }
                            
                            break;
                        case 15:
                            int gusee, krolik, kol = 64;
                            for (gusee = 0; gusee <= kol; gusee++)
                            {
                                for (krolik = 0; krolik <= kol / 2; krolik++)
                                {
                                    if (2 * gusee + 4 * krolik == kol)
                                    {
                                        Console.WriteLine($"Гуси = { gusee} Кролики = { krolik}");
                                    }
                                }
                            }
                            
                            break;
                        case 16:
                            { 
                                string password;
                                string root = "root";
                                do
                                {
                                    Console.WriteLine("Введите пароль: ");
                                    password = Console.ReadLine();
                                    if (password != root)
                                    {
                                        Console.WriteLine("Неверный пароль!");
                                    }
                                    else 
                                    {
                                        Console.WriteLine("Верный пароль!");
                                    }
                                } while (password != root);
                                
                            }
                            
                            break;                             


                            default:
                            //Console.WriteLine("Вы нажали что-то другое, нажмите от 1-16...");
                            break;
                    }
                    //Console.Write("\nНажмите любую клавишу для выполнения другого задания");
                    Console.ReadLine();
                    Console.Clear();
                }
            } while (i <17);
        }
    }
}
