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
        Display.DisplayItems();

    }
}


public class Item
{
    public string Name { get; set; }
    public int Amount { get; set; }
}



// Static classes
public static class Variables
{
    public static string inputItem { get; set; }
    public static string inputAmount { get; set; }
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
        Console.WriteLine("Add amount: ");
Variables.inputAmount = Int32.Parse(Console.ReadLine());
        if(Variables.inputItem != "end")
        {
            var newItem = new Item();
            newItem.Name = Variables.inputItem;
            newItem.Amount = Variables.inputAmount;
            Store.allItems.Add(newItem);
        }
    }
}

public static class Display
{
    public static void DisplayItems()
    {
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

    public static void DisplayItemsTotal()
    {

    }
}

public static class Calculate
{

    public static int AddAllItems()
    {
        int total = 0;

        foreach(var els in Store.allItems)
        {
          total = total + els.Amount;
        }
        return total;
    }
}
