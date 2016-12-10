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
            Item it = new Item("Generic Item", 3);
            FoodItem fi = new FoodItem("Food", 4, new Date(3, 2, 2016), new Date(3, 2, 2017));
            RefrigeratedItem ri = new RefrigeratedItem("Refrig", 6, new Date(6, 12, 2016), new Date(6, 12, 2018), -10, -1);
            ElectronicItem ei = new ElectronicItem("Elec", 7, new Date(4, 10, 2017));

            List<Item> stKolBo = new List<Item>(100);
            stKolBo.Add(it);
            stKolBo.Add(fi);
            stKolBo.Add(ri);
            stKolBo.Add(ei);

            Stock stk = new Stock();
            stk.AddItem(it);
            stk.AddItem(fi);
            stk.AddItem(ri);
            stk.AddItem(ei);

            //Console.WriteLine(fi);

            //Console.WriteLine(stk);

            //stk.AddItem(ri);
            //stk.AddItem(fi);
            //stk.AddItem(ri);
            //stk.AddItem(fi);

            stk.AddItem(new RefrigeratedItem("Refrig1", 2, new Date(6, 12, 2016), new Date(6, 12, 2018), -10, -1));
            stk.AddItem(new RefrigeratedItem("Refrig2", 2, new Date(6, 12, 2016), new Date(6, 12, 2018), -10, -1));
            stk.AddItem(new RefrigeratedItem("Refrig3", 10, new Date(6, 12, 2016), new Date(6, 12, 2018), -10, -1));
            stk.AddItem(new RefrigeratedItem("Refrig4", 2, new Date(6, 12, 2016), new Date(6, 12, 2018), -10, -1));
            stk.AddItem(new RefrigeratedItem("Refrig5", 23, new Date(6, 12, 2016), new Date(6, 12, 2019), -10, -1));
            stk.AddItem(new RefrigeratedItem("Refrig6", 2, new Date(6, 12, 2016), new Date(6, 12, 2018), -10, -1));
            stk.AddItem(new RefrigeratedItem("Refrig7", 13, new Date(6, 12, 2016), new Date(6, 12, 2020), -10, -1));

            stk.Order(9);

            int refrigCount = stk.HowMany(-6);

            stk.RemoveAfterDate(new Date(1,1,2019));
        }
    }
}
