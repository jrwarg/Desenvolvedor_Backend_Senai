using System;

class Pessoa
{
    // Atributo
    private string? nome = "Juan";

    // Construtor
    public Pessoa(string nome)
    {
        Console.WriteLine(nome);
        // Se quisermos utilizar o atributo, não o parâmetro do construtor:
        Console.WriteLine(this.nome);

        // O "this" sempre liga o ATRIBUTO DA CLASSE AO SEU MÉTODO!
    }
}