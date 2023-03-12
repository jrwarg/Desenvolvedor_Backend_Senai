using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade
{
    class Clientes
    {
        public string nome { get; set; }    
        public string endereco { get; set; }    
        public float valor { get; protected set; }    
        public float valor_imposto { get; protected set; }    
        public float total { get; protected set; }    

        public virtual void Pagar_Imposto (float v)
        {
            this.valor = v;
            this.valor_imposto = (float)(this.valor * 0.1);
            this.total = this.valor + (float)this.valor_imposto; 
        }
    }


}