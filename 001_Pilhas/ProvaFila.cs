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
    public partial class ProvaFila : Form
    {
        public ProvaFila()
        {
            InitializeComponent();
            Inicializa(ref fila); 
            //Inicializa(ref filaNMe);
            //Inicializa(ref filaNMa);
        }
        // COPIAR A PARTIR DAQUI
        // Organização dos dados
        const int MAX = 50;
        struct tp_fila
        {
            public int inicio, fim;
            public string[] vetor; // string, não char
        }
        //tp_fila fila, filaNMe, filaNMa;
        tp_fila fila;

        // Inicialização
        void Inicializa(ref tp_fila f)
        {
            f.inicio = f.fim = 1;
            f.vetor = new string[MAX];
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
        void Insere(ref tp_fila f, string valor)
        {
            f.vetor[++f.fim] = valor;
        }

        // Remove um elemento
        string Remove(ref tp_fila f)
        {
            return (f.vetor[++f.inicio]);
        }

        private void BTInsereFila_Click(object sender, EventArgs e)
        {
            string valor;
            //Inicializa(ref fila); no load
            valor = TBValor.Text[0].ToString();
            Insere(ref fila, valor);
            TBValor.Clear();
            TBValor.Focus();
        }

        private void BTExibeFilas_Click(object sender, EventArgs e)
        {
            while (!EstaVazia(fila))
            {
                LBNumMenores.Items.Add(Remove(ref fila));
                /*remove = Remove(ref filaNMe);
                LBNumMenores.Items.Add(remove); //(Convert.ToString(remove));não precisa converter //listbox é um vetor de string; */
            }
        }

        private void BTDivide2Filas_Click(object sender, EventArgs e)
        {
            while (!EstaVazia(fila))
            {
                TBValorP.Text += Remove(ref fila);
                /*remove = Remove(ref filaNMe);
                LBNumMenores.Items.Add(remove); //(Convert.ToString(remove));não precisa converter //listbox é um vetor de string; */
            }
        }





        // COPIAR ATÉ DAQUI
    }
}

