using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("N=");
            int N=Convert.ToInt32(Console.ReadLine());
            Int32[] broevi = new Int32[N];
            Console.WriteLine("Vnesete izbor: 1-Racno vnesuvanje, 2-Random Generiranje");
            Int32 choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                for (int i = 0; i < N; i++)
                {
                    Console.WriteLine("Broj {0}:", i + 1);
                    Int32 tekoven = Convert.ToInt32(Console.ReadLine());
                    broevi[i] = tekoven;
                }
                pecatenje(broevi);

            }
            else if (choice == 2)
            {
                Random random = new Random();
                for (int i = 0; i < N; i++)
                {
                    Int32 tekoven = random.Next(1, 1000);
                    Console.WriteLine("{0}-iot generiran broj iznesuva {1}",i+1,tekoven);
                    broevi[i] = tekoven;
                }
                pecatenje(broevi);
            }
            else {
                Console.WriteLine("Vnesovte {0}!!!\nPogresen izbor!!!",choice);
            }
            Console.WriteLine("\nPecatenje na vrednostite na out-parametrite:");
            double min;
            double max;
            double average;
            outParametri(out min,out max,out average,broevi);
            Console.WriteLine("Min={0}, Max={1}, Average={2}",min,max,average);
            Console.ReadKey();
        }
        public static void pecatenje(Int32[] niza) {
            Console.WriteLine("\nMaximum na site vneseni broevi={0}", niza.Max());
            Console.WriteLine("Minimum na site vneseni broevi={0}", niza.Min());
            Console.WriteLine("Prosek na site vneseni broevi={0}", niza.Average());
            Console.WriteLine("Zbir na site vneseni broevi={0}", niza.Sum());
        }
        public static void outParametri(out double min, out double max, out double average,Int32[] niza) {
            min = niza.Min();
            max = niza.Max();
            average = niza.Average();
        }
    }
}
