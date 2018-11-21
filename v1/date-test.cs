// https://stackoverflow.com/questions/18375752/filter-large-list-based-on-date-time

using System;
using System.Collections.Generic;

public class Program
{
	public static void Main()
	{

      var myList = new List<Item>();

      var i1 = new Item();
      i1.Name = "Item 1";
      i1.Date = new DateTime(11,22,2018);

      var i2 = new Item();
      i2.Name = "Item 2";
      i2.Date = new DateTime(11,22,2016);

      var startDate = new DateTime(11,22,2015);
      var endDate = new DateTime(12,22,2015);

      myList.Add(i1);
      myList.Add(i2);

      if(startDate <= i1.Date)
        Console.WriteLine("Start date is less than my date i1");


	}
}

public class Item
{
    public string Name { get; set; }
    public DateTime Date { get; set; }
}
