namespace sistema_consultorio.br.com.projeto.view
{
    partial class frmFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFuncionario));
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mskTelefone = new System.Windows.Forms.MaskedTextBox();
            this.mskCelular = new System.Windows.Forms.MaskedTextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label21 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbNivelAcesso = new System.Windows.Forms.ComboBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDataCadastro = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mskCPF = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grupoSexo = new System.Windows.Forms.GroupBox();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.rbFeminino = new System.Windows.Forms.RadioButton();
            this.mskDataNascimento = new System.Windows.Forms.MaskedTextBox();
            this.txtRG = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.Endereço = new System.Windows.Forms.GroupBox();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.btnCep = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.mskCep = new System.Windows.Forms.MaskedTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tabFuncionarios = new System.Windows.Forms.TabControl();
            this.pageDados = new System.Windows.Forms.TabPage();
            this.pageConsulta = new System.Windows.Forms.TabPage();
            this.tbgFuncionario = new System.Windows.Forms.DataGridView();
            this.btnPesquisaNome = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.txtNomeConsulta = new System.Windows.Forms.TextBox();
            this.ttFuncionario = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grupoSexo.SuspendLayout();
            this.Endereço.SuspendLayout();
            this.tabFuncionarios.SuspendLayout();
            this.pageDados.SuspendLayout();
            this.pageConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbgFuncionario)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExcluir
            // 
            this.btnExcluir.Image = global::sistema_consultorio.Properties.Resources.remove;
            this.btnExcluir.Location = new System.Drawing.Point(12, 322);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(60, 49);
            this.btnExcluir.TabIndex = 0;
            this.ttFuncionario.SetToolTip(this.btnExcluir, "Excluir");
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Image = global::sistema_consultorio.Properties.Resources.save;
            this.btnSalvar.Location = new System.Drawing.Point(12, 212);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(60, 49);
            this.btnSalvar.TabIndex = 1;
            this.ttFuncionario.SetToolTip(this.btnSalvar, "Salvar");
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Image = global::sistema_consultorio.Properties.Resources.search;
            this.btnPesquisar.Location = new System.Drawing.Point(12, 267);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(60, 49);
            this.btnPesquisar.TabIndex = 2;
            this.ttFuncionario.SetToolTip(this.btnPesquisar, "Pesquisar");
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.Image = global::sistema_consultorio.Properties.Resources.insert2;
            this.btnInserir.Location = new System.Drawing.Point(12, 102);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(60, 49);
            this.btnInserir.TabIndex = 3;
            this.ttFuncionario.SetToolTip(this.btnInserir, "Novo");
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Image = global::sistema_consultorio.Properties.Resources.edit;
            this.btnEditar.Location = new System.Drawing.Point(12, 157);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(60, 49);
            this.btnEditar.TabIndex = 4;
            this.ttFuncionario.SetToolTip(this.btnEditar, "Editar");
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Image = global::sistema_consultorio.Properties.Resources._out;
            this.btnSair.Location = new System.Drawing.Point(12, 377);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(60, 49);
            this.btnSair.TabIndex = 5;
            this.ttFuncionario.SetToolTip(this.btnSair, "Sair");
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mskTelefone);
            this.groupBox1.Controls.Add(this.mskCelular);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Location = new System.Drawing.Point(481, 294);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(515, 179);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Contato";
            // 
            // mskTelefone
            // 
            this.mskTelefone.Enabled = false;
            this.mskTelefone.Location = new System.Drawing.Point(17, 52);
            this.mskTelefone.Mask = "(##) ####-####";
            this.mskTelefone.Name = "mskTelefone";
            this.mskTelefone.Size = new System.Drawing.Size(115, 23);
            this.mskTelefone.TabIndex = 28;
            this.mskTelefone.ValidatingType = typeof(System.DateTime);
            // 
            // mskCelular
            // 
            this.mskCelular.Enabled = false;
            this.mskCelular.Location = new System.Drawing.Point(17, 117);
            this.mskCelular.Mask = "(##) #####-####";
            this.mskCelular.Name = "mskCelular";
            this.mskCelular.Size = new System.Drawing.Size(115, 23);
            this.mskCelular.TabIndex = 27;
            this.mskCelular.ValidatingType = typeof(System.DateTime);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(17, 94);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(47, 15);
            this.label18.TabIndex = 25;
            this.label18.Text = "Celular:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(17, 34);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(54, 15);
            this.label17.TabIndex = 23;
            this.label17.Text = "Telefone:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.label21);
            this.panel1.Location = new System.Drawing.Point(-5, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1501, 89);
            this.panel1.TabIndex = 30;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI Semibold", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label21.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label21.Location = new System.Drawing.Point(365, 6);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(912, 86);
            this.label21.TabIndex = 1;
            this.label21.Text = "CADASTRO DE FUNCIONÁRIO";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtSenha);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cbNivelAcesso);
            this.groupBox2.Controls.Add(this.txtCodigo);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtDataCadastro);
            this.groupBox2.Controls.Add(this.txtNome);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.mskCPF);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.grupoSexo);
            this.groupBox2.Controls.Add(this.mskDataNascimento);
            this.groupBox2.Controls.Add(this.txtRG);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Location = new System.Drawing.Point(20, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(446, 461);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados Principais";
            // 
            // txtSenha
            // 
            this.txtSenha.Enabled = false;
            this.txtSenha.Location = new System.Drawing.Point(33, 343);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(357, 23);
            this.txtSenha.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Código:";
            // 
            // cbNivelAcesso
            // 
            this.cbNivelAcesso.Enabled = false;
            this.cbNivelAcesso.FormattingEnabled = true;
            this.cbNivelAcesso.Items.AddRange(new object[] {
            "Admnistrador",
            "Usuário"});
            this.cbNivelAcesso.Location = new System.Drawing.Point(32, 393);
            this.cbNivelAcesso.Name = "cbNivelAcesso";
            this.cbNivelAcesso.Size = new System.Drawing.Size(150, 23);
            this.cbNivelAcesso.TabIndex = 26;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(33, 53);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(100, 23);
            this.txtCodigo.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(32, 375);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 15);
            this.label9.TabIndex = 25;
            this.label9.Text = "Nível de acesso:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nome:";
            // 
            // txtDataCadastro
            // 
            this.txtDataCadastro.Location = new System.Drawing.Point(165, 53);
            this.txtDataCadastro.Name = "txtDataCadastro";
            this.txtDataCadastro.ReadOnly = true;
            this.txtDataCadastro.Size = new System.Drawing.Size(121, 23);
            this.txtDataCadastro.TabIndex = 24;
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Location = new System.Drawing.Point(33, 110);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(357, 23);
            this.txtNome.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(165, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 15);
            this.label8.TabIndex = 23;
            this.label8.Text = "Data de cadastro:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "CPF:";
            // 
            // mskCPF
            // 
            this.mskCPF.Enabled = false;
            this.mskCPF.Location = new System.Drawing.Point(33, 170);
            this.mskCPF.Mask = "###,###,###-##";
            this.mskCPF.Name = "mskCPF";
            this.mskCPF.Size = new System.Drawing.Size(149, 23);
            this.mskCPF.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 325);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 15);
            this.label7.TabIndex = 21;
            this.label7.Text = "Senha:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Data de nascimento:";
            // 
            // grupoSexo
            // 
            this.grupoSexo.Controls.Add(this.rbMasculino);
            this.grupoSexo.Controls.Add(this.rbFeminino);
            this.grupoSexo.Location = new System.Drawing.Point(190, 209);
            this.grupoSexo.Name = "grupoSexo";
            this.grupoSexo.Size = new System.Drawing.Size(200, 60);
            this.grupoSexo.TabIndex = 20;
            this.grupoSexo.TabStop = false;
            this.grupoSexo.Text = "Sexo";
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Enabled = false;
            this.rbMasculino.Location = new System.Drawing.Point(102, 29);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(80, 19);
            this.rbMasculino.TabIndex = 22;
            this.rbMasculino.TabStop = true;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            // 
            // rbFeminino
            // 
            this.rbFeminino.AutoSize = true;
            this.rbFeminino.Enabled = false;
            this.rbFeminino.Location = new System.Drawing.Point(21, 29);
            this.rbFeminino.Name = "rbFeminino";
            this.rbFeminino.Size = new System.Drawing.Size(75, 19);
            this.rbFeminino.TabIndex = 21;
            this.rbFeminino.TabStop = true;
            this.rbFeminino.Text = "Feminino";
            this.rbFeminino.UseVisualStyleBackColor = true;
            // 
            // mskDataNascimento
            // 
            this.mskDataNascimento.Enabled = false;
            this.mskDataNascimento.Location = new System.Drawing.Point(33, 227);
            this.mskDataNascimento.Mask = "00/00/0000";
            this.mskDataNascimento.Name = "mskDataNascimento";
            this.mskDataNascimento.Size = new System.Drawing.Size(115, 23);
            this.mskDataNascimento.TabIndex = 15;
            this.mskDataNascimento.ValidatingType = typeof(System.DateTime);
            // 
            // txtRG
            // 
            this.txtRG.Enabled = false;
            this.txtRG.Location = new System.Drawing.Point(211, 170);
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(179, 23);
            this.txtRG.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "E-mail:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(211, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 15);
            this.label6.TabIndex = 18;
            this.label6.Text = "RG:";
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Location = new System.Drawing.Point(33, 293);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(357, 23);
            this.txtEmail.TabIndex = 17;
            // 
            // Endereço
            // 
            this.Endereço.Controls.Add(this.cbEstado);
            this.Endereço.Controls.Add(this.btnCep);
            this.Endereço.Controls.Add(this.label16);
            this.Endereço.Controls.Add(this.txtCidade);
            this.Endereço.Controls.Add(this.label15);
            this.Endereço.Controls.Add(this.mskCep);
            this.Endereço.Controls.Add(this.label14);
            this.Endereço.Controls.Add(this.txtComplemento);
            this.Endereço.Controls.Add(this.label13);
            this.Endereço.Controls.Add(this.txtBairro);
            this.Endereço.Controls.Add(this.label12);
            this.Endereço.Controls.Add(this.txtNum);
            this.Endereço.Controls.Add(this.label11);
            this.Endereço.Controls.Add(this.txtEndereco);
            this.Endereço.Controls.Add(this.label10);
            this.Endereço.Location = new System.Drawing.Point(481, 19);
            this.Endereço.Name = "Endereço";
            this.Endereço.Size = new System.Drawing.Size(520, 257);
            this.Endereço.TabIndex = 28;
            this.Endereço.TabStop = false;
            this.Endereço.Text = "Endereço:";
            // 
            // cbEstado
            // 
            this.cbEstado.Enabled = false;
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RR",
            "RO",
            "RJ",
            "RN",
            "RS",
            "SC",
            "SP",
            "SE",
            "TO",
            ""});
            this.cbEstado.Location = new System.Drawing.Point(393, 162);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(89, 23);
            this.cbEstado.TabIndex = 26;
            // 
            // btnCep
            // 
            this.btnCep.BackgroundImage = global::sistema_consultorio.Properties.Resources.pesquisa;
            this.btnCep.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCep.Location = new System.Drawing.Point(143, 156);
            this.btnCep.Name = "btnCep";
            this.btnCep.Size = new System.Drawing.Size(33, 32);
            this.btnCep.TabIndex = 25;
            this.btnCep.UseVisualStyleBackColor = true;
            this.btnCep.Click += new System.EventHandler(this.btnCep_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(387, 144);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(45, 15);
            this.label16.TabIndex = 23;
            this.label16.Text = "Estado:";
            // 
            // txtCidade
            // 
            this.txtCidade.Enabled = false;
            this.txtCidade.Location = new System.Drawing.Point(196, 162);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(185, 23);
            this.txtCidade.TabIndex = 22;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(196, 144);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(47, 15);
            this.label15.TabIndex = 21;
            this.label15.Text = "Cidade:";
            // 
            // mskCep
            // 
            this.mskCep.Enabled = false;
            this.mskCep.Location = new System.Drawing.Point(22, 162);
            this.mskCep.Mask = "#####-###";
            this.mskCep.Name = "mskCep";
            this.mskCep.Size = new System.Drawing.Size(115, 23);
            this.mskCep.TabIndex = 20;
            this.mskCep.ValidatingType = typeof(System.DateTime);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(22, 144);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(31, 15);
            this.label14.TabIndex = 18;
            this.label14.Text = "CEP:";
            // 
            // txtComplemento
            // 
            this.txtComplemento.Enabled = false;
            this.txtComplemento.Location = new System.Drawing.Point(256, 102);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(226, 23);
            this.txtComplemento.TabIndex = 17;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(256, 84);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 15);
            this.label13.TabIndex = 16;
            this.label13.Text = "Complemento:";
            // 
            // txtBairro
            // 
            this.txtBairro.Enabled = false;
            this.txtBairro.Location = new System.Drawing.Point(22, 102);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(226, 23);
            this.txtBairro.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(22, 84);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 15);
            this.label12.TabIndex = 14;
            this.label12.Text = "Bairro:";
            // 
            // txtNum
            // 
            this.txtNum.Enabled = false;
            this.txtNum.Location = new System.Drawing.Point(399, 45);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(83, 23);
            this.txtNum.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(399, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 15);
            this.label11.TabIndex = 12;
            this.label11.Text = "Número:";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Enabled = false;
            this.txtEndereco.Location = new System.Drawing.Point(22, 45);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(347, 23);
            this.txtEndereco.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 15);
            this.label10.TabIndex = 10;
            this.label10.Text = "Rua/Av:";
            // 
            // tabFuncionarios
            // 
            this.tabFuncionarios.Controls.Add(this.pageDados);
            this.tabFuncionarios.Controls.Add(this.pageConsulta);
            this.tabFuncionarios.Location = new System.Drawing.Point(97, 102);
            this.tabFuncionarios.Name = "tabFuncionarios";
            this.tabFuncionarios.SelectedIndex = 0;
            this.tabFuncionarios.Size = new System.Drawing.Size(1022, 519);
            this.tabFuncionarios.TabIndex = 31;
            // 
            // pageDados
            // 
            this.pageDados.Controls.Add(this.Endereço);
            this.pageDados.Controls.Add(this.groupBox2);
            this.pageDados.Controls.Add(this.groupBox1);
            this.pageDados.Location = new System.Drawing.Point(4, 24);
            this.pageDados.Name = "pageDados";
            this.pageDados.Padding = new System.Windows.Forms.Padding(3);
            this.pageDados.Size = new System.Drawing.Size(1014, 491);
            this.pageDados.TabIndex = 0;
            this.pageDados.Text = "Dados Pessoais";
            this.pageDados.UseVisualStyleBackColor = true;
            // 
            // pageConsulta
            // 
            this.pageConsulta.Controls.Add(this.tbgFuncionario);
            this.pageConsulta.Controls.Add(this.btnPesquisaNome);
            this.pageConsulta.Controls.Add(this.label19);
            this.pageConsulta.Controls.Add(this.txtNomeConsulta);
            this.pageConsulta.Location = new System.Drawing.Point(4, 24);
            this.pageConsulta.Name = "pageConsulta";
            this.pageConsulta.Padding = new System.Windows.Forms.Padding(3);
            this.pageConsulta.Size = new System.Drawing.Size(1014, 491);
            this.pageConsulta.TabIndex = 1;
            this.pageConsulta.Text = "Consulta";
            this.pageConsulta.UseVisualStyleBackColor = true;
            // 
            // tbgFuncionario
            // 
            this.tbgFuncionario.AllowUserToAddRows = false;
            this.tbgFuncionario.AllowUserToDeleteRows = false;
            this.tbgFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbgFuncionario.Location = new System.Drawing.Point(41, 95);
            this.tbgFuncionario.Name = "tbgFuncionario";
            this.tbgFuncionario.ReadOnly = true;
            this.tbgFuncionario.RowTemplate.Height = 25;
            this.tbgFuncionario.Size = new System.Drawing.Size(956, 390);
            this.tbgFuncionario.TabIndex = 33;
            this.tbgFuncionario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbgFuncionario_CellClick);
            // 
            // btnPesquisaNome
            // 
            this.btnPesquisaNome.BackgroundImage = global::sistema_consultorio.Properties.Resources.search;
            this.btnPesquisaNome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPesquisaNome.Location = new System.Drawing.Point(404, 39);
            this.btnPesquisaNome.Name = "btnPesquisaNome";
            this.btnPesquisaNome.Size = new System.Drawing.Size(32, 33);
            this.btnPesquisaNome.TabIndex = 32;
            this.btnPesquisaNome.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(41, 27);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(43, 15);
            this.label19.TabIndex = 10;
            this.label19.Text = "Nome:";
            // 
            // txtNomeConsulta
            // 
            this.txtNomeConsulta.Location = new System.Drawing.Point(41, 45);
            this.txtNomeConsulta.Name = "txtNomeConsulta";
            this.txtNomeConsulta.Size = new System.Drawing.Size(357, 23);
            this.txtNomeConsulta.TabIndex = 11;
            this.txtNomeConsulta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomeConsulta_KeyPress);
            // 
            // frmFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 637);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.tabFuncionarios);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Funcionário";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmFuncionario_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grupoSexo.ResumeLayout(false);
            this.grupoSexo.PerformLayout();
            this.Endereço.ResumeLayout(false);
            this.Endereço.PerformLayout();
            this.tabFuncionarios.ResumeLayout(false);
            this.pageDados.ResumeLayout(false);
            this.pageConsulta.ResumeLayout(false);
            this.pageConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbgFuncionario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnExcluir;
        private Button btnSalvar;
        private Button btnPesquisar;
        private Button btnInserir;
        private Button btnEditar;
        private Button btnSair;
        private GroupBox groupBox1;
        private MaskedTextBox mskTelefone;
        private MaskedTextBox mskCelular;
        private Label label18;
        private Label label17;
        private Panel panel1;
        private Label label21;
        private GroupBox groupBox2;
        private TextBox txtSenha;
        private Label label1;
        private ComboBox cbNivelAcesso;
        private TextBox txtCodigo;
        private Label label9;
        private Label label2;
        private TextBox txtDataCadastro;
        private TextBox txtNome;
        private Label label8;
        private Label label3;
        private MaskedTextBox mskCPF;
        private Label label7;
        private Label label4;
        private GroupBox grupoSexo;
        private RadioButton rbMasculino;
        private RadioButton rbFeminino;
        private MaskedTextBox mskDataNascimento;
        private TextBox txtRG;
        private Label label5;
        private Label label6;
        private TextBox txtEmail;
        private GroupBox Endereço;
        private Label label16;
        private TextBox txtCidade;
        private Label label15;
        private MaskedTextBox mskCep;
        private Label label14;
        private TextBox txtComplemento;
        private Label label13;
        private TextBox txtBairro;
        private Label label12;
        private TextBox txtNum;
        private Label label11;
        private TextBox txtEndereco;
        private Label label10;
        private TabControl tabFuncionarios;
        private TabPage pageDados;
        private TabPage pageConsulta;
        private Button btnCep;
        private ComboBox cbEstado;
        private DataGridView tbgFuncionario;
        private Button btnPesquisaNome;
        private Label label19;
        private TextBox txtNomeConsulta;
        private ToolTip ttFuncionario;
    }
}