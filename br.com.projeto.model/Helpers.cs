using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_consultorio.br.com.projeto.model
{
    public class Helpers
    {
        Boolean validacao = false;
        public void LimparTela(Form tela)
        {
            foreach (Control ctrPai in tela.Controls)
            {
                foreach (Control ctr1 in ctrPai.Controls)
                {
                    if (ctr1 is TabPage)
                    {
                        foreach (Control ctr2 in ctr1.Controls)
                        {
                            if (ctr2 is TextBox)
                            {
                                //Limpa o campo de texto
                                (ctr2 as TextBox).Text = string.Empty;
                            }

                            if (ctr2 is MaskedTextBox)
                            {
                                //Limpa o campo de texto
                                (ctr2 as MaskedTextBox).Text = string.Empty;
                            }

                            if (ctr2 is ComboBox)
                            {
                                //Limpa o campo de texto
                                (ctr2 as ComboBox).Text = string.Empty;
                            }
                        }
                    }
                }
            }
        }

        public void DesbloqueiaEndereco(Form tela) 
        {
            foreach (Control ctrPai in tela.Controls)
            {
                foreach (Control ctr1 in ctrPai.Controls)
                {
                    //Console.WriteLine(ctr1.Name);    
                    if (ctr1 is TextBox)
                    {
                        //desbloqueia o campo de texto
                        (ctr1 as TextBox).Enabled = true; 
                    }

                    if (ctr1 is MaskedTextBox)
                    {
                        //desbloqueia o campo de mascara
                        (ctr1 as MaskedTextBox).Enabled = true;
                    }

                    if (ctr1 is ComboBox)
                    {
                        //desbloqueia o campo de texto
                        (ctr1 as ComboBox).Enabled = true;
                    }
                    if (ctr1.Name.Equals("grupoSexo"))
                    {
                        //desbloqueia o campo de texto
                        foreach (Control ctr2 in ctr1.Controls)
                        {
                            (ctr2 as RadioButton).Enabled = true;
                        }
                            
                    }
                   

                }
            }
        }

        public Boolean ValidaInsercao(object obj)
        {
            var erros = Validacao.getValidationErros(obj);
            foreach (var error in erros)
            {
                MessageBox.Show((error.ErrorMessage));
                validacao = true;
            }

            if (validacao)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}
