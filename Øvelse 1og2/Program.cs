using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Øvelse_1og2
{
    class MyCLass
    {
        public void Task1()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("C#-trådning er nemt!");
                Thread.Sleep(1000);
            }            
        }
        public void Task2()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Også med flere tråde ...");
                Thread.Sleep(1000);
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyCLass myCLass = new MyCLass();
            Thread t1 = new Thread(myCLass.Task1);
            Thread t2 = new Thread(myCLass.Task2);
            t1.Start();
            t2.Start();            
            Console.Read();
        }
    }
}
