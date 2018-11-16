using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        List<Item> AllItems = new List<Item>();


        while (true)
        {
            Console.Write("Enter a item (or 'end' to exit): ");
            var itemInput = Console.ReadLine();
            Item MyItem = new Item();
            MyItem.Name = itemInput;

            if (itemInput.ToLower() == "end")
            break;
        }


    }
}


public class Item
{
    public String Name { get; set; }
}
