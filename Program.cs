using System;
using System.Diagnostics;
using System.Linq;
using System.Threading;

namespace mucuq
{
    class Program
    {
        static void Main(string[] args)
        {



            int N;
            decimal intPP = 0;
            decimal intMul = 0;
            decimal floatPP = 0;
            decimal floatMul = 0;
            string temppp;
            string[] temp;

            int iterationCount;

            Console.WriteLine("N: ");
            N = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("iterationCount: ");
            iterationCount = Convert.ToInt32(Console.ReadLine());

            for (int lolololo = 0; lolololo < iterationCount; lolololo++)
            {
                Console.WriteLine("iteration: " + lolololo);

                temp = ppInt(N).Split(new string[] { ":" }, StringSplitOptions.None);
                temppp = temp.Last();
                intPP += Convert.ToDecimal(temppp.Replace(".", ","));
                Console.WriteLine("     int+: " + temppp);


                temp = mulInt(N).Split(new string[] { ":" }, StringSplitOptions.None);
                temppp = temp.Last();
                intMul += Convert.ToDecimal(temppp.Replace(".", ","));
                Console.WriteLine("     int*: " + temppp);


                temp = ppF(N).Split(new string[] { ":" }, StringSplitOptions.None);
                temppp = temp.Last();
                floatPP += Convert.ToDecimal(temppp.Replace(".", ","));
                Console.WriteLine("     float+: " + temppp);


                temp = mulF(N).Split(new string[] { ":" }, StringSplitOptions.None);
                temppp = temp.Last();
                floatMul += Convert.ToDecimal(temppp.Replace(".", ","));
                Console.WriteLine("     float*: " + temppp);


            }

            Console.WriteLine("");
            Console.WriteLine("results");

            Console.WriteLine(" in " + iterationCount + " iteration");

            Console.WriteLine("     intTop: "+ (intPP / iterationCount).ToString());
            Console.WriteLine("     intCarp: " + (intMul / iterationCount).ToString());
            Console.WriteLine("     floatTop: " + (floatPP / iterationCount).ToString());
            Console.WriteLine("     floatCarp: " + (floatMul / iterationCount).ToString());


            Console.ReadLine();
        }
        public static string ppInt(int a)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            int d;
            for (int i = 0; i < a; i++)
            {
                d = 10 + 10;
            }


            watch.Stop();
            string dd = watch.Elapsed.ToString();
            return dd;
        }
        public static string mulInt(int a)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            int d;
            for (int i = 0; i < a; i++)
            {
                d = 10 * 10;
            }


            watch.Stop();
            string dd = watch.Elapsed.ToString();
            return dd;
        }
        public static string ppF(int a)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            float d;
            for (int i = 0; i < a; i++)
            {
                d = 10.5f + 10.5f;
            }


            watch.Stop();
            string dd = watch.Elapsed.ToString();
            return dd;
        }
        public static string mulF(int a)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            float d;
            for (int i = 0; i < a; i++)
            {
                d = 10.5f * 10.5f;
            }


            watch.Stop();
            string dd = watch.Elapsed.ToString();
            return dd;
        }
    }
}
