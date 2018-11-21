namespace MMApp
{
    public static class Calculate
    {

        public static int AddAllItems()
        {
            int total = 0;

            foreach (var els in Store.allItems)
            {
                total = total + els.Amount;
            }
            return total;
        }


    }
}