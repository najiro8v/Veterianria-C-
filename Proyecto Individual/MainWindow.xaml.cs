using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Proyecto_Individual
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        manejador_De_Archivos mnj=new manejador_De_Archivos();
        public MainWindow()
        {
            InitializeComponent();
            //IFormatter formatter = new BinaryFormatter();
            Stream lstream = new FileStream("contactos.txt", FileMode.OpenOrCreate);
            //formatter.Serialize(lstream, mnj);
            lstream.Close();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                IFormatter formatter = new BinaryFormatter();
                Stream lstream = new FileStream("contactos.txt", FileMode.Open, FileAccess.Read, FileShare.None);
                mnj = (manejador_De_Archivos)formatter.Deserialize(lstream);
               
                lstream.Close();

            }
            catch (Exception ex) { MessageBox.Show("Error atroz"); }
            List<Dueño> temp = mnj.obtenerCont();
            foreach (Dueño mtemp in temp)
            {
                
                if (mtemp.Usuario1.Equals(usuario.Text))
                {
                    MessageBox.Show("usuario encontrado");
                    Principal tempo = new Principal();
                    this.Close();
                    tempo.seText(usuario.Text);
                    tempo.Show();
                }
                else
                {
                    MessageBox.Show("usuario No existente");
                }
            }

        }

        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            registro nuevo = new registro();

            nuevo.ShowDialog();
        }
    }
}
