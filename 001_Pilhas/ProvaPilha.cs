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
    public partial class ProvaPilha : Form
    {
        public ProvaPilha()
        {
            InitializeComponent();
            pilha.topo = -1;
            pilha.vetor = new int[MAX];
        }
        const int MAX = 50;
        struct tp_pilha
        {
            public int topo;
            public int[] vetor;
        }
        tp_pilha pilha;
        //void Inicializa(ref tp_pilha p)
        //{
       //     p.topo = -1;
        //    p.vetor = new int[MAX];
        //}
        bool EstaVazia(tp_pilha p)
        {
            return (p.topo == -1);
        }
        bool EstaCheia(tp_pilha p)
        {  //verificar se esta cheia
            return (p.topo == MAX - 1);
        }
        // Insere um elemento
        void Empilha(ref tp_pilha p, int valor)
        {
            p.vetor[++p.topo] = valor;
        }
        // Remove um elemento
        int Desempilha(ref tp_pilha p)
        {
            return (p.vetor[p.topo--]);
        }

        private void btInsere_Click(object sender, EventArgs e)
        {
            if (!EstaCheia(pilha))
            {
                int valor;
                //Inicializa(ref fila); no load
                valor = Convert.ToInt32(tbValor.Text);
                Empilha(ref pilha, valor);
                tbValor.Clear();
                tbValor.Focus();
                //Evento voltar o foco para o input
            }
            else
                MessageBox.Show("Fila Cheia!");
        }

        private void btExibe_Click(object sender, EventArgs e)
        {
            while (!EstaVazia(pilha))
            {
                lbResultado.Items.Add(Desempilha(ref pilha));
            }
        }
        //private void BProcessa_Click(object sender, EventArgs e)
        //{
        //    Inicializa(ref pilha);
        //}
    }
}
