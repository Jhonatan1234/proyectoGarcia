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

     

        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {
            demoEF db = new demoEF();
            combo2.ItemsSource = db.BUS.ToList();
            combo2.DisplayMemberPath = "marca_bus";
            combo2.SelectedValuePath = "idbus";
            combo2.SelectedIndex = 0;
            

            combo3.ItemsSource = db.choferes.ToList();
            combo3.DisplayMemberPath = "Nombrecho";
            combo3.SelectedValuePath = "idchofer";
            combo3.SelectedIndex = 0;

            combo4.ItemsSource = db.pasajeros.ToList();
            combo4.DisplayMemberPath = "Nombre";
            combo4.SelectedValuePath = "idpasajero";
            combo4.SelectedIndex = 0;

            combo5.ItemsSource = db.Empleados.ToList();
            combo5.DisplayMemberPath = "nombre";
            combo5.SelectedValuePath = "idempleado";
            combo5.SelectedIndex = 0;

            
          
        }

     

      

        

       

    }
}
