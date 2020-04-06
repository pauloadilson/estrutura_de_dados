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
    public partial class Ex04 : Form
    {
        public Ex04()
        {
            InitializeComponent();
        }
        // COPIAR A PARTIR DAQUI

        const int MAX = 50;
        struct tp_pilha
        {
            public int topo;
            public char[] vetor;
        }
        tp_pilha pilha;
        void Inicializa(ref tp_pilha p)
        {
            p.topo = -1;
            p.vetor = new char[MAX];
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
        void Empilha(ref tp_pilha p, char valor)
        {
            p.vetor[++p.topo] = valor;
        }
        // Remove um elemento
        char Desempilha(ref tp_pilha p)
        {
            return (p.vetor[p.topo--]);
        }

        private void BTProcessa_Click(object sender, EventArgs e)
        {
            //*inicia
            string Frase = TBFraseOD.Text;
            int tam = Frase.Length;
            string FraseOI = "";

            Inicializa(ref pilha);

            for (int i=0; i< tam; i++)
            {
                if (Frase[i] != ' ')
                    Empilha(ref pilha, Frase[i]);
                else
                {
                    while (!EstaVazia(pilha))
                        FraseOI += Desempilha(ref pilha); //não precisa converter char pra toString
                    FraseOI += ' ';
                }
            }
            while (!EstaVazia(pilha))
                FraseOI += Desempilha(ref pilha);
            TBFraseOI.Text = FraseOI;
            //termina */
            /*
            string Frase = TBFraseOD.Text; 
            string FraseOI = "";

            Inicializa(ref pilha);

            foreach (char l in Frase)
            {
                if (l != ' ')
                    Empilha(ref pilha, l);
                else
                {
                    while (!EstaVazia(pilha))
                        FraseOI += Desempilha(ref pilha);
                    FraseOI += ' ';
                }
            }
            while (!EstaVazia(pilha))
                FraseOI += Desempilha(ref pilha);
            TBFraseOI.Text = FraseOI;
            */




        }

        // COPIAR ATÉ DAQUI
    }
}
