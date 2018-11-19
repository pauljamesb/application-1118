using System;
using System.Collections.Generic;


public class Program
{
    public static void Main()
    {

        while(true)
        {
            Console.WriteLine("Enter item: ");
            var inputItem = Console.ReadLine();
            var newItem = new Item();
            newItem.Name = inputItem;
            Store.allItems.Add(newItem);

            if (inputItem.ToLower() == "end")
				break;
        }

    		Console.WriteLine("");
    		Console.WriteLine("All Items:");
    		Console.WriteLine("=============================================");
    		Console.WriteLine("");
        foreach(var els in Store.allItems)
        {
            Console.WriteLine(els.Name);
            Console.WriteLine("---------------------------------------------");
        }

    }
}


public class Item
{
    public String Name { get; set; }
}

public static class Store
{
    public static List<Item> allItems = new List<Item>();
}
