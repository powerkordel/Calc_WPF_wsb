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

namespace Kalkulator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string output;
        string zero = "0";



        public MainWindow()
        {
            InitializeComponent();
            Ekran.Text = zero;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Ekran.Text = output;
            output = (string)((Button)sender).Content;
            Ekran.Text = Ekran.Text + output;

        }
        
        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            output = "";
            Ekran.Text = output;
        }

        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            Ekran.Text += "+";
        }

        private void btnMinus_Click(object sender, RoutedEventArgs e)
        {
            Ekran.Text += "-";
        }

        private void btnRazy_Click(object sender, RoutedEventArgs e)
        {
            Ekran.Text += "x";
        }

        private void btnDziel_Click(object sender, RoutedEventArgs e)
        {
            Ekran.Text += "/";
        }

        private void btnRowna_Click(object sender, RoutedEventArgs e)
        {
            var temp = Ekran.Text;

            if (temp.Contains('+'))
            {
                var part = temp.Split('+');
                var suma = double.Parse(part[0]) +  double.Parse(part[1]);
                Ekran.Text = suma.ToString();
            }

            if (temp.Contains('-'))
            {
                var part = temp.Split('-');

                var roznica = double.Parse(part[0]) - double.Parse(part[1]);
                Ekran.Text = roznica.ToString();
            }

            if (temp.Contains('x'))
            {
                var part = temp.Split('x');

                var iloczyn = double.Parse(part[0]) * double.Parse(part[1]);
                Ekran.Text = iloczyn.ToString();
            }

            if (temp.Contains('/'))
            {
                var part = temp.Split('/');
                double elemJeden = double.Parse(part[0]);
                double elemDwa = double.Parse(part[1]);

                if (elemDwa == 0)
                {
                    Ekran.Text = "nie dziel przez zero";
                }
                else
                
                Ekran.Text = (elemJeden / elemDwa).ToString();

                
                    
            }

            
        }
    }
}
