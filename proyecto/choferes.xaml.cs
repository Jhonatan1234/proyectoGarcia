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
    /// Interaction logic for choferes.xaml
    /// </summary>
    public partial class choferes : Window
    {
        public choferes()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            if (Regex.IsMatch(nom.Text, @"^[a-zA-Z]+$") && Regex.IsMatch(ape.Text, @"^[a-zA-Z]+$") && Regex.IsMatch(dir.Text, @"^[a-zA-Z]+$"))
            {
                demoEF db = new demoEF();
               chofer emp = new chofer();

                emp.Nombrecho = nom.Text;
                emp.Apellidocho = ape.Text;
                emp.Direccion = dir.Text;
             
                
                db.choferes.Add(emp);
                db.SaveChanges();

            }
            else { MessageBox.Show("Solo  letras"); }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (Regex.IsMatch(idcho.Text, @"^\d+$"))
            {
                demoEF db = new demoEF();
                int idc = int.Parse(idcho.Text);
                var emp = db.choferes.SingleOrDefault(x => x.idchofer == idc);/*from x in db.Empleado
                      where x.id == id
                      select x;*/
                if (emp != null)
                {
                    db.choferes.Remove(emp);

                    db.SaveChanges();
                }
            }
            else { MessageBox.Show("Solo numeros #id"); }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (Regex.IsMatch(idcho.Text, @"^\d+$"))
            {
                demoEF db = new demoEF();

                int idbus = int.Parse(idcho.Text);
                var bus = db.choferes.SingleOrDefault(x => x.idchofer == idbus);/*from x in db.Empleado
                      where x.id == id
                      select x;*/
                if (bus != null)
                {
                    bus.Nombrecho = nom.Text;
                    bus.Apellidocho = ape.Text;
                    bus.Direccion = dir.Text;
                   
                   

                    db.SaveChanges();
                }
            }
            else { MessageBox.Show("Solo Numeros , Solo letras"); }
        }
    }
}
