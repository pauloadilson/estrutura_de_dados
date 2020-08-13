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
    public partial class ProvaListaEncadeada : Form
    {
        public ProvaListaEncadeada()
        {
            InitializeComponent();
            Inicializa(ref inicio);
        }
        const string msgNaoEncontrado = "Nome não encontrado!";

        class tp_no
        {
            public string nome;
            public int idade;
            public string sexo;
            public tp_no prox;
        }

        tp_no inicio;
        tp_no atual, anterior;
        // Função que inicializa
        void Inicializa(ref tp_no inicio)
        {
            inicio = null;
            atual = null;
            anterior = null;
        }
        // Função insere
        void Insere(ref tp_no inicio, tp_no no)
        {
            if (inicio != null) no.prox = inicio;
            inicio = no;
        }
        /*
        void InsereNoFim(Node no)
        {
            if (inicio != null)
            {
                atual = inicio; //auxiliar para não sobrescrever
                while (atual.prox != null)
                    atual = atual.prox;
                atual.prox = no;
            }
            else
                inicio = no;
        } */
        public void btGravarInclusao_Click(object sender, EventArgs e)
        {
            tp_no node = new tp_no(); //alocar memória, cria uma instância
            node.nome = tbNomeInclusao.Text;
            node.idade = Convert.ToInt32(tbIdadeInclusao.Text);
            node.sexo = cbSexoInclusao.SelectedItem.ToString();
            node.prox = null;
            Insere(ref inicio, node);
            tbNomeInclusao.Clear();
            tbIdadeInclusao.Clear();
            cbSexoInclusao.SelectedIndex = -1;
            tbNomeInclusao.Focus();

        }
        //busca sequencial
        void Consulta(string nomeConsultado)
        {
            anterior = null;
            atual = inicio; //auxiliar para não sobrescrever
            while (atual != null && nomeConsultado != atual.nome)
            {
                anterior = atual;
                atual = atual.prox;
            }
        }
        //alterar
        private void btConsultaAlteracao_Click(object sender, EventArgs e)
        {
            Consulta(tbNomeConsultaAlterar.Text);
            if (atual != null)
            {
                tbNomeAlteracao.Text = atual.nome;
                tbIdadeAlteracao.Text = Convert.ToString(atual.idade);
                cbSexoAlteracao.SelectedItem = atual.sexo;
            }
            else
                MessageBox.Show(msgNaoEncontrado);
        }


        private void btGravarAlteracao_Click(object sender, EventArgs e)
        {
            Consulta(tbNomeConsultaAlterar.Text);

            if (atual != null)
            {
                atual.nome = tbNomeAlteracao.Text;
                atual.idade = Convert.ToInt32(tbIdadeAlteracao.Text);
                atual.sexo = cbSexoAlteracao.SelectedItem.ToString();
            }
            else
                MessageBox.Show(msgNaoEncontrado);
            tbNomeAlteracao.Clear();
            tbIdadeAlteracao.Clear();
            cbSexoAlteracao.SelectedIndex = -1;
            tbNomeConsultaAlterar.Focus();
        }
        //excluir
        //consulta
        private void btProcurarExclusao_Click(object sender, EventArgs e)
        {
            Consulta(tbConsultaNomeExclusao.Text);
            if (atual != null)
            {
                tbNomeExclusao.Text = atual.nome;
                tbIdadeExclusao.Text = Convert.ToString(atual.idade);
                tbSexoExclusao.Text = atual.sexo;
            }
            else
                MessageBox.Show(msgNaoEncontrado);
        }
        //exclusão
        private void btExcluir_Click(object sender, EventArgs e)
        {
            if (atual == inicio) //primeiro nó
            {
                inicio = atual.prox;
                atual.prox = null;
            }
            else if (atual.prox == null) //ultimo nó
            {
                anterior.prox = null;
            }
            else
            {   
                anterior.prox = atual.prox;
                atual.prox = null;
            }
            tbNomeExclusao.Clear();
            tbIdadeExclusao.Clear();
            tbSexoExclusao.Clear();
            tbConsultaNomeExclusao.Focus();
        }
        //exibir
        private void btExibeRegistros_Click(object sender, EventArgs e)
        {
            lbExibeRegistros.Items.Clear();
            Exibir();
        }
        void Exibir()
        {
            int i = 1;
            atual = inicio;
            while (atual != null)
            {
                lbExibeRegistros.Items.Add($"Registro {i}");
                lbExibeRegistros.Items.Add($" Nome: {atual.nome}.");
                lbExibeRegistros.Items.Add($" Idade: {atual.idade} anos.");
                lbExibeRegistros.Items.Add($" Sexo: {atual.sexo}.");
                lbExibeRegistros.Items.Add(" ");
                atual = atual.prox;
                i++;
            }
        }

    }
}
