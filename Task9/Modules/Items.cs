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
            public DateTime productionDate { get; set; }
            public DateTime expiryDate { get; set; }

            public FoodItem(string name, int quantity, DateTime prodDate, DateTime expDate)
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

            public RefrigeratedItem(string name, int quantity,DateTime prodDate, DateTime expDate, int minTemp, int maxTemp)
                : base (name, quantity, prodDate, expDate)
            {
                minTemperature = minTemp;
                maxTemperature = maxTemp;
            }
        }

        public class ElectronicItem : Item
        {
            public DateTime guaranteeDate;

            public ElectronicItem(string name, int quantity, DateTime guarDate)
                :base(name, quantity)
            {
                guaranteeDate = guarDate;
            }
        }

        public class Date
        {
            public readonly DateTime GivenDate;

            public Date(int day, int month, int year)
            {
                GivenDate = new DateTime(year, month, day);
            }
        }
    }


}
