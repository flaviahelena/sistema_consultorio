namespace sistema_consultorio.br.com.projeto.view
{
    partial class frmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.dentistaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFuncionario = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPaciente = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGerencial = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConsultas = new System.Windows.Forms.ToolStripMenuItem();
            this.agendarConsultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasAgendadasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRelatorios = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFinanceiro = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtData = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCadastro,
            this.menuGerencial,
            this.menuConsultas,
            this.menuRelatorios,
            this.menuFinanceiro,
            this.menuSair});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(963, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuCadastro
            // 
            this.menuCadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dentistaToolStripMenuItem,
            this.menuFuncionario,
            this.menuPaciente});
            this.menuCadastro.Name = "menuCadastro";
            this.menuCadastro.Size = new System.Drawing.Size(71, 20);
            this.menuCadastro.Text = "Cadastros";
            // 
            // dentistaToolStripMenuItem
            // 
            this.dentistaToolStripMenuItem.Name = "dentistaToolStripMenuItem";
            this.dentistaToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.dentistaToolStripMenuItem.Text = "Dentista";
            this.dentistaToolStripMenuItem.Click += new System.EventHandler(this.dentistaToolStripMenuItem_Click);
            // 
            // menuFuncionario
            // 
            this.menuFuncionario.Name = "menuFuncionario";
            this.menuFuncionario.Size = new System.Drawing.Size(137, 22);
            this.menuFuncionario.Text = "Funcionário";
            this.menuFuncionario.Click += new System.EventHandler(this.menuFuncionario_Click);
            // 
            // menuPaciente
            // 
            this.menuPaciente.Name = "menuPaciente";
            this.menuPaciente.Size = new System.Drawing.Size(137, 22);
            this.menuPaciente.Text = "Paciente";
            // 
            // menuGerencial
            // 
            this.menuGerencial.Name = "menuGerencial";
            this.menuGerencial.Size = new System.Drawing.Size(68, 20);
            this.menuGerencial.Text = "Gerencial";
            // 
            // menuConsultas
            // 
            this.menuConsultas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agendarConsultaToolStripMenuItem,
            this.consultasAgendadasToolStripMenuItem});
            this.menuConsultas.Name = "menuConsultas";
            this.menuConsultas.Size = new System.Drawing.Size(71, 20);
            this.menuConsultas.Text = "Consultas";
            // 
            // agendarConsultaToolStripMenuItem
            // 
            this.agendarConsultaToolStripMenuItem.Name = "agendarConsultaToolStripMenuItem";
            this.agendarConsultaToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.agendarConsultaToolStripMenuItem.Text = "Agendar Consulta";
            // 
            // consultasAgendadasToolStripMenuItem
            // 
            this.consultasAgendadasToolStripMenuItem.Name = "consultasAgendadasToolStripMenuItem";
            this.consultasAgendadasToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.consultasAgendadasToolStripMenuItem.Text = "Consultas Agendadas";
            // 
            // menuRelatorios
            // 
            this.menuRelatorios.Name = "menuRelatorios";
            this.menuRelatorios.Size = new System.Drawing.Size(71, 20);
            this.menuRelatorios.Text = "Relatórios";
            // 
            // menuFinanceiro
            // 
            this.menuFinanceiro.Name = "menuFinanceiro";
            this.menuFinanceiro.Size = new System.Drawing.Size(74, 20);
            this.menuFinanceiro.Text = "Financeiro";
            // 
            // menuSair
            // 
            this.menuSair.Name = "menuSair";
            this.menuSair.Size = new System.Drawing.Size(38, 20);
            this.menuSair.Text = "Sair";
            this.menuSair.Click += new System.EventHandler(this.menuSair_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.txtData,
            this.toolStripStatusLabel3,
            this.txtHora,
            this.toolStripStatusLabel5,
            this.txtUser});
            this.statusStrip1.Location = new System.Drawing.Point(0, 555);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(963, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(36, 17);
            this.toolStripStatusLabel1.Text = "Data:";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // txtData
            // 
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(118, 17);
            this.txtData.Text = "toolStripStatusLabel2";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(37, 17);
            this.toolStripStatusLabel3.Text = "Hora:";
            // 
            // txtHora
            // 
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(118, 17);
            this.txtHora.Text = "toolStripStatusLabel4";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(113, 17);
            this.toolStripStatusLabel5.Text = "Usuario conectado:";
            // 
            // txtUser
            // 
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(118, 17);
            this.txtUser.Text = "toolStripStatusLabel6";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(963, 577);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenu";
            this.Text = "frmMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuCadastro;
        private ToolStripMenuItem dentistaToolStripMenuItem;
        private ToolStripMenuItem menuFuncionario;
        private ToolStripMenuItem menuPaciente;
        private ToolStripMenuItem menuGerencial;
        private ToolStripMenuItem menuConsultas;
        private ToolStripMenuItem menuRelatorios;
        private ToolStripMenuItem menuFinanceiro;
        private ToolStripMenuItem menuSair;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel txtData;
        private ToolStripStatusLabel toolStripStatusLabel3;
        private ToolStripStatusLabel txtHora;
        private ToolStripStatusLabel toolStripStatusLabel5;
        private ToolStripStatusLabel txtUser;
        private ToolStripMenuItem agendarConsultaToolStripMenuItem;
        private ToolStripMenuItem consultasAgendadasToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
    }
}