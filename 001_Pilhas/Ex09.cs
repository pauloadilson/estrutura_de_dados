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
    public partial class Ex09 : Form
    {
        public Ex09()
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
        private void BTInsereFila_Click(object sender, EventArgs e)
        {
            if (!EstaCheia(fila))
            {
                if (TBAviao.Text != "")
                {
                    int valor;
                    valor = Convert.ToInt32(TBAviao.Text);
                    Insere(ref fila, valor);
                    TBAviao.Text = "";
                    TBAviao.Focus(); //Evento voltar o foco para o input
                }
                else
                {
                    MessageBox.Show("Informe um número!");
                }
            }
            else
            {
                MessageBox.Show("Fila cheia!");
            }
        }
        private void TBAviao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                BTInsereFila_Click(this, new EventArgs());
        }
        private void BTQtdeFila_Click(object sender, EventArgs e)
        {
            TBQtdeFila.Text = "";
            if (!EstaVazia(fila))
                TBQtdeFila.Text = Convert.ToString(fila.fim - fila.inicio);
        }
        private void BTAutorizaDec_Click(object sender, EventArgs e)
        {
            TBAutorizaDec.Text = "";
            if (!EstaVazia(fila))
                TBAutorizaDec.Text = Convert.ToString(Remove(ref fila));
        }
        private void BTPrimeiroFila_Click(object sender, EventArgs e)
        {
            TBPrimeiroFila.Text = "";
            if (!EstaVazia(fila))
                TBPrimeiroFila.Text = Convert.ToString(fila.vetor[fila.inicio+1]);
        }
        private void BTAvioesFila_Click(object sender, EventArgs e)
        {
            LBAvioesFila.Items.Clear();
            if (!EstaVazia(fila))
            {
                int i = fila.inicio + 1;
                while (!(i == fila.fim + 1)) { 
                    LBAvioesFila.Items.Add(fila.vetor[i]);
                    i++;
                }
            }
        }

        
        // COPIAR ATÉ DAQUI
    }
}

