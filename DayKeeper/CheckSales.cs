using System;

namespace DayKeeper
{
    public class CheckSales
    {
        public string checkSales(string month, int year)
        {
            int cur_year = Convert.ToInt32(year);
            // check sales
            string checksales = "SELECT SUM(Sales) FROM Records WHERE Date LIKE '%" + month + "%' AND Date LIKE '%" + cur_year + "%'";
            string sales = Connection.ReadString(checksales);
            return sales;
        }
    }
}
