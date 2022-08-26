using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StockAccountManagement
{
    
    class StockManage:IStocks
    {

        int share = 1000;
        List<string> arr = new List<string>();
        List<string> arr2 = new List<string>();
        public void stockAccount()
        {
            Console.WriteLine("Compony Stocks");
            arr.Add("Compony Name : Infosys");
            arr.Add("Total Stocks : " + share);
            for (int i = 0; i < arr.Count; i++)
            {
                Console.WriteLine(arr[i]);
            }
            arr2.Add("Compony Name : Tata");
            arr2.Add("Total Stocks : " + share);
            for (int j = 0; j < arr2.Count; j++)
            {
                Console.WriteLine(arr2[j]);
            }
        }
        public void transaction()
        {
            int choice;
            do
            {
                Console.WriteLine("\n**Select Your Choice**");
                Console.WriteLine("\n1:Enter to Buy shares");
                Console.WriteLine("2:Enter to Sell shares");
                Console.WriteLine("3:Enter to Show Portfolio");
                Console.WriteLine("4:Enter to showCompony Stock Data");
                Console.WriteLine("0:Exit");
                Console.WriteLine("\nEnter Your Choice");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        buy();
                        break;
                    case 2:
                        sell();
                        break;
                    case 3:
                        save();
                        break;
                    case 4:
                        stockAccount();
                        break;

                }
            } while (choice != 0);
        }
        public void buy()
        {
            Console.WriteLine("\n");
            Console.WriteLine("--------> You are purchasing shares <-----------");
            Console.WriteLine("\n");
            Console.WriteLine("Enter Customer Name");
            string cname = Console.ReadLine();
            arr2.Add("Customer Name : " + cname);
            //Console.WriteLine("Share Name");
            //string sname = Console.ReadLine();
            //arr2.Add("Compony Name : " + sname);
            Console.WriteLine("Quantity");
            int quantity = int.Parse(Console.ReadLine());
            if (share - quantity >= 0)
            {
                share = share - quantity;
                arr2.Add("Quantity : " + quantity);
                arr.Add("Total Stocks : " + share);
            }
            else
            {

                Console.WriteLine("All shares of compony already sold");
                Console.WriteLine("No seller Available");
            }

        }

        public void sell()
        {
            Console.WriteLine("-----------> You are Selling your shares <-------------");
            Console.WriteLine("Quantity to sell");
            int quantity = int.Parse(Console.ReadLine());
            share = share + quantity;
            arr2.Add("Quantity : " + quantity);
            arr.Add("Total Stocks : " + share);
            Console.WriteLine("\n");

        }

        public void save()
        {
            Console.WriteLine("\n");
            Console.WriteLine("------------------> Customer Portfolio <----------------");
            Console.WriteLine("\n");
            for (int i = 0; i < arr2.Count; i++)
            {
                Console.WriteLine(arr2[i]);
            }
        }
    }
}
