using System;


namespace MMApp
{
    public static class CreateItem
    {
        public static void CreateNewItem()
        {

            while (true)
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
}
