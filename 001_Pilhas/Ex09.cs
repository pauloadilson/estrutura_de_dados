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
    { //criei uma Thread pra abrir esse componente
        public Ex09()
        {
            InitializeComponent();
            Inicializa(ref fila); // carrega a fila junto com o componente
        }
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

        private void InsereNaFilaOnClick(object sender, EventArgs e)
        {
            if (!EstaCheia(fila))
            {
                if (!String.IsNullOrEmpty(TBAviao.Text))
                {
                    int valor;
                    valor = Convert.ToInt32(TBAviao.Text);
                    Insere(ref fila, valor);
                    //InformaQuantidadeNaFilaOnClick(sender, e)//(this, new EventArgs());
                    TBAviao.Clear();
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
        private void InsereNaFilaOnKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                InsereNaFilaOnClick(sender, e);
        }
        private void MostraAvioesNaFilaOnClick(object sender, EventArgs e)
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
        private void MostraQuantidadeNaFilaOnClick(object sender, EventArgs e)
        {
            TBQtdeFila.Clear();
            //TBQtdeFila.Text = Convert.ToString(fila.fim - fila.inicio);
            int tamanhoFila = tamanho(ref fila);
            TBQtdeFila.Text = Convert.ToString(tamanhoFila);
        }
        int tamanho(ref tp_fila f)
        {
            return f.fim - f.inicio;
        }
        private void AutorizaDecolagemOnClick(object sender, EventArgs e)
        {
            TBAutorizaDec.Clear();
            if (!EstaVazia(fila))
                TBAutorizaDec.Text = Convert.ToString(Remove(ref fila));
            else
            {
                MessageBox.Show("Não há aeronaves para decolar!");
            }
        }
        private void MostraPrimeiroDaFilaOnClick(object sender, EventArgs e)
        {
            TBPrimeiroFila.Clear();
            int picoFila = pico(ref fila);
            if (!EstaVazia(fila))
                TBPrimeiroFila.Text = Convert.ToString(picoFila);
        }
        int pico(ref tp_fila f)
        {
            return f.vetor[f.inicio+1]; //inicio começa de -1, mas o indice começa em 0
        }
    }
}

