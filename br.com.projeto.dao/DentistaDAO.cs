using MySql.Data.MySqlClient;
using sistema_consultorio.br.com.projeto.model;
using sistema_consultorio.br.com.projeto.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_consultorio.br.com.projeto.dao
{
    public class DentistaDAO
    {
        private MySqlConnection conexao;

        public DentistaDAO()
        {
            this.conexao = new ConnectionFactory().getconnection();
        }

        #region Método para cadastrar um dentista
        public void CadastrarDentista(Dentista obj)
        {
            try
            {
                //comando SQL
                string strCmd = @"insert into tb_dentistas (nome,data_cadastro,data_nascimento,cpf,rg,telefone,celular
                                  email,senha,nivel_acesso,endereco,numero,complemento,bairro,cidade,cep,estado,sexo,nome_pai,nome_mae) values
                                  (@nome,@data_cadastro,@data_nascimento,@cpf,@rg,@telefone,@celular
                                  @email,@senha,@nivel_acesso,@endereco,@numero,@complemento,@bairro,@cidade,@cep,@estado,@sexo,@cro,@uf_cro)";

                MySqlCommand executacmd = new MySqlCommand(strCmd, conexao);
                executacmd.Parameters.AddWithValue("@nome", obj.nome);
                executacmd.Parameters.AddWithValue("@data_cadastro", obj.data_cadastro);
                executacmd.Parameters.AddWithValue("@data_nascimento", obj.data_nascimento);
                executacmd.Parameters.AddWithValue("@cpf", obj.cpf);
                executacmd.Parameters.AddWithValue("@rg", obj.rg);
                executacmd.Parameters.AddWithValue("@telefone", obj.telefone);
                executacmd.Parameters.AddWithValue("@celular", obj.celular);
                executacmd.Parameters.AddWithValue("@email", obj.email);
                executacmd.Parameters.AddWithValue("@senha", obj.senha);
                executacmd.Parameters.AddWithValue("@nivel_acesso", obj.nivel_acesso);
                executacmd.Parameters.AddWithValue("@endereco", obj.endereco);
                executacmd.Parameters.AddWithValue("@numero", obj.numero);
                executacmd.Parameters.AddWithValue("@complemento", obj.complemento);
                executacmd.Parameters.AddWithValue("@bairro", obj.bairro);
                executacmd.Parameters.AddWithValue("@cidade", obj.cidade);
                executacmd.Parameters.AddWithValue("@cep", obj.cep);
                executacmd.Parameters.AddWithValue("@estado", obj.estado);
                executacmd.Parameters.AddWithValue("@sexo", obj.sexo);
                executacmd.Parameters.AddWithValue("@cro", obj.cro);
                executacmd.Parameters.AddWithValue("@uf_cro", obj.uf_cro);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Dentista cadastrado com sucesso!");

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
        public void AlterarDentista(Dentista obj)
        {
            try
            {
                //comando SQL
                string strCmd = @"update tb_dentistas set nome=@nome,data_cadastro=@data_cadastro,data_nascimento=@data_nascimento,
                                  cpf=@cpf,rg=@rg,telefone=@telefone,celular=@celular,email=@email,senha=@senha,nivel_acessp=@nivel_acesso,
                                  endereco=@endereco,numero=@numero,complemento=@complemento,bairro=@bairro,
                                 cidade=@cidade,cep=@cep,estado=@estado,sexo=@sexo,cro=@cro,uf_cro=@uf_cro 
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
                executacmd.Parameters.AddWithValue("@email", obj.email);
                executacmd.Parameters.AddWithValue("@senha", obj.senha);
                executacmd.Parameters.AddWithValue("@nivel_acesso", obj.nivel_acesso);
                executacmd.Parameters.AddWithValue("@endereco", obj.endereco);
                executacmd.Parameters.AddWithValue("@numero", obj.numero);
                executacmd.Parameters.AddWithValue("@complemento", obj.complemento);
                executacmd.Parameters.AddWithValue("@bairro", obj.bairro);
                executacmd.Parameters.AddWithValue("@cidade", obj.cidade);
                executacmd.Parameters.AddWithValue("@cep", obj.cep);
                executacmd.Parameters.AddWithValue("@estado", obj.estado);
                executacmd.Parameters.AddWithValue("@sexo", obj.sexo);
                executacmd.Parameters.AddWithValue("@cro", obj.cro);
                executacmd.Parameters.AddWithValue("@uf_cro", obj.uf_cro);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Dentista alterado com sucesso!");

                conexao.Close();
            }
            catch (Exception erro)
            {

                MessageBox.Show("Ocorreu o erro: " + erro);
                conexao.Close();
            }
        }
        #endregion  

        #region Método para excluir dentista
        public void ExcluirDentista(Dentista obj)
        {
            try
            {
                //definir o cmd SQL - delete
                string strCmd = @"delete from tb_dentistas where id=@id";

                //organizar o cmd SQL
                MySqlCommand executacmd = new MySqlCommand(strCmd, conexao);
                executacmd.Parameters.AddWithValue("@id", obj.codigo);

                //abrir conexao e executar o cmd
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Dentista excluído com sucesso!");

                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Ocorreu um erro: " + erro);
                conexao.Close();
            }
        }
        #endregion

        #region Método de efetuar login
        public Boolean EfetuarLoginDentista(string email, string senha)
        {
            try
            {
                //comando SQL
                string strCmd = "select * from tb_dentistas " +
                                "where email = @email and senha = @senha";

                //Organizar comando e executar
                MySqlCommand executacmd = new MySqlCommand(strCmd, conexao);
                executacmd.Parameters.AddWithValue("email", email);
                executacmd.Parameters.AddWithValue("senha", senha);

                conexao.Open();
                MySqlDataReader rd = executacmd.ExecuteReader();

                if (rd.Read())
                {
                    //login realizado com sucesso
                    string nivel = rd.GetString("nivel_acesso");
                    string nome = rd.GetString("nome");

                    MessageBox.Show("Login realizado com sucesso!");
                    frmMenu telaMenu = new frmMenu();

                    telaMenu.txtUsuario.Text = nome;

                    if (nivel.Equals("Administrador"))
                    {
                        telaMenu.Show();
                    }
                    else if (nivel.Equals("Vendedor"))
                    {


                        //telaMenu.menuProdutos.Enabled= false;
                        telaMenu.Show();
                    }

                    conexao.Close();
                    return true;
                }
                else
                {
                    //dados de entrada inválido
                    MessageBox.Show("Email ou senha incorretos!");
                    return false;
                }



            }
            catch (Exception erro)
            {
                MessageBox.Show("Ocorreu um erro: " + erro);
                return false;
            }
        }
        #endregion
    }
}
