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

namespace ControleStructuren_5___Machtsverheffening
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            // Getal uitlezen van textbox. Als dit niet lukt (geen getal is), 
            // dan niets doen (return => weggaan uit BtnBerekenen_Click)
            ulong number;
            bool isSucceeded = ulong.TryParse(numberTextBox.Text, out number);
            if (!isSucceeded || number > 84)
            {
                return;
            }
            // Maak de TxtResultaat textbox weer leeg
            resultTextBox.Text = string.Empty;

            const int NumberOfPowers = 10;
            ulong power = 1;
            for (int i = 1; i <= NumberOfPowers; i++)
            {
                power *= number; //macht = macht * getal;
                resultTextBox.Text += $"Macht {i:d2} van {number} is {power}\r\n";
            }
        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            numberTextBox.Text = string.Empty;
            resultTextBox.Text = string.Empty;
        }

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
