using System;
using System.Media;
using System.Windows.Forms;

namespace DayKeeper
{
    public partial class Records : UserControl
    {
        Connection con = new Connection();
        StyleDataGrid grid = new StyleDataGrid();
        public Records()
        {
            InitializeComponent();
            loadRecords();
        }

        public void loadRecords()
        {
            con.LoadData("SELECT * FROM Records", data_records);
            data_records.Columns[0].Visible = false;
            grid.style(data_records);
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Delete Record?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    Home home = new Home();
                    int id = Convert.ToInt32(data_records.CurrentRow.Cells[0].Value.ToString()); // collect id from selected row
                    string queryDelete = "DELETE FROM Records WHERE Id = '" + id + "'";
                    con.ExecuteQuery(queryDelete);
                    string queryRecords = "SELECT * FROM Records";
                    home.LoadData(queryRecords, data_records);

                }
                catch (Exception)
                {
                    MessageBox.Show("Failed to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Btn_apply_Click(object sender, EventArgs e)
        {
            // declare variables for input data
            string date = date_input.Text;
            string mileage = txt_mileage.Text;
            string crew = txt_crew.Text;
            string fuel = txt_fuel.Text;
            string income = txt_income.Text;
            string notes = txt_notes.Text;
            // check if entry already exists
            string result = con.ReadString($"SELECT ID FROM Records where Date = '{date}'");
            if (!string.IsNullOrEmpty(result))
            {
                try
                {
                    con.ExecuteQuery($"UPDATE Records SET Mileage = '{mileage}', Crew = '{crew}', Fuel = '{fuel}', Income = '{income}', Notes = '{notes}' WHERE ID = '{result}'");
                    SoundPlayer save = new SoundPlayer(@"click.wav");
                    save.Play();
                    loadRecords();
                }
                catch (Exception)
                {
                    MessageBox.Show("Application error!", "Assistant", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    con.ExecuteQuery($"INSERT INTO Records (Date, Mileage, Crew, Fuel, Income, Notes) VALUES ('{date}', '{mileage}', '{crew}', '{fuel}', '{income}', '{notes}')");
                    SoundPlayer save = new SoundPlayer(@"click.wav");
                    save.Play();
                    loadRecords();
                }
                catch (Exception)
                {
                    MessageBox.Show("Application error!", "Assistant", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
