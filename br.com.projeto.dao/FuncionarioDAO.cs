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
            try
            {
                //comando SQL
                string strCmd = @"insert into tb_funcionarios (nome,data_cadastro,data_nascimento,cpf,rg,telefone,celular
                                  email,senha,endereco,numero,complemento,bairro,cidade,cep,estado,sexo) values
                                  (@nome,@data_cadastro,@data_nascimento,@cpf,@rg,@telefone,@celular
                                  @email,@senha,@endereco,@numero,@complemento,@bairro,@cidade,@cep,@estado,@sexo)";

                MySqlCommand executacmd = new MySqlCommand(strCmd, conexao);
                executacmd.Parameters.AddWithValue("@nome", obj.nome);
                executacmd.Parameters.AddWithValue("@data_cadastro", obj.data_cadastro);
                executacmd.Parameters.AddWithValue("@data_nascimento", obj.data_nascimento);
                executacmd.Parameters.AddWithValue("@cpf", obj.cpf);
                executacmd.Parameters.AddWithValue("@rg", obj.rg);
                executacmd.Parameters.AddWithValue("@telefone", obj.telefone);
                executacmd.Parameters.AddWithValue("@celular", obj.celular);
                executacmd.Parameters.AddWithValue("@senha", obj.senha);
                executacmd.Parameters.AddWithValue("@endereco", obj.endereco);
                executacmd.Parameters.AddWithValue("@numero", obj.numero);
                executacmd.Parameters.AddWithValue("@complemento", obj.complemento);
                executacmd.Parameters.AddWithValue("@bairro", obj.bairro);
                executacmd.Parameters.AddWithValue("@cidade", obj.cidade);
                executacmd.Parameters.AddWithValue("@cep", obj.cep);
                executacmd.Parameters.AddWithValue("@estado", obj.estado);
                executacmd.Parameters.AddWithValue("@sexo", obj.sexo);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Funcionario cadastrado com sucesso!");

                conexao.Close();
            }
            catch (Exception erro)
            {

                MessageBox.Show("Ocorreu o erro: " + erro);
                conexao.Close();
            }
        }
        #endregion

        #region Método para alterar funcionario
        public void AlterarFuncionario(Funcionario obj)
        {
            try
            {
                //comando SQL
                string strCmd = @"update tb_funcionarios set nome=@nome,data_cadastro=@data_cadastro,data_nascimento=@data_nascimento,
                                  cpf=@cpf,rg=@rg,telefone=@telefone,celular=@celular,email=@email,senha=@senha,
                                  endereco=@endereco,numero=@numero,complemento=@complemento,bairro=@bairro,
                                 cidade=@cidade,cep=@cep,estado=@estado,sexo=@sexo 
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
                executacmd.Parameters.AddWithValue("@senha", obj.senha);
                executacmd.Parameters.AddWithValue("@endereco", obj.endereco);
                executacmd.Parameters.AddWithValue("@numero", obj.numero);
                executacmd.Parameters.AddWithValue("@complemento", obj.complemento);
                executacmd.Parameters.AddWithValue("@bairro", obj.bairro);
                executacmd.Parameters.AddWithValue("@cidade", obj.cidade);
                executacmd.Parameters.AddWithValue("@cep", obj.cep);
                executacmd.Parameters.AddWithValue("@estado", obj.estado);
                executacmd.Parameters.AddWithValue("@sexo", obj.sexo);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Funcionario alterado com sucesso!");

                conexao.Close();
            }
            catch (Exception erro)
            {

                MessageBox.Show("Ocorreu o erro: " + erro);
                conexao.Close();
            }
        }
        #endregion  

        #region Método para excluir funcionario
        //Metodo para excluir cliente
        public void ExcluirFuncionario(Funcionario obj)
        {
            try
            {
                //definir o cmd SQL - delete
                string strCmd = @"delete from tb_funcionarios where id=@id";

                //organizar o cmd SQL
                MySqlCommand executacmd = new MySqlCommand(strCmd, conexao);
                executacmd.Parameters.AddWithValue("@id", obj.codigo);

                //abrir conexao e executar o cmd
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Funcionario excluído com sucesso!");

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
