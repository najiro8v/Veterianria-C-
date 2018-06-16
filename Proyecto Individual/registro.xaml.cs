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
using System.Windows.Shapes;

namespace Proyecto_Individual
{
    /// <summary>
    /// Lógica de interacción para registro.xaml
    /// </summary>
    public partial class registro : Window
    {
        manejador_De_Archivos mnj = new manejador_De_Archivos();
        public registro()
        {
            InitializeComponent();
            genero.Items.Add("Masculino");
            genero.Items.Add("Femenino");
            imi.IsEnabled = false;


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Nombre: " + nombre.Text + "\nNombre De Usuario: " + Username.Text
                + "\nContraseña: " + password1.Password + "\nGenero : "
                + genero.SelectedItem.ToString() + "\nFecha: " + gregoriano.SelectedDate.Value.ToShortDateString() + "\nCorreo electronico: "
                    + gmail.Text);
            Dueño n = new Dueño(nombre.Text, gregoriano.SelectedDate.Value.ToShortDateString(), 15, genero.SelectedItem.ToString(), gmail.Text, password1.Password, Username.Text);
            mnj.agregarCOn(n);

            IFormatter formatter = new BinaryFormatter();
            Stream lstream = new FileStream("contactos.txt", FileMode.OpenOrCreate,FileAccess.Write, FileShare.None);
            formatter.Serialize(lstream, mnj);
            lstream.Close();
            MessageBox.Show("registro Listo");
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            gregoriano.DisplayDateEnd = DateTime.Today.AddYears(-18);
            gregoriano.DisplayDateStart = DateTime.Today.AddYears(-80);
            gregoriano.DisplayDate = DateTime.Today.AddYears(-18); 

        }

        private void StackPanel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            
        }

        private void No_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Yes_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Yes_Checked(object sender, RoutedEventArgs e)
        {
            No.IsChecked = false;
            imi.IsEnabled = true;
        }

        private void No_Checked(object sender, RoutedEventArgs e)
        {
            Yes.IsChecked = false;
            imi.IsEnabled = false;
        }
    }
}
