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
    public partial class ExModelo : Form
    {
        public ExModelo()
        {
            InitializeComponent();
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
            f.inicio = f.fim =
            1;
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

        // COPIAR ATÉ DAQUI
    }
}
