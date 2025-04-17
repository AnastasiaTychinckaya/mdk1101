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
using MySqlConnector;
using System.Data;

namespace mdk1101
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class Roz : Window
    {
        MySqlConnection conn1;


        public Roz()
        {
            InitializeComponent();
        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            conn1 = new MySqlConnection("Server = 127.0.0.1; user id = root; password = 1234; database = cartoteka");
            conn1.Open();
            MySqlCommand com = new MySqlCommand("SELECT * FROM rozisk", conn1);
            MySqlDataReader reader = com.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            rozisk.ItemsSource = dt.DefaultView;
            conn1.Close();



        }
    }

}