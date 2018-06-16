using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Individual
{[Serializable]
    class Base
    {
        private string nombre,FechaDN,Genero;
        private int  age;

        public string Nombre { get => nombre; set => nombre = value; }
        public string FechaDN1 { get => FechaDN; set => FechaDN = value; }
        public string Genero1 { get => Genero; set => Genero = value; }
        public int Age { get => age; set => age = value; }
    }
}
