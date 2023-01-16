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
        
        [Display(Name = "Nome Completo", Description = "Nome e Sobrenome.")]
        [Required(ErrorMessage = "O nome completo é obrigatório.")]
        public string nome { get; set; }

        [Display(Name = "Data de nascimento", Description = "Data de nasicmento.")]
        [Required(ErrorMessage = "A data de nascimento é obrigatória.")]
        public DateTime data_nascimento { get; set; }
        public DateTime data_cadastro { get; set; }

        [Display(Name = "Cpf", Description = "Numero do cpf.")]
        [Required(ErrorMessage = "O numero do CPF é obrigatório.")]
        public string cpf { get; set; }
        public string rg { get; set; }
        public string telefone { get; set; }

        [Display(Name = "Celular", Description = "Numero do celular.")]
        [Required(ErrorMessage = "O numero do celular é obrigatório.")]
        public string celular { get; set; }
        public string email { get; set; }
        //[Required]
        public string endereco { get; set; }
        public string complemento { get; set; }
        //[Required]
        public string numero { get; set; }
        //[Required]
        public string bairro { get; set; }
        //[Required]
        public string cidade { get; set; }

        [Display(Name = "Cep", Description = "Numero do cep.")]
        [Required(ErrorMessage = "O numero do Cep é obrigatório.")]
        public string cep { get; set; }
        //[Required]
        public string estado { get; set; }
        public string sexo { get; set; }


    }
}
