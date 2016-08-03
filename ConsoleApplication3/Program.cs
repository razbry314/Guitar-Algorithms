using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Text.RegularExpressions;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ConsoleApplication3
{
    class Program
    {

        static void Main(string[] args)
        {
            string[] Notes = new string[12] {"A","A#", "B", "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#" };

            string Fnote, UpperFnote;

            Console.Write("Please enter the first note: ");
            Fnote = Console.ReadLine();

            UpperFnote = Fnote.ToUpper();

            int i = Array.IndexOf(Notes, UpperFnote);

            foreach (string j in Notes)
            {
                if(i <= 11 )
                {
                    Console.Write("{0} ", Notes[i]);
                    i++;
                }
                else
                {
                    i = 1;
                    Console.Write("{0} ", Notes[0]);
                }
            }

                Console.ReadKey();

        }

    }
}
