using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TI_AED_SO
{
    class Program
    {
        static void InserirProcessos(string local, ListaCircular[] listas)
        {
            Processo aux;
            string pid, nome, prioridade, tempo, quant;
            StreamReader reader = new StreamReader(local);
            string arquivo = reader.ReadToEnd();
            arquivo = arquivo.Replace("\r", null);
            string[] linhas = arquivo.Split('\n');
            for (int i = 0; i < linhas.Length; i++)
            {
                string[] dados = linhas[i].Split(';');
                pid = dados[0];
                nome = dados[1];
                prioridade = dados[2];
                tempo = dados[3];
                quant = dados[4];
                aux = new Processo(int.Parse(pid), nome, int.Parse(prioridade), float.Parse(tempo), int.Parse(quant));
                listas[int.Parse(prioridade)].Inserir(aux);

            }
            reader.Close();
        }
        static void Main(string[] args)
        {






        }
    }
}
