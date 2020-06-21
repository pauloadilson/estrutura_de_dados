using System;
using System.Windows.Forms;
using System.Threading;

namespace _001_Pilhas
{
    public partial class Exercicios : Form
    {
        Thread nt;
        public Exercicios()
        {
            InitializeComponent();
        }

        private void Ex02_Click(object sender, EventArgs e)
        {
            nt = new Thread(Exerc);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void Exerc()
        {
            Application.Run(new Ex02());
        }

        private void Ex03_Click(object sender, EventArgs e)
        {
            nt = new Thread(Exerc03);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void Exerc03()
        {
            Application.Run(new Ex03());
        }
        private void Ex04_Click(object sender, EventArgs e)
        {
            nt = new Thread(Exerc04);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void Exerc04()
        {
            Application.Run(new Ex04());
        }
        private void Ex05_Click(object sender, EventArgs e)
        {
            nt = new Thread(Exerc05);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void Exerc05()
        {
            Application.Run(new Ex05());
        }
        //
        private void Ex07_Click(object sender, EventArgs e)
        {
            nt = new Thread(Exerc07);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void Exerc07()
        {
            Application.Run(new Ex07());
        }
        private void BTEx07B_Click(object sender, EventArgs e)
        {
            nt = new Thread(Exerc07B);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }
        /*private void Ex07B_Click(object sender, EventArgs e)
        {
            nt = new Thread(Exerc07B);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }*/

        private void Exerc07B()
        {
            Application.Run(new Ex07B());
        }
        private void Ex08_Click(object sender, EventArgs e)
        {
            nt = new Thread(Exerc08);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void Exerc08()
        {
            Application.Run(new Ex08());
        }
        private void Ex09_Click(object sender, EventArgs e)
        {
            nt = new Thread(Exerc09);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void Exerc09()
        {
            Application.Run(new Ex09());
        }

        private void BTEx09B_Click(object sender, EventArgs e)
        {
            nt = new Thread(Exerc09B);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }
        private void Exerc09B()
        {
            Application.Run(new Ex09B());
        }

        private void BTEx10_Click(object sender, EventArgs e)
        {
            nt = new Thread(Exerc10);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }
        private void Exerc10()
        {
            Application.Run(new Ex10());
        }

        private void BTEx11a15_Click(object sender, EventArgs e)
        {
            nt = new Thread(Exerc11a15);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }
        private void Exerc11a15()
        {
            Application.Run(new Ex11a15());
        }

        private void btProvaPilha_Click(object sender, EventArgs e)
        {
            nt = new Thread(ProvaDePilha);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }
        private void ProvaDePilha()
        {
            Application.Run(new ProvaPilha());
        }

        private void btProvaFila_Click(object sender, EventArgs e)
        {
            nt = new Thread(ProvaDeFila);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }
        private void ProvaDeFila()
        {
            Application.Run(new ProvaFila());
        }

        private void btProvaRecursividade_Click(object sender, EventArgs e)
        {
            nt = new Thread(ProvaDeRecursividade);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }
        private void ProvaDeRecursividade()
        {
            Application.Run(new ProvaRecursividade());
        }

        private void btEx16OnClick(object sender, EventArgs e)
        {
            nt = new Thread(Exerc16);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }
        private void Exerc16()
        {
            Application.Run(new Ex16());
        }

        private void btEx17_Click(object sender, EventArgs e)
        {
            nt = new Thread(Exerc17);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
            
        }
        private void Exerc17()
        {
            Application.Run(new Ex17());
        }

        private void btEx24_Click(object sender, EventArgs e)
        {
            nt = new Thread(Exerc24);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();

        }
        private void Exerc24()
        {
            Application.Run(new Ex24());
        }

        private void btEx26_Click(object sender, EventArgs e)
        {
            nt = new Thread(Exerc26);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();

        }
        private void Exerc26()
        {
            Application.Run(new Ex26());
        }

        private void btEx27_Click(object sender, EventArgs e)
        {
            nt = new Thread(Exerc27);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();

        }
        private void Exerc27()
        {
            Application.Run(new Ex27());
        }
    }
}
