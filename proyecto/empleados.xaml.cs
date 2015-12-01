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
    /// Interaction logic for empleados.xaml
    /// </summary>
    public partial class empleados : Window
    {
        public empleados()
        {
            InitializeComponent();
        }

      

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (Regex.IsMatch(nom.Text, @"^[a-zA-Z]+$") && Regex.IsMatch(ape.Text, @"^[a-zA-Z]+$")  && Regex.IsMatch(dir.Text, @"^[a-zA-Z]+$")  && Regex.IsMatch(ge.Text, @"^[a-zA-Z]+$"))
            {
                demoEF db = new demoEF();
                empleado emp = new empleado();

                emp.nombre = nom.Text;
                emp.Apellido = ape.Text;
                
                 
                 emp.direccion = dir.Text;
                
                 emp.genero = ge.Text;
                
                db.Empleados.Add(emp);
                db.SaveChanges();

            }
            else { MessageBox.Show("Solo  letras"); }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
              if (Regex.IsMatch(idem.Text, @"^\d+$"))
            {
                demoEF db = new demoEF();
                int idempleado = int.Parse(idem.Text);
                var emp = db.Empleados.SingleOrDefault(x => x.idempleado == idempleado);/*from x in db.Empleado
                      where x.id == id
                      select x;*/
                if (emp != null)
                {
                    db.Empleados.Remove(emp);

                    db.SaveChanges();
                }
            }
            else { MessageBox.Show("Solo numeros #id"); }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (Regex.IsMatch(idem.Text, @"^\d+$"))
            {
                demoEF db = new demoEF();

                int idempleado = int.Parse(idem.Text);
                var bus = db.Empleados.SingleOrDefault(x => x.idempleado == idempleado);/*from x in db.Empleado
                      where x.id == id
                      select x;*/
                if (bus != null)
                {
                    bus.nombre = nom.Text;
                    bus.Apellido = ape.Text;
                    
                   
                    bus.direccion = dir.Text;
                 
                    bus.genero = ge.Text;

                    db.SaveChanges();
                }
            }
            else { MessageBox.Show("Solo Numeros , Solo letras"); }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            demoEF db = new demoEF();
           var registros = from s in db.Empleados

                            select s;
            dbfrid.ItemsSource = registros.ToList();
        }

   

     


        

    }
}
