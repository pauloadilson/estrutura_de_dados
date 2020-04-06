using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace _001_Pilhas
{
    public partial class Ex09B : Form
    {
        public Ex09B()
        {
            InitializeComponent();
        }
        // Organização dos dados
        Queue fila = new Queue();

        private void BTInsereFila_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TBAviao.Text))
            {
                int valor;
                valor = Convert.ToInt32(TBAviao.Text);
                fila.Enqueue(valor);
                TBAviao.Clear();
                TBAviao.Focus(); //Evento voltar o foco para o input
            }
            else
                MessageBox.Show("Informe um número!");
        }
        private void TBAviao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                BTInsereFila_Click(this, new EventArgs());
        }
        private void BTQtdeFila_Click(object sender, EventArgs e)
        {
            TBQtdeFila.Text = "";
            if (fila.Count != 0)
                TBQtdeFila.Text = Convert.ToString(fila.Count);
        }
        private void BTAutorizaDec_Click(object sender, EventArgs e)
        {
            TBAutorizaDec.Text = "";
            if (fila.Count != 0)
                TBAutorizaDec.Text = Convert.ToString(fila.Dequeue());
        }
        private void BTPrimeiroFila_Click(object sender, EventArgs e)
        {
            TBPrimeiroFila.Text = "";
            if (fila.Count != 0)
                TBPrimeiroFila.Text = Convert.ToString(fila.Peek());
        }
        private void BTAvioesFila_Click(object sender, EventArgs e)
        {
            LBAvioesFila.Items.Clear();
            if (fila.Count != 0)
            {
                foreach (var item in fila.ToArray())
                    LBAvioesFila.Items.Add(item);
            }
        }


        // COPIAR ATÉ DAQUI
    }
}
