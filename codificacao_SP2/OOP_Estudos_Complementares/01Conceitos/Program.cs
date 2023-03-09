namespace _01Conceitos
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Instanciar um objeto
            Pessoa obj = new Pessoa();
            obj.nome = "José";
            obj.idade = 63;
            obj.mensagem();
        }
    }

}