using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploConstrutores.Models
{
    public class Matemática
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Matemática(int x , int y)
        {
            X = x; 
            Y = y;

            Calculadora.EventoCalculadora += EventHandler;
        }

        public void Somar()
        {
            Calculadora.Somar(X, Y);
        }

        public void EventHandler()
        {
            Console.WriteLine("Método Executado");
        }
    }
}
