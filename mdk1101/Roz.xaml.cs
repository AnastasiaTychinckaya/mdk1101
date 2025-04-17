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
    public partial class Roz : Window
    {
        MySqlConnection conn1;
        public DataRowView rowView;
        public DataRowView data;



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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (rozisk.SelectedIndex != -1)
            {
                data = rozisk.SelectedItem as DataRowView;
                MySqlCommand command = new MySqlCommand($"DELETE FROM rozisk WHERE id = '{data["id"].ToString()}'", conn1);
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
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM rozisk", conn1);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            rozisk.ItemsSource = dt.DefaultView;

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window1 window = new Window1();
            this.Close();
            window.ShowDialog();


        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (rozisk.SelectedIndex != -1)
            {
                Window1 window = new Window1();
                window.rowView = rozisk.SelectedItem as DataRowView;
                this.Close();
                window.ShowDialog();
            }

        }
    }


}