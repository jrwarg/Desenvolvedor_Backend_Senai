using System;

class Gerente : Imposto
{
    public  override void valeAlimentacao( double salario)
    {
        Console.WriteLine("Desconto gerente do Vale Alimentação: " + salario * 0.15);
    }
}