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

namespace proyecto
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

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
           
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            nuevaventana vta = new nuevaventana();
            vta.Show();
        //}
        }

       

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            choferes vta = new choferes();
            vta.Show();

        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            empleados vta = new empleados();
            vta.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            pasajeros vta = new pasajeros();
            vta.Show();
        }
    }
}
