using System.Drawing;
using System.Windows.Forms;

namespace DayKeeper
{
    class StyleDataGrid
    {
        // styling of the datagrid
        public void style(DataGridView dataGrid)
        {
            //dataGrid.BorderStyle = BorderStyle.None;
            dataGrid.EnableHeadersVisualStyles = false;
            dataGrid.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGrid.RowHeadersVisible = false;
            dataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //dataGrid.BackgroundColor = Color.FromArgb(17, 17, 17);
            dataGrid.RowsDefaultCellStyle.BackColor = Color.FromArgb(17, 17, 17);
            dataGrid.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(17, 17, 17);
            dataGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(17,17,17);
            dataGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(17, 17, 17);

            dataGrid.RowsDefaultCellStyle.ForeColor = Color.White;
            dataGrid.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGrid.AlternatingRowsDefaultCellStyle.ForeColor = Color.White;

            dataGrid.ColumnHeadersHeight = 30;
            
            dataGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Roboto", 11);
            dataGrid.DefaultCellStyle.Font = new Font("Roboto", 8);
            dataGrid.AlternatingRowsDefaultCellStyle.Font = new Font("Roboto", 8);

        }
    }
}
