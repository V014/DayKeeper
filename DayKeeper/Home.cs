using System;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data;
using System.Drawing;
using System.Media;

namespace DayKeeper
{
    public partial class Home : Form
    {
        // program starts, when the first windows (Home) loads,
        // it updates the session date to current (month/day/year - 1/1/2022) format
        Connection con = new Connection();
        public Home()
        {
            InitializeComponent();
            loadHome();
            string date = DateTime.Now.ToString("f");
            con.ExecuteQuery($"UPDATE Session SET Date = '{date}' WHERE id = 1");
        }
        void loadHome()
        {
            this.panel_main.Controls.Clear();
            Welcome welcome = new Welcome();
            this.panel_main.Controls.Add(welcome);
            welcome.Dock = DockStyle.Fill;
            welcome.AutoSize = true;
            welcome.Show();
        }
        // calls homepage
        private void home_btn_Click(object sender, EventArgs e)
        {
            loadHome();
        }
        // call user control on click
        private void records_btn_Click(object sender, EventArgs e)
        {
            this.panel_main.Controls.Clear();
            Records records = new Records();
            this.panel_main.Controls.Add(records);
            records.Dock = DockStyle.Fill;
            records.Show();
        }
        public void cashflow_btn_Click(object sender, EventArgs e)
        {
            this.panel_main.Controls.Clear();
            Cashflow chart = new Cashflow();
            chart.Dock = DockStyle.Fill;
            this.panel_main.Controls.Add(chart);
            chart.Show();
        }
        private void strategy_btn_Click(object sender, EventArgs e)
        {
            this.panel_main.Controls.Clear();
            Strategy strategy = new Strategy();
            strategy.Dock = DockStyle.Fill;
            this.panel_main.Controls.Add(strategy);
            strategy.Show();
        }
    }
}
