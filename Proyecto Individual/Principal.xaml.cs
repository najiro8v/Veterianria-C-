using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Proyecto_Individual
{
    /// <summary>
    /// Lógica de interacción para Principal.xaml
    /// </summary>
    public partial class Principal : Window
    {   
        
        public Principal()
        {
            InitializeComponent();
            Compras();
            
                
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            

        }
        public void seText(string nameU)
        {
            UsuarioDeterminado.Content = "User: "+nameU;
        }

        private void MenuIcerrar_Click(object sender, RoutedEventArgs e)
        {
            MainWindow back = new MainWindow();
            back.Show();
            this.Close();
           
        }
        public void Compras()
        {
            Sucursales tiendas = new Sucursales(SLarreynaga, new DayOfWeek[] { DayOfWeek.Friday, DayOfWeek.Monday, DayOfWeek.Wednesday }),
            /******************************************************************************************/
            
                tienda = new Sucursales(SHugoChavez, new DayOfWeek[] { DayOfWeek.Saturday, DayOfWeek.Sunday, DayOfWeek.Tuesday }),
            /******************************************************************************************/

                tienda1 = new Sucursales(SNindiri, new DayOfWeek[] { DayOfWeek.Tuesday,
                    DayOfWeek.Wednesday, DayOfWeek.Friday }),
            /******************************************************************************************/

                tienda2 = new Sucursales(SMetrocentro, new DayOfWeek[] { DayOfWeek.Saturday, DayOfWeek.Sunday, DayOfWeek.Tuesday }),
            /******************************************************************************************/

                tienda3 = new Sucursales(SLaSubasta, new DayOfWeek[] { DayOfWeek.Saturday, DayOfWeek.Sunday, DayOfWeek.Tuesday }),
            /******************************************************************************************/

                tienda4 = new Sucursales(SMayoreo, new DayOfWeek[] { DayOfWeek.Tuesday,
                    DayOfWeek.Wednesday, DayOfWeek.Friday  }),

            /******************************************************************************************/
                tienda5 = new Sucursales(SBoaco, new DayOfWeek[] { DayOfWeek.Saturday, DayOfWeek.Sunday, DayOfWeek.Tuesday }),
            /******************************************************************************************/

                tienda6 = new Sucursales(SMasaya, new DayOfWeek[] { DayOfWeek.Monday, DayOfWeek.Wednesday, DayOfWeek.Tuesday }),
            /******************************************************************************************/

                tienda7 = new Sucursales(STiscapa, new DayOfWeek[] { DayOfWeek.Saturday, DayOfWeek.Sunday, DayOfWeek.Tuesday }),
            /******************************************************************************************/

            tienda8 = new Sucursales(SJinotega, new DayOfWeek[] { DayOfWeek.Monday, DayOfWeek.Wednesday, DayOfWeek.Tuesday }),
            /******************************************************************************************/

            tienda9 = new Sucursales(SJalisco, new DayOfWeek[] { DayOfWeek.Saturday, DayOfWeek.Sunday, DayOfWeek.Tuesday }),
            /******************************************************************************************/

            tienda10 = new Sucursales(Smonterrey, new DayOfWeek[] { DayOfWeek.Friday, DayOfWeek.Sunday, DayOfWeek.Tuesday }),
            /******************************************************************************************/

            tienda11 = new Sucursales(SBuenosAires, new DayOfWeek[] { DayOfWeek.Saturday, DayOfWeek.Sunday, DayOfWeek.Tuesday }),
            /******************************************************************************************/

            tienda12 = new Sucursales(SCucuta, new DayOfWeek[] { DayOfWeek.Saturday, DayOfWeek.Sunday, DayOfWeek.Tuesday }),
            /******************************************************************************************/

            tienda13 = new Sucursales(SBogota, new DayOfWeek[] { DayOfWeek.Wednesday, DayOfWeek.Sunday, DayOfWeek.Tuesday }),
            /******************************************************************************************/

            tienda14= new Sucursales(Snjose, new DayOfWeek[] { DayOfWeek.Monday, DayOfWeek.Wednesday, DayOfWeek.Tuesday }),
            /******************************************************************************************/

            tienda15 = new Sucursales(Satenea, new DayOfWeek[] { DayOfWeek.Monday, DayOfWeek.Wednesday, DayOfWeek.Tuesday, DayOfWeek.Saturday, DayOfWeek.Sunday, DayOfWeek.Tuesday, DayOfWeek.Friday });

            tienda.Run();
            tiendas.Run();
            tienda1.Run();
            tienda2.Run();
            tienda3.Run();
            tienda4.Run();
            tienda5.Run();
            tienda6.Run();
            tienda7.Run();
            tienda8.Run();
            tienda9.Run();
            tienda10.Run();
            tienda11.Run();
            tienda12.Run();
            tienda13.Run();
            tienda14.Run();
            tienda15.Run();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void agregarMasc_Click(object sender, RoutedEventArgs e)
        {
            registro nuevo = new registro();
            nuevo.ShowDialog();
        }
    }
}
