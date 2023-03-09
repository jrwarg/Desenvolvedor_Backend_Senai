using System;

namespace _03ExercicioEscolar
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno a = new Aluno();
            a.nome = "João";
            a.nota1 = 8.0;
            a.nota2 = 10.0;
            a.mensagem();
        }
    }
}

