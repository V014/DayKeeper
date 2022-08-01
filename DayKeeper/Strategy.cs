using System;
using System.Windows.Forms;
using System.Media;
using System.Data.SQLite;
using System.Drawing;

namespace DayKeeper
{
    public partial class Strategy : UserControl
    {
        CheckSales checksales = new CheckSales();
        CheckLosses checklosses = new CheckLosses();
        // check current month and year
        private static int monthNumber = DateTime.Now.Month;
        private static int year = DateTime.Now.Year;
        string month = getMonth.currentMonth(monthNumber);
        public Strategy()
        {
            InitializeComponent();
            // when page loads. pull required data
            loadStrategy();
        }
        private int checkCashflow()
        {
            string sales = checksales.checkSales(month, year);
            string losses = checklosses.checklosses(month, year);
            int profit = Convert.ToInt32(sales) - Convert.ToInt32(losses);
            return profit;
        }
        // pulls data from the strategy table
        private void loadStrategy()
        {
            SQLiteConnection con = Connection.GetConnection();
            SQLiteCommand cmd = new SQLiteCommand("SELECT DailyTarget, MonthlyTarget, AnnualTarget, Investment, Offset, Date FROM Strategy WHERE id = 1", con);
            SQLiteDataReader reader = cmd.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    daily_txt.Text = reader.GetInt32(0).ToString();
                    monthly_txt.Text = reader.GetInt32(1).ToString();
                    annual_txt.Text = reader.GetInt32(2).ToString();
                    investment_txt.Text = reader.GetInt32(3).ToString();
                    offset_txt.Text = reader.GetInt32(4).ToString();
                    update_lbl.Text = reader.GetString(5);
                    // calculate profit
                    profit_txt.Text = checkCashflow().ToString();
                    // display progress on chart-----------------------------------
                    string sales = checksales.checkSales(month, year);
                    int progress = Convert.ToInt32(sales); 
                    chart_progress.Series[0].Points.Clear();
                    chart_progress.Series[0].Points.Add(Convert.ToInt32(progress));
                    chart_progress.Series[1].Points.Clear();
                    chart_progress.Series[1].Points.Add(reader.GetInt32(1));
                    // color the text according to the result
                    if (checkCashflow() > 0)
                    {
                        profit_txt.ForeColor = Color.PaleGreen;
                        
                    }
                    else
                    {
                        profit_txt.ForeColor = Color.IndianRed;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Failed to load strategy", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // deny strings in number fields
        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            int asciiCode = Convert.ToInt32(e.KeyChar);
            if ((asciiCode != 8))
            {
                if ((asciiCode >= 48 && asciiCode <= 57))
                {
                    e.Handled = false;
                }
                else
                {
                    MessageBox.Show("Numbers Only Please!", "Error: Number Only", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    e.Handled = true;
                }
            }
        }  
        private void save_btn_Click(object sender, EventArgs e)
        {
            string daily = daily_txt.Text;
            string monthly = monthly_txt.Text;
            string annual = annual_txt.Text;
            string investment = investment_txt.Text;
            string offset = offset_txt.Text;
            string profit = profit_txt.Text;
            string date = DateTime.Now.ToString("f");
            // update records
            string cmd = "UPDATE Strategy SET DailyTarget = '" + daily +"', MonthlyTarget = '" + monthly + "', AnnualTarget = '" + annual + "', Investment = '" + investment +"', Offset = '" + offset +"', Date = '" + date + "' WHERE id = 1";
            Connection.ExecuteQuery(cmd);
            SoundPlayer save = new SoundPlayer(@"click.wav");
            save.Play();
            save_btn.Text = "Saved!";
            // refresh fields
            loadStrategy();
        }
    }
}
