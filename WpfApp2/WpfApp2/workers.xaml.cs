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
    /// Логика взаимодействия для workers.xaml
    /// </summary>
    public partial class workers : Window
    {
        public workers()
        {
            InitializeComponent();
        }

        private void ReceptionAddButton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ReceptionAdd.Text))
            {
                MessageBox.Show("Введите Имя и Фамилию работника", "Ошибка", MessageBoxButton.OK);
                return;
            }

            Reception.Items.Add(ReceptionAdd.Text);

            ReceptionAdd.Clear();
        }

        private void TherapistAddButton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TherapistAdd.Text))
            {
                MessageBox.Show("Введите Имя и Фамилию работника", "Ошибка", MessageBoxButton.OK);
                return;
            }

            Therapist.Items.Add(TherapistAdd.Text);

            TherapistAdd.Clear();
        }

        private void CardioAddButton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(CardioAdd.Text))
            {
                MessageBox.Show("Введите Имя и Фамилию работника", "Ошибка", MessageBoxButton.OK);
                return;
            }

            Cardio.Items.Add(CardioAdd.Text);

            CardioAdd.Clear();
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            Reception.Items.Remove(Reception.SelectedItem);
            Therapist.Items.Remove(Therapist.SelectedItem);
            Cardio.Items.Remove(Cardio.SelectedItem);

        }
    }
}

