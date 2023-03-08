namespace OOP
{
    public class MaquinaCafe
    {
        // EXEMPLO DE ABSTRAÇÃO 
        // mover o foco dos detalhes da implementação para as operações disponíveis, escondendo-os de um objeto externo.
        // não disponível para utilização externa ao objeto

        private void VerificarTemperatura(){
            // métodos
        }

        // Ação disponível:
        void FazerCafe()
        {
            VerificarTemperatura();
        }
    }
}