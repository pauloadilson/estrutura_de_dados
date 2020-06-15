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
    public partial class Ex24 : Form
    {
        public Ex24()
        {
            InitializeComponent();
            Inicializa(ref raiz);
        }
        class tp_no
        {
            public tp_no esq;
            public int valor;
            public tp_no dir;
        }
        tp_no raiz;
        void Inicializa(ref tp_no T)
        {
            T = null;
        }
        //Inserir
        void Insere(ref tp_no T, int X)
        {
            if (T == null)
            {
                T = new tp_no();
                T.valor = X;
                T.esq = T.dir = null;
            }
            else if (X < T.valor)
                Insere(ref T.esq, X);
            else
                Insere(ref T.dir, X);
        }
        private void btInserir_Click(object sender, EventArgs e)
        {
            int valor = Convert.ToInt32(tbNomeConsultaAlterar.Text);
            Insere(ref raiz, valor);
            tbNomeConsultaAlterar.Clear();
            tbNomeConsultaAlterar.Focus();
        }

        //Procurar
        tp_no Busca(tp_no T, int X)
        {
            if (T == null)
                return null;
            else if (X == T.valor)
                return T;
            else if (X < T.valor) // <-- esquerda se x é menor
                return Busca(T.esq, X);
            else //direita --> se x é maior
                return Busca(T.dir, X);
        }
        private void btPesquisar_Click(object sender, EventArgs e)
        {
            int valor = Convert.ToInt32(tbNomeConsultaAlterar.Text);
            tp_no flag = Busca(raiz, valor);
            if (flag != null)
                MessageBox.Show($"Número {valor} encontrado!");
            else
                MessageBox.Show($"Número {valor} não encontrado!");
            tbNomeConsultaAlterar.Clear();
            tbNomeConsultaAlterar.Focus();
        }
        //Retornar o maior
        tp_no RetornaMaior(ref tp_no T)
        {
            if (T.dir == null)
            {
                tp_no P = T;
                T = T.esq;
                return P;
            }
            else
                return RetornaMaior(ref T.dir);
        }
        //Remover
        tp_no Remove(ref tp_no T, int X) // recursividade
        {
            if (T == null) // elemento nao encontrado
                return null;
            else if (X == T.valor) // elemento encontrado Retorna P e exclui e rearranja
            {
                tp_no P = T;
                if (T.esq == null) // nao tem filho esquerdo/menor
                    T = T.dir;  // T é igual o filho direito
                else if (T.dir == null) // nao tem filho direito
                    T = T.esq;
                else
                { // tem ambos os filhos
                    P = RetornaMaior(ref T.esq); 
                    T.valor = P.valor;
                }
                return P;
            }
            else if (X < T.valor)
                return Remove(ref T.esq, X); // procura na subarvore esquerda //// recursividade
            else
                return Remove(ref T.dir, X); // procura na subarvore direta // recursividade
        } // maior n
        private void btRemover_Click(object sender, EventArgs e)
        {
            int valor = Convert.ToInt32(tbNomeConsultaAlterar.Text);
            tp_no flag = Remove(ref raiz, valor);
            if (flag != null)
                MessageBox.Show($"Número {valor} removido com sucesso!");
            else
                MessageBox.Show($"Número {valor} não encontrado!");
            tbNomeConsultaAlterar.Clear();
            tbNomeConsultaAlterar.Focus();
        }

        //Em ordem
        void EmOrdem(tp_no T)
        {
            if (T != null)
            {
                EmOrdem(T.esq);
                lbExibeArvore.Items.Add(T.valor);
                EmOrdem(T.dir);
            }
        }
        //Pre ordem
        void PreOrdem(tp_no T)
        {
            if (T != null)
            {
                lbExibeArvore.Items.Add(T.valor);
                PreOrdem(T.esq);
                PreOrdem(T.dir);
            }
        }
        //Pos ordem
        void PosOrdem(tp_no T)
        {
            if (T != null)
            {
                PosOrdem(T.esq);
                PosOrdem(T.dir);
                lbExibeArvore.Items.Add(T.valor);
            }
        }
        private void btExibirArvoreBinaria_Click(object sender, EventArgs e)
        {
            lbExibeArvore.Items.Clear();
            if (rbEmOrdem.Checked)
                EmOrdem(raiz);
            else if (rbPreOrdem.Checked)
                PreOrdem(raiz);
            else if (rbPosOrdem.Checked)
                PosOrdem(raiz);
        }
    }
}
