﻿using System;
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
        const string msgNaoEncontrado = "Nome não encontrado!";
        const int N = 5;
        // Organização dos dados
        int Hash(int chave)
        {
            return (chave % N);
        }
        class tp_reg
        {
            public int idade;
            public string nome, sexo;
        }
        void Inicializa(ref tp_reg[] vet)
        {
            vet = new tp_reg[N];
            for (int i = 0; i < N; i++)
                vet[i] = null;
        }
        ///sem tratamento
        tp_reg[] vetorST;
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
            int nota = Convert.ToInt32(tbIdadeST.Text);
            tp_reg registro = BuscaLinearST(nota);
            if (registro != null)
            {
                tbNomeST.Text = registro.nome;
                cbSexoST.SelectedItem = registro.sexo;
            }
            else
                MessageBox.Show(msgNaoEncontrado);
        }
        tp_reg BuscaLinearST(int chave)
        {
            int flag = 0;
            int pos = Hash(chave);
            while (vetorST[pos] == null || vetorST[pos].idade != chave)
            {
                pos++;
                pos = pos % N;
                flag++;
                if (flag == N)
                    return null;
            }
            return vetorST[pos];
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
                if (pessoa != null)
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
            while (vet[pos] != null)
            {
                pos++;
                pos = pos % N;
            }
            vet[pos] = pessoa;
        }

        //consultar
        private void btConsultarCTL_Click(object sender, EventArgs e)
        {
            int nota = Convert.ToInt32(tbIdadeCTL.Text);
            tp_reg registro = BuscaLinear(nota);
            if (registro != null)
            {
                tbNomeCTL.Text = registro.nome;
                cbSexoCTL.SelectedItem = registro.sexo;
            }
            else
                MessageBox.Show(msgNaoEncontrado);
        }
        tp_reg BuscaLinear(int chave)
        {
            int flag = 0;
            int pos = Hash(chave);
            while (vetorCTL[pos] == null || vetorCTL[pos].idade != chave)
            {
                pos++;
                pos = pos % N;
                flag++;
                if (flag == N)
                    return null;
            }
            return vetorCTL[pos];
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
                if (pessoa != null)
                {
                    lbResultadoCTL.Items.Add($" Idade: {pessoa.idade} anos.");
                    lbResultadoCTL.Items.Add($" Nome: {pessoa.nome}.");
                    lbResultadoCTL.Items.Add($" Sexo: {pessoa.sexo}.");
                    lbResultadoCTL.Items.Add(" ");
                }
            }
        }
        ///com tratamento linear
        class tp_reg_enc
        {
            public int idade;
            public string nome, sexo;
            public tp_reg_enc prox;
        }
        tp_reg_enc[] vetorCTLE;
        tp_reg_enc atual;

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
                    lbResultadoCTLE.Items.Add($" Idade: {pessoa.idade} anos.");
                    lbResultadoCTLE.Items.Add($" Nome: {pessoa.nome}.");
                    lbResultadoCTLE.Items.Add($" Sexo: {pessoa.sexo}.");
                    lbResultadoCTLE.Items.Add(" ");
                    atual = atual.prox;
                }
            }
        }
    }
}