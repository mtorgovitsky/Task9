using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9.Modules
{
    public class Item
    {
        public readonly string ProductName;
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
            public Date productionDate { get; set; }
            public Date expiryDate { get; set; }

            public FoodItem(string name, int quantity, Date prodDate, Date expDate)
                : base(name, quantity)
            {
                productionDate = prodDate;
                expiryDate = expDate;
            }
        }

        public class RefrigeratedItem : FoodItem
        {
            public readonly int minTemperature;
            public readonly int maxTemperature;

            public RefrigeratedItem(string name, int quantity, Date prodDate, Date expDate, int minTemp, int maxTemp)
                : base (name, quantity, prodDate, expDate)
            {
                minTemperature = minTemp;
                maxTemperature = maxTemp;
            }
        }

        public class ElectronicItem : Item
        {
            public Date guaranteeDate;

            public ElectronicItem(string name, int quantity, Date guarDate)
                :base(name, quantity)
            {
                guaranteeDate = guarDate;
            }
        }

        public class Date
        {
            public readonly DateTime DateParam;

            public Date(int day, int month, int year)
            {
                DateParam = new DateTime(year, month, day);
            }
        }
    }


}
