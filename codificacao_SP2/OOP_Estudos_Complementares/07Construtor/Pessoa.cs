using System;

class Pessoa
{
    // CONSTRUTOR :  É executado imediatamente sempre que uma classe que o contém é instanciada!

    public Pessoa()
    {
        Console.WriteLine("Construtor Executado!");
    }

    public Pessoa (string nome)
    {
        Console.WriteLine("Olá, " + nome);
    }
}