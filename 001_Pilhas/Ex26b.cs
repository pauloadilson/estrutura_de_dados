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
    public partial class Ex26b : Form
    {
        public Ex26b()
        {
            InitializeComponent();
            InicializaEnc(ref vetorEnc);
        }
        // Organização dos dados
        const int N = 5;
        int Hash(int chave)
        {
            return (chave % N);
        }
        tp_no Busca(int chave)
        {
            int flag = 0;
            int pos = Hash(chave);
            while (vetorEnc[pos] == null || vetorEnc[pos].nota != chave)
            {
                pos++;
                pos = pos % N;
                flag++;
                if (flag == N)
                    return null;
            }
            return vetorEnc[pos];
        }

        class tp_no
        {
            public int nota;
            public string nome, email;
            public tp_no prox;
        }
        tp_no[] vetorEnc;
        void InicializaEnc(ref tp_no[] vet)
        {
            vet = new tp_no[N];
            for (int i = 0; i < N; i++)
                vet[i] = null;
        }
        void InsereEnc(ref tp_no[] vet, tp_no no)
        {
            int pos = Hash(no.nota);
            if (vet[pos] != null)
                no.prox = vet[pos];
            vet[pos] = no;
        }

        private void btGravar_Click(object sender, EventArgs e)
        {
            tp_no aluno = new tp_no();
            aluno.nota = Convert.ToInt32(tbNotaIns.Text);
            aluno.nome = tbNomeIns.Text;
            aluno.email = tbEmailIns.Text;
            aluno.prox = null;
            InsereEnc(ref vetorEnc, aluno);
            tbNotaIns.Clear();
            tbNomeIns.Clear();
            tbEmailIns.Clear();
            tbNotaIns.Focus();
        }
        const string msgNaoEncontrado = "Nome não encontrado!";
        private void btProcurar_Click(object sender, EventArgs e)
        {
            int nota = Convert.ToInt32(tbNotaRec.Text);
            tp_no atual = Busca(nota);
            if (atual != null)
            {
                //tbNomeRec.Text = atual.nome;
                //tbEmailRec.Text = atual.email;
            }
            else
                MessageBox.Show(msgNaoEncontrado);
        }

        private void btExibeNumColisoes_Click(object sender, EventArgs e)
        {

        }
    }
}
