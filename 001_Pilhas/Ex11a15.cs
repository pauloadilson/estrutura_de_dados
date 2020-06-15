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
    public partial class Ex11a15 : Form
    {
        public Ex11a15()
        {
            InitializeComponent();
        }

        private void ProcessarBinarioOnClick(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(tbNumeroBase10.Text);
            string binario = "";
            MostrarConversaoParaBinario(numero, ref binario); // sem retorno
            lbResultado.Items.Clear();
            lbResultado.Items.Add(binario); //add apenas um item
        }

        void MostrarConversaoParaBinario(int numero, ref string binario)
        {
            int resto;
            if (numero == 1)
                binario = Convert.ToString(numero) + binario;
            else
            {
                resto = numero % 2;
                numero = numero / 2;
                binario = Convert.ToString(resto) + binario;
                MostrarConversaoParaBinario(numero, ref binario);
            }
        }
            private void ProcessarMDCOnClick(object sender, EventArgs e)
        {
            int numX = Convert.ToInt32(tbX.Text);
            int numY = Convert.ToInt32(tbY.Text);
            int mdc = MDCRecursiva(numX, numY); //com retorno
            tbX.Clear();
            tbY.Clear();
            lbResultado.Items.Clear();
            lbResultado.Items.Add(mdc); //add apenas um item
        }
        int MDCRecursiva(int numX, int numY)
        {
            if (numX == numY)
                return numX;
            else if (numX < numY)
                return MDCRecursiva(numY, numX);
            else
                return MDCRecursiva(numX - numY, numY);
        }

        private void ProcessarPotenciaOnClick(object sender, EventArgs e)
        {
            int nBase = Convert.ToInt32(tbBase.Text);
            int nExpoente = Convert.ToInt32(tbExpoente.Text);
            int resultado = PotenciaRecursiva(nBase, nExpoente); //com retorno
            tbBase.Clear();
            tbExpoente.Clear();
            lbResultado.Items.Clear();
            lbResultado.Items.Add(resultado); //add apenas um item
        }

        int PotenciaRecursiva(int nBase, int expoente)
        {
            if (expoente > 1)
                return nBase * PotenciaRecursiva(nBase, expoente - 1);
            else
                return nBase;
        }

        private void ProcessarCubodeNNumerosOnClick(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(tbNNumerosAoCubo.Text);
            int inicio = 0;
            //int resultado = CuboRecursivo(nBase, nExpoente);//com retorno
            lbResultado.Items.Clear();
            CuboRecursivo(numero, inicio); //sem retorno
            tbNNumerosAoCubo.Clear();
            //lbResultado.Items.Add(resultado);//add apenas um item
        }
        //int CuboRecursivo(int nBase, int expoente)
        void CuboRecursivo(int NNumerosAoCubo, int inicio)
        {
            int cubo;
            if (NNumerosAoCubo == 0 || NNumerosAoCubo == 1)
                lbResultado.Items.Add(NNumerosAoCubo); // dentro da função add varios itens
            else if (inicio < NNumerosAoCubo)
            {
                cubo = inicio * inicio * inicio;
                lbResultado.Items.Add(cubo); // dentro da função add varios itens
                CuboRecursivo(NNumerosAoCubo, inicio + 1);
            }
            else
            {
                cubo = inicio * inicio * inicio;
                lbResultado.Items.Add(cubo);  // dentro da função add varios itens
            }
            /*if (expoente > 1)
                return nBase * CuboRecursivo(nBase, expoente - 1);
            else
                return nBase;*/
        }

        private void ProcessarFibonacciOnClick(object sender, EventArgs e)
        {
            int nInt = Convert.ToInt32(tbFibo.Text);
            int resultado = FiboRecursivo(nInt); //com retorno
            tbFibo.Clear();
            lbResultado.Items.Clear();
            lbResultado.Items.Add(resultado); //add apenas um item
        }
        int FiboRecursivo(int nInt)
        {
            if (nInt == 0 || nInt == 1)
                return nInt;
            else
                return FiboRecursivo(nInt - 1) + FiboRecursivo(nInt - 2);
        }
        }
    }
