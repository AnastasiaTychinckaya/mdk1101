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
    public partial class Prestupniki : Window
    {
        MySqlConnection conn2;

        public Prestupniki()
        {
            InitializeComponent();
        }

        private void prestupniki_Loaded(object sender, RoutedEventArgs e)
        {
            conn2 = new MySqlConnection("Server = 127.0.0.1; user id = root; password = 1234; database = cartoteka");
            conn2.Open();
            MySqlCommand com = new MySqlCommand("SELECT * FROM prestupniki", conn2);
            MySqlDataReader reader = com.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            prestup.ItemsSource = dt.DefaultView;
            conn2.Close();



        }
    }

}