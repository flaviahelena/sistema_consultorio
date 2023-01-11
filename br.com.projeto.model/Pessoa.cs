using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace sistema_consultorio.br.com.projeto.model
{
    public class Pessoa
    {
        public int codigo { get; set; }
        //[Required]
        [Display(Name = "Nome Completo", Description = "Nome e Sobrenome.")]
        [Required(ErrorMessage = "O nome completo é obrigatório.")]
        public string nome { get; set; }
        //[Required]
        public DateTime data_nascimento { get; set; }
        public DateTime data_cadastro { get; set; }

        //[Required]
        public string cpf { get; set; }
        public string rg { get; set; }
        public string telefone { get; set; }
        //[Required]
        public string celular { get; set; }
        public string email { get; set; }
        public string senha { get; set; }
        //[Required]
        public string endereco { get; set; }
        public string complemento { get; set; }
        //[Required]
        public int numero { get; set; }
        //[Required]
        public string bairro { get; set; }
        //[Required]
        public string cidade { get; set; }
        //[Required]
        public string cep { get; set; }
        //[Required]
        public string estado { get; set; }
        public string sexo { get; set; }
        //[Required]
        public string nivel_acesso { get; set; }


    }
}
