using System;
using System.IO;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Diagnostics.Eventing.Reader;

namespace WpfApp2 
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool _isResizing = false;
        private const double AspectRatio = 16.0 / 9.0;
        public MainWindow()
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
        Window1 w = new Window1();
        Admin admin = new Admin();
        private void Join_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Login.Text) ||
                string.IsNullOrWhiteSpace(Password.Text))
            {
                MessageBox.Show("Сначала введите данные (Логин и/или пароль)", "ОШИБКА", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (Login.Text == "Admin" && Password.Text == "Admin")
            {
                admin.Show();
                this.Close();
                w.Close();
                return;
            }
            if (Login.Text == "Admin" && Password.Text != "Admin")
            {
                    MessageBox.Show("Введите пароль для администратора");
                    w.Close();
                    this.Show();
                    Password.Clear();
                return;
            }
                    this.Close();
                    w.Show();
        }
    }
}