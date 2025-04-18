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
using System.Windows.Markup;

namespace mdk1101
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class Prestupniki : Window
    {
        MySqlConnection conn2;
        public DataRowView rowView;
        public DataRowView data;

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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window2 window = new Window2();
            this.Close();
            window.ShowDialog();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (prestup.SelectedIndex != -1)
            {
                data = prestup.SelectedItem as DataRowView;
                MySqlCommand command = new MySqlCommand($"DELETE FROM prestup WHERE id = '{data["id"].ToString()}'", conn2);
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
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM rozisk", conn2);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            prestup.ItemsSource = dt.DefaultView;

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (prestup.SelectedIndex != -1)
            {
                Window2 window = new Window2();
                window.rowView = prestup.SelectedItem as DataRowView;
                this.Close();
                window.ShowDialog();
            }
        }
    }
 }

