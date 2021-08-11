using System;

namespace Laboratorio7
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa[] pessoas = {
                new Pessoa("Jose", 25),
                new Pessoa("Ana", 28),
                new Pessoa("Paulo", 20)
            };

            Array.Sort(pessoas, Pessoa.sortByAge());

            foreach (var item in pessoas)
            {
                Console.WriteLine($"Nome: {item.Nome}. Idade: {item.Idade}");
            }
        }
    }
}