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
            //Indikere at det er her programmet starter (er nødvendigt vis man vil gå tilbage til start senere i programmet)
            Start:
            //Sætter default window size
            Console.SetWindowSize(130, 20);
            //Baggrunds farve
            Console.BackgroundColor = ConsoleColor.White;
            //Tekst osv. farve
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            //Menuen    //Input fra brugeren    //sætter hvor teksten skal stå
            Console.SetCursorPosition(50, 1 );
            Console.WriteLine("Velkommen til Rois Converter");
            Console.SetCursorPosition(50, 3 );
            Console.WriteLine("Indtast enten");
            Console.SetCursorPosition(50, 5 );
            Console.WriteLine("'d/D' for Decimal tal");
            Console.SetCursorPosition(50, 7 );
            Console.WriteLine("'b/B' for Binært tal");
            Console.SetCursorPosition(50, 9 );
            Console.WriteLine("'h/H' for Hexadecimale tal");
            Console.SetCursorPosition(50, 11 );
            Console.WriteLine("'q/Q' for at Afslutte");
            Console.SetCursorPosition(50, 13 );
            //String der læser input fra brugeren
            string input = Convert.ToString(Console.ReadLine().ToLower());

            //Switch case "input" og cases "d", "b", "h"
            switch (input)
            {
                case "d":
                    {
                        //sætter hvor teksten skal stå
                        Console.Clear();
                        Console.SetCursorPosition(50, 1 );

                        //Input fra brugeren
                        Console.Write("Indtast decimal tal : ");
                        //String der læser input fra brugeren
                        int decimaltal = Convert.ToInt32(Console.ReadLine());
                       
                        //Udregninger & Convertere
                        //Tallet "2" Indikere at det er 2tals systemet man bruger altså "Binære tal"
                        string binary = Convert.ToString(decimaltal, 2);
                        //"X" Definere at det hexadecimale tal der skal bruges
                        string hex = decimaltal.ToString("X");

                        Console.Clear();
                        //Udskrivning af "decimaltal", "binary", "hex"
                        Console.SetCursorPosition(41, 1 );
                        Console.WriteLine("{0} Decimal er = {1} i binary", decimaltal, binary);
                        Console.SetCursorPosition(41, 3 );
                        Console.WriteLine("{0} Decimal er = {1} i hexadecimal", decimaltal, hex);
                        Console.SetCursorPosition(41, 5 );
                        Console.Write("Tryk på en tast for at komme tilbage til menuen");

                        Console.SetCursorPosition(41, 7 );
                        Console.ReadKey();
                        Console.Clear();
                        goto Start;
                    }
                case "b":
                    {
                        //sætter hvor teksten skal stå
                        Console.Clear();
                        Console.SetCursorPosition(41, 1 );

                        //Input fra brugeren
                        Console.Write("Indtast binært tal : ");
                        //String der læser input fra brugeren
                        string binary = (Console.ReadLine());

                        //Udregninger & Convertere
                        //Tallet "2" Indikere at det er 2tals systemet man bruger altså "Binære tal"
                        int decimaltal1 = Convert.ToInt32(binary, 2);
                        //"X" Definere at det hexadecimale tal der skal bruges
                        string hex = (Convert.ToInt32(decimaltal1)).ToString("X");

                        Console.Clear();
                        //Udskrivning af "binary", "decimaltal1", "hex"
                        Console.SetCursorPosition(41, 1 );
                        Console.WriteLine("{0} Binært er = {1} i decimaltal", binary, decimaltal1);
                        Console.SetCursorPosition(41, 3 );
                        Console.WriteLine("{0} Binært er = {1} i hexadecimal", binary, hex);
                        Console.SetCursorPosition(41, 5 );
                        Console.Write("Tryk på en tast for at komme tilbage til menuen");
                        
                        Console.SetCursorPosition(41, 7 );
                        Console.ReadKey();
                        Console.Clear();
                        goto Start;
                    }
                case "h":
                    {
                        //sætter hvor teksten skal stå
                        Console.Clear();
                        Console.SetCursorPosition(50, 1 );

                        //Input fra brugeren
                        Console.Write("Indtast hexadecimalt tal : ");
                        //String der læser input fra brugeren
                        string hex = (Console.ReadLine());

                        //Udregninger & Convertere
                        //Tallet "16" Indikere at det er 16tals systemet man bruger altså "Hexadecimale tal"
                        int decimaltal1 = Convert.ToInt32(hex, 16);
                        //Omregningen fra hexadecimaletal til det arabiske talsystem "Sys.Globalization.NumberStyles.Hexnumber" sørger for det
                        int decimaltal2 = int.Parse(hex, System.Globalization.NumberStyles.HexNumber);

                        Console.Clear();
                        //Udskrivning af "hex", "decimaltal1", "decimaltal2"
                        Console.SetCursorPosition(41, 1 );
                        Console.WriteLine("{0} Hexadecimal er = {1} i decimaltal", hex, decimaltal1);
                        Console.SetCursorPosition(41, 3 );
                        Console.WriteLine("{0} Hexadecimal er = {1} i hexadecimal", hex, decimaltal2);
                        Console.SetCursorPosition(41, 5 );
                        Console.Write("Tryk på en tast for at komme tilbage til menuen");

                        Console.SetCursorPosition(41, 7 );
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
                    goto Start;
                break;
            }
        }
    }
}
