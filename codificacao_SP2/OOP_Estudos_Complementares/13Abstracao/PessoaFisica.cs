using System;

class PessoaFisica : Padrao
{
    // Método obrigatório:
    public override void taxaEmprestimo(double valor)
    {
        Console.WriteLine("Taxa de Empréstimo para Pessoa Física: " + valor * 0.1);
    }
}