using System;
using System.Collections.Generic;

namespace financeApp
{



    public class AllItems
    {
        public List<Item> AllMyItems { get; set; } = new List<Item>();

    }


    class Program
    {




        static void Main(string[] args)
        {

            AllItems AI = new AllItems();

            List<Item> MyList = new List<Item>();

            

    



            for (var i = 0; i < 5; i++)
            {

                Console.WriteLine("Make a selection: ");
                var MyVal = Console.ReadLine();

                if (MyVal == "new")
                {
                    Console.WriteLine("Add an item: ");
                    var el = new Item
                    {
                        Name = Console.ReadLine()
                    };
                    AI.AllMyItems.Add(el);
                }
                else if (MyVal =="end")
                {
                    foreach (var my in MyList)
                    {
                        Console.WriteLine("-------------------------------------");
                        Console.WriteLine(my.Name);
                    }
                }
                else
                {
                    Console.WriteLine("Finnished..");
                }
            }


        }
    }



    public class Item
    {
        public string Name { get; set; }
    }


}
