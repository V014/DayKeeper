using System;
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
                    Connection.ExecuteQuery(queryDelete);
                    string queryRecords = "SELECT * FROM Records";
                    home.LoadData(queryRecords, data_records);

                }
                catch (Exception)
                {
                    MessageBox.Show("Failed to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            Insert insert = new Insert();
            insert.Show();
        }

        private void Txt_mileage_Click(object sender, EventArgs e)
        {
            txt_mileage.Text = "";
        }
    }
}
