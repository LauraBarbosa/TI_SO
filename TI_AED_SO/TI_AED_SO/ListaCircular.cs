using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_AED_SO
{
    class ListaCircular
    {
        Elemento prim, atual;

        public ListaCircular()
        {
            this.prim = new Elemento(null);
            this.atual = this.prim;
            this.atual.prox = this.prim;
        }

        public void Inserir(IDados novo)
        {
            Elemento aux = new Elemento(novo);
            aux.prox = atual.prox;
            atual.prox = aux;
            atual = aux;
        }

        public IDados Retirar(IDados o)
        {
            Elemento aux = this.atual;
            if (aux == this.atual)
            {
                while (aux.prox != this.atual)
                    aux = aux.prox;
                Elemento auxRet = aux.prox;
                aux.prox = auxRet.prox;
                auxRet.prox = null;
                if ((auxRet == this.atual) && (aux.prox != this.prim)) this.atual = aux.prox;
                else if (this.prim.prox != null) this.atual = this.prim.prox;
                else this.atual = this.prim;
                return auxRet.dados;
            }
            while ((aux != this.atual) && (aux.dados != null) && (!aux.prox.dados.Equals(o)))
                aux = aux.prox;
            if (aux.prox.dados != null)
            {
                Elemento auxRet = aux.prox;
                aux.prox = auxRet.prox;
                if ((auxRet == this.atual) && (aux.prox != this.prim)) this.atual = aux.prox;
                else if (this.prim.prox != null) this.atual = this.prim.prox;
                else this.atual = this.prim;
                auxRet.prox = null;
                return auxRet.dados;
            }
            return null;
        }

        public void Avancar()
        {
            if (this.atual.prox.dados != null)
                this.atual = atual.prox;
            else
                this.atual = this.prim.prox;
        }

        public bool Vazia()
        {
            if (this.atual == this.prim)
                return true;
            else
                return false;
        }

        public IDados GetAtual()
        {
            if (this.atual != null)
                return this.atual.dados;
            else
                return null;
        }

        public IDados GetMenor()
        {
            Elemento aux = this.atual.prox;
            Elemento menor = aux;
            while (aux.dados != null && !aux.Equals(this.atual))
            {
                if (aux.prox.dados != null)
                    aux = aux.prox;
                else if (aux.prox == this.prim && this.prim.prox.dados != null)
                    aux = this.prim.prox;
                else
                    return null;
                if (aux.dados.CompareTo(menor.dados) < 0)
                    menor = aux;
            }
            return menor.dados;
        }
    }
}
