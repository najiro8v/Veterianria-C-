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
    /// Lógica de interacción para RegistroMascota.xaml
    /// </summary>
    public partial class RegistroMascota : Window
    {
        manejador_De_Archivos mnj;
        public RegistroMascota()
        {
            InitializeComponent();
            genero.Items.Add("Masculino");
            genero.Items.Add("Femenino");
            espec();
           
        }
        public void espec()
        {
            Especie.Items.Add(  new string[] { "Perro","Gato","Caballo","Hamster","Conejo"});
        }
        public string placa()
        {
            Random anormal = new Random();
            string palabra = "";
            do
            {
                palabra = "";
                for (int i = 0; i < 4; i++)
                {
                    palabra += Convert.ToChar(anormal.Next(95, 107));
                }
            } while (PlacaExistente(palabra) == false);
            return palabra;
        }

        public bool PlacaExistente(string placa)
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

                foreach (Mascota mas in mtemp.MisMascotas)
                {
                    if (mas.Id1.Equals(placa))
                    {
                        return true;
                    }
                }
               
            }
            return false;
        }
    }
}
