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
    /// Interaction logic for nuevaventana.xaml
    /// </summary>
    public partial class nuevaventana : Window
    {
        public nuevaventana()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
           
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
             //instanciar bd
            if (Regex.IsMatch(txtsueldo.Text, @"^\d+$") && Regex.IsMatch(txtnombre.Text,@"^[a-zA-Z]+$"))
            { 
                demoEF db = new demoEF();
                Empleado emp = new Empleado();
                emp.Nombre = txtnombre.Text;
                emp.Sueldo = int.Parse(txtsueldo.Text);
                emp.DepartamentoId = (int)cbdepartamento.SelectedValue;
                db.Empleado.Add(emp);
                db.SaveChanges();

            }
            else { MessageBox.Show("Solo Numeros y letras"); }
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }
        }
    }
}
