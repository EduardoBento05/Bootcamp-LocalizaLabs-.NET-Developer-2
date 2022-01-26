using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploPOO.models
{
    internal class Retangulo
    {
        private double comprimento;
        private double largura;
        private bool valido;

        public void DefinirMedidas(double comprimento, double largura)
        {   
            if(comprimento > 0 && largura > 0) 
            { 
            this.comprimento = comprimento;
            this.largura = largura;
            valido = true;
            }
            else
            {
                System.Console.WriteLine("Valores Inválidos");   
            }
        }

        public double ObterArea()
        {
            if (valido)
            {
                return comprimento * largura;
            }

            else
            {
               System.Console.WriteLine("Preencha Valores Válidos");
                return 0;
            }
        }
    }
}
