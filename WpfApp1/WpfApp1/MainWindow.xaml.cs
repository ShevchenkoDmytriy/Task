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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int n = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void But1_Click(object sender, RoutedEventArgs e)
        {
            But1.Visibility= Visibility.Hidden;
            But2.Visibility= Visibility.Hidden;
            But3.Visibility = Visibility.Visible;
            Lab1.Visibility = Visibility.Visible;
            Lab4.Visibility = Visibility.Visible;
            Lab5.Visibility = Visibility.Visible;
            Lab6.Visibility = Visibility.Visible;
            But4.Visibility = Visibility.Visible;
        }

        private void But3_Click(object sender, RoutedEventArgs e)
        {
            But1.Visibility = Visibility.Visible;
            But2.Visibility = Visibility.Visible;
            But3.Visibility = Visibility.Hidden;
            Lab1.Visibility = Visibility.Hidden;
            Lab4.Visibility = Visibility.Hidden;
            Lab5.Visibility = Visibility.Hidden;
            Lab6.Visibility = Visibility.Hidden;
            But4.Visibility = Visibility.Hidden;
            But6.Visibility = Visibility.Hidden;
            Lab2.Visibility = Visibility.Hidden;
            Lab3.Visibility = Visibility.Hidden;
            Lab10.Visibility = Visibility.Hidden;
            Lab11.Visibility = Visibility.Hidden;
            Lab12.Visibility = Visibility.Hidden;
            But7.Visibility = Visibility.Hidden;
            Lab7.Visibility = Visibility.Hidden;
            Lab9.Visibility = Visibility.Hidden;
        }

        private void But2_Click(object sender, RoutedEventArgs e)
        {
            But1.Visibility = Visibility.Hidden;
            But2.Visibility = Visibility.Hidden;
            But3.Visibility = Visibility.Visible;
            Lab10.Visibility = Visibility.Visible;
            Lab11.Visibility = Visibility.Visible;
            Lab12.Visibility = Visibility.Visible;
            if(n==1) 
            {
                Lab7.Visibility = Visibility.Visible;
                But7.Visibility = Visibility.Visible;
            }
            
        }

        private void But4_Click(object sender, RoutedEventArgs e)
        {
            But4.Visibility = Visibility.Hidden;
            But6.Visibility = Visibility.Visible;
            Lab2.Visibility = Visibility.Visible;
            Lab1.Visibility = Visibility.Hidden;
        }

        private void But6_Click(object sender, RoutedEventArgs e)
        {
            But6.Visibility = Visibility.Hidden;
            Lab3.Visibility = Visibility.Visible;
            Lab2.Visibility = Visibility.Hidden;
            n = 1;
        }

        private void But7_Click(object sender, RoutedEventArgs e)
        {
            Lab7.Visibility = Visibility.Hidden;
            But8.Visibility = Visibility.Visible;
            Lab8.Visibility = Visibility.Visible;
            But7.Visibility = Visibility.Hidden;
        }

        private void But8_Click(object sender, RoutedEventArgs e)
        {
            Lab8.Visibility = Visibility.Hidden;
            Lab9.Visibility = Visibility.Visible;
            But8.Visibility= Visibility.Hidden;
        }
    }
}
