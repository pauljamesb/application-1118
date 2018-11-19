using System;
using System.Collections.Generic;



public class Program
{
    public static void Main()
    {

        while(true)
        {
            CreateItem.CreateNewItem();

            if (Variables.inputItem.ToLower() == "end")
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



// Static classes
public static class Variables
{
    public static string inputItem { get; set; }
}


public static class Store
{
    public static List<Item> allItems = new List<Item>();
}


public static class CreateItem
{
    public static void CreateNewItem()
    {
        Console.WriteLine("Enter item: ");
        Variables.inputItem = Console.ReadLine();
        if(Variables.inputItem != "end")
        {
            var newItem = new Item();
            newItem.Name = Variables.inputItem;
            Store.allItems.Add(newItem);
        }
    }
}
