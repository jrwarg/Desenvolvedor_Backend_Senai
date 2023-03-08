namespace OOP
{
    class Conta
    {
        public string Agencia;
        public string NomeConta;
        public double saldo { get; private set; } // não pode ser acessado externamente -> Relacionado ao Paradigma ENCAPSULAMENTO

        public void Depositar (double valorDepositado)
        {
            this.saldo += valorDepositado;
        }
    }
}