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
    public partial class Ex16 : Form
    {
        public Ex16()
        {
            InitializeComponent();
            Inicializa(ref inicio);
        }
        // Organização dos dados
        class tp_no
        {
            public int valor;
            public tp_no prox;
        }
        tp_no inicio;
        // Função que inicializa
        void Inicializa(ref tp_no l)
        {
            l = null;
        }
        // Função insere
        void Insere(ref tp_no l, tp_no no)
        {
            if (l != null) no.prox = l;
            l = no;
        }
        // Evento clique botão insere

        private void BTInsere_Click(object sender, EventArgs e)
        {
            tp_no no = new tp_no(); //alocar memória, cria uma instância
            no.valor = Convert.ToInt32(tbNum.Text);
            no.prox = null;
            Insere(ref inicio, no);
            tbNum.Clear(); //Clear é melhor que .Text = ""
            tbNum.Focus();
        }
        // Função remove
        tp_no Remove(ref tp_no l)
        {
            tp_no no = null;
            if (l != null)
            {
                no = l;
                l = l.prox;
                no.prox = null;
            }
            return no;
        }

        private void BTProcessa_Click(object sender, EventArgs e)
        {
            tp_no no = Remove(ref inicio);
            if (no != null)
                lbNumerosRemovidos.Items.Add(no.valor);
            else
                MessageBox.Show("Vazia");
        }
    }
}
