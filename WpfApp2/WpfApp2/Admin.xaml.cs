using System;
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
    /// Логика взаимодействия для Admin.xaml
    /// </summary>
    public partial class Admin : Window
    {
        private bool _isResizing = false;
        private const double AspectRatio = 16.0 / 9.0;
        public Admin()
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
        private void Back_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow m = new MainWindow();
            m.Show();
        }
    }
}
