using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp4;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            SortAlgorithms.Test();          
        }

        static void Swap(ref int a, ref int b)
        {
            var temp = a;
            a = b;
            b = temp;
        }

        class Product
        {
            public Product(string name, int newID)
            {
                ItemName = name;
                ItemID = newID;
            }

            public string ItemName { get; set; }
            public int ItemID { get; set; }

            public override int GetHashCode()
            {
                int hashCode = -1;
                return hashCode;
            }
        }

        private static void ChangeByReference(Product itemRef)
        {
            // Change the address that is stored in the itemRef parameter.
            //itemRef = new Product("Stapler", 99999);

            // You can change the value of one of the properties of
            // itemRef. The change happens to item in Main as well.
            itemRef.ItemID = 12345;
        }

        private static void ModifyProductsByReference()
        {
            // Declare an instance of Product and display its initial values.
            Product item = new Product("Fasteners", 54321);
            System.Console.WriteLine("Original values in Main.  Name: {0}, ID: {1}\n",
                item.ItemName, item.ItemID);

            // Pass the product instance to ChangeByReference.
            ChangeByReference(item);
            System.Console.WriteLine("Back in Main.  Name: {0}, ID: {1}\n",
                item.ItemName, item.ItemID);
        }

        static void SetObj(object obj) { }
        static object GetObj() { return null; }
        static void SetStr(string str) { }
        static String GetStr() { return ""; }
        static void TestMethodIN(in int num)
        {
            Console.WriteLine(num);
        }

        static void TestMethodParams(params int[] nums)
        {
            Console.WriteLine(nums);
        }

        static void TestMethodOut(out int num)
        {
            num = 3;
            Console.WriteLine(num);
        }

        static void TestMethodRef(ref int num)
        {
            Console.WriteLine(num);
        }

        public class DaysOfTheWeek : IEnumerable
        {
            private string[] days = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };

            public IEnumerator GetEnumerator()
            {
                for (int index = 0; index < days.Length; index++)
                {
                    // Yield each day of the week.
                    yield return days[index];
                }
            }
        }
    }

    public class EagerSingleton
    {
        // create an instance of the class.
        private static EagerSingleton _instance = new EagerSingleton();

        // private constructor, so it cannot be instantiated outside this class.
        private EagerSingleton() { }
        static EagerSingleton()
        {

        }

        // get the only instance of the object created.
        public static EagerSingleton getInstance()
        {
            return _instance;
        }
    }

    public class Singleton
    {
        private static Singleton _instance = new Singleton();
        private Singleton()
        {

        }

        public Singleton Instance { get => _instance; }
    }
}

public class ThreadSingleton
{
    private static volatile ThreadSingleton _instance;
    private static readonly object _syncRoot = new object();

    public static ThreadSingleton Instance
    {
        get
        {
            if (_instance == null)
            {
                lock (_syncRoot)
                {
                    if (_instance == null)
                    {
                        _instance = new ThreadSingleton();
                    }
                }
            }
            return _instance;
        }
    }



    class Item
    {
        public string Id { get; set; }
        public string Revision { get; set; }
    }

    public struct Person
    {
        public string Name;
        public int Age;
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }


}
