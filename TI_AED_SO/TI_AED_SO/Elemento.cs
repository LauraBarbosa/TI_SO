using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_AED_SO
{
    class Elemento
    {
        //o elemento possui um tipo de dado que o compõe e também um outro elemento próximo para dar continuidade á lista/fila/pilha
        public IDados dados;
        public Elemento prox;

        public Elemento(IDados d)
        {
            this.dados = d;
            this.prox = null;
        }
    }
}
