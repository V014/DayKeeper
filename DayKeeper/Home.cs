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
        public Home()
        {
            InitializeComponent();
            loadHome();
            string date = DateTime.Now.ToString("f");
            Connection.ExecuteQuery("UPDATE Session SET Date = '" + date + "' WHERE id = 1");
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
        //loads data into a data grid
        public void LoadData(string query, DataGridView dataGrid)
        {
            var con = Connection.GetConnection();
            var DB = new SQLiteDataAdapter(query, con);
            var DS = new DataSet();
            var DT = new DataTable();
            DB.Fill(DS);
            DT = DS.Tables[0];
            dataGrid.DataSource = DT;
            con.Close();
        }
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
        // styling of the datagrid
        void styleDarkDataGridView(DataGridView dataGrid)
        {
            dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGrid.BorderStyle = BorderStyle.None;
            dataGrid.EnableHeadersVisualStyles = false;
            dataGrid.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGrid.RowHeadersWidth = 30;

            dataGrid.BackgroundColor = Color.FromArgb(37, 37, 39);
            dataGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(34, 34, 34);
            dataGrid.AlternatingRowsDefaultCellStyle.ForeColor = Color.White;

            dataGrid.RowsDefaultCellStyle.BackColor = Color.FromArgb(34, 34, 34);
            dataGrid.RowsDefaultCellStyle.ForeColor = Color.White;
            dataGrid.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(34, 34, 34);

            dataGrid.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(34, 34, 34);
            dataGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dataGrid.DefaultCellStyle.Font = new Font("Roboto", 9);
            dataGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Roboto", 9);
            dataGrid.AlternatingRowsDefaultCellStyle.Font = new Font("Roboto", 9);

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
