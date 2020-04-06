using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _001_Pilhas
{
    public partial class Ex07 : Form
    {
        public Ex07()
        {
            InitializeComponent();
            Inicializa(ref fila); //funcao de load separada da entrada separada 
            Inicializa(ref filaNMe); //parametro por referencia.. tbm há parametro de valor, de entrada e saida
            Inicializa(ref filaNMa);


        }
        // COPIAR A PARTIR DAQUI
        // Organização dos dados
        const int MAX = 50;
        struct tp_fila
        {
            public int inicio, fim;
            public int[] vetor;
        }
        tp_fila fila, filaNMe, filaNMa; //


        // Inicialização
        void Inicializa(ref tp_fila f)
        {
            f.inicio = f.fim = 1;
            f.vetor = new int[MAX];
        }

        // Verificando limites
        bool EstaVazia(tp_fila f)
        {
            return (f.inicio == f.fim);
        }
        bool EstaCheia(tp_fila f)
        {
            return (f.fim == MAX - 1);
        }

        // Insere um elemento
        void Insere(ref tp_fila f, int valor)
        {
            f.vetor[++f.fim] = valor;
        }

        // Remove um elemento
        int Remove(ref tp_fila f)
        {
            return (f.vetor[++f.inicio]);
        }

        private void BTExibeFilas_Click(object sender, EventArgs e)
        {
            //int remove;
            while (!EstaVazia(filaNMe))
            {
                LBNumMenores.Items.Add(Remove(ref filaNMe));
                /*remove = Remove(ref filaNMe);
                LBNumMenores.Items.Add(remove); //(Convert.ToString(remove));não precisa converter //listbox é um vetor de string; */
            }
            while (!EstaVazia(filaNMa))
            {
                LBNumMaiores.Items.Add(Remove(ref filaNMa));
            }
        }

        private void BTInsereFila_Click(object sender, EventArgs e)
        {
            if (!EstaCheia(fila))
            {
                int valor;
                //Inicializa(ref fila);
                valor = Convert.ToInt32(TBValor.Text);
                Insere(ref fila, valor);
                TBValor.Clear();
                TBValor.Focus();
                //Evento voltar o foco para o input
            }
            else
                MessageBox.Show("Fila Cheia!");
            
        }
        private void TBValor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BTInsereFila_Click(this, new EventArgs());
            }
        }
        private void BTDivide2Filas_Click(object sender, EventArgs e)
        {
            int vPrioridade, remove;
            vPrioridade = Convert.ToInt32(TBValorP.Text);
            while (!EstaVazia(fila))
            {
                remove = Remove(ref fila);
                if (remove < vPrioridade)
                    Insere(ref filaNMe, remove);  
                    //LBNumMenores.Items.Add(Convert.ToString(remove));
                else if (remove > vPrioridade)
                    Insere(ref filaNMa, remove);
                //LBNumMaiores.Items.Add(Convert.ToString(remove));
            }
            BTExibeFilas.Focus();
            //for (i = 0; i < LBNumMenores; i++)
        }
        private void TBValorP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BTDivide2Filas_Click(this, new EventArgs());
            }
        }

        // COPIAR ATÉ DAQUI
    }
}
