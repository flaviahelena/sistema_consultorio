using sistema_consultorio.br.com.projeto.dao;
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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string email = txtUsuario.Text;
            string senha = txtSenha.Text;

            if(rbDentista.Checked ) 
            {
                DentistaDAO dao = new DentistaDAO();

                if(dao.EfetuarLoginDentista( email, senha))
                {
                    this.Hide();
                }
            }
            else if(rbFuncionario.Checked )
            {
                FuncionarioDAO dao = new FuncionarioDAO();

                if(dao.EfetuarLoginFuncionario( email, senha))
                {
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Selecione uma opção de usuário!");
                
            }
        }
    }
}
