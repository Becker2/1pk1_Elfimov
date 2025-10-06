using System;
using System.IO;
using Microsoft.Win32;
using System.Text.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        private bool _isResizing = false;
        private const double AspectRatio = 16.0 / 9.0;
        public Window1()
        {
            InitializeComponent();
        }
        protected override void OnRenderSizeChanged(SizeChangedInfo sizeInfo)
        {
            if (_isResizing) return;

            _isResizing = true;

            if (sizeInfo.WidthChanged)
            {
                this.Height = sizeInfo.NewSize.Width / AspectRatio;
            }
            else if (sizeInfo.HeightChanged)
            {
                this.Width = sizeInfo.NewSize.Height * AspectRatio;
            }

            _isResizing = false;
            base.OnRenderSizeChanged(sizeInfo);
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            Data.Items.Remove(Data.SelectedItem);
        }

        private void Export_Click(object sender, RoutedEventArgs e)
        {
            if (Data.Items.Count == 0)
            {
                MessageBox.Show("Не все данные введены");
                return;
            }

            var dialog = new SaveFileDialog { FileName = "Patients.txt" };

            if (dialog.ShowDialog() == true)
            {
                File.WriteAllLines(dialog.FileName, Data.Items.Cast<object>()
                .Select(item => item.ToString()));
                MessageBox.Show("Экспорт завершен!!");
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
                    Data.Items.Add(lines[i]);
                }
            }
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(inf.Text))
            {
                MessageBox.Show("Введите данные пациента", "Ошибка", MessageBoxButton.OK);
            }

            Data.Items.Add(inf.Text);

            inf.Clear(); 
        }
    }
}