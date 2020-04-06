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
    public partial class Ex03 : Form
    {
        public Ex03()
        {
            InitializeComponent();
        }
        // COPIAR A PARTIR DAQUI

        const int MAX = 50;
        struct tp_pilha
        {
            public int topo;
            public int[] vetor;
        }
        tp_pilha pilha;
        void Inicializa(ref tp_pilha p)
        {
            p.topo = -1;
            p.vetor = new int[MAX];
        }
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

        private void BProcessa_Click(object sender, EventArgs e)
        {
            int NumInt, i = 1;
            string NumResultado = "";
            string Oper = TBOperations.Text;
            NumInt = Convert.ToInt32(TBNElements.Text);

            Inicializa(ref pilha);

            foreach (char l in Oper)
            {
                if (l == 'E')
                {
                    Empilha(ref pilha, i);
                    i++;
                 }
                else if (l == 'D')
                    NumResultado += Convert.ToString(Desempilha(ref pilha));
            }
            TBNumResultado.Text = NumResultado;
        }

    }
}
