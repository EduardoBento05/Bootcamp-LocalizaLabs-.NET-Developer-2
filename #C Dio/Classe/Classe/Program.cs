// See https://aka.ms/new-console-template for more information
using Csharp;
using Interface;
using Enum;

Console.WriteLine("Hello, World!");


Pessoa person = new Pessoa();

person.Nome = "Eduardo";
person.Estado = "Paraná";
person.Idade = 26;

var person2 = new Pessoa();

person2.Nome = "Lais";
person2.Idade = 23;
person2.Estado = "São Paulo";

Animal animal = new Animal();

animal.Nome = "Ozzy";
animal.NomeDono = "Eduardo";
animal.NomeEspecie = "Pastor Alemão";

var pessoa1 = (pessoas)0;

pessoas pessoa2 = pessoas.Lucas;

pessoas pessoa3 = pessoas.Silvana;


