using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace csharpfeatures
{
    static public class CompareInterface
    {
        public static void Test()
        {
            List<Car> justOrders = new();
            justOrders.Add(new Car { Id = 2, Name = "Oleg" });
            justOrders.Add(new Car { Id = 1, Name = "Michele" });
            justOrders.Add(new Car { Id = 3, Name = "Denis" });
            justOrders.Add(new Car { Id = 5, Name = "Antoni" });
            justOrders.Add(new Car { Id = 4, Name = "Sergeiya" });

            WriteLine("Before sorting");
            Print<Car>(justOrders);
            justOrders.Sort(new CarCompare());
            WriteLine("After sorting");
            Print<Car>(justOrders);
        }

        private static void Print<T>(IEnumerable<T> list)
        {
            foreach(var item in list)
            {
                WriteLine(item);
            }
        }
    }

    public class JustOrder
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return $"Id = {Id}, Name = {Name}";
        }
    }

    public class Order : IComparable<Order>
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int CompareTo(Order other)
        {
            return this.Id.CompareTo(other.Id);
        }
        public override string ToString()
        {
            return $"Id = {Id}, Name = {Name}";
        }
    }

    public class Car
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return $"Id = {Id}, Name = {Name}";
        }
    }

    public class CarCompare : IComparer<Car>
    {
        public int Compare(Car x, Car y)
        {
            return x.Name.Length.CompareTo(y.Name.Length);
        }
    }
}
