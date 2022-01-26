using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploPOO.models
{
    internal class Diretor : Professor
    {
        public override void apresentar()
        {
            Console.WriteLine($"Olá Meu nome é {Nome}, tenho {Idade} anos  e sou um Diretor");
        }
    }
}
