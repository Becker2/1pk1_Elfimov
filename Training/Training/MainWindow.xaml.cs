using System.Text;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
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

namespace Training
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
        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            foreach (char c in e.Text)
            {
                if (!char.IsDigit(c))
                {
                    e.Handled = true;
                    return;
                }
            }
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Exam.Text) ||
                string.IsNullOrWhiteSpace(Student.Text) ||
                string.IsNullOrWhiteSpace(Rate.Text))
            {
                MessageBox.Show("Не все данные введены", "Ошбика", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            } 

            string info = $"{Student.Text} - {Rate.Text}";

            inf.Items.Add(info);

            Student.Clear();
            Rate.Clear();
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            inf.Items.Remove(inf.SelectedItems);
        }

        private void Export_Click(object sender, RoutedEventArgs e)
        {
            if (inf.Items.Count == 0)
            {
                MessageBox.Show("Данных нет", "Ошибка", MessageBoxButton.OK);
            }

            var dialog = new SaveFileDialog() { FileName = "Rating.text" };

            if (dialog.ShowDialog() == true)
            {
                File.WriteAllLines(dialog.FileName, inf.Items.Cast<object>().Select(item => item.ToString()));
                MessageBox.Show("Экспорт завершен");
            }
        }

        private void Import_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                string[] lines = File.ReadAllLines(openFileDialog.FileName);
                for (int i = 0; i < lines.Length; i++)
                {
                    inf.Items.Add((string)lines[i]);
                }
            }
        }

        private void Window_Close(object sender, RoutedEventArgs e)
        {
            File.WriteAllText("save.json", JsonSerializer.Serialize(inf.Items));
        }
    }
}