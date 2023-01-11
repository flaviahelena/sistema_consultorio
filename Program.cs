using sistema_consultorio.br.com.projeto.view;

namespace sistema_consultorio
{
     static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmAgendamento());

            //ApplicationConfiguration.Initialize();
            //Application.Run(new frmLogin());
        }
    }
}