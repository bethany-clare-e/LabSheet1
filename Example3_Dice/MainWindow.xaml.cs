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

namespace Example3_Dice
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

        private void BtnRollDice_Click(object sender, RoutedEventArgs e)
        {
            Update();

        }

        public async void Update()
        {
            //GENERATE A RANDOM NUMBER (1-6)
            Random r = new Random();
            

            for (int i = 0; i < 20; i++)
            {
                int number = r.Next(1, 7);
                //DISPLAY ON SCREEN
                tblkNumber.Text = number.ToString();

                await Task.Delay(20);
            }

            
        }
    }
}
