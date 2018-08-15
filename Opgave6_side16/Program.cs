using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave6_side16
{
    class Program
    {
        static void Main(string[] args)
        {
            Start:
            Console.WriteLine("Indtast enten");
            Console.WriteLine("'d' for Decimal tal");
            Console.WriteLine("'b' for Binært tal");
            Console.WriteLine("'h' for Hexadecimale tal");
            Console.WriteLine("'q' for at Afslutte");
            string input = Convert.ToString(Console.ReadLine());

            switch (input)
            {
                case "d":
                    {
                        Console.Clear();
                        Console.Write("Indtast decimal tal : ");
                        int decimaltal = Convert.ToInt32(Console.ReadLine());

                        //Tallet "2" Indikere at det er 2tals systemet man bruger altså "Binære tal"
                        string binary = Convert.ToString(decimaltal, 2);
                        string hex = decimaltal.ToString("X");

                        Console.Clear();
                        Console.WriteLine("{0} Decimal er = {1} i binary", decimaltal, binary);
                        Console.WriteLine("{0} Decimal er = {1} i hexadecimal", decimaltal, hex);

                        Console.ReadKey();
                        Console.Clear();
                        goto Start;
                    }
                case "b":
                    {
                        Console.Clear();
                        Console.Write("Indtast binært tal : ");
                        string binary = (Console.ReadLine());

                        //Tallet "2" Indikere at det er 2tals systemet man bruger altså "Binære tal"
                        int decimaltal1 = Convert.ToInt32(binary, 2);
                        string hex = (Convert.ToInt32(decimaltal1)).ToString("X");

                        Console.Clear();
                        Console.WriteLine("{0} Binært er = {1} i decimaltal", binary, decimaltal1);
                        Console.WriteLine("{0} Binært er = {1} i hexadecimal", binary, hex);

                        Console.ReadKey();
                        Console.Clear();
                        goto Start;
                    }
                case "h":
                    {
                        Console.Clear();
                        Console.Write("Indtast hexadecimalt tal : ");
                        string hex = (Console.ReadLine());

                        //Tallet "16" Indikere at det er 16tals systemet man bruger altså "Hexadecimale tal"
                        int decimaltal1 = Convert.ToInt32(hex, 16);
                        int decimaltal2 = int.Parse(hex, System.Globalization.NumberStyles.HexNumber);

                        Console.Clear();
                        Console.WriteLine("{0} Hexadecimal er = {1} i decimaltal", hex, decimaltal1);
                        Console.WriteLine("{0} Hexadecimal er = {1} i hexadecimal", hex, decimaltal2);

                        Console.ReadKey();
                        Console.Clear();
                        goto Start;
                    }
                case "q":
                    {
                        Environment.Exit(0);
                        Console.ReadKey();
                        break;
                    }
                default:
                break;
            }
        }
    }
}
