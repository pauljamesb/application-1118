using System;

namespace MMApp
{
    public static class Display
    {
        public static void DisplayItems()
        {
            Console.WriteLine("");
            Console.WriteLine("All Items:");
            Console.WriteLine("=============================================");
            Console.WriteLine("");
            foreach (var els in Store.allItems)
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
}