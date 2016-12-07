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
            FoodItem fi = new FoodItem("HH", 4, DateTime.Now, DateTime.Now.AddYears(1));
        }
    }
}
