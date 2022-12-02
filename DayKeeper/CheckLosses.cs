using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayKeeper
{
    class CheckLosses
    {
        Connection con = new Connection();
        public string checklosses(string _month, int cur_year)
        {
            int _year = Convert.ToInt32(cur_year);
            // check losses
            string checkloss = "SELECT SUM(Losses) FROM Records WHERE Date LIKE '%" + _month + "%' AND Date LIKE '%" + _year + "%'";
            string bills = con.ReadString(checkloss);
            return bills;
        }
    }
}
