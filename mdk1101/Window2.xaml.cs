using System.Data;
using System.Windows;
using MySqlConnector;

namespace mdk1101
{
    /// <summary>
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        MySqlConnection conn2;
        public DataRowView rowView;
        public Window2()
        {
            InitializeComponent();
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            conn2 = new MySqlConnection("server=127.0.0.1; uid=root; pwd=1234; database=cartoteka");
            conn2.Open();
            MySqlCommand command1 = new MySqlCommand($"INSERT INTO rozisk(ID, name, surname, opisanie) VALUES('{ID.Text}', '{Name.Text}', '{Surname.Text}', '{Opisanie.Text}', 0)", conn2);
            command1.ExecuteNonQuery();
            MessageBox.Show("Данные введены успешно");
            Prestupniki window2 = new Prestupniki();
            this.Close();
            window2.ShowDialog();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Prestupniki window = new Prestupniki();
            this.Close();
            window.ShowDialog();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            conn2 = new MySqlConnection("server=127.0.0.1; uid=root; pwd=1234; database=cartoteka");
            conn2.Open();
            MySqlCommand command1 = new MySqlCommand($"UPDATE INTO rozisk(ID, name, surname, opisanie) VALUES('{ID.Text}', '{Name.Text}', '{Surname.Text}', '{Opisanie.Text}', 0)", conn2);
            command1.ExecuteNonQuery();
            MessageBox.Show("Данные введены успешно");
            Prestupniki window2 = new Prestupniki();
            this.Close();
            window2.ShowDialog();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ID.Text = rowView["ID"].ToString();
            Name.Text = rowView["name"].ToString();
            Surname.Text = rowView["surname"].ToString();
            Opisanie.Text = rowView["opisanie"].ToString();
        }
    }

}
