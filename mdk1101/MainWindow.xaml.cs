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
using System.Windows.Navigation;
using System.Windows.Shapes;
using MySqlConnector;
using System.Data;

namespace mdk1101
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MySqlConnection conn;
        public DataRowView DataRow;
        public DataRowView view;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            conn = new MySqlConnection("Server = 127.0.0.1; user id = root; password = 1234; database = cartoteka");
            conn.Open();
            MySqlCommand com = new MySqlCommand("SELECT * FROM cartoteka", conn);
            MySqlDataReader reader = com.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            cartoteka.ItemsSource = dt.DefaultView;
            conn.Close();



        }
    }
  
}
