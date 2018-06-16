using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Individual
{[Serializable]
    class Mascota:Base
    {
        private string especie,tratamiento,enfermedad;
        private string Id;

        private double peso, altura;
        private bool esta_enfermo;

        public string Especie { get => especie; set => especie = value; }
        public string Tratamiento { get => tratamiento; set => tratamiento = value; }
        public string Enfermedad { get => enfermedad; set => enfermedad = value; }
        public double Peso { get => peso; set => peso = value; }
        public double Altura { get => altura; set => altura = value; }
        public bool Esta_enfermo { get => esta_enfermo; set => esta_enfermo = value; }
        public string Id1 { get => Id; set => Id = value; }

        /*********************/
        public Mascota(string Name,string Date, int edad, string genero,
                        string Especie_1,string tratamiento_1,string enfermedad_1,
                        double peso_1, double altura_1,bool esta_enfermo_1, string placa)
        {
            Nombre = Name;
            FechaDN1 = Date;
            Age = edad;
            Genero1 = genero;
            /**************/
            Especie = Especie_1;
            Tratamiento = tratamiento_1;
            Enfermedad = enfermedad_1;
            Peso = peso_1;
            Altura = altura_1;
            Esta_enfermo = esta_enfermo_1;
            Id1 = placa;
        }
        public Mascota(string Name, string Date, int edad, string genero,
                       string Especie_1, string tratamiento_1, string enfermedad_1,
                       double peso_1, double altura_1,string placa)
        {
            Nombre = Name;
            FechaDN1 = Date;
            Age = edad;
            Genero1 = genero;
            /**************/
            Especie = Especie_1;
            Tratamiento = tratamiento_1;
            Enfermedad = enfermedad_1;
            Peso = peso_1;
            Altura = altura_1;
            Id1 = placa;

        }
        public Mascota(string Name, string Date, int edad, string genero,
                       string Especie_1,  string enfermedad_1,
                       double peso_1, double altura_1, string placa)
        {
            Nombre = Name;
            FechaDN1 = Date;
            Age = edad;
            Genero1 = genero;
            /**************/
            Especie = Especie_1;
            
            Enfermedad = enfermedad_1;
            Peso = peso_1;
            Altura = altura_1;
            Id1 = placa;

        }
    }
}
