using System;

class Pessoa
{
    // Atributos
    // protected = apenas a classe e classes extendidas tem acesso
    protected string? nome;
    protected int idade;

    // Método
    protected void mensagemPessoa()
    {
        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("Idade: " + idade);
    }
}
