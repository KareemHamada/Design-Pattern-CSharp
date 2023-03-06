using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    sealed class SingletonClass
    {
        private static int counter;
        ////============================ used for lazy loading  ============================
        //// wait unit when call object
        // private static SingletonClass instance = null;


        ////============================ used for eager loading  ============================
        //// when system start it direct work
        //private static readonly SingletonClass instance = new SingletonClass();

        ////============================ used for lazy loading  ============================
        private static readonly Lazy<SingletonClass> instance = new Lazy<SingletonClass>(()=> new SingletonClass());


        ////============================ used for threading  ============================
        //private static readonly object obj = new object();

        //// in Singleton => constructor must be private
        private SingletonClass()
        {
            counter += 1;
            Console.WriteLine("Istance number " + counter.ToString());
        }

        //// ============================ used for eager loading ============================

        public static SingletonClass getInstance()
        {
            return instance.Value;
        }


        //// ============================ used for lazy loading ============================
        //public static SingletonClass getInstance()
        //{
        //    if (instance == null)
        //    {
        //        instance = new SingletonClass();
        //    }

        //    return instance;
        //}

        //// ============================ used for threading ============================
        //public static SingletonClass getInstance()
        //{
        //    if (instance == null)
        //        lock (obj)
        //        {
        //            if (instance == null)
        //            {
        //                instance = new SingletonClass();
        //            }
        //        }

        //    return instance;
        //}


        public void print(string msg)
        {
            Console.WriteLine(msg);
        }


        //public class son : SingletonClass
        //{

        //}
    }
}





// in eager lazy loading all data loaded at first time => big size => lower performance
// in lazy loading data that i need to use only        => small size => higher performance