using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_AED_SO
{
    class Elemento
    {
        public IDados dados;
        public Elemento prox;

        public Elemento(IDados d)
        {
            this.dados = d;
            this.prox = null;
        }
    }
}
