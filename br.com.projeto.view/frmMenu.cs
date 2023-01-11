using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistema_consultorio.br.com.projeto.view
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void dentistaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDentista tela = new frmDentista();
            tela.ShowDialog();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            txtData.Text = DateTime.Now.ToShortDateString();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtHora.Text = DateTime.Now.ToLongTimeString();
        }

        private void menuSair_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja sair do sistema?", "ATENÇÃO!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void menuFuncionario_Click(object sender, EventArgs e)
        {
            frmFuncionario tela = new frmFuncionario();
            tela.ShowDialog();
        }
    }
}
