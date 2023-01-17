using MySql.Data.MySqlClient;
using sistema_consultorio.br.com.projeto.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_consultorio.br.com.projeto.dao
{
    
    public class PacienteDAO
    {
        private MySqlConnection conexao;

        public PacienteDAO()
        {
            this.conexao = new ConnectionFactory().getconnection();
        }

        #region Método para cadastrar um paciente
        public void CadastrarPaciente(Paciente obj)
        {
            try
            {
                //comando SQL
                string strCmd = @"insert into tb_pacientes (nome,data_cadastro,data_nascimento,cpf,rg,telefone,celular
                                  email,senha,endereco,numero,complemento,bairro,cidade,cep,estado,sexo,nome_pai,nome_mae) values
                                  (@nome,@data_cadastro,@data_nascimento,@cpf,@rg,@telefone,@celular
                                  @email,@senha,@endereco,@numero,@complemento,@bairro,@cidade,@cep,@estado,@sexo,@nome_pai,@nome_mae)";

                MySqlCommand executacmd = new MySqlCommand(strCmd, conexao);
                executacmd.Parameters.AddWithValue("@nome", obj.nome);
                executacmd.Parameters.AddWithValue("@data_cadastro", obj.data_cadastro);
                executacmd.Parameters.AddWithValue("@data_nascimento", obj.data_nascimento);
                executacmd.Parameters.AddWithValue("@cpf", obj.cpf);
                executacmd.Parameters.AddWithValue("@rg", obj.rg);
                executacmd.Parameters.AddWithValue("@telefone", obj.telefone);
                executacmd.Parameters.AddWithValue("@celular", obj.celular);
                executacmd.Parameters.AddWithValue("@endereco", obj.endereco);
                executacmd.Parameters.AddWithValue("@numero", obj.numero);
                executacmd.Parameters.AddWithValue("@complemento", obj.complemento);
                executacmd.Parameters.AddWithValue("@bairro", obj.bairro);
                executacmd.Parameters.AddWithValue("@cidade", obj.cidade);
                executacmd.Parameters.AddWithValue("@cep", obj.cep);
                executacmd.Parameters.AddWithValue("@estado", obj.estado);
                executacmd.Parameters.AddWithValue("@sexo", obj.sexo);
                executacmd.Parameters.AddWithValue("@nome_pai", obj.nome_pai);
                executacmd.Parameters.AddWithValue("@nome_mae", obj.nome_mae);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Paciente cadastrado com sucesso!");

                conexao.Close();
            }
            catch (Exception erro)
            {

                MessageBox.Show("Ocorreu o erro: " + erro);
                conexao.Close();
            }
        }
        #endregion

        #region Método para alterar paciente
        public void AlterarPaciente(Paciente obj)
        {
            try
            {
                //comando SQL
                string strCmd = @"update tb_pacientes set nome=@nome,data_cadastro=@data_cadastro,data_nascimento=@data_nascimento,
                                  cpf=@cpf,rg=@rg,telefone=@telefone,celular=@celular,email=@email,
                                  endereco=@endereco,numero=@numero,complemento=@complemento,bairro=@bairro,
                                 cidade=@cidade,cep=@cep,estado=@estado,sexo=@sexo,nome_mae=@nome_mae,nome_pai=@nome_pai 
                                  where id=@id";

                MySqlCommand executacmd = new MySqlCommand(strCmd, conexao);
                executacmd.Parameters.AddWithValue("@id", obj.codigo);
                executacmd.Parameters.AddWithValue("@nome", obj.nome);
                executacmd.Parameters.AddWithValue("@data_cadastro", obj.data_cadastro);
                executacmd.Parameters.AddWithValue("@data_nascimento", obj.data_nascimento);
                executacmd.Parameters.AddWithValue("@cpf", obj.cpf);
                executacmd.Parameters.AddWithValue("@rg", obj.rg);
                executacmd.Parameters.AddWithValue("@telefone", obj.telefone);
                executacmd.Parameters.AddWithValue("@celular", obj.celular);
                executacmd.Parameters.AddWithValue("@endereco", obj.endereco);
                executacmd.Parameters.AddWithValue("@numero", obj.numero);
                executacmd.Parameters.AddWithValue("@complemento", obj.complemento);
                executacmd.Parameters.AddWithValue("@bairro", obj.bairro);
                executacmd.Parameters.AddWithValue("@cidade", obj.cidade);
                executacmd.Parameters.AddWithValue("@cep", obj.cep);
                executacmd.Parameters.AddWithValue("@estado", obj.estado);
                executacmd.Parameters.AddWithValue("@sexo", obj.sexo);
                executacmd.Parameters.AddWithValue("@nome_pai", obj.nome_pai);
                executacmd.Parameters.AddWithValue("@nome_mae", obj.nome_mae);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Paciente alterado com sucesso!");

                conexao.Close();
            }
            catch (Exception erro)
            {

                MessageBox.Show("Ocorreu o erro: " + erro);
                conexao.Close();
            }
        }
        #endregion  

        #region Método para excluir paciente
        public void ExcluirPaciente(Paciente obj)
        {
            try
            {
                //definir o cmd SQL - delete
                string strCmd = @"delete from tb_pacientes where id=@id";

                //organizar o cmd SQL
                MySqlCommand executacmd = new MySqlCommand(strCmd, conexao);
                executacmd.Parameters.AddWithValue("@id", obj.codigo);

                //abrir conexao e executar o cmd
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Paciente excluído com sucesso!");

                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Ocorreu um erro: " + erro);
                conexao.Close();
            }
        }
        #endregion


    }
}
