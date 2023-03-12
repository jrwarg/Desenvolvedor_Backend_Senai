class Program
{
    static void Main(string[] args)
    {
        //  Instanciar estagiario
            Imposto e = new Estagiario();
            e.valeAlimentacao(1000);
            e.valeTransporte(1000);
        //  Instanciar gerente
            Imposto g = new Gerente();
            g.valeAlimentacao(5000);
            g.valeTransporte(5000);
        //  Instanciar atendente
            Imposto a = new Atendente();
            a.valeAlimentacao(2000);
            a.valeTransporte(2000);
    }
}
