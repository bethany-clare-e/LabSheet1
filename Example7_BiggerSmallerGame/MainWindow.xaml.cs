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

namespace Example7_BiggerSmallerGame
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

        private void BtnStartGame_Click(object sender, RoutedEventArgs e)
        {
            Update();
        }

        public async void Update()
        {
            //GENERATE A RANDOM NUMBER (1-6)
            Random r = new Random();


            for (int i = 0; i < 20; i++)
            {
                int number2 = r.Next(1, 21);
                //DISPLAY ON SCREEN
                tblkFirstNumber.Text = number2.ToString();

                await Task.Delay(20);
            }


        }

        private void BtnGuess_Click(object sender, RoutedEventArgs e)
        {
            Random r = new Random();


            bool biggerSelected = rbBigger.IsChecked.Equals(true);
            bool smallerSelected = rbSmaller.IsChecked.Equals(true);
            int number2 = Convert.ToInt32(tblkSecondNumber.Text);
            int number1 = r.Next(1, 21);
            

            if (number2 > number1)
                biggerSelected = true;
            else if (number2 == number1)
                smallerSelected = true;

            tblkSecondNumber.Text = number2.ToString();

        }
    }
}
