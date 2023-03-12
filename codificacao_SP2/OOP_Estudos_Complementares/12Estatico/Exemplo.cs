using System;

// Métodos e atributos estáticos  NÃO PRECISAM DE INSTACIAMENTO! Podem ser chamados direto na execução

class Exemplo
{

    // Atributo Estático
public static string? nome = "José Reinaldo Guerra";
    // Método Estatico
    public static void soma(int n1, int n2)
    {
        Console.WriteLine("A soma é: " + (n1 + n2));
    }

}