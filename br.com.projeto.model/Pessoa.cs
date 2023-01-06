using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_consultorio.br.com.projeto.model
{
    public class Pessoa
    {
        public int codigo { get; set; }
        public string nome { get; set; }
        public DateTime data_nascimento { get; set; }
        public DateTime data_cadastro { get; set; }
        public string cpf { get; set; }
        public string rg { get; set; }
        public string telefone { get; set; }
        public string celular { get; set; }
        public string email { get; set; }
        public string senha { get; set; }
        public string endereco { get; set; }
        public string complemento { get; set; }
        public int numero { get; set; }
        public string bairro { get; set; }
        public string cidade { get; set; }
        public string cep { get; set; }
        public string estado { get; set; }
        public string sexo { get; set; }
        public string nivel_acesso { get; set; }


    }
}
