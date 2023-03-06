using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    internal class Program
    {

        static void Main(string[] args)
        {


            //// ============================ for parrallel methods  ============================
            Parallel.Invoke(
                () => method1(),
                () => method2()
                );

            //// for singelton class
            //SingletonClass sn = SingletonClass.getInstance();
            //sn.print("ss");

            //SingletonClass ww = SingletonClass.getInstance();
            //ww.print("ww");


            Console.ReadKey();
        }


        //// ============================ for parrallel methods  ============================

        public static void method1()
        {
            SingletonClass s = SingletonClass.getInstance();
            s.print("hello world");
        }

        public static void method2()
        {
            SingletonClass w = SingletonClass.getInstance();
            w.print("hello world 222");
        }
    }
}
