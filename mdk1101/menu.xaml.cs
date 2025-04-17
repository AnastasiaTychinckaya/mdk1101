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

namespace mdk1101
{
    /// <summary>
    /// Логика взаимодействия для Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
       
        {
            MainWindow window = new MainWindow();
            this.Close();
            window.ShowDialog();

        }
        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            Prestupniki window = new Prestupniki();
            this.Close();
            window.ShowDialog();
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            Roz window = new Roz();
            this.Close();
            window.ShowDialog();
        }

    }
}
 
