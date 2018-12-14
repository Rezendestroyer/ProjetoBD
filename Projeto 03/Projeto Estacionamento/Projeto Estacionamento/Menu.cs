using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Diagnostics;

namespace Projeto_Estacionamento
{
    public partial class Menu : Form
    {
        public Menu()
        {
            /*Thread t = new Thread(new ThreadStart(StartForm));
            t.Start();
            Thread.Sleep(8000);*/
            InitializeComponent();
            //t.Abort();
        }

        public void StartForm()
        {
            Application.Run(new SplashScreen());
        }

        private void bt_MenuCadCliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            CadastroCliente cadC = new CadastroCliente();
            cadC.ShowDialog();
            this.Show();
        }

        private void bt_MenuUsuario_Click(object sender, EventArgs e)
        {

        }

        private void bt_MenuEntSaidas_Click(object sender, EventArgs e)
        {
            this.Hide();
            EntradasSaidas entSaid = new EntradasSaidas();
            entSaid.ShowDialog();
            this.Show();
        }

        private void bt_MenuRelatorio_Click(object sender, EventArgs e)
        {
            this.Hide();
            Relatorio relat = new Relatorio();
            relat.ShowDialog();
            this.Show();
        }

        private void bt_MenuSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
