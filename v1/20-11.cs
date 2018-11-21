using System;
using System.Collections.Generic;



public class Program
{
    public static void Main()
    {
        CreateItem.CreateNewItem();
        Display.DisplayItems();
        Display.DisplayItemsTotal()
    }
}


public class Item
{
    public string Name { get; set; }
    public string Cat { get; set; }
    public int Amount { get; set; }
    public DateTime Date { get; set; }
}



// Static classes
public static class Variables
{
    public static string inputItem { get; set; }
    public static string inputCat { get; set; }
    public static int inputAmount { get; set; }
    public static DateTime inputDate { get; set; }
}


public static class Store
{
    public static List<Item> allItems = new List<Item>();
}


public static class CreateItem
{
    public static void CreateNewItem()
    {

        while(true)
        {

            Console.WriteLine("Enter category (cat1, cat2, cat3): ");
            Variables.inputCat = Console.ReadLine();

            if (Variables.inputCat.ToLower() == "end")
                break;

            Console.WriteLine("Enter item: ");
            Variables.inputItem = Console.ReadLine();
            Console.WriteLine("Enter date (MM/DD/YYYY): ");
            Variables.inputDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Add amount: ");
            Variables.inputAmount = Convert.ToInt32(Console.ReadLine());
            var newItem = new Item();
            newItem.Name = Variables.inputItem;
            newItem.Cat = Variables.inputCat;
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
            Console.Write(els.Cat);
            Console.Write(", ");
            Console.Write(els.Name);
            Console.Write(", ");
            Console.Write(els.Date);
            Console.Write(", ");
            Console.WriteLine(els.Amount);
            Console.WriteLine("---------------------------------------------");
        }
    }

    public static void DisplayItemsTotal()
    {
        Console.WriteLine("");
        Console.WriteLine("                           ==================");
        Console.Write("Total: ");
        Console.Write(Calculate.AddAllItems());
        Console.WriteLine("                           ------------------");
        Console.WriteLine("");
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
