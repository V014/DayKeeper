using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace DayKeeper
{
    public partial class Welcome : UserControl
    {
        // check current month and year
        private static int monthNumber = DateTime.Now.Month;
        private static int year = DateTime.Now.Year;
        string month = getMonth.currentMonth(monthNumber);

        // call cashflow class
        CheckSales sales = new CheckSales();
        CheckLosses losses = new CheckLosses();

        public Welcome()
        {
            InitializeComponent();
            
        }
    }
}
