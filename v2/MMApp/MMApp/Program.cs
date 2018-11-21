using System;

namespace MMApp
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateItem.CreateNewItem();
            Display.DisplayItems();
            Display.DisplayItemsTotal();
        }
    }
}
