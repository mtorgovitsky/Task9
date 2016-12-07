using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task9.Modules;
using static Task9.Modules.Item;

namespace Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            Item it = new Item("GB", 3);
            FoodItem fi = new FoodItem("HH", 4, new Date(3, 2, 2016), new Date(3, 2, 2017));
            RefrigeratedItem ri = new RefrigeratedItem("Refrig", 2, new Date(6, 12, 2016), new Date(6, 12, 2018), -10, -1);
            ElectronicItem ei = new ElectronicItem("Elec", 7, new Date(4, 10, 2017));
        }
    }
}
