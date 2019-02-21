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

namespace Example5_RadioButtons
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

        private void BtnCheck_Click(object sender, RoutedEventArgs e)
        {
            //check what radio button was selected
            bool biggerSelected = rbBigger.IsChecked.Equals(true);
            bool smallerSelected = rbSmaller.IsChecked.Equals(true);

            //display message
            if (biggerSelected)
                MessageBox.Show("You selected bigger");
            else if (smallerSelected)
                MessageBox.Show("You selected smaller");

               
        }
    }
}
