using Notes.Properties;
using System;
using System.IO;
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

namespace Notes
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            tB.Text = Settings.Default["TextInBox"].ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            tB.Text = "";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Settings.Default["TextInBox"] = tB.Text;
            Settings.Default.Save();
        }
    }
}
