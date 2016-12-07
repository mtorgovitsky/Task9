using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9.Modules
{
    public class Item
    {
        public string ProductName;
        private readonly int ProductID;
        public int Quantity;

        static int CurrentID = 1;


        public Item(string name, int quantity)
        {
            ProductName = name;
            Quantity = quantity;
            ProductID = CurrentID;
            CurrentID++;
        }

        public class FoodItem : Item
        {
            public DateTime productionDate { get; set; }
            public DateTime expiryDate { get; set; }

            public FoodItem(string name, int quantity, DateTime prodDate, DateTime expDate)
                : base(name, quantity)
            {
                productionDate = prodDate;
                expiryDate = expDate;
            }
        }

        //public class RafrigeratedItem : FoodItem
        //{
        //    public int minTemperature;
        //    public int maxTemperature;

        //    public RafrigeratedItem()
        //    {

        //    }
        //}

        public class ElectronicItem : Item
        {
            public DateTime guaranteeDate;

            public ElectronicItem(string name, int quantity, DateTime guarDate)
                :base(name, quantity)
            {
                guaranteeDate = guarDate;
            }
        }
    }


}
