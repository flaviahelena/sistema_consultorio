using MySql.Data.MySqlClient;
using sistema_consultorio.br.com.projeto.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_consultorio.br.com.projeto.dao
{
    public class FuncionarioDAO
    {
        private MySqlConnection conexao;
        public FuncionarioDAO()
        {
            this.conexao = new ConnectionFactory().getconnection();
        }

        #region Método para cadastrar um funcionario
        public void CadastrarFuncionario (Funcionario obj)
        {

        }
        #endregion
    }
}
