using MySqlX.XDevAPI;
using sistema_consultorio.br.com.projeto.dao;
using sistema_consultorio.br.com.projeto.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Interop;

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
            new Helpers().DesbloquearCampos(this);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Funcionario obj = new Funcionario();
            obj.nome = txtNome.Text;
            obj.data_cadastro = DateTime.Parse(txtDataCadastro.Text);
            obj.data_nascimento = DateTime.Parse(mskDataNascimento.Text);
            obj.rg = txtRG.Text; ;
            obj.cpf = mskCPF.Text;
            obj.email = txtEmail.Text;
            obj.senha = txtSenha.Text;
            obj.telefone = mskTelefone.Text;
            obj.celular = mskCelular.Text;
            obj.endereco = txtEndereco.Text;
            obj.numero = txtNum.Text;
            obj.complemento = txtComplemento.Text;
            obj.bairro = txtBairro.Text;
            obj.cidade = txtCidade.Text;
            obj.estado = cbEstado.Text;
            obj.cep = mskCep.Text;
            obj.nivel_acesso = cbNivelAcesso.Text;

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
                tbgFuncionario.DataSource = dao.ListarFuncionarios();
                new Helpers().LimparTela(this);
                new Helpers().BloquearCampos(this);
            }
            else
            {
                MessageBox.Show("Campos faltantes!");
            }
            
        }

        private void frmFuncionario_Load(object sender, EventArgs e)
        {
            txtDataCadastro.Text = DateTime.Now.ToShortDateString();

            FuncionarioDAO dao = new FuncionarioDAO();
            tbgFuncionario.DataSource = dao.ListarFuncionarios();
        }

        private void btnCep_Click(object sender, EventArgs e)
        {
            //Botao consultar CEP
            try
            {
                string cep = mskCep.Text;
                DataSet dados = new DataSet();
                string xml = "http://viacep.com.br/ws/" + cep + "/xml/";

                dados.ReadXml(xml);

                txtEndereco.Text = dados.Tables[0].Rows[0]["logradouro"].ToString();
                txtBairro.Text = dados.Tables[0].Rows[0]["bairro"].ToString();
                txtCidade.Text = dados.Tables[0].Rows[0]["localidade"].ToString();
                txtComplemento.Text = dados.Tables[0].Rows[0]["complemento"].ToString();
                cbEstado.Text = dados.Tables[0].Rows[0]["uf"].ToString();

            }
            catch (Exception)
            {

                MessageBox.Show("Cep não encontrado! Digite manualmente");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //Botao excluir
            Funcionario obj = new Funcionario();

            //pegar o codigo
            obj.codigo = int.Parse(txtCodigo.Text);

            FuncionarioDAO dao = new FuncionarioDAO();
            dao.ExcluirFuncionario(obj);
            tbgFuncionario.DataSource = dao.ListarFuncionarios();

            new Helpers().LimparTela(this);
            new Helpers().BloquearCampos(this);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            //Alterar para a guia de Consulta
            tabFuncionarios.SelectedTab = pageConsulta;
        }

        private void txtNomeConsulta_KeyPress(object sender, KeyPressEventArgs e)
        {
            string nome = "%" + txtNomeConsulta.Text + "%";

            FuncionarioDAO dao = new FuncionarioDAO();
            tbgFuncionario.DataSource = dao.ListarFuncionarioPeloNome(nome);
        }

        private void tbgFuncionario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Pegar os dados da linha selecionada
            new Helpers().LimparTela(this);
            txtCodigo.Text = tbgFuncionario.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = tbgFuncionario.CurrentRow.Cells[1].Value.ToString();
            mskDataNascimento.Text = tbgFuncionario.CurrentRow.Cells[2].Value.ToString();
            txtDataCadastro.Text = tbgFuncionario.CurrentRow.Cells[3].Value.ToString();
            txtRG.Text = tbgFuncionario.CurrentRow.Cells[4].Value.ToString();
            mskCPF.Text = tbgFuncionario.CurrentRow.Cells[5].Value.ToString();
            txtEmail.Text = tbgFuncionario.CurrentRow.Cells[6].Value.ToString();
            txtSenha.Text = tbgFuncionario.CurrentRow.Cells[7].Value.ToString();
            mskTelefone.Text = tbgFuncionario.CurrentRow.Cells[8].Value.ToString();
            mskCelular.Text = tbgFuncionario.CurrentRow.Cells[9].Value.ToString();
            mskCep.Text = tbgFuncionario.CurrentRow.Cells[10].Value.ToString();
            txtEndereco.Text = tbgFuncionario.CurrentRow.Cells[11].Value.ToString();
            txtNum.Text = tbgFuncionario.CurrentRow.Cells[12].Value.ToString();
            txtComplemento.Text = tbgFuncionario.CurrentRow.Cells[13].Value.ToString();
            txtBairro.Text = tbgFuncionario.CurrentRow.Cells[14].Value.ToString();
            txtCidade.Text = tbgFuncionario.CurrentRow.Cells[15].Value.ToString();
            cbEstado.Text = tbgFuncionario.CurrentRow.Cells[16].Value.ToString();
            string sexo = tbgFuncionario.CurrentRow.Cells[17].Value.ToString();

            if (sexo.Equals("F"))
            {
                rbFeminino.Checked = true;
            }
            else
            {
                rbMasculino.Checked = true;
            }
            
            cbNivelAcesso.Text = tbgFuncionario.CurrentRow.Cells[18].Value.ToString();

            //Alterar para a guia de Dados Pessoais
            tabFuncionarios.SelectedTab = pageDados;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Funcionario obj = new Funcionario();
            obj.codigo = int.Parse(txtCodigo.Text);
            obj.nome = txtNome.Text;
            obj.data_cadastro = DateTime.Parse(txtDataCadastro.Text);
            obj.data_nascimento = DateTime.Parse(mskDataNascimento.Text);
            obj.rg = txtRG.Text; ;
            obj.cpf = mskCPF.Text;
            obj.email = txtEmail.Text;
            obj.senha = txtSenha.Text;
            obj.telefone = mskTelefone.Text;
            obj.celular = mskCelular.Text;
            obj.endereco = txtEndereco.Text;
            obj.numero = txtNum.Text;
            obj.complemento = txtComplemento.Text;
            obj.bairro = txtBairro.Text;
            obj.cidade = txtCidade.Text;
            obj.estado = cbEstado.Text;
            obj.cep = mskCep.Text;
            obj.nivel_acesso = cbNivelAcesso.Text;
            Console.WriteLine(cbNivelAcesso.Text);
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
            if (validacao == false)
            {
                FuncionarioDAO dao = new FuncionarioDAO();
                dao.AlterarFuncionario(obj);
                tbgFuncionario.DataSource = dao.ListarFuncionarios();
                new Helpers().LimparTela(this);
                new Helpers().BloquearCampos(this);
            }
            else
            {
                MessageBox.Show("Campos faltantes!");
            }

        }

        private void btnPesquisaNome_Click(object sender, EventArgs e)
        {
            string nome = txtNomeConsulta.Text;
            FuncionarioDAO dao = new FuncionarioDAO();
            tbgFuncionario.DataSource = dao.BuscarFuncionarioNome(nome);

            if (tbgFuncionario.Rows.Count == 0)
            {
                tbgFuncionario.DataSource = dao.ListarFuncionarios();
            }
        }
    }
}
