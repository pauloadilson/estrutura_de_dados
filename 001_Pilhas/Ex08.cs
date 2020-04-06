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
    public partial class Ex08 : Form
    {
        public Ex08()
        {
            InitializeComponent();
            Inicializa(ref fila);
        }
        // COPIAR A PARTIR DAQUI
        // Organização dos dados
        const int MAX = 50;
        struct tp_fila
        {
            public int inicio, fim;
            public int[] vetor;
        }
        tp_fila fila;

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

        private void BTInsere_Click(object sender, EventArgs e)
        {
            if (!EstaCheia(fila))
            {
                int valor;
                valor = Convert.ToInt32(TBNum.Text);
                Insere(ref fila, valor);
                TBNum.Text = "";
                TBNum.Focus();
                //Evento voltar o foco para o input
            }
            else
                MessageBox.Show("Fila Cheia!");
        }
        private void TBNum_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BTInsere_Click(this, new EventArgs());
            }
        }


        private void BTProcessa_Click(object sender, EventArgs e)
        {
            int i = 0, remove, maiorNum = 0, menorNum = 0, soma = 0;
            double media;
            while (!EstaVazia(fila))
            {   
                remove = Remove(ref fila);
                if (i == 0)
                {
                    maiorNum = remove;
                    menorNum = remove;
                    soma += remove;
                }
                else
                {
                    if (maiorNum < remove)
                        maiorNum = remove;
                    else if (menorNum > remove)
                        menorNum = remove;
                    soma += remove;
                }
                i++;
            }
            media = (double)soma / i;
            LBNumeros.Items.Add("Menor:" + menorNum);
            LBNumeros.Items.Add("Maior:" + maiorNum);
            LBNumeros.Items.Add("Média:" + media);
            LBNumeros.Focus();
        }

        

        // COPIAR ATÉ DAQUI
    }
}

