using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TI_AED_SO
{
    public partial class Principal : Form
    {
        Fila[] prioridades = new Fila[5];
        Fila finalizados;
        public Principal()
        {
            InitializeComponent();
            //as filas foram criadas manualmente, as principais, para depois acrescentar as listas e os elementos.
            this.prioridades[0] = new Fila();
            this.prioridades[1] = new Fila();
            this.prioridades[2] = new Fila();
            this.prioridades[3] = new Fila();
            this.prioridades[4] = new Fila();
            this.finalizados = new Fila();
            this.Preencher();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            //depois apagar
        }

        private void Preencher()
        {
            //leitura do arquivo e instanciando a fila
            string[] texto;
            StreamReader arq = new StreamReader(@"Arquivo.txt");
            //int quant = arq.ReadLine().Count();
            int quant = File.ReadLines(@"Arquivo.txt").Count();
            
            for (int i = 0; i < quant; i++)
            {
                texto = arq.ReadLine().Split(';');
                texto[3] = texto[3].Replace(',', '.');
                Processo auxP = new Processo(int.Parse(texto[0]), texto[1], int.Parse(texto[2]), float.Parse(texto[3]), int.Parse(texto[4]));
                prioridades[auxP.Prioridade].Inserir(auxP);
            }
            arq.Close();
        }
        private void Executar()
        {
            //conferir se todos as prioridades foram atendidas e se está funcionando corretamente.
            for (int i = 0; i < this.prioridades.Length; i++)
            {
                if (!this.prioridades[i].Vazia())
                {
                    Elemento auxE = prioridades[i].Retirar();
                    Processo auxP = (Processo)(IDados)auxE;
                    
                    if (auxP.Ciclo())
                        finalizados.Inserir(auxP); //já está inserindo na nova lista de atividades finalizadas.
                    else
                        this.prioridades[auxP.Qtd].Inserir(auxP);
                }
            }
        }
    }
}
