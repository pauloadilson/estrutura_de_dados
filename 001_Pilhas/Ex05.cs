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
    public partial class Ex05 : Form
    {
        public Ex05()
        {
            InitializeComponent();
        }
        const int MAX = 50;
        struct tp_pilha
        {
            public int topo;
            public char[] vetor;
        }
        tp_pilha pilha;
        void Inicializa(ref tp_pilha p)
        {
            p.topo = -1;
            p.vetor = new char[MAX];
        }
        bool EstaVazia(tp_pilha p)
        {
            return (p.topo == -1);
        }
        bool EstaCheia(tp_pilha p)
        {  //verificar se esta cheia
            return (p.topo == MAX - 1);
        }
        // Insere um elemento
        void Empilha(ref tp_pilha p, char valor)
        {
            p.vetor[++p.topo] = valor;
        }
        // Remove um elemento
        char Desempilha(ref tp_pilha p)
        {
            return (p.vetor[p.topo--]);
        }

        private void BTProcessa_Click(object sender, EventArgs e)
        {
            /*
            string Expr = TBExpressao.Text;
            Inicializa(ref pilha);
            int result = 1;
            foreach (char l in Expr)
            {
                switch (l)
                {
                    case '(':
                    case '[':
                    case '{':
                        Empilha(ref pilha, l);
                        break;
                    case ')':
                        result = (Desempilha(ref pilha) == '(') ? 1 : 0;
                        break;
                    case ']':
                        result = (Desempilha(ref pilha) == '[') ? 1 : 0;
                        break;
                    case '}':
                        result = (Desempilha(ref pilha) == '{') ? 1 : 0;
                        break;
                    default:
                        result = 1;
                        break;
                }
                if (result == 0)
                    break;
                */
            string Expr = TBExpressao.Text;
            int len = Expr.Length;
            Inicializa(ref pilha);
            int flag = 1;
            for (int c = 0; c < len; c++)
            {
                if (Expr[c] == '(' || Expr[c] == '[' || Expr[c] == '{')
                    Empilha(ref pilha, Expr[c]);
                else if (Expr[c] == ')')
                    flag = EstaVazia(pilha) ? 0 : (Desempilha(ref pilha) == '(' ? 1 : 0);
                else if (Expr[c] == ']')
                    flag = EstaVazia(pilha) ? 0 : (Desempilha(ref pilha) == '[' ? 1 : 0);
                else if (Expr[c] == '}')
                    flag = EstaVazia(pilha) ? 0 : (Desempilha(ref pilha) == '{' ? 1 : 0);
                else
                    flag = 1;
                if (flag == 0)
                    break;
            }
            LResultado.Text = (EstaVazia(pilha) && flag == 1) ? "Bem formulada!" : "Mal formulada!";
        }
    }
}
