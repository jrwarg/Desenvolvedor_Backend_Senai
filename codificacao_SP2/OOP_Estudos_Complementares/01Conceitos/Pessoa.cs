using System;
class Pessoa
{
    // Atribuitos
    public string? nome;
    public int idade;

    // Métodos (funções)
    public void mensagem()
    {
        Console.WriteLine("Olá, " + nome + ". Você tem " + idade+ " anos!");
    }
}