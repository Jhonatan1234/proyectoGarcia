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
            if (Regex.IsMatch(nom.Text, @"^[a-zA-Z]+$") && Regex.IsMatch(co.Text, @"^\d+$") && Regex.IsMatch(na.Text, @"^[a-zA-Z]+$") && Regex.IsMatch(dir.Text, @"^[a-zA-Z]+$") && Regex.IsMatch(des.Text, @"^[a-zA-Z]+$") && Regex.IsMatch(b.Text, @"^\d+$"))
            {
                demoEF db = new demoEF();
                pasajero emp = new pasajero();

                emp.Nombre = nom.Text;
                emp.codigo_pasajero = int.Parse(co.Text);
                emp.nacionalidad = na.Text;
                emp.Direccion = dir.Text;
                emp.Destino = des.Text;
                emp.bussidbus = int.Parse(b.Text);
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
                    bus.codigo_pasajero = int.Parse(co.Text);
                    bus.nacionalidad = na.Text;
                    bus.Direccion = dir.Text;
                    bus.Destino = des.Text;
                    bus.bussidbus = int.Parse(b.Text);

                    db.SaveChanges();
                }
            }
            else { MessageBox.Show("Solo Numeros , Solo letras"); }
        }
    }
}
