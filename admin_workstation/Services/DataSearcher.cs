using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace admin_workstation.Services
{
    public class DataSearcher
    {
        private readonly DataGridView dataGridView;
        private readonly TextBox searchTextBox;
        private DataTable? originalDataTable;

        public DataSearcher(DataGridView dgv, TextBox searchBox)
        {
            if (dgv == null) throw new ArgumentNullException(nameof(dgv));
            if (searchBox == null) throw new ArgumentNullException(nameof(searchBox));

            dataGridView = dgv;
            searchTextBox = searchBox;

            if (dataGridView.DataSource is DataTable sourceTable)
            {
                originalDataTable = sourceTable.Copy();
            }

            searchTextBox.TextChanged += SearchTextBox_TextChanged;
        }

        private void SearchTextBox_TextChanged(object? sender, EventArgs e)
        {
            if (originalDataTable == null) return;

            string searchText = searchTextBox.Text.ToLower().Trim();

            if (string.IsNullOrEmpty(searchText))
            {
                // Reset to original data if search box is empty
                dataGridView.DataSource = originalDataTable;
                return;
            }

            // Create a new DataTable with the same structure
            DataTable filteredTable = originalDataTable.Clone();

            foreach (DataRow row in originalDataTable.Rows)
            {
                bool matchFound = false;

                // Search through all columns
                foreach (DataColumn col in originalDataTable.Columns)
                {
                    string? cellValue = row[col]?.ToString();
                    if (cellValue != null && cellValue.ToLower().Contains(searchText))
                    {
                        matchFound = true;
                        break;
                    }
                }

                if (matchFound)
                {
                    filteredTable.ImportRow(row);
                }
            }

            dataGridView.DataSource = filteredTable;
        }

        // Method to update the original data
        public void UpdateOriginalData()
        {
            if (dataGridView.DataSource is DataTable sourceTable)
            {
                originalDataTable = sourceTable.Copy();
            }
        }
    }
}
