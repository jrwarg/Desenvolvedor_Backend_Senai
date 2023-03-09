using System;

class Pessoa
{
    public double peso;
    public double altura;
    public double calcularIMC(double peso, double altura)
    {
        return peso / (altura * altura);
    }

    public string situacao()
    {
        if (calcularIMC < 18.5)
        {
            Console.Writeline("Abaixo do peso!");
        }
        else if (calcularIMC < 25)
        {
           Console.Writeline("Peso normal!") ;
        }
        else if (calcularIMC < 30)
        {
            Console.Writeline("Acima do peso!");
        }
        else if (calcularIMC < 35)
        {
            Console.Writeline("Obesidade I");
        }
        else if (calcularIMC < 40)
        {
            Console.Writeline("Obesidade II");
        }
        else if (calcularIMC >=40)
        {
            Console.Writeline ("Obesidade III");
        }
    }

    public string mensagem()
    {
        double calculo = calcularIMC();
        string situacao = situacao();

        Console.WriteLine("O IMC é "+ calcularIMC + " - " + situacao);
    }
}