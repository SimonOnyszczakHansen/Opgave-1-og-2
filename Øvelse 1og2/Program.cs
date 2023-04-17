using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Xml;

namespace Øvelse_1og2
{
    class MyCLass
    {
        public void Task1()//Creates a method that we use to print a text in console
        {
            for (int i = 0; i < 5; i++)//a for loop that runs 5 times
            {
                Console.WriteLine("C#-trådning er nemt!");//Writes the string in console
                Thread.Sleep(1000);//Pauses the thread for 1 second
            }            
        }
        public void Task2()//Creates a method that we use to print another text in console
        {
            for (int i = 0; i < 5; i++)//Creates a loop that runs the code inside of it 5 times
            {
                Console.WriteLine("Også med flere tråde ...");//Writes the text in console
                Thread.Sleep(1000);//Makes the thread sleep for 1 second
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyCLass myCLass = new MyCLass();//Creates an object for the class
            Thread t1 = new Thread(myCLass.Task1);//Creates a thread using the method for Task 1 
            Thread t2 = new Thread(myCLass.Task2);//Creates a thread using the method for Task 2
            //Starts the thread
            t1.Start();
            t2.Start();            
            Console.Read();
        }
    }
}
