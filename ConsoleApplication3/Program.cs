using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ConsoleApplication3
{
    class Program
    {
        //string[] Notes = new string[12] { "A", "A#", "B", "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#" };

        static void Main(string[] args)
        {
            int b=0;
            string Fnote, Snote, Tnote, UpperFnote;
            char delim = ',';

                Console.Write("Please enter the tuning for the guitar (notes comma seperated): ");
                Fnote = Console.ReadLine();

                UpperFnote = Fnote.ToUpper();

                string[] input = UpperFnote.Split(delim);

                foreach(string i in input)
                {
                    FretBoardAlgo(input[b]);
                    b++;
                }

                Console.ReadKey();
            
        }
       public static void FretBoardAlgo(string Note)
        {
            string[] Notes = new string[12] { "A", "A#", "B", "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#" };
            int i = Array.IndexOf(Notes, Note);

            foreach (string j in Notes)
            {
                if (i <= 11)
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
            Console.Write("\n");
        }

    }
}
