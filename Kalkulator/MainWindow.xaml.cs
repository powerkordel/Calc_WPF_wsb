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
        string zawartoscBtn;
        double result = 0;
        double first = 0;
        double second = 0;
        double czasowy = 0;
        string funkcja = "";


        public MainWindow()
        {
            InitializeComponent();
            Ekran.Text = czasowy.ToString();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            zawartoscBtn = (string)((Button)sender).Content;
            czasowy = (double.Parse(Ekran.Text) * 10) + double.Parse(zawartoscBtn);
            Ekran.Text = czasowy.ToString();
            second = double.Parse(Ekran.Text);
        }
        
        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            first = 0;
            second = 0;
            czasowy = 0;
            result = 0;
            funkcja = "";
            Ekran.Text = "0";
        }

        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            first = double.Parse(Ekran.Text);
            //second = 0;
            //result += first;
            funkcja = "+";
            Ekran.Text = "0";//result.ToString();
            
        }

        private void btnMinus_Click(object sender, RoutedEventArgs e)
        {
            first = double.Parse(Ekran.Text);
            
            funkcja = "-";
            Ekran.Text = "0";
        }

        private void btnRazy_Click(object sender, RoutedEventArgs e)
        {
            first = double.Parse(Ekran.Text);
            funkcja = "x";
            Ekran.Text = "0";
        }

        private void btnDziel_Click(object sender, RoutedEventArgs e)
        {
            first = double.Parse(Ekran.Text);
            funkcja = "/";
            Ekran.Text = "0";
        }

        private void btnRowna_Click(object sender, RoutedEventArgs e)
        {
            if (funkcja == "+")
            {
                if (Ekran.Text == "0"|| first ==0)
                {
                    
                    result += second;
                    first = 0;
                }
                else
                {
                    second = double.Parse(Ekran.Text);
                    result = first + second;
                    //first = 0;
                }
                first = 0;
                Ekran.Text = result.ToString();

            }

            if(funkcja == "-")
            {
                result = first - second;
                Ekran.Text = result.ToString();
            }

            if (funkcja == "x")
            {
                result = first * second;
                Ekran.Text = result.ToString();
            }

            if (funkcja == "/")
            {
                if (Ekran.Text =="0")
                {
                    Ekran.Text = "nie dziel przez zero";
                }
                else
                {

                    result = first / second;
                    Ekran.Text = result.ToString();
                }
            }
        }
    }
}

