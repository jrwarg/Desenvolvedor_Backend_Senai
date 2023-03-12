using System;

abstract class Padrao
{
    // Método Obrigatório
    public abstract void taxaEmprestimo(double valor);
    // Método Opcional
    public void calculoPoupanca(double valor, double taxa)
    {
        Console.WriteLine("Ganhos obtidos na Poupança: " + valor * taxa);
    }
}