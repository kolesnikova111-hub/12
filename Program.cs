using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Field
    {
        public void Matr10()
        {
            char[,] Matrx1 = {{'|','-','-','-','-','-','-','-','-','|'},
                              {'|',' ',' ',' ',' ',' ',' ',' ',' ','|'},
                              {'|',' ',' ',' ',' ',' ',' ',' ',' ','|'},
                              {'|',' ',' ',' ',' ',' ',' ',' ',' ','|'},
                              {'|',' ',' ',' ',' ',' ',' ',' ',' ','|'},
                              {'|',' ',' ',' ',' ',' ',' ',' ',' ','|'},
                              {'|',' ',' ',' ',' ',' ',' ',' ',' ','|'},
                              {'|',' ',' ',' ',' ',' ',' ',' ',' ','|'},
                              {'|',' ',' ',' ',' ',' ',' ',' ',' ','|'},
                              {'|','-','-','-','-','-','-','-','-','|'}};
            for (int i = 0; i < 10; ++i)
            {
                for (int j = 0; j < 10; ++j)
                {
                    Console.Write(Matrx1[i, j].ToString().PadLeft(2));
                }
                Console.WriteLine();
            }
        }
        public void Matr15()
        {
            char[,] Matrx2 = {{'|','-','-','-','-','-','-','-','-','-','-','-','-','-','|'},
                              {'|',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','|'},
                              {'|',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','|'},
                              {'|',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','|'},
                              {'|',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','|'},
                              {'|',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','|'},
                              {'|',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','|'},
                              {'|',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','|'},
                              {'|',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','|'},
                              {'|',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','|'},
                              {'|',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','|'},
                              {'|',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','|'},
                              {'|',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','|'},
                              {'|',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','|'},
                              {'|','-','-','-','-','-','-','-','-','-','-','-','-','-','|'} };
            for (int i = 0; i < 15; ++i)
            {
                for (int j = 0; j < 15; ++j)
                {
                    Console.Write(Matrx2[i, j].ToString().PadLeft(2));
                }
                Console.WriteLine();
            }
        }
        public void Matr20()
        {
            char[,] Matrx3 = {{'-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','|'},
                              {'|',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','|'},
                              {'|',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','|'},
                              {'|',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','|'},
                              {'|',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','|'},
                              {'|',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','|'},
                              {'|',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','|'},
                              {'|',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','|'},
                              {'|',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','|'},
                              {'|',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','|'},
                              {'|',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','|'},
                              {'|',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','|'},
                              {'|',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','|'},
                              {'|',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','|'},
                              {'|',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','|'},
                              {'|',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','|'},
                              {'|',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','|'},
                              {'|',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','|'},
                              {'|',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','|'},
                              {'|','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','|'}};
            for (int i = 0; i < 20; ++i)
            {
                for (int j = 0; j < 20; ++j)
                {
                    Console.Write(Matrx3[i, j].ToString().PadLeft(2));
                }
                Console.WriteLine();
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Field field = new Field();

            Console.WriteLine("Difficult:\n1 - Easy\n2 - Normal\n3 - Hard");
            int

            dif = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            switch (dif)
            {
                case 1:
                    field.Matr10();
                    break;
                case 2:
                    field.Matr15();
                    break;
                case 3:
                    field.Matr20();
                    break;
            }
            Player(dif);
            Console.ReadKey();
        }

        static void Player(int dif)
        {
            Console.SetCursorPosition(3, 3);
            Console.CursorVisible = false;
            int x = 3;
            int y = 3;
            ConsoleKeyInfo k;

            do
            {
                Console.SetCursorPosition(x, y);
                Console.Write('▄');
                k = Console.ReadKey(true);

                if (k.Key == ConsoleKey.UpArrow)
                {
                    do
                    {
                        Console.SetCursorPosition(x, y);
                        Console.Write(' ');
                        y--;
                        Console.SetCursorPosition(x, y);
                        Console.Write('▄');
                        System.Threading.Thread.Sleep(200);
                    } while (!Console.KeyAvailable);

                }
                else if (k.Key == ConsoleKey.DownArrow)
                {
                    do
                    {
                        Console.SetCursorPosition(x, y);
                        Console.Write(' ');
                        y++;
                        Console.SetCursorPosition(x, y);
                        Console.Write('▄');
                        System.Threading.Thread.Sleep(200);
                    } while (!Console.KeyAvailable);


                }
                else if (k.Key == ConsoleKey.LeftArrow)
                {
                    do
                    {
                        Console.SetCursorPosition(x, y);
                        Console.Write(' ');
                        x -= 2;
                        Console.SetCursorPosition(x, y);
                        Console.Write('▄');
                        System.Threading.Thread.Sleep(200);
                    } while (!Console.KeyAvailable);
                }
                else if (k.Key == ConsoleKey.RightArrow)
                {
                    do
                    {
                        Console.SetCursorPosition(x, y);
                        Console.Write(' ');
                        x += 2;
                        Console.SetCursorPosition(x, y);
                        Console.Write('▄');
                        System.Threading.Thread.Sleep(200);
                    } while (!Console.KeyAvailable);
                }

            } while (k.Key != ConsoleKey.Escape);
        }
    }
}