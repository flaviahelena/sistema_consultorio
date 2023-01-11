using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistema_consultorio.br.com.projeto.view
{
    public partial class userControlDias : UserControl
    {
        public static string static_day;
        public userControlDias()
        {
            InitializeComponent();
        }

        private void userControlDias_Load(object sender, EventArgs e)
        {

        }

        public void Days(int numday)
        {
            lblDias.Text = numday +"";
        }

        private void userControlDias_Click(object sender, EventArgs e)
        {
            static_day = lblDias.Text;
            frmEvento evento= new frmEvento();
            evento.ShowDialog();
        }
    }
}
