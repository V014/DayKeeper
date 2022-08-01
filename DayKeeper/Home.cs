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
            string cmd = "UPDATE Session SET Date = '" + date + "' WHERE id = 1";
            Connection.ExecuteQuery(cmd);
            lbl_lastentry.Text = date;
            // SoundPlayer load = new SoundPlayer(@"tap.wav");
            // load.Play();
        }
        void loadHome()
        {
            this.mainPanel.Controls.Clear();
            Welcome welcome = new Welcome();
            this.mainPanel.Controls.Add(welcome);
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
            this.mainPanel.Controls.Clear();
            Records records = new Records();
            this.mainPanel.Controls.Add(records);
            records.Dock = DockStyle.Fill;
            records.Show();
            string queryRecords = "SELECT * FROM Records";
            LoadData(queryRecords, records.dataGrid);
            records.dataGrid.Columns[0].Visible = false;
            styleDarkDataGridView(records.dataGrid);
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
            this.mainPanel.Controls.Clear();
            Cashflow chart = new Cashflow();
            chart.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(chart);
            chart.Show();
        }
        private void strategy_btn_Click(object sender, EventArgs e)
        {
            this.mainPanel.Controls.Clear();
            Strategy strategy = new Strategy();
            strategy.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(strategy);
            strategy.Show();
        }
 
        private void Home_SizeChanged(object sender, EventArgs e)
        {
            if (this.Width < 900)
            {
                panel_nav.Width = 40;
                // menu
                btn_menu.Width = 35;
                btn_menu.Text = "";
                // home
                btn_home.Width = 35;
                btn_home.Text = "";
                // records
                btn_records.Width = 35;
                btn_records.Text = "";
                // cashflow
                btn_cashflow.Width = 35;
                btn_cashflow.Text = "";
                // strategy
                btn_strategy.Width = 35;
                btn_strategy.Text = "";
                // panel
                panel_user.Hide();
                btn_manager.Show();
            }
            else
            {
                panel_nav.Width = 200;
                // menu
                btn_menu.Width = 200;
                btn_menu.Text = "Menu";
                // home
                btn_home.Width = 200;
                btn_home.Text = "Home";
                // records
                btn_records.Width = 200;
                btn_records.Text = "Records";
                // cashflow
                btn_cashflow.Width = 200;
                btn_cashflow.Text = "Cashflow";
                // strategy
                btn_strategy.Width = 200;
                btn_strategy.Text = "Strategy";
                // panel
                panel_user.Show();
                btn_manager.Hide();
            }
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            if (panel_nav.Width == 200)
            {
                panel_nav.Width = 40;
                // menu
                btn_menu.Width = 35;
                btn_menu.Text = "";
                // home
                btn_home.Width = 35;
                btn_home.Text = "";
                // records
                btn_records.Width = 35;
                btn_records.Text = "";
                // cashflow
                btn_cashflow.Width = 35;
                btn_cashflow.Text = "";
                // strategy
                btn_strategy.Width = 35;
                btn_strategy.Text = "";
                // panel
                panel_user.Hide();
                btn_manager.Width = 35;
                btn_manager.Text = "";
                btn_manager.Show();
            }
            else
            {
                panel_nav.Width = 200;
                // menu
                btn_menu.Width = 200;
                btn_menu.Text = "Menu";
                // home
                btn_home.Width = 200;
                btn_home.Text = "Home";
                // records
                btn_records.Width = 200;
                btn_records.Text = "Records";
                // cashflow
                btn_cashflow.Width = 200;
                btn_cashflow.Text = "Cashflow";
                // strategy
                btn_strategy.Width = 200;
                btn_strategy.Text = "Strategy";
                // panel
                panel_user.Show();
                btn_manager.Hide();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
