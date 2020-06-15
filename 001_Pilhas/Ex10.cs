using System;
using System.Collections;
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
    public partial class Ex10 : Form
    {
        public Ex10()
        {
            InitializeComponent();
            vetor2 = new int[20];
            tl = 0;
        }
        void CrescenteIterativa(int nI, int nF)
        {
            LB_Resultado.Items.Clear();
            while (nI < nF)
            {
                LB_Resultado.Items.Add(nI);
                nI++;
            }
        }
        void CrescenteRecursiva(int nI, int nF)
        {
            if (nI <= nF)
            {
                LB_Resultado.Items.Add(nI);
                CrescenteRecursiva(nI+1, nF);
            }
        }
        private void btCrescenteRecursivaOnClick(object sender, EventArgs e)
        {
            int nI = Convert.ToInt32(TBNumInicial.Text);
            int nF = Convert.ToInt32(TBNumFinal.Text);
            LB_Resultado.Items.Clear();
            CrescenteRecursiva(nI, nF);
        }
        void DecrescenteRecursiva(int nI, int nF)
        {
            if (nI <= nF)
            {
                DecrescenteRecursiva(nI+1, nF);
                LB_Resultado.Items.Add(nI);
            }
        }
        void ImparesRecursiva(int nI, int nF)
        {
            if (nI <= nF)
            {
                if (nI < 0)
                    {
                    LB_Resultado.Items.Add(nI);
                    ImparesRecursiva(nI + 1, nF);
                }
            }
            
        }
        void SomatorioRecursivo(int nI, int nF, ref int s)
        {
            if (nI <= nF)
            {
                s += nI;
                SomatorioRecursivo(nI + 1, nF, ref s);
            }
        }

        private void BTAutorizaDec_Click(object sender, EventArgs e)
        {
            int nI = Convert.ToInt32(TBNumInicial.Text);
            int nF = Convert.ToInt32(TBNumFinal.Text);
            LB_Resultado.Items.Clear();
            DecrescenteRecursiva(nI, nF);
        }

        private void BTInsereFila_Click(object sender, EventArgs e)
        {
            int nI = Convert.ToInt32(TBNumInicial.Text);
            int nF = Convert.ToInt32(TBNumFinal.Text);
            LB_Resultado.Items.Clear();
            int r = 0;
            SomatorioRecursivo(nI, nF, ref r);
            LB_Resultado.Items.Clear();
            LB_Resultado.Items.Add(r);
        }

        private void BTAvioesFila_Click(object sender, EventArgs e)
        {
            int nI = Convert.ToInt32(TBNumInicial.Text);
            int nF = Convert.ToInt32(TBNumFinal.Text);
            LB_Resultado.Items.Clear();
            ImparesRecursiva(nI, nF);
        }

        //ArrayList vetor = new ArrayList();
        int[] vetor2;
        int tl; /// não se costuma atribuir aqui o valor  

        private void btInsereNoVetor_Click(object sender, EventArgs e)
        {
            //int numero = Convert.ToInt32(tbNumero.Text);
            //vetor.Add(numero);
            vetor2[tl++] = Convert.ToInt32(tbNumero.Text);
            tbNumero.Clear();
            tbNumero.Focus();

        }
        /*void SomatorioVetor(ArrayList vetor)
        {
            int somatVetor = 0;
            if (vetor.Count > 0)
            {
                somatVetor += vetor.RemoveAt(0);
                SomatorioVetor(vetor);

            }
            
            
            foreach (int number in vetor)
            {
                somatorioVetor += number;
            }
            LB_Resultado.Items.Add(somatorioVetor);
    }*/
        int SomatorioVetor(int[] vetor, int fim, int inicio)
        {
            if (inicio < fim)
                return vetor[inicio] + SomatorioVetor(vetor, fim, inicio + 1);
            else
                return vetor[inicio];
        }
        private void btSomaVetor_Click(object sender, EventArgs e)
        {
            //SomatorioVetor(vetor, vetor.Count);
            
            int i = 0;
            int s = SomatorioVetor(vetor2, tl, i);
            LB_Resultado.Items.Clear();
            LB_Resultado.Items.Add(s);
            vetor2 = new int[20];
        }
    }
}
