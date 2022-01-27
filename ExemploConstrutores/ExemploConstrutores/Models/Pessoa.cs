using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploConstrutores.Models
{
    public class Pessoa
    {
        private  string nome ;
        private  string sobrenome;

        public Pessoa()//construtor vazio que possui nenhum parametros
        {
            nome = string.Empty;
            sobrenome = string.Empty;   
        }

        public Pessoa(string nome , string sobrenome)//construtor com parametros
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
            System.Console.WriteLine("Construtor Classe Pessoa");
        }

        public void Apresentar()
        {    
            System.Console.WriteLine($"Olá,Meu nome é {nome} {sobrenome}");
        }
    }
}


/*Construtor padrão é um sem parametros quando  você não define nenhum construtor*/