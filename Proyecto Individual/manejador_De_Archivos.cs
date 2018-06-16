using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Individual
{
    [Serializable]
    class manejador_De_Archivos
    {
        List<Dueño> contactos = new List<Dueño>();
        public void agregarCOn(Dueño persona)
        {
            contactos.Add(persona);
        }

        public List<Dueño> obtenerCont()
        {
            return contactos;
        }
    }
}
