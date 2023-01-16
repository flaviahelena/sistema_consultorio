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
                    Console.WriteLine(ctr1.Name);
                    if (ctr1 is TabPage)
                    {
                        foreach (Control ctr2 in ctr1.Controls)
                        {
                            if (ctr2 is GroupBox)
                            {
                                foreach (Control ctr3 in ctr2.Controls)
                                {
                                    Console.WriteLine(ctr2.Name);
                                    if (ctr3 is TextBox)
                                    {
                                        //desbloqueia o campo de texto
                                        if (!(ctr3.Name.Equals("txtDataCadastro")))
                                        {
                                            (ctr3 as TextBox).Text = string.Empty;
                                        }
                                        
                                    }

                                    if (ctr3 is MaskedTextBox)
                                    {
                                        //desbloqueia o campo de mascara
                                        (ctr3 as MaskedTextBox).Text = string.Empty;
                                    }

                                    if (ctr3 is ComboBox)
                                    {
                                        //desbloqueia o campo de texto
                                        (ctr3 as ComboBox).Text = string.Empty;
                                    }
                                    if (ctr3.Name.Equals("grupoSexo"))
                                    {
                                        //desbloqueia o campo de texto
                                        foreach (Control ctr4 in ctr3.Controls)
                                        {
                                            (ctr4 as RadioButton).Checked = false;
                                        }

                                    }
                                }

                            }

                        }
                    }
                }
            }
        }

        public void DesbloquearCampos(Form tela) 
        {
            foreach (Control ctrPai in tela.Controls)
            {
                foreach (Control ctr1 in ctrPai.Controls)
                {
                    Console.WriteLine(ctr1.Name);
                   if(ctr1 is TabPage)
                    {
                        foreach(Control ctr2 in ctr1.Controls)
                        {   
                            if (ctr2 is GroupBox)
                            {   
                                foreach(Control ctr3 in ctr2.Controls)
                                {
                                    Console.WriteLine(ctr2.Name);
                                    if (ctr3 is TextBox)
                                    {
                                        //desbloqueia o campo de texto
                                        (ctr3 as TextBox).Enabled = true;
                                    }

                                    if (ctr3 is MaskedTextBox)
                                    {
                                        //desbloqueia o campo de mascara
                                        (ctr3 as MaskedTextBox).Enabled = true;
                                    }

                                    if (ctr3 is ComboBox)
                                    {
                                        //desbloqueia o campo de texto
                                        (ctr3 as ComboBox).Enabled = true;
                                    }
                                    if (ctr3.Name.Equals("grupoSexo"))
                                    {
                                        //desbloqueia o campo de texto
                                        foreach (Control ctr4 in ctr3.Controls)
                                        {
                                            (ctr4 as RadioButton).Enabled = true;
                                        }

                                    }
                                }
                                
                            }
                            
                        }
                    }
                }
            }
        }

        public void BloquearCampos(Form tela)
        {
            foreach (Control ctrPai in tela.Controls)
            {
                foreach (Control ctr1 in ctrPai.Controls)
                {
                    Console.WriteLine(ctr1.Name);
                    if (ctr1 is TabPage)
                    {
                        foreach (Control ctr2 in ctr1.Controls)
                        {
                            if (ctr2 is GroupBox)
                            {
                                foreach (Control ctr3 in ctr2.Controls)
                                {
                                    Console.WriteLine(ctr2.Name);
                                    if (ctr3 is TextBox)
                                    {
                                        //desbloqueia o campo de texto
                                        (ctr3 as TextBox).Enabled = false;
                                    }

                                    if (ctr3 is MaskedTextBox)
                                    {
                                        //desbloqueia o campo de mascara
                                        (ctr3 as MaskedTextBox).Enabled = false;
                                    }

                                    if (ctr3 is ComboBox)
                                    {
                                        //desbloqueia o campo de texto
                                        (ctr3 as ComboBox).Enabled = false;
                                    }
                                    if (ctr3.Name.Equals("grupoSexo"))
                                    {
                                        //desbloqueia o campo de texto
                                        foreach (Control ctr4 in ctr3.Controls)
                                        {
                                            (ctr4 as RadioButton).Enabled = false;
                                        }

                                    }
                                }

                            }

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
