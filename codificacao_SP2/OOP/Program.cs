using System;
using System. Collections.Generic;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta c = new Conta();
            c.Depositar(100); // depositar um valor em conta
            Console.WriteLine(c.saldo);

            Carro carro = new Carro();
            carro.Modelo = "Tesla";
            carro.QuantidadePortas = 2;

           // criando uma lista do tipo Livro
           var Livros = new List<Livro>()
           {
               new Livro() { Id = 1, Titulo = "Do mil ao milhão", Preco = 12 },
               new Livro() { Id = 2, Titulo = "O poder do Agora", Preco = 12 },
               new Livro() { Id = 3, Titulo = "Comece pelo porquê", Preco = 12 },
               new Livro() { Id = 4, Titulo = "Breves Respostas para grandes questões", Preco = 12 }
           };
           // obtém a quantidade de itens
           Console.WriteLine(Livros.Count); // 4
           // percorrendo a lista de livros, e para cada item, imprimindo o título no console
           Livros.ForEach(Livro => Console.WriteLine(Livro.Titulo));
        }

        class Livro
        {
            public int Id { get; set; }
            public string? Titulo { get; set; }
            public double Preco { get; set; }
        }
    }
}