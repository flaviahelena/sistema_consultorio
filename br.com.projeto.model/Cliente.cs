using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_consultorio.br.com.projeto.model
{
    public class Cliente : Pessoa
    {
        public Image foto { get; set; }
        public string nome_pai { get; set; }
        public string nome_mae { get; set; }
    }
}
