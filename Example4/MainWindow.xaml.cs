﻿using System;
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

namespace Example4
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

        private void BtnNumbercheck_Click(object sender, RoutedEventArgs e)
        {
            //read text from textbox
            string numberEntered = tbxNumber.Text;

            //check if it is a number
            int number;
            bool isNum = int.TryParse(numberEntered, out number);

            //display a message
            if (isNum)
                tblkMessage.Text = "Valid number entered";
            else
                tblkMessage.Text = "Invalid number entered";
        }
    }
}
