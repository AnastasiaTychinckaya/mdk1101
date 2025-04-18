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
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        MySqlConnection conn1;
        public DataRowView rowView;
        public Window1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            conn1 = new MySqlConnection("server=127.0.0.1; uid=root; pwd=1234; database=cartoteka");
            conn1.Open();
            MySqlCommand command1 = new MySqlCommand($"INSERT INTO rozisk(ID, status, mestopologenie, data) VALUES('{ID.Text}', '{Status.Text}', '{Mestopologenie.Text}', '{Data.Text}', 0)", conn1);
            command1.ExecuteNonQuery();
            MessageBox.Show("Данные введены успешно");
            Roz window2 = new Roz();
            this.Close();
            window2.ShowDialog();


        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Roz window = new Roz();
            this.Close();
            window.ShowDialog();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ID.Text = rowView["ID"].ToString();
            Status.Text = rowView["status"].ToString();
            Mestopologenie.Text = rowView["mestopologenie"].ToString();
            Data.Text = rowView["data"].ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            conn1 = new MySqlConnection("server=127.0.0.1; uid=root; pwd=1234; database=cartoteka");
            conn1.Open();
            MySqlCommand command1 = new MySqlCommand($"UPDATE INTO rozisk(ID, status, mestopologenie, data) VALUES('{ID.Text}', '{Status.Text}', '{Mestopologenie.Text}', '{Data.Text}', 0)", conn1);
            command1.ExecuteNonQuery();
            MessageBox.Show("Данные введены успешно");
            Roz window2 = new Roz();
            this.Close();
            window2.ShowDialog();
        }
    }
}
