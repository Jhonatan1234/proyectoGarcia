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
using System.Windows.Shapes;

namespace proyecto
{
    /// <summary>
    /// Interaction logic for bole.xaml
    /// </summary>
    public partial class bole : Window
    {
        public bole()
        {
            InitializeComponent();
        }

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }

        private void combo1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void grid_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {
            demoEF db = new demoEF();
            combo2.ItemsSource = db.BUS.ToList();
            combo2.DisplayMemberPath = "marca_bus";
            combo2.SelectedValuePath = "idbus";

            combo3.ItemsSource = db.choferes.ToList();
            combo3.DisplayMemberPath = "nombrecho";
            combo3.SelectedValuePath = "idchofer";

            combo4.ItemsSource = db.pasajeros.ToList();
            combo4.DisplayMemberPath = "Nombre";
            combo4.SelectedValuePath = "idpasajero";

            combo5.ItemsSource = db.Empleados.ToList();
            combo5.DisplayMemberPath = "nombre";
            combo5.SelectedValuePath = "idempleado";

            
          
        }

      

        private void tex4_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

       

    }
}
