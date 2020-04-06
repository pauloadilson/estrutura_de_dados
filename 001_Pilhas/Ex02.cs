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
    public partial class Ex02 : Form
    {
        public Ex02()
        {
            InitializeComponent();
        }
        private void recebeDecimal_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _ = ReleaseCapture();
                _ = SendMessage(Handle,
                            WM_NCLBUTTONDOWN,
                            HT_CAPTION,
                            0);
            }
        }
        const int MAX = 50;
        struct tp_pilha
        {
            public int topo;
            public int[] vetor;
        }
        tp_pilha pilha;
        void Inicializa(ref tp_pilha p)
        {
            p.topo = -1;
            p.vetor = new int[MAX];
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
        void Empilha(ref tp_pilha p, int valor)
        {
            p.vetor[++p.topo] = valor;
        }
        // Remove um elemento
        int Desempilha(ref tp_pilha p)
        {
            return (p.vetor[p.topo--]);
        }

        private void BConvert_Click_1(object sender, EventArgs e)
        {
            string NumBin = "";
            int NumInt;
            NumInt = Convert.ToInt32(TBNumDecimal.Text);
            Inicializa(ref pilha);
            while (NumInt != 0)
            {
                Empilha(ref pilha, NumInt % 2);
                NumInt /= 2;
            }
            while (!EstaVazia(pilha))
                NumBin += Convert.ToString(Desempilha(ref pilha));
            TBNumBinary.Text = NumBin;
        }
    }
}
