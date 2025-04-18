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
using System.Windows.Markup;

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
        public DataRowView rowView;
        public DataRowView data;
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window4 window = new Window4();
            this.Close();
            window.ShowDialog();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (cartoteka.SelectedIndex != -1)
            {
                data = cartoteka.SelectedItem as DataRowView;
                MySqlCommand command = new MySqlCommand($"DELETE FROM prestup WHERE id = '{data["id"].ToString()}'", conn);
                command.ExecuteNonQuery();
                UpdateGrid();
            }
            else
            {
                MessageBox.Show("Выбирите нужную специальность!");
            }

        }
        public void UpdateGrid()
        {
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM rozisk", conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            cartoteka.ItemsSource = dt.DefaultView;

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (cartoteka.SelectedIndex != -1)
            {
                Window4 window = new Window4();
                window.rowView = cartoteka.SelectedItem as DataRowView;
                this.Close();
                window.ShowDialog();
            }
        }
    }
    }
  
}
