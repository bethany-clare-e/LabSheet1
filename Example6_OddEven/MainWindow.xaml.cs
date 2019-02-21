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

namespace Example6_OddEven
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

        private void TbxNumber_GotFocus(object sender, RoutedEventArgs e)
        {
            tbxNumber.Clear();
        }

        private void BtnCheckOddEven_Click(object sender, RoutedEventArgs e)
        {

                string Str = tbxNumber.Text.Trim();
                int number;
                bool isNum = int.TryParse(Str, out number);
            if (isNum)
            {



                //check if odd or even
                if (number % 2 == 0)
                {


                    //display message
                    //MessageBox.Show("Number is even");
                    tblk1.Text = "Number is even";
                    tblk1.Background = Brushes.Black;
                    tblk1.Foreground = Brushes.White;

                }

                else
                {
                    //MessageBox.Show("Number is odd");
                    tblk1.Text = "Number is odd";
                    tblk1.Background = Brushes.HotPink;
                    tblk1.Foreground = Brushes.White;

                }



            }

            else
                MessageBox.Show("Number is invalid");
        }
    }
}
