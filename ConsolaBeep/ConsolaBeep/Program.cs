using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaBeep
{
    public enum Tone
    {
        /*
         * 
         *  64	do5	C6	1046,50
            63	si4	B5	987,767
            62	la♯4/si♭4	A♯5/B♭5	932,328
            61	la4	A5	880,000
            60	sol♯4/la♭4	G♯5/A♭5	830,609
            59	sol4	G5	783,991
            58	fa♯4/sol♭4	F♯5/G♭5	739,989
            57	fa4	F5	698,456
            56	mi4	E5	659,255
            55	re♯4/mi♭4	D♯5/E♭5	622,254
            54	re4	D5	587,330
            53	do♯4/re♭4	C♯5/D♭5	554,365
            52	do4	C5	523,251
         * */
        REST = 0,
        C4 = 523,
        C4sharp = 554,
        D4 = 587,
        D4sharp = 622,
        E4 = 660,
        F4 = 698,
        F4sharp = 740,
        G4 = 784,
        G4sharp = 831,
        A4 = 880,
        A4sharp = 932,
        B4 = 988,
        C5 = 1047,
        Csharp5 = 1109,
        D5 = 1175,
        D5sharp = 1245,
        E5 = 1318,
        F5 = 1397,
        F5sharp = 1480,
        G5 = 1568
    };

    /*
     * 71	sol5	G6	1567,98
        70	fa♯5/sol♭5	F♯6/G♭6	1479,98
        69	fa5	F6	1396,91
        68	mi5	E6	1318,51
        67	re♯5/mi♭5	D♯6/E♭6	1244,51
        66	re5	D6	1174,66
        65	do♯5/re♭5	C♯6/D♭6	1108,73
    */
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.Write("Happy Birthday!");
            Console.ForegroundColor = ConsoleColor.Green;

            Console.ReadKey();

            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Write("Happy Birthday!");
            Console.ForegroundColor = ConsoleColor.White;

            Console.Beep((int)Tone.C4, 400);
            Console.Beep((int)Tone.D4, 400);
            Console.Beep((int)Tone.E4, 400);
            Console.Beep((int)Tone.F4, 400);
            Console.Beep((int)Tone.G4, 400);
            Console.Beep((int)Tone.A4, 400);
            Console.Beep((int)Tone.B4, 400);
            Console.Beep((int)Tone.C5, 800);

            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Write("Happy Birthday!");
            Console.ForegroundColor = ConsoleColor.White;


            Console.Beep((int)Tone.G4, 400);
            Console.Beep((int)Tone.G4, 400);
            Console.Beep((int)Tone.A4, 800);
            Console.Beep((int)Tone.G4, 800);
            Console.Beep((int)Tone.C5, 800);
            Console.Beep((int)Tone.B4, 1400);
            Console.Beep((int)Tone.G4, 400);
            Console.Beep((int)Tone.G4, 400);
            Console.Beep((int)Tone.A4, 800);

            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.Write("Happy Birthday!");
            Console.ForegroundColor = ConsoleColor.Green;

            Console.Beep((int)Tone.G4, 800);
            Console.Beep((int)Tone.D5, 800);
            Console.Beep((int)Tone.C5, 1400);
            Console.Beep((int)Tone.G4, 400);
            Console.Beep((int)Tone.G4, 400);
            Console.Beep((int)Tone.G5, 800);
            Console.Beep((int)Tone.E5, 800);
            Console.Beep((int)Tone.C5, 800);
            Console.Beep((int)Tone.B4, 800);
            Console.Beep((int)Tone.A4, 800);

            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.Write("Happy Birthday!");
            Console.ForegroundColor = ConsoleColor.Black;

            Console.Beep((int)Tone.F5, 400);
            Console.Beep((int)Tone.F5, 400);
            Console.Beep((int)Tone.E5, 800);
            Console.Beep((int)Tone.C5, 800);
            Console.Beep((int)Tone.D5, 800);
            Console.Beep((int)Tone.C5, 1200);

            Console.ReadKey();
        }
    }
}
