using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace Pianino
{
    internal class Program
    {
        static int[] Octava(int numOct)
        {

            int[] octava = { 1047, 1109, 1175, 1245, 1319, 1397, 1480, 1568, 1661, 1760, 1865, 1976, };
            int[] octava2 = { 2093, 2217, 2349, 2489, 2637, 2794, 2960, 3136, 3322, 3520, 3729, 3951, };

            if (numOct == 1)
            {
                return octava;
            }
            else
            {
                return octava2;
            }

        }
        static void Main()
        {
            int[] oct = Octava(1);

            Console.WriteLine("Чтобы поменять октаву нажмите f5 , f6 ");
            Console.WriteLine("Выбрана октава: 1");



            while (true)
            {
                ConsoleKeyInfo klavishi = Console.ReadKey();
                if (klavishi.Key == ConsoleKey.A)
                {
                    Console.Beep(oct[0], 50);
                }
                else if (klavishi.Key == ConsoleKey.S)
                {
                    Console.Beep(oct[1], 50);
                }
                else if (klavishi.Key == ConsoleKey.D)
                {
                    Console.Beep(oct[2], 50);
                }
                else if (klavishi.Key == ConsoleKey.F)
                {
                    Console.Beep(oct[3], 50);
                }
                else if (klavishi.Key == ConsoleKey.G)
                {
                    Console.Beep(oct[4], 50);
                }
                else if (klavishi.Key == ConsoleKey.H)
                {
                    Console.Beep(oct[5], 50);
                }
                else if (klavishi.Key == ConsoleKey.J)
                {
                    Console.Beep(oct[6], 50);
                }
                else if (klavishi.Key == ConsoleKey.K)
                {
                    Console.Beep(oct[7], 50);
                }
                else if (klavishi.Key == ConsoleKey.L)
                {
                    Console.Beep(oct[8], 50);
                }
                else if (klavishi.Key == ConsoleKey.Z)
                {
                    Console.Beep(oct[9], 50);
                }
                else if (klavishi.Key == ConsoleKey.X)
                {
                    Console.Beep(oct[10], 50);
                }
                else if (klavishi.Key == ConsoleKey.C)
                {
                    Console.Beep(oct[11], 50);
                }
                else if (klavishi.Key == ConsoleKey.V)
                {
                    Console.Beep(oct[12], 50);
                }
                else if (klavishi.Key == ConsoleKey.F5)
                {
                    oct = Octava(1);
                    Console.Clear();
                    Console.WriteLine("Для смены октавы нажмите f5 , f6");
                    Console.WriteLine("Выбрана октава: 1");

                }
                else if (klavishi.Key == ConsoleKey.F6)
                {
                    oct = Octava(2);
                    Console.Clear();
                    Console.WriteLine("Для смены октавы нажмите f5 , f6");
                    Console.WriteLine("Выбрана октава: 2");

                }




            }
        }
    }
}