using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9.Modules
{
    public class Stock
    {
        private List<Item> itemsInStock;
        private const int maxItems = 100;

        public Stock()
        {
            itemsInStock = new List<Item>(maxItems);
        }

        private bool StockIsNotEmpty()
        {
            if (itemsInStock.Count > 0)
                return true;
            else
                return false;
        }

        public void AddItem(Item newItem)
        {
            try
            {
                if (itemsInStock.Count <= maxItems)
                    itemsInStock.Add(newItem);
                else
                    throw new IndexOutOfRangeException
                        ("The Stock if Full!\nPlease sell one or more items and then try to add new.");
            }
            catch (IndexOutOfRangeException exStockFull)
            {
                Console.WriteLine(exStockFull.Message);
            }
            catch
            {
                Console.WriteLine("Cannot Add {0}", newItem.ToString());
            }
        }

        public void RemoveItem(Item item)
        {
            try
            {
                if (StockIsNotEmpty())
                    itemsInStock.Remove(item);
                else
                    throw new ArgumentNullException
                        ("The Stock if empty!\nPlease add one or more items and then try to delete.");
            }
            catch
            {
                Console.WriteLine("Cannot Delete {0}", item.ToString());
            }
        }

        public override string ToString()
        {
            StringBuilder tmpSB = new StringBuilder();
            if (StockIsNotEmpty())
            {
                foreach (Item item in itemsInStock)
                {
                    tmpSB.Append(item + " ");
                }
            }
            else
                return "The Stock is Empty";

            return tmpSB.ToString();
        }

        public void RemoveAfterDate(Date d)
        {
            if (StockIsNotEmpty())
            {
                for (int i = itemsInStock.Count - 1; i > 0; i--)
                {
                    if (itemsInStock[i] is RefrigeratedItem)
                    {
                        RefrigeratedItem tmpDel = itemsInStock[i] as RefrigeratedItem;
                        if (tmpDel.expiryDate.DateParam < d.DateParam)
                            itemsInStock.RemoveAt(i);
                    }
                }
            }
        }

        public int HowMany(int temp)
        {
            int refrigRes = 0;
            if (StockIsNotEmpty())
            {
                foreach (Item item in itemsInStock)
                {
                    if (item is RefrigeratedItem)
                    {
                        RefrigeratedItem tmpRefrig = item as RefrigeratedItem;
                        if (tmpRefrig.minTemperature <= temp && tmpRefrig.maxTemperature >= temp)
                            refrigRes++;
                    }
                }
            }
            return refrigRes;
        }

        public void Order(int x)
        {
            if (StockIsNotEmpty())
            {
                foreach (Item item in itemsInStock)
                {
                    if(item.Quantity < x)
                        Console.WriteLine("The item {0} has {1} entities in the stock. PLease order more!", item.ProductName, item.Quantity);
                    
                    
                    //int itemCount = 0;
                    //Item tmpItem;
                    //for (int i = 0; i < itemsInStock.Count; i++)
                    //{
                    //    tmpItem = itemsInStock[i];
                    //    for (int j = (i + 1); j < itemsInStock.Count - 1; j++)
                    //    {
                    //        if (itemsInStock[i].ProductName == itemsInStock[i + 1].ProductName)
                    //            itemCount++;
                    //    }
                    //    if (itemCount < x)
                    //    {
                    //        Console.WriteLine("The item {0} has {1} entities in the stock. PLease order more!", itemsInStock[i], itemCount);
                    //        itemCount = 0;
                    //    }
                    //}
                }
            }
        }
    }

}
