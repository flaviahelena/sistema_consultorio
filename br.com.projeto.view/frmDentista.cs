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
    public partial class frmDentista : Form
    {
        public frmDentista()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            new Helpers().DesbloquearCampos(this);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Dentista obj = new Dentista();
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
            obj.uf_cro = cbEstadoCro.Text;
            obj.cro = int.Parse(txtCro.Text);

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
                DentistaDAO dao = new DentistaDAO();
                dao.CadastrarDentista(obj);
                tbgDentista.DataSource = dao.ListarDentistas();
                new Helpers().LimparTela(this);
                new Helpers().BloquearCampos(this);
            }
            else
            {
                MessageBox.Show("Campos faltantes!");
            }

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
            Dentista obj = new Dentista();

            //pegar o codigo
            obj.codigo = int.Parse(txtCodigo.Text);

            DentistaDAO dao = new DentistaDAO();
            dao.ExcluirDentista(obj);
            tbgDentista.DataSource = dao.ListarDentistas();

            new Helpers().LimparTela(this);
            new Helpers().BloquearCampos(this);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            //Alterar para a guia de Consulta
            tabDentista.SelectedTab = pageConsulta;
        }

        private void txtNomeConsulta_KeyPress(object sender, KeyPressEventArgs e)
        {
            string nome = "%" + txtNomeConsulta.Text + "%";

            DentistaDAO dao = new DentistaDAO();
            tbgDentista.DataSource = dao.ListarDentistaPeloNome(nome);
        }

        private void tbgDentista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Pegar os dados da linha selecionada
            new Helpers().LimparTela(this);
            txtCodigo.Text = tbgDentista.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = tbgDentista.CurrentRow.Cells[1].Value.ToString();
            mskDataNascimento.Text = tbgDentista.CurrentRow.Cells[2].Value.ToString();
            txtDataCadastro.Text = tbgDentista.CurrentRow.Cells[3].Value.ToString();
            txtRG.Text = tbgDentista.CurrentRow.Cells[4].Value.ToString();
            mskCPF.Text = tbgDentista.CurrentRow.Cells[5].Value.ToString();
            txtCro.Text = tbgDentista.CurrentRow.Cells[6].Value.ToString();
            cbEstadoCro.Text = tbgDentista.CurrentRow.Cells[7].Value.ToString();
            txtEmail.Text = tbgDentista.CurrentRow.Cells[8].Value.ToString();
            txtSenha.Text = tbgDentista.CurrentRow.Cells[9].Value.ToString();
            cbNivelAcesso.Text = tbgDentista.CurrentRow.Cells[10].Value.ToString();
            mskTelefone.Text = tbgDentista.CurrentRow.Cells[11].Value.ToString();
            mskCelular.Text = tbgDentista.CurrentRow.Cells[12].Value.ToString();
            mskCep.Text = tbgDentista.CurrentRow.Cells[13].Value.ToString();
            txtEndereco.Text = tbgDentista.CurrentRow.Cells[14].Value.ToString();
            txtNum.Text = tbgDentista.CurrentRow.Cells[15].Value.ToString();
            txtComplemento.Text = tbgDentista.CurrentRow.Cells[16].Value.ToString();
            txtBairro.Text = tbgDentista.CurrentRow.Cells[17].Value.ToString();
            txtCidade.Text = tbgDentista.CurrentRow.Cells[18].Value.ToString();
            cbEstado.Text = tbgDentista.CurrentRow.Cells[19].Value.ToString();
            string sexo = tbgDentista.CurrentRow.Cells[20].Value.ToString();

            if (sexo.Equals("F"))
            {
                rbFeminino.Checked = true;
            }
            else
            {
                rbMasculino.Checked = true;
            }

            

            //Alterar para a guia de Dados Pessoais
            tabDentista.SelectedTab = pageDados;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Dentista obj = new Dentista();
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
            obj.uf_cro = cbEstadoCro.Text;
            obj.cro = int.Parse(txtCro.Text);
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
                DentistaDAO dao = new DentistaDAO();
                dao.AlterarDentista(obj);
                tbgDentista.DataSource = dao.ListarDentistas();
                new Helpers().LimparTela(this);
                new Helpers().BloquearCampos(this);
            }
            else
            {
                MessageBox.Show("Campos faltantes!");
            }

        }

        private void frmDentista_Load(object sender, EventArgs e)
        {
            new Helpers().BloquearCampos(this);
            txtDataCadastro.Text = DateTime.Now.ToShortDateString();

            DentistaDAO dao = new DentistaDAO();
            tbgDentista.DataSource = dao.ListarDentistas();
        }

        private void btnPesquisaNome_Click(object sender, EventArgs e)
        {
            string nome = txtNomeConsulta.Text;
            DentistaDAO dao = new DentistaDAO();
            tbgDentista.DataSource = dao.BuscarDentistaNome(nome);

            if (tbgDentista.Rows.Count == 0)
            {
                tbgDentista.DataSource = dao.ListarDentistas();
            }
        }
    }
}
