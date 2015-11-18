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
            if (Regex.IsMatch(id.Text, @"^\d+$"))
            {
                demoEF db = new demoEF();
                int idbus = int.Parse(id.Text);
                var emp = db.BUS.SingleOrDefault(x => x.idbus == idbus);/*from x in db.Empleado
                      where x.id == id
                      select x;*/
                if (emp != null)
                {
                    emp.tipo_bus = nombus.Text;
                     emp.marca_bus = marbus.Text;
                     emp.color_bus = cobus.Text;
                   
                    db.SaveChanges();
                }
            }
            else { MessageBox.Show("Solo Numeros , Solo letras"); }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

            if (Regex.IsMatch(nombus.Text, @"^[a-zA-Z]+$") && Regex.IsMatch(marbus.Text, @"^[a-zA-Z]+$")&& Regex.IsMatch(cobus.Text, @"^[a-zA-Z]+$"))
            {
                demoEF db = new demoEF();
                buss emp = new buss();

                emp.tipo_bus = nombus.Text;
                emp.marca_bus = marbus.Text;
                emp.color_bus = cobus.Text;
                db.BUS.Add(emp);
                db.SaveChanges();

            }
            else { MessageBox.Show("Solo  letras"); }
        }



      
        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            
            if (Regex.IsMatch(id.Text, @"^\d+$"))
            {
                demoEF db = new demoEF();
                int idbus = int.Parse(id.Text);
                var emp = db.BUS.SingleOrDefault(x => x.idbus == idbus);/*from x in db.Empleado
                      where x.id == id
                      select x;*/
                if (emp != null)
                {
                    db.BUS.Remove(emp);

                    db.SaveChanges();
                }
            }
            else { MessageBox.Show("Solo numeros #id"); }
        }

        }
    }


    

