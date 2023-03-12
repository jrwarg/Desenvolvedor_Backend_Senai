using System;

class Atendente : Imposto
{
    public  override void valeAlimentacao( double salario)
    {
        Console.WriteLine("Desconto atendente do Vale Alimentação: " + salario * 0.12);
    }
}