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
            AllItems.Add(MyItem);

            if (itemInput.ToLower() == "end")
            break;
        }
        foreach(var el in AllItems)
        {
            Console.WriteLine(el.Name);
        }


    }
}


public class Item
{
    public String Name { get; set; }
}
