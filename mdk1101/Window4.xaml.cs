using System;
using System.Collections.Generic;
using System.Data;
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
using MySqlConnector;

namespace mdk1101
{
    /// <summary>
    /// Логика взаимодействия для Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {
        MySqlConnection conn;
        public DataRowView rowView;
        public Window4()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            conn = new MySqlConnection("server=127.0.0.1; uid=root; pwd=1234; database=cartoteka");
            conn.Open();
            MySqlCommand command1 = new MySqlCommand($"UPDATE INTO rozisk(ID, name, surname, age) VALUES('{ID.Text}', '{Name.Text}', '{Surname.Text}', '{Age.Text}', 0)", conn);
            command1.ExecuteNonQuery();
            MessageBox.Show("Данные введены успешно");
            MainWindow window2 = new MainWindow();
            this.Close();
            window2.ShowDialog();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            conn = new MySqlConnection("server=127.0.0.1; uid=root; pwd=1234; database=cartoteka");
            conn.Open();
            MySqlCommand command1 = new MySqlCommand($"INSERT INTO rozisk(ID, name, surname, age) VALUES('{ID.Text}', '{Name.Text}', '{Surname.Text}', '{Age.Text}', 0)", conn);
            command1.ExecuteNonQuery();
            MessageBox.Show("Данные введены успешно");
            MainWindow window2 = new MainWindow();
            this.Close();
            window2.ShowDialog();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            this.Close();
            window.ShowDialog();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ID.Text = rowView["ID"].ToString();
            Name.Text = rowView["name"].ToString();
            Surname.Text = rowView["surname"].ToString();
            Age.Text = rowView["age"].ToString();
        }
    }
}
