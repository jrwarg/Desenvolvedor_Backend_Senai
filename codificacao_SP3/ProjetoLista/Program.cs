namespace ProjetoLista;
class Program
{
    static void Main(string[] args)
    {
        ClientesPF cl1 = new ClientesPF();
        cl1.id = 1;
        cl1.nome = "Ana";

        List<ClientesPF> lista= new List<ClientesPF>();
        lista.Add( new ClientesPF());
        lista.Add(cl1);
        lista.Add(new ClientesPF() {id=2 , nome = "Carlos"});

        foreach( ClientesPF aux in lista)
        {
            System.Console.WriteLine("Cliente {0} : " + aux.nome);
        }
    }
}
