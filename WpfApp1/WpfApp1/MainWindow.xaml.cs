using System.Text;
using System.Text.Json;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Win32;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {

            OpenFolderDialog openFolderDialog = new OpenFolderDialog();
            if (openFolderDialog.ShowDialog() ==  true)
            {
                DirectoryInfo f = new DirectoryInfo(openFolderDialog.FolderName);
                FileInfo[] files = f.GetFiles();

                for (int i = 0; i < files.Length; i++)
                {
                    string line = $"{files[i].Length} {files[i].LastWriteTime}";
                    Data.Items.Add(line);
                }
            }
        }

        private void Hours_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Hours.Text.Length > 2)
            {
                MessageBox.Show("Некорректное значение", "Ошибка");
                Hours.Clear();
                return;

            }
            int number;
            if (int.TryParse(Hours.Text, out number))
            {
                if (number > 12)
                {
                    MessageBox.Show("Ошибка: число не должно быть больше 12", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    Hours.Clear();
                    return;
                }
            }
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            Data.Items.Remove(Data.SelectedItem);
        }

        private void Window_Closing(object sender, RoutedEventArgs e)
        {
            File.WriteAllText("save.json", JsonSerializer.Serialize(Data.Items));
        }

        private void Export_Click(object sender, RoutedEventArgs e)
        {
            if (Data.Items.Count == 0)
            {
                MessageBox.Show("Сначала введите данные", "Ошибка", MessageBoxButton.OK);
                return;
            }

            var dialog = new SaveFileDialog { FileName = "data.txt" };

            if (dialog.ShowDialog() == true)
            {
                File.WriteAllLines(dialog.FileName, Data.Items.Cast<object>().Select(item => item.ToString()));
                MessageBox.Show("Экспорт завершен!", "Успешно", MessageBoxButton.OK);
            }
        }

        private void Day_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            string input = textBox.Text;

            if (!string.IsNullOrEmpty(input) && !input.All(char.IsDigit))
            {
                MessageBox.Show("Можно вводить только цифры", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);

                string digitsOnly = new string(input.Where(char.IsDigit).ToArray());
                textBox.Text = digitsOnly;

                textBox.CaretIndex = digitsOnly.Length;
            }
        }

        private void Import_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                var f = new DirectoryInfo(openFileDialog.FileName);
                string[] lines = File.ReadAllLines(openFileDialog.FileName);
                for (int i = 0; i < lines.Length; i++)
                {
                    Data.Items.Add(lines[i]);
                }
            }
        }

        private void d_Click(object sender, RoutedEventArgs e)
        {
        }
    }
}