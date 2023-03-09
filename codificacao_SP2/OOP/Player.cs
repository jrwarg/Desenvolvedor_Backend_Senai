namespace OOP
{
    // POLIMORFISMO
    /* as classes derivadas de uma superclasse
podem ter a mesma assinatura (método), mas terão comportamentos
diferentes. Nesse sentido, embora a ação possa ser a mesma, os
objetos podem responder diferentemente.
*/
    public class Player
    {
        // virtual é utilizado para que ela possa ser
        // substituida em uma classe derivada
        private float velocidade;
        private float forcaPulo;
    
        public virtual void Correr() { }
        public virtual void Pular() {}
    }
}