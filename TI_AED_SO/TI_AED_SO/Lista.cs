using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_AED_SO
{
    class Lista
    {
        Elemento prim, ult;

        public Lista()
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

        public IDados Localizar(Object o)
        {
            Elemento aux = this.prim.prox;
            while (aux != null && !aux.dados.Equals(o))
                aux = aux.prox;
            if (aux == null) return null;
            else return aux.dados;
        }

        public IDados Retirar(Object o)
        {
            Elemento aux = this.prim;
            while ((aux.prox != null) && (!aux.prox.dados.Equals(o)))
                aux = aux.prox;
            if (aux.prox != null)
            {
                Elemento auxRet = aux.prox;
                aux.prox = auxRet.prox;
                if (auxRet == this.ult) this.ult = aux;
                else auxRet.prox = null;
                return auxRet.dados;
            }
            return null;
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
