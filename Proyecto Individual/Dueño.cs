using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Individual
{[Serializable]
    class Dueño: Base
    {

        private string Correo, Contraseña,Usuario;
        private List<Mascota> misMascotas;



        public Dueño(string Name, string Date, int edad, string genero,
                     string Email, string password, string UserName)
                      
        {
            Nombre = Name;
            FechaDN1 = Date;
            Age = edad;
            Genero1 = genero;
            /**************/
            Correo1 = Email;
            Contraseña1 = password;
            Usuario1 = UserName;
            misMascotas = new List<Mascota>();
            
        }

        public string Correo1 { get => Correo; set => Correo = value; }
        public string Contraseña1 { get => Contraseña; set => Contraseña = value; }
        public string Usuario1 { get => Usuario; set => Usuario = value; }
        internal List<Mascota> MisMascotas { get => misMascotas; set => misMascotas = value; }

        public bool addMascota(Mascota temp)
        {
            try
            {
                MisMascotas.Add(temp);
                return true;
            } catch (Exception) { return false; }
        }
        public Mascota BuscarMascotaPorNombre(string name)
        {
            foreach (Mascota temp in MisMascotas)
            {
                if (temp.Nombre.Equals(name))
                {
                    return temp;
                }
            }
            return null;
        }
        public Mascota BuscarMascotaPorPlaca(string placa)
        {
            foreach (Mascota temp in MisMascotas)
            {
                if (temp.Id1.Equals(placa))
                {
                    return temp;
                }
            }
            return null;
        }
        public bool ElminarMascotaPorplaca(string placa)
        {
            int index = 0;
            foreach (Mascota temp in MisMascotas)
            {
                if (temp.Id1.Equals(placa))
                {
                    MisMascotas.RemoveAt(index);
                    return true;
                }
                index++;
            }
            return false;
        }
    }
}
