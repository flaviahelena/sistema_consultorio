using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.Common;
using MySql.Data.MySqlClient;
using sistema_consultorio.br.com.projeto.model;

namespace sistema_consultorio.br.com.projeto.view
{
    public partial class frmEvento : Form
    {
        private MySqlConnection conexao;

        //public PacienteDAO()
        //{
        //    this.conexao = new ConnectionFactory().getconnection();
        //}

        public frmEvento()
        {
            InitializeComponent();
        }

        private void frmEvento_Load(object sender, EventArgs e)
        {
            txtData.Text = userControlDias.static_day + "/" + frmAgendamento.static_mes + "/" + frmAgendamento.static_ano;
        }

        private void btnAgendar_Click(object sender, EventArgs e)
        {
            string strCmd = @"insert into tb_calendario (nome_paciente,data,procedimento)
                              values(@nome_paciente,@data,@procedimento)";

            MySqlCommand executacmd = new MySqlCommand(strCmd, conexao);
            executacmd.Parameters.AddWithValue("@nome_paciente", txtNome.Text);
            executacmd.Parameters.AddWithValue("@data", txtData.Text);
            executacmd.Parameters.AddWithValue("@procedimento", txtProcedimento.Text);

            conexao.Open();
            executacmd.ExecuteNonQuery();

            MessageBox.Show("Consulta agendada!");
            conexao.Close();

        }
    }
}
