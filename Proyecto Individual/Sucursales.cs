using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Proyecto_Individual
{
    class Sucursales 
    {
        TextBox temp;
        DayOfWeek []tiempo;
        

        public Sucursales(TextBox mientras, DayOfWeek[] dayOfs)
        {
            Temp=mientras;
            Tiempo = dayOfs;
            
        }

        public TextBox Temp { get => temp; set => temp = value; }
        public DayOfWeek[] Tiempo { get => tiempo; set => tiempo = value; }
        

        public void Run()
        {
            string P ="";
                foreach (DayOfWeek tempo in Tiempo)
                {
                       
                    if (DateTime.Today.DayOfWeek.Equals(tempo))
                    {
                        Temp.Foreground = Brushes.White;
                        Temp.Background = Brushes.Green;
                        P = " (Abierto)";
                        break;

                        
                    }
                    else
                    {
                        Temp.Foreground = Brushes.White;
                        Temp.Background = Brushes.Red;
                        P = " (Cerrado)";

                }
            }
                Temp.Text = Temp.Text + P;
            
        }
    }
}
