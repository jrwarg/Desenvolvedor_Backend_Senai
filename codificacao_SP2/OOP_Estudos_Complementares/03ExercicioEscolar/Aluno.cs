using System;

class Aluno
{
    public string? nome;
    public double nota1, nota2;

    public double media()
    {
        return (nota1 + nota2) / 2;
    }

    public string situacao (double media)
    {
        return media >= 7 ? "Aprovado" : "Reprovado";
    }

    public void mensagem()
    {
        // obter a média
        double obterMedia = media();
        // obter a situação
        string obterSituacao = situacao(obterMedia);
        // mensagem:
        Console.WriteLine( nome + " está " + obterSituacao + " com a média " + obterMedia + "!");        
    }
}