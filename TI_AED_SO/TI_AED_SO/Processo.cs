using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TI_AED_SO
{
    class Processo : IDados
    {
        private int pid;
        private string nome;
        private int prioridade;
        private float tempo;
        private int qtd;

       public Processo(int pid, string nome, int prior, double ciclo, float tempo)
        {
            this.pid = pid;
            this.nome = nome;
            this.prioridade = prior;
            this.tempo = tempo;
            this.qtd = 0;
        }
        //Feitor por Jeff, os compareTo estão corretos? São necessários?
        public int CompareTo(IDados other) //Comparar os processos e quantidade de vezes a executar
        {
            Processo aux = (Processo)other;
            if (this.Qtd < aux.Qtd) return -1;
            else if (this.Qtd == aux.Qtd) return 0;
            else return 1;
        }
        public int CompareTo(int prioridade) //Comparar a prioridade dos processos
        {
            if (this.Prioridade < prioridade) return -1;
            else if (this.Prioridade == prioridade) return 0;
            else return 1;
        }
        public bool Equals(IDados other) //método de conferir igualdade de processos por PiD
        {
            Processo aux = (Processo)other;
            if (this.Pid == aux.Pid) return true;
            else return false;
        }
        //////////////////////////////////////
        public bool Ciclo()
        {
            //Ana: thread para execução do tempo e parada correta.
            qtd--;
            Thread.Sleep((int)(tempo * 1000));
            if (qtd == 0)
                return true;
            else
                return false;
        }
        //gets
        public int Pid { get { return pid; } set { pid = value; } }
        public string Nome { get { return nome; } set { nome = value; } }
        public int Prioridade { get { return prioridade; } set { prioridade = value; } }
        public float Tempo { get { return tempo; } set { tempo = value; } }
        public int Qtd { get { return qtd; } set { qtd = value; } }

    }
}
