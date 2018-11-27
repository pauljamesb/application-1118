public async Task<IActionResult> Met(DateTime start, DateTime end)
{
  var myRes = _db.Items.Where(x => Items.date >= start && Items.date <= end ).ToList();
  return View(myRes); 
}












































// https://docs.microsoft.com/en-us/dotnet/api/system.datetime.maxvalue?view=netframework-4.7.2

//Grab the highest value using the Max() method
int max = db.Products.Max(p => p.ID);
