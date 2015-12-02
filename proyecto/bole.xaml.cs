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
using proyecto.mibd;
using System.Text.RegularExpressions;
namespace proyecto
{
    /// <summary>
    /// Interaction logic for bole.xaml
    /// </summary>
    public partial class bole : Window
    {
        private boleto tmpProduct = null;

        private List<boleto> ShoppingCart;
        public bole()
        {
            InitializeComponent();
            //on the constructor of the class we create a new instance of the shooping cart
            ShoppingCart = new List<boleto>();
        }
        private void actualizar()
        {
            var cartItems = from s in ShoppingCart
                            select new
                            {
                                s.num_boleto,
                                s.fecha,
                                s.Destino,
                                s.precio,
                                s.idbus,
                                s.idchofer,
                                s.idpasajero,
                                s.idempleado,
                                SubTotal = s.precio + s.precio
                            };

            //refresh dataGridview-----------
            bogrid.ItemsSource = null;
            bogrid.ItemsSource = cartItems;

            //we add the total with sum(price) and apply a currency formating.
            lbtotal.Content = string.Format("Total: {0}", ShoppingCart.Sum(x => x.precio + x.precio).ToString("C"));

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

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            demoEF db = new demoEF();
            boleto emp = new boleto();

            emp.fecha = fac.SelectedDate.Value;
            emp.Destino = combo1.Text;
            emp.precio = int.Parse(tex4.Text);
            emp.idbus = int.Parse(combo2.SelectedValue.ToString());
            emp.idchofer = int.Parse(combo3.SelectedValue.ToString());
            emp.idpasajero = int.Parse(combo4.SelectedValue.ToString());
            emp.idempleado = int.Parse(combo5.SelectedValue.ToString());
            db.boletos.Add(emp);
            db.SaveChanges();
          
            MessageBox.Show("Se Guardaron los datos");

        }

        private void Button_Click_2(object sender, RoutedEventArgs e) {
             if ( combo1.SelectedIndex > -1 && combo2.SelectedIndex > -1 && combo3.SelectedIndex > -1 && combo4.SelectedIndex > -1 && combo5.SelectedIndex > -1)
            {
               demoEF db = new demoEF();
                
                int id = Convert.ToInt32(combo5.SelectedValue);
                boleto p = db.boletos.SingleOrDefault(x => x.num_boleto== id);

                if (p != null)
                {
                   tmpProduct = p;

                }

               ShoppingCart.Add(new boleto()
                {
                    num_boleto= tmpProduct.num_boleto,
                    fecha =  tmpProduct.fecha,
                    Destino =  tmpProduct.Destino,
                    precio =  tmpProduct.precio,
                    idbus =  tmpProduct.  idbus,
                    idchofer =  tmpProduct.idchofer,
                    idpasajero =  tmpProduct.idpasajero,
                    idempleado =  tmpProduct.idempleado,
                });

                actualizar();
                tmpProduct = null;
             
            }
            else
            {
                MessageBox.Show("Tiene que seleccionar al menos un opcion en cada campo", "precaucion", MessageBoxButton.OK, MessageBoxImage.Hand);
            }
        }

        private void bogrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
            }
        }

    

            //we first check if a product has been selected
           //var cartItems = from s in ShoppingCart
           //     select new
           //     {
           //         s.num_boleto,
           //         s.fecha,
           //         s.Destino,
           //         s.precio,
           //         s.idbus,
           //         s.idchofer,
           //         s.idpasajero,
           //         s.idempleado,
           //         SubTotal = s.precio+s.precio
           //     };

           // //refresh dataGridview-----------
           // bogrid.ItemsSource = null;
           // bogrid.ItemsSource = cartItems;

           // //we add the total with sum(price) and apply a currency formating.
           // lbtotal.Content = string.Format("Total: {0}", ShoppingCart.Sum(x => x.precio + x.precio).ToString("C"));
         
           // }
        
        
        

     

      

        

       

    

