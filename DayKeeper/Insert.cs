using System;
using System.Data.SQLite;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace DayKeeper
{
    public partial class Insert : Form
    {
        Connection con = new Connection();
        public Insert()
        {
            InitializeComponent();
        }
        // refresh page
        private void refresh()
        {
            lbl_title.Text = "Add Record";
            milin_txt.Text = "0";
            milout_txt.Text = "0";
            crew_txt.Text = "Fatsani";
            fuel_txt.Text = "0";
            sales_txt.Text = "0";
            losses_txt.Text = "0";
            notes_txt.Text = "";
            save_btn.Text = "Save";
            lbl_title.ForeColor = Color.PaleGreen;
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
        // recat to save button
        private void save_btn_Click(object sender, EventArgs e)
        {
            string date = insertDatePicker.Text;
            string queryEntry = "SELECT id FROM Records where Date = '" + date + "'";
            string result = con.ReadString(queryEntry);
            if (result != "")
            {
                try
                {
                    string queryInsert = "UPDATE Records SET MileageOld = '" + milout_txt.Text + "', MileageNew = '" + milin_txt.Text + "', Crew = '" + crew_txt.Text + "', Fuel = '" + fuel_txt.Text + "', Sales = '" + sales_txt.Text + "', Losses = '" + losses_txt.Text + "', Notes = '" + notes_txt.Text + "' WHERE id = '" + result + "'";
                    con.ExecuteQuery(queryInsert);
                    SoundPlayer save = new SoundPlayer(@"click.wav");
                    save.Play();
                    lbl_title.Text = "Record Updated!";
                    lbl_title.ForeColor = Color.FromArgb(0, 122, 204);
                    save_btn.Text = "Updated!";
                }
                catch (Exception)
                {
                    MessageBox.Show("Failed to update!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    string queryInsert = "INSERT INTO Records (Date, MileageOld, MileageNew, Crew, Fuel, Sales, Losses, Notes) VALUES ('" + date + "', '" + milin_txt.Text + "', '" + milout_txt.Text + "', '" + crew_txt.Text + "', '" + fuel_txt.Text + "', '" + sales_txt.Text + "', '" + losses_txt.Text + "', '" + notes_txt.Text + "')";
                    con.ExecuteQuery(queryInsert);
                    SoundPlayer save = new SoundPlayer(@"click.wav");
                    save.Play();
                    lbl_title.Text = "Record Saved!";
                    lbl_title.ForeColor = Color.FromArgb(134, 251, 135);
                    save_btn.Text = "Saved!";
                }
                catch (Exception)
                {
                    MessageBox.Show("Failed to record!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void refresh_btn_Click(object sender, EventArgs e)
        {
            refresh();
        }
        private void insertDatePicker_ValueChanged(object sender, EventArgs e)
        {
            refresh();
            string date = insertDatePicker.Text;
            SQLiteConnection con = Connection.GetConnection();
            SQLiteCommand cmd = new SQLiteCommand("SELECT MileageOld, MileageNew, Crew, Fuel, Sales, Losses, Notes FROM Records WHERE Date = '" + date + "'", con);
            SQLiteDataReader reader = cmd.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    milin_txt.Text = reader.GetInt32(0).ToString();
                    milout_txt.Text = reader.GetInt32(1).ToString();
                    crew_txt.Text = reader.GetString(2);
                    fuel_txt.Text = reader.GetInt32(3).ToString();
                    sales_txt.Text = reader.GetInt32(4).ToString();
                    losses_txt.Text = reader.GetInt32(5).ToString();
                    notes_txt.Text = reader.GetString(6);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Failed to load records", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
