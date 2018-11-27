using System;
using System.Collections.Generic;
using System.Linq;





























public class Program
{
	public static void Main()
	{
		List<Item> myItems = new List<Item>();

		var i1 = new Item();
		i1.Id = 1;
		i1.Name = "Item 1";
		i1.Rec = "Rec";
		i1.Date = new DateTime(2017, 11, 05);
		myItems.Add(i1);

		var i2 = new Item();
		i2.Id = 2;
		i2.Name = "Item 2";
		i2.Rec = "No";
		i2.Date = new DateTime(2018, 06, 22);
		myItems.Add(i2);









		var myVal = myItems.Where(x => x.Name == "Item 1");
		var v = myVal.ToArray()[0];

		Console.WriteLine(v.Name);


































































	}
}












public class Item
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Rec { get; set; }
    public DateTime Date { get; set; }
}
