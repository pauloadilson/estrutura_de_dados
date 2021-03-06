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
    public partial class Ex26 : Form
    {
        public Ex26()
        {
            InitializeComponent();
            Inicializa(ref vetor);
        }
        // Organização dos dados
        const int N = 5;
        tp_no[] vetor;
        tp_no atual;
        int colisoes = 0;
        void Inicializa(ref tp_no[] vet)
        {
            vet = new tp_no[N];
            for (int i = 0; i < N; i++)
                vet[i] = null;
        }
        int Hash(int chave)
        {
            return (chave % N);
        }
        tp_no BuscaLinear(int chave)
        {
            int flag = 0;
            int pos = Hash(chave);
            while (vetor[pos] == null || vetor[pos].nota != chave)
            {
                pos++;
                pos = pos % N;
                flag++;
                if (flag == N)
                    return null;
            } 
            return vetor[pos];
        }
        void InsereLinear(ref tp_no[] vet, tp_no pessoa)
        {
            int pos = Hash(pessoa.nota);
            while (vet[pos] != null)
            {
                colisoes++;
                pos++;
                pos = pos % N;
            }
            vet[pos] = pessoa;
        }
        class tp_no 
        {
            public int nota;
            public string nome, email;
        }

            private void btGravar_Click(object sender, EventArgs e)
        {
            tp_no aluno = new tp_no();
            aluno.nota = Convert.ToInt32(tbNotaIns.Text);
            aluno.nome = tbNomeIns.Text;
            aluno.email = tbEmailIns.Text;
            InsereLinear(ref vetor, aluno);
            tbNotaIns.Clear();
            tbNomeIns.Clear();
            tbEmailIns.Clear();
            tbNotaIns.Focus();
        }
        const string msgNaoEncontrado = "Nota não encontrada!";
        private void btProcurar_Click(object sender, EventArgs e)
        {
            int nota = Convert.ToInt32(tbNotaRec.Text);
            tp_no registro = BuscaLinear(nota);
            if (registro != null)
            {
                tbNomeRec.Text = registro.nome;
                tbEmailRec.Text = registro.email;
            }
            else
                MessageBox.Show(msgNaoEncontrado);
        }

        private void btExibeNumColisoes_Click(object sender, EventArgs e)
        {
            lbColisoes.Text = Convert.ToString(colisoes);
        }
    }
}
