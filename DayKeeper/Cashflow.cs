using System;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Drawing;
using System.Media;

namespace DayKeeper
{
    public partial class Cashflow : UserControl
    {
        Home home = new Home();
        // check current month and year
        private static int monthNumber = DateTime.Now.Month;
        private static int year = DateTime.Now.Year;
        string month = getMonth.currentMonth(monthNumber);

        public Cashflow()
        {
            InitializeComponent();
            // call cashflow class
            CheckSales sales = new CheckSales();
            CheckLosses losses = new CheckLosses();
            // check cashflow on month
            SQLiteConnection con = Connection.GetConnection();
            SQLiteCommand cmd = new SQLiteCommand("SELECT CAST(Sales AS INT) FROM Records WHERE Date LIKE '%" + month + "%'", con);
            SQLiteDataReader profit = cmd.ExecuteReader();
            SQLiteCommand getExpenditure = new SQLiteCommand("SELECT CAST(Losses AS INT) FROM Records WHERE Date LIKE '%" + month + "%'", con);
            SQLiteDataReader expenditure = getExpenditure.ExecuteReader();
            try
            {
                chart1.Series[0].Points.Clear();
                while (profit.Read())
                {
                    chart1.Series[0].Points.Add(profit.GetInt32(0));
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Failed to load profits", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                chart2.Series[0].Points.Clear();
                while (expenditure.Read())
                {
                    chart2.Series[0].Points.Add(expenditure.GetInt32(0));
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Failed to load expenditure", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // check sales
            sales_txt.Text = sales.checkSales(month, year);
            string _sales = sales.checkSales(month, year);

            // check losses
            expenditure_txt.Text = losses.checklosses(month, year);
            string bills = losses.checklosses(month, year);

            if (_sales != "")
            {
                // check profit
                if (Convert.ToInt32(bills) >= Convert.ToInt32(_sales))
                {
                    int loss = Convert.ToInt32(bills) - Convert.ToInt32(_sales);
                    loss_txt.Text = loss.ToString();
                    loss_txt.ForeColor = Color.FromArgb(191, 42, 38);
                    sum_lbl.Text = "Loss";
                }
                else
                {
                    int loss = Convert.ToInt32(_sales) - Convert.ToInt32(bills);
                    loss_txt.Text = loss.ToString();
                    loss_txt.ForeColor = Color.FromArgb(46, 139, 87);
                    sum_lbl.Text = "Porfit";
                }
            }
            else
            {
                hint_lbl.Text = "Records from this month not available";
                hint_lbl.ForeColor = Color.Tomato;
            }
            
            // check breakdowns days
            breakdowns_txt.Text = checkBreakdowns(month, year);

            //check days worked
            daysworked_txt.Text = checkDaysworked(month, year);

            // check days off
            daysoff_txt.Text = checkDaysoff(month, year);
            
        }
        public string checkBreakdowns(string _month, int cur_year)
        {
            int _year = Convert.ToInt32(cur_year);
            // check breakdown
            string checkbreakdowns = "SELECT count(Crew) FROM Records WHERE Date LIKE '%" + _month + "%' AND Date LIKE '%" + _year + "%' AND Crew LIKE '%Breakdown%'";
            string breakdowns = Connection.ReadString(checkbreakdowns);
            return breakdowns;
        }
        public string checkDaysworked(string _month, int cur_year)
        {
            int _year = Convert.ToInt32(cur_year);
            // check days worked
            string checkdaysworked = "SELECT count(Sales) FROM Records WHERE Date LIKE '%" + _month + "%' AND Date LIKE '%" + _year + "%' AND Sales > 0";
            string daysworked = Connection.ReadString(checkdaysworked);
            return daysworked;
        }
        public string checkDaysoff(string _month, int cur_year)
        {
            int _year = Convert.ToInt32(cur_year);
            string checkdaysoff = "SELECT count(Crew) FROM Records WHERE Date LIKE '%" + _month + "%' AND Date LIKE '%" + _year + "%' AND Crew LIKE '%Off%'";
            string daysoff = Connection.ReadString(checkdaysoff);
            return daysoff;
        }
        private void month_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (month_cmb.Text != "Month" && year_cmb.Text != "Year")
            {
                // call cashflow class
                CheckSales sales = new CheckSales();
                CheckLosses losses = new CheckLosses();
                // check cashflow on month
                SQLiteConnection con = Connection.GetConnection();
                SQLiteCommand cmd = new SQLiteCommand("SELECT CAST(Sales AS INT) FROM Records WHERE Date LIKE '%" + month_cmb.Text + "%' AND Date LIKE '%" + year_cmb.Text + "%'", con);
                SQLiteDataReader reader = cmd.ExecuteReader();
                SQLiteCommand getExpenditure = new SQLiteCommand("SELECT CAST(Losses AS INT) FROM Records WHERE Date LIKE '% " + month_cmb.Text + " %' AND Date LIKE '%" + year_cmb.Text + "%'", con);
                SQLiteDataReader expenditure = getExpenditure.ExecuteReader();
                // sales try catch
                try
                {
                    chart1.Series[0].Points.Clear();
                    while (reader.Read())
                    {
                        chart1.Series[0].Points.Add(reader.GetInt32(0));
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Failed to load chart", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                // losses try catch
                try
                {
                    chart2.Series[0].Points.Clear();
                    while (expenditure.Read())
                    {
                        chart2.Series[0].Points.Add(expenditure.GetInt32(0));
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Failed to load chart 2", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                int yearSelected = Convert.ToInt32(year_cmb.Text);

                // check sales
                sales_txt.Text = sales.checkSales(month_cmb.Text, yearSelected);
                string _sales = sales.checkSales(month_cmb.Text, yearSelected);

                // check losses
                expenditure_txt.Text = losses.checklosses(month_cmb.Text, yearSelected);
                string bills = losses.checklosses(month_cmb.Text, yearSelected);

                // check profit
                try
                {
                    if (Convert.ToInt32(bills) >= Convert.ToInt32(_sales))
                    {
                        int loss = Convert.ToInt32(bills) - Convert.ToInt32(sales);
                        loss_txt.Text = loss.ToString();
                        loss_txt.ForeColor = Color.FromArgb(191, 42, 38);
                        sum_lbl.Text = "Loss";
                    }
                    else
                    {
                        int loss = Convert.ToInt32(_sales) - Convert.ToInt32(bills);
                        loss_txt.Text = loss.ToString();
                        loss_txt.ForeColor = Color.FromArgb(46, 139, 87);
                        sum_lbl.Text = "Porfit";
                    }
                }
                catch(Exception)
                {
                    SoundPlayer save = new SoundPlayer(@"error.wav");
                    save.Play();
                    MessageBox.Show("Too far ahead to calculate");
                }
                
                // check breakdowns days
                breakdowns_txt.Text = checkBreakdowns(month_cmb.Text, yearSelected);

                //check days worked
                daysworked_txt.Text = checkDaysworked(month_cmb.Text, yearSelected);

                // check days off
                daysoff_txt.Text = checkDaysoff(month_cmb.Text, yearSelected);
            }
            else
            {
                hint_lbl.Text = "Set both a month and year";
                hint_lbl.ForeColor = Color.PaleGreen;
            }
            
        }
    }
}
