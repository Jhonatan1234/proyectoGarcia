using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Interaction logic for pasajeros.xaml
    /// </summary>
    public partial class pasajeros : Window
    {
        public pasajeros()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (Regex.IsMatch(nom.Text, @"^[a-zA-Z]+$")  && Regex.IsMatch(na.Text, @"^[a-zA-Z]+$") && Regex.IsMatch(dir.Text, @"^[a-zA-Z]+$"))
            {
                demoEF db = new demoEF();
                pasajero emp = new pasajero();

                emp.Nombre = nom.Text;
              
                emp.nacionalidad = na.Text;
                emp.Direccion = dir.Text;
                
               
                db.pasajeros.Add(emp);
                db.SaveChanges();

            }
            else { MessageBox.Show("Solo  letras , codigo y buss son numero"); }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (Regex.IsMatch(idpa.Text, @"^\d+$"))
            {
                demoEF db = new demoEF();
                int idbus = int.Parse(idpa.Text);
                var emp = db.pasajeros.SingleOrDefault(x => x.idpasajero == idbus);/*from x in db.Empleado
                      where x.id == id
                      select x;*/
                if (emp != null)
                {
                    db.pasajeros.Remove(emp);

                    db.SaveChanges();
                }
            }
            else { MessageBox.Show("Solo numeros #id"); }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (Regex.IsMatch(idpa.Text, @"^\d+$"))
            {
                demoEF db = new demoEF();

                int idbus = int.Parse(idpa.Text);
                var bus = db.pasajeros.SingleOrDefault(x => x.idpasajero == idbus);/*from x in db.Empleado
                      where x.id == id
                      select x;*/
                if (bus != null)
                {
                    bus.Nombre = nom.Text;
                  
                    bus.nacionalidad = na.Text;
                    bus.Direccion = dir.Text;
                    
                   

                    db.SaveChanges();
                }
            }
            else { MessageBox.Show("Solo Numeros , Solo letras"); }
        }

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            demoEF db = new demoEF();
            var registros = from s in db.pasajeros

                            select s;
            consulta.ItemsSource = registros.ToList();
        }
    }
}
