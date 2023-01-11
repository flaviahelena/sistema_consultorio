using sistema_consultorio.br.com.projeto.dao;
using sistema_consultorio.br.com.projeto.model;
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
    public partial class frmFuncionario : Form
    {
        public frmFuncionario()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {   
            new Helpers().LimparTela(this);
            new Helpers().DesbloqueiaEndereco(this);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Funcionario obj = new Funcionario();
            obj.nome = txtNome.Text;
            obj.data_cadastro = DateTime.Parse(txtDataCadastro.Text);
            obj.data_nascimento = DateTime.Parse(mskDataNascimento.Text);
            obj.rg = txtRG.Text; ;
            obj.email = txtEmail.Text;
            obj.senha = txtSenha.Text;
            obj.telefone = mskTelefone.Text;
            obj.celular = mskCelular.Text;
            obj.endereco = txtEndereco.Text;
            obj.numero = int.Parse(txtNum.Text);
            obj.complemento = txtComplemento.Text;
            obj.bairro = txtBairro.Text;
            obj.cidade = txtCidade.Text;
            obj.estado = txtEstado.Text;

            //conferindo qual opção de sexo está marcada
            if (rbFeminino.Checked)
            {
                obj.sexo = "F";
            }
            else
            {
                obj.sexo = "M";
            }

            Boolean validacao;
            validacao = new Helpers().ValidaInsercao(obj);

            //cria um objeto da classe FuncionarioDAO e chama o método de cadastrar
            if(validacao == false)
            {
                FuncionarioDAO dao = new FuncionarioDAO();
                dao.CadastrarFuncionario(obj);
                new Helpers().LimparTela(this);
            }
            else
            {
                MessageBox.Show("Campos faltantes!");
            }
            
        }

        private void frmFuncionario_Load(object sender, EventArgs e)
        {
            txtDataCadastro.Text = DateTime.Now.ToShortDateString();
        }
    }
}
