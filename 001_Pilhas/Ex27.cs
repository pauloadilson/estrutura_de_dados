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
    public partial class Ex27 : Form
    {
        public Ex27()
        {
            InitializeComponent();
            Inicializa(ref vetorST);
            Inicializa(ref vetorCTL);
            InicializaCTLE(ref vetorCTLE);
        }
        const string msgNaoEncontrado = "Idade não encontrada!";
        const int N = 5;
        // Organização dos dados
        int Hash(int chave)
        {
            return (chave % N);
        }
        struct tp_reg
        {
            public int idade;
            public string nome, sexo;
        }
        void Inicializa(ref tp_reg[] vet)
        {
            vet = new tp_reg[N];
            for (int i = 0; i < N; i++)
                vet[i].idade = 0;
        }
        ///sem tratamento
        tp_reg[] vetorST;
        tp_reg inicioST;
        //grava
        private void btGravarST_Click(object sender, EventArgs e)
        {
            tp_reg pessoa = new tp_reg();
            pessoa.idade = Convert.ToInt32(tbIdadeST.Text);
            pessoa.nome = tbNomeST.Text;
            pessoa.sexo = cbSexoST.SelectedItem.ToString(); ;
            InsereSemTratamento(ref vetorST, pessoa);
            tbIdadeST.Clear();
            tbNomeST.Clear();
            cbSexoST.SelectedIndex = -1;
            tbIdadeST.Focus();
        }
        void InsereSemTratamento(ref tp_reg[] vet, tp_reg pessoa)
        {
            int pos = Hash(pessoa.idade);
            vet[pos] = pessoa;
        }
        //consulta
        private void btConsultarST_Click(object sender, EventArgs e)
        {
            int idade = Convert.ToInt32(tbIdadeST.Text);
            int pos = BuscaLinearST(idade);
            if (vetorST[pos].idade != 0 && pos >= 0)
            {
                tbNomeST.Text = vetorST[pos].nome;
                cbSexoST.SelectedItem = vetorST[pos].sexo;
            }
            else
                MessageBox.Show(msgNaoEncontrado);
        }
        int BuscaLinearST(int chave)
        {
            int flag = 0;
            int pos = Hash(chave);
            while (vetorST[pos].idade == 0 || vetorST[pos].idade != chave)
            {
                pos++;
                pos = pos % N;
                flag++;
                if (flag == N)
                    return -1;
            }
            return pos;
        }
        //exibir
        private void btExibirST_Click_1(object sender, EventArgs e)
        {
            lbRelatorioST.Items.Clear();
            ExibirST();
        }
        void ExibirST()
        {
            foreach (tp_reg pessoa in vetorST)
            {
                if (pessoa.idade != 0)
                {
                    lbRelatorioST.Items.Add($" Idade: {pessoa.idade} anos.");
                    lbRelatorioST.Items.Add($" Nome: {pessoa.nome}.");
                    lbRelatorioST.Items.Add($" Sexo: {pessoa.sexo}.");
                    lbRelatorioST.Items.Add(" ");
                }
            }
        }

        ///com tratamento linear
        tp_reg[] vetorCTL;
        //gravar
        private void btGravarCTL_Click(object sender, EventArgs e)
        {
            tp_reg pessoa = new tp_reg();
            pessoa.idade = Convert.ToInt32(tbIdadeCTL.Text);
            pessoa.nome = tbNomeCTL.Text;
            pessoa.sexo = cbSexoCTL.SelectedItem.ToString(); ;
            InsereTratamentoLinear(ref vetorCTL, pessoa);
            tbIdadeCTL.Clear();
            tbNomeCTL.Clear();
            cbSexoCTL.SelectedIndex = -1;
            tbIdadeCTL.Focus();
        }
        void InsereTratamentoLinear(ref tp_reg[] vet, tp_reg pessoa)
        {
            int pos = Hash(pessoa.idade);
            while (vet[pos].idade != 0)
            {
                pos++;
                pos = pos % N;
            }
            vet[pos] = pessoa;
        }

        //consultar
        private void btConsultarCTL_Click(object sender, EventArgs e)
        {
            int idade = Convert.ToInt32(tbIdadeCTL.Text);
            string nome = tbNomeCTL.Text;
            int pos = BuscaLinear(idade,nome);
            if (vetorCTL[pos].idade != 0 && pos >= 0)
            {
                tbNomeCTL.Text = vetorCTL[pos].nome;
                cbSexoCTL.SelectedItem = vetorCTL[pos].sexo;
            }
            else
                MessageBox.Show(msgNaoEncontrado);
        }

        int BuscaLinear(int idade, string nome)
        {
            int flag = 0;
            int pos = Hash(idade);
            while (vetorCTL[pos].idade == 0 || vetorCTL[pos].nome != nome)
            {
                pos++;
                pos = pos % N;
                flag++;
                if (flag == N)
                    return -1;
            }
            return pos;
        }
        //alterar
        private void btAlterarCTL_Click(object sender, EventArgs e)
        {
            int nota = Convert.ToInt32(tbIdadeCTL.Text);
            string nome = tbNomeCTL.Text;
            int pos = BuscaLinear(nota, nome);
            if (vetorCTL[pos].idade != 0 && pos >= 0)
            {
                vetorCTL[pos].nome = tbNomeCTL.Text;
                vetorCTL[pos].sexo = cbSexoCTL.SelectedItem.ToString();
            }
            else
                MessageBox.Show(msgNaoEncontrado);
            tbIdadeCTL.Clear();
            tbNomeCTL.Clear();
            cbSexoCTL.SelectedIndex = -1;
            tbIdadeCTL.Focus();
        }

        //exibir
        private void btExibirCTL_Click(object sender, EventArgs e)
        {
            lbResultadoCTL.Items.Clear();
            ExibirCTL();
        }
        void ExibirCTL()
        {
            foreach (tp_reg pessoa in vetorCTL)
            {
                if (pessoa.idade != 0)
                {
                    lbResultadoCTL.Items.Add($" Idade: {pessoa.idade} anos.");
                    lbResultadoCTL.Items.Add($" Nome: {pessoa.nome}.");
                    lbResultadoCTL.Items.Add($" Sexo: {pessoa.sexo}.");
                    lbResultadoCTL.Items.Add(" ");
                }
            }
        }
        ///com tratamento lista encadeada
        class tp_reg_enc
        {
            public int idade;
            public string nome, sexo;
            public tp_reg_enc prox;
        }
        tp_reg_enc[] vetorCTLE;
        tp_reg_enc atual, anterior;

        void InicializaCTLE(ref tp_reg_enc[] vet)
        {
            vet = new tp_reg_enc[N];
            for (int i = 0; i < N; i++)
                vet[i] = null;
            atual = null;
        }
        //gravar
        private void btGravarCTLE_Click(object sender, EventArgs e)
        {
            tp_reg_enc pessoa = new tp_reg_enc();
            pessoa.idade = Convert.ToInt32(tbIdadeCTLE.Text);
            pessoa.nome = tbNomeCTLE.Text;
            pessoa.sexo = cbSexoCTLE.SelectedItem.ToString(); ;
            InsereCTLE(ref vetorCTLE, pessoa);
            tbIdadeCTLE.Clear();
            tbNomeCTLE.Clear();
            cbSexoCTLE.SelectedIndex = -1;
            tbIdadeCTLE.Focus();
        }
        void InsereCTLE(ref tp_reg_enc[] vet, tp_reg_enc no)
        {
            int pos = Hash(no.idade);
            if (vet[pos] != null)
                no.prox = vet[pos];
            vet[pos] = no;
        }
        //consultar
        private void btConsultarCTLE_Click(object sender, EventArgs e)
        {

            int nota = Convert.ToInt32(tbIdadeCTLE.Text);
            string nome = tbNomeCTLE.Text;
            BuscaListaEncadeada(nota, nome);
            if (atual != null)
            {
                cbSexoCTLE.SelectedItem = atual.sexo;
                tbNomeCTLE.Text = atual.nome;
            }
            else
                MessageBox.Show(msgNaoEncontrado);
        }
        void BuscaListaEncadeada(int idade, string nome)
        {
            anterior = null;
            foreach (tp_reg_enc pessoa in vetorCTLE)
            {
                atual = pessoa;
                if (atual == null || atual.idade != idade)
                    continue;
                while (atual != null && atual.nome != nome) 
                {
                    anterior = atual;
                    atual = atual.prox;
                }
                if (atual!= null && atual.nome == nome)
                    break;
            }
        }
        //alterar
        private void btAlterarCTLE_Click(object sender, EventArgs e)
        {
            //tp_no resultadoConsulta = Consulta(ref inicio, tbNomeConsultaAlterar.Text);
            int nota = Convert.ToInt32(tbIdadeCTLE.Text);
            string nome = tbNomeCTLE.Text;
            BuscaListaEncadeada(nota,nome);
            if (atual != null)
            {
                atual.nome = tbNomeCTLE.Text;
                atual.sexo = cbSexoCTLE.SelectedItem.ToString();
            }
            else
                MessageBox.Show(msgNaoEncontrado);
            tbIdadeCTLE.Clear();
            tbNomeCTLE.Clear();
            cbSexoCTLE.SelectedIndex = -1;
            tbIdadeCTLE.Focus();
        }

        //exibir
        private void btExibirCTLE_Click(object sender, EventArgs e)
        {
            lbResultadoCTLE.Items.Clear();
            ExibirCTLE();
        }

        void ExibirCTLE()
        {
            foreach (tp_reg_enc pessoa in vetorCTLE)
            {
                atual = pessoa;
                while (atual != null)
                {
                    lbResultadoCTLE.Items.Add($" Idade: {atual.idade} anos.");
                    lbResultadoCTLE.Items.Add($" Nome: {atual.nome}.");
                    lbResultadoCTLE.Items.Add($" Sexo: {atual.sexo}.");
                    lbResultadoCTLE.Items.Add(" ");
                    atual = atual.prox;
                }
            }
        }
    }
}
