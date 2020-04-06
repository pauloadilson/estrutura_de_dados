using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _001_Pilhas
{
    public partial class Ex04B : Form
    {
        public Ex04B()
        {
            InitializeComponent();
        }

        //Stack pilha = new Stack();

        private void BTProcessa_Click(object sender, EventArgs e)
        {
            Stack pilha = new Stack();
            string Frase = TBFraseOD.Text;
            string FraseOI = "";

            foreach (char l in Frase)
            {
                if (l != ' ')
                    pilha.Push(l);
                else
                {
                    while (pilha.Count != 0)
                        FraseOI += pilha.Pop();
                    FraseOI += ' ';
                }
            }
            while (pilha.Count != 0)
                FraseOI += pilha.Pop();
            TBFraseOI.Text = FraseOI;


        }

        // COPIAR ATÉ DAQUI
    }
}
