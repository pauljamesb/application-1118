using System;
using System.Collections.Generic;

public class Program
{
	public static void Main()
	{
			AllItems AI = new AllItems();


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



public class AllItems
{
	public List<Item> AllMyItems = new List<Item>();
}

public class Item
{
	public string Name { get; set; }
}
