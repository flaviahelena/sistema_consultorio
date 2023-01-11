using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistema_consultorio.br.com.projeto.view
{
    public partial class frmAgendamento : Form
    {
        int vMonth, vYear;

        //criando variaveis estaticas 
        public static int static_mes, static_ano;
        public frmAgendamento()
        {
            InitializeComponent();
        }

        private void frmAgendamento_Load(object sender, EventArgs e)
        {
            DisplayDays();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            //limpando o container
            layoutDay.Controls.Clear();
            //decrementando mes/mes
            vMonth--;

            String nomeMes = DateTimeFormatInfo.CurrentInfo.GetMonthName(vMonth);
            lblMes.Text = nomeMes + " " + vYear;

            static_mes = vMonth;
            static_ano = vYear;
            //pegandos os primeiros dias do mês
            DateTime inicioMes = new DateTime(vYear, vMonth, 1);

            //quantidade de dias do mes
            int days = DateTime.DaysInMonth(vYear, vMonth);

            //convertendo o inicio do mes em inteiro
            int diaSemana = Convert.ToInt32(inicioMes.DayOfWeek.ToString("d")) + 1;

            //criando um controle em branco
            for (int i = 1; i < diaSemana; i++)
            {
                controleBranco cBranco = new controleBranco();
                layoutDay.Controls.Add(cBranco);
            }

            //user control para dias
            for (int i = 1; i <= days; i++)
            {
                userControlDias ucDias = new userControlDias();
                ucDias.Days(i);
                layoutDay.Controls.Add(ucDias);
            }
        }

        private void bntProximo_Click(object sender, EventArgs e)
        {   
            //limpando o container
            layoutDay.Controls.Clear();
            //incrementando mes/mes
            vMonth++;

            String nomeMes = DateTimeFormatInfo.CurrentInfo.GetMonthName(vMonth);
            lblMes.Text = nomeMes + " " + vYear;

            static_mes = vMonth;
            static_ano = vYear;
            //pegandos os primeiros dias do mês
            DateTime inicioMes = new DateTime(vYear, vMonth, 1);

            //quantidade de dias do mes
            int days = DateTime.DaysInMonth(vYear, vMonth);

            //convertendo o inicio do mes em inteiro
            int diaSemana = Convert.ToInt32(inicioMes.DayOfWeek.ToString("d")) + 1;

            //criando um controle em branco
            for (int i = 1; i < diaSemana; i++)
            {
                controleBranco cBranco = new controleBranco();
                layoutDay.Controls.Add(cBranco);
            }

            //user control para dias
            for (int i = 1; i <= days; i++)
            {
                userControlDias ucDias = new userControlDias();
                ucDias.Days(i);
                layoutDay.Controls.Add(ucDias);
            }
        }

        private void DisplayDays()
        {
            DateTime now = DateTime.Now;
            vMonth= now.Month;
            vYear= now.Year;

            String nomeMes = DateTimeFormatInfo.CurrentInfo.GetMonthName(vMonth);
            lblMes.Text = nomeMes + " " + vYear;

            static_mes = vMonth;
            static_ano = vYear;
            //pegandos os primeiros dias do mês
            DateTime inicioMes = new DateTime(vYear, vMonth, 1);

            //quantidade de dias do mes
            int days = DateTime.DaysInMonth(vYear, vMonth);

            //convertendo o inicio do mes em inteiro
            int diaSemana = Convert.ToInt32(inicioMes.DayOfWeek.ToString("d")) + 1;

            //criando um controle em branco
            for(int i=1; i< diaSemana; i++) 
            { 
                controleBranco cBranco = new controleBranco();
                layoutDay.Controls.Add(cBranco);    
            }

            //user control para dias
            for(int i = 1; i<= days; i++)
            {
                userControlDias ucDias = new userControlDias();
                ucDias.Days(i);
                layoutDay.Controls.Add(ucDias); 
            }
        }
    }
}
