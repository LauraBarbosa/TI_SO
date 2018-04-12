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

        public Fila()
        {
            this.prim = new Elemento(null);
            this.ult = this.prim;
        }

        public void Inserir(IDados novo)
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
        public bool Vazia()
        {
            if (ult == prim)
                return true;
            else
                return false;
        }
    }
}
