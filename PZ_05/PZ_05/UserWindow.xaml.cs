using System.Collections.Generic;
using System.Windows;

namespace TableBookingSystem
{
    public partial class UserWindow : Window
    {
        private List<Table> tables;

        public UserWindow()
        {
            LoadTables();
        }

        private void LoadTables()
        {
            tables = TableStorage.GetTables();
            foreach (var table in tables)
            {
                if (!table.IsBooked)
                    AvailableTablesList.Items.Add($"Столик #{table.Id}");
            }
        }

        private void BookTable_Click(object sender, RoutedEventArgs e)
        {
            if (AvailableTablesList.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите столик.");
                return;
            }

            string selected = (string)AvailableTablesList.SelectedItem;
            int id = int.Parse(selected.Replace("Столик #", ""));
            string time = BookingTimeTextBox.Text;

            var table = tables.Find(t => t.Id == id);
            table.IsBooked = true;
            table.BookingTime = time;

            MessageBox.Show($"Столик #{id} забронирован на {time}");
            LoadTables();
        }
    }
}