using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_AED_SO
{
    class Fila
    {
        private Elemento prim, ult;

        public Fila() //Ana: tinha um Dado que não estava sendo utilizado e prejudicava na hora de instanciar no Principal
        {
            this.prim = new Elemento(null);
            this.ult = this.prim;
        }

        public void Inserir(IDados novo) //Ana: a fila só precisa de um dado nesse momento, para fazer a inserção, antes tinha no construtor (retirei, vide construtor)
        {
            Elemento aux = new Elemento(novo);
            this.ult.prox = aux;
            this.ult = aux;
        }

        public Elemento Retirar()
        {
            Elemento aux = this.prim.prox;
            if (aux != null)
            {
                this.prim.prox = aux.prox;
                aux.prox = null;
                if (aux.Equals(this.ult))
                    this.prim = this.ult;
                return aux;
            }
            else
                return null;
        }
        public Elemento Peek()
        {
            return prim.prox;
        }
        public bool Vazia() //Ana: Adicionado para poder fazer a validação da fila 
        {
            if (ult == prim)
                return true;
            else
                return false;
        }
    }
}
