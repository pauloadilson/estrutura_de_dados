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
    public partial class Ex17 : Form
    {
        public Ex17()
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
            // anterior.prox = atual; não é necessário, já recebe na atribuição
            // caso o nome não exista, a última atribuição vai ser atual = null (ultimo atual.prox)
        }
        //alterar
        private void btConsultaAlteracao_Click(object sender, EventArgs e)
        {
            //tp_no resultadoConsulta = Consulta(ref inicio, tbNomeConsultaAlterar.Text);
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
            // inicio: 10 >> no1:20 >> no2:30 >> no:40 >> nulo
            if (atual == inicio) //primeiro nó
            {
                // excluir 10
                // inicio = 10
                // while (atual != null |true| && nomeConsultado != atual.nome |false|)
                // // inicio: 10; inicio.prox = 20
                // // atual: 10; atual.prox = 20
                // // anterior: null
                // logo,    inicio = atual.prox
                //          atual = null
                // inicio: 10 >> no1:20 >> no2:30 >> no:40 >> nulo
                //sempre exlcui o ponteiro
                inicio = atual.prox;
                atual.prox = null;
            }
            else if (atual.prox == null) //ultimo nó
            {
                // inicio = 40
                // while (atual != null |true| && nomeConsultado != atual.nome |false|)
                // // inicio: 10; inicio.prox = 20
                // // atual: 40; atual.prox = null
                // // anterior: 30; anterior.prox = 40
                // logo,    inicio = atual.prox
                //          atual = null
                // inicio: 10 >> no1:20 >> no2:30 >> no:40 >> nulo
                //atual = null;
                //sempre exlcui o ponteiro
                anterior.prox = null; // senão, anterior continua apontando pro ultimo item
            }
            else
            {   //excluir 20
                //procura 20
                // // inicio: 10; inicio.prox = 20
                // // atual: 20; atual.prox = 30
                // // anterior: 10; anterior.prox = 20
                // logo,    anterior.prox = atual.prox
                //          atual = null
                // inicio: 10 >> no1:20 >> no2:30 >> no:40 >> nulo
                anterior.prox = atual.prox;
                atual.prox = null;
                //sempre exlcui o ponteiro
            }
            tbNomeExclusao.Clear();
            tbIdadeExclusao.Clear();
            tbSexoExclusao.Clear();
            tbConsultaNomeExclusao.Focus();
        }
        private void btExibeRegistros_Click(object sender, EventArgs e)
        {
            lbExibeRegistros.Items.Clear();
            Exibir();

        }
        //exibir
        void Exibir()
        {
            int i = 1;
            atual = inicio;
            //tp_no seguinte;
            while (atual != null)
            {
                //seguinte = flag.prox;
                //lbExibeRegistros.Items.Add(inicio != null ? $" Inicio: {inicio.nome} " : " Inicio: null");
                //lbExibeRegistros.Items.Add(atual != null ? $" Atual: {atual.nome} " : " Atual: null");
                //lbExibeRegistros.Items.Add(anterior != null ? $" Anterior: {anterior.nome} " : " Anterior: null");
                lbExibeRegistros.Items.Add($"Registro {i}");
                lbExibeRegistros.Items.Add($" Nome: {atual.nome}.");
                lbExibeRegistros.Items.Add($" Idade: {atual.idade} anos.");
                lbExibeRegistros.Items.Add($" Sexo: {atual.sexo}.");
                //lbExibeRegistros.Items.Add(seguinte != null ? $" Proximo Nome: {seguinte.nome}." : " Proximo Nome: Não há");
                //lbExibeRegistros.Items.Add(flag.prox != null ? $" Flag.prox: {seguinte}." : " Flag.prox: null");
                lbExibeRegistros.Items.Add(" ");
                atual = atual.prox;
                i++;
            }
        }

    }
}
