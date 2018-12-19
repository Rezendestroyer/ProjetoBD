namespace Projeto_Estacionamento
{
    partial class CadastroCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroCliente));
            this.lb_CadCNome = new System.Windows.Forms.Label();
            this.lb_CadCCPF = new System.Windows.Forms.Label();
            this.lb_CadCCelular = new System.Windows.Forms.Label();
            this.lb_CadCEndereco = new System.Windows.Forms.Label();
            this.tb_CadCNome = new System.Windows.Forms.TextBox();
            this.mtb_CadCCPF = new System.Windows.Forms.MaskedTextBox();
            this.mtb_CadCCelular = new System.Windows.Forms.MaskedTextBox();
            this.tb_CadCEndereco = new System.Windows.Forms.TextBox();
            this.panel_CadCCliente = new System.Windows.Forms.Panel();
            this.cb_CadCEstado = new System.Windows.Forms.ComboBox();
            this.lb_CadCCEP = new System.Windows.Forms.Label();
            this.lb_CadCEstado = new System.Windows.Forms.Label();
            this.tb_CadCCidade = new System.Windows.Forms.TextBox();
            this.lb_CadCCidade = new System.Windows.Forms.Label();
            this.tb_CadCBairro = new System.Windows.Forms.TextBox();
            this.lb_CadCBairro = new System.Windows.Forms.Label();
            this.tb_CadCNumero = new System.Windows.Forms.TextBox();
            this.lb_CadCNumero = new System.Windows.Forms.Label();
            this.mtb_CadCTelefone = new System.Windows.Forms.MaskedTextBox();
            this.lb_CadCTelefone = new System.Windows.Forms.Label();
            this.mtb_CadCCEP = new System.Windows.Forms.MaskedTextBox();
            this.cb_CadCCPF = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bt_CadCSair = new System.Windows.Forms.Button();
            this.bt_CadCConsultar = new System.Windows.Forms.Button();
            this.bt_CadCAtualizar = new System.Windows.Forms.Button();
            this.bt_CadCCadastrar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bt_CadCExcluir = new System.Windows.Forms.Button();
            this.bt_CadCCancelar = new System.Windows.Forms.Button();
            this.bt_CadCConfirmar = new System.Windows.Forms.Button();
            this.bt_CadCVeiculos = new System.Windows.Forms.Button();
            this.panel_CadCConsultar = new System.Windows.Forms.Panel();
            this.bt_CadCPesquisar = new System.Windows.Forms.Button();
            this.dg_CadCConsulta = new System.Windows.Forms.DataGridView();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tb_CadCPesquisa = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_CadCCliente.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel_CadCConsultar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_CadCConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_CadCNome
            // 
            this.lb_CadCNome.AutoSize = true;
            this.lb_CadCNome.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CadCNome.Location = new System.Drawing.Point(9, 10);
            this.lb_CadCNome.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_CadCNome.Name = "lb_CadCNome";
            this.lb_CadCNome.Size = new System.Drawing.Size(65, 22);
            this.lb_CadCNome.TabIndex = 1;
            this.lb_CadCNome.Text = "Nome:";
            // 
            // lb_CadCCPF
            // 
            this.lb_CadCCPF.AutoSize = true;
            this.lb_CadCCPF.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CadCCPF.Location = new System.Drawing.Point(9, 75);
            this.lb_CadCCPF.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_CadCCPF.Name = "lb_CadCCPF";
            this.lb_CadCCPF.Size = new System.Drawing.Size(46, 22);
            this.lb_CadCCPF.TabIndex = 2;
            this.lb_CadCCPF.Text = "CPF:";
            // 
            // lb_CadCCelular
            // 
            this.lb_CadCCelular.AutoSize = true;
            this.lb_CadCCelular.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CadCCelular.Location = new System.Drawing.Point(383, 75);
            this.lb_CadCCelular.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_CadCCelular.Name = "lb_CadCCelular";
            this.lb_CadCCelular.Size = new System.Drawing.Size(74, 22);
            this.lb_CadCCelular.TabIndex = 3;
            this.lb_CadCCelular.Text = "Celular:";
            // 
            // lb_CadCEndereco
            // 
            this.lb_CadCEndereco.AutoSize = true;
            this.lb_CadCEndereco.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CadCEndereco.Location = new System.Drawing.Point(146, 140);
            this.lb_CadCEndereco.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_CadCEndereco.Name = "lb_CadCEndereco";
            this.lb_CadCEndereco.Size = new System.Drawing.Size(93, 22);
            this.lb_CadCEndereco.TabIndex = 4;
            this.lb_CadCEndereco.Text = "Endereço:";
            // 
            // tb_CadCNome
            // 
            this.tb_CadCNome.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_CadCNome.Location = new System.Drawing.Point(13, 37);
            this.tb_CadCNome.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tb_CadCNome.Name = "tb_CadCNome";
            this.tb_CadCNome.Size = new System.Drawing.Size(549, 33);
            this.tb_CadCNome.TabIndex = 0;
            // 
            // mtb_CadCCPF
            // 
            this.mtb_CadCCPF.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtb_CadCCPF.Location = new System.Drawing.Point(13, 102);
            this.mtb_CadCCPF.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.mtb_CadCCPF.Mask = "000,000,000-00";
            this.mtb_CadCCPF.Name = "mtb_CadCCPF";
            this.mtb_CadCCPF.Size = new System.Drawing.Size(175, 33);
            this.mtb_CadCCPF.TabIndex = 1;
            this.mtb_CadCCPF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mtb_CadCCelular
            // 
            this.mtb_CadCCelular.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtb_CadCCelular.Location = new System.Drawing.Point(387, 102);
            this.mtb_CadCCelular.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.mtb_CadCCelular.Mask = "(00) 00000-0000";
            this.mtb_CadCCelular.Name = "mtb_CadCCelular";
            this.mtb_CadCCelular.Size = new System.Drawing.Size(175, 33);
            this.mtb_CadCCelular.TabIndex = 3;
            this.mtb_CadCCelular.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_CadCEndereco
            // 
            this.tb_CadCEndereco.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_CadCEndereco.Location = new System.Drawing.Point(150, 167);
            this.tb_CadCEndereco.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tb_CadCEndereco.Name = "tb_CadCEndereco";
            this.tb_CadCEndereco.Size = new System.Drawing.Size(300, 33);
            this.tb_CadCEndereco.TabIndex = 5;
            // 
            // panel_CadCCliente
            // 
            this.panel_CadCCliente.Controls.Add(this.cb_CadCEstado);
            this.panel_CadCCliente.Controls.Add(this.lb_CadCCEP);
            this.panel_CadCCliente.Controls.Add(this.lb_CadCEstado);
            this.panel_CadCCliente.Controls.Add(this.tb_CadCCidade);
            this.panel_CadCCliente.Controls.Add(this.lb_CadCCidade);
            this.panel_CadCCliente.Controls.Add(this.tb_CadCBairro);
            this.panel_CadCCliente.Controls.Add(this.lb_CadCBairro);
            this.panel_CadCCliente.Controls.Add(this.tb_CadCNumero);
            this.panel_CadCCliente.Controls.Add(this.lb_CadCNumero);
            this.panel_CadCCliente.Controls.Add(this.mtb_CadCTelefone);
            this.panel_CadCCliente.Controls.Add(this.tb_CadCEndereco);
            this.panel_CadCCliente.Controls.Add(this.lb_CadCTelefone);
            this.panel_CadCCliente.Controls.Add(this.lb_CadCEndereco);
            this.panel_CadCCliente.Controls.Add(this.lb_CadCNome);
            this.panel_CadCCliente.Controls.Add(this.tb_CadCNome);
            this.panel_CadCCliente.Controls.Add(this.mtb_CadCCelular);
            this.panel_CadCCliente.Controls.Add(this.lb_CadCCelular);
            this.panel_CadCCliente.Controls.Add(this.lb_CadCCPF);
            this.panel_CadCCliente.Controls.Add(this.mtb_CadCCEP);
            this.panel_CadCCliente.Controls.Add(this.cb_CadCCPF);
            this.panel_CadCCliente.Controls.Add(this.mtb_CadCCPF);
            this.panel_CadCCliente.Location = new System.Drawing.Point(201, 12);
            this.panel_CadCCliente.Name = "panel_CadCCliente";
            this.panel_CadCCliente.Size = new System.Drawing.Size(571, 275);
            this.panel_CadCCliente.TabIndex = 0;
            // 
            // cb_CadCEstado
            // 
            this.cb_CadCEstado.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_CadCEstado.FormattingEnabled = true;
            this.cb_CadCEstado.Items.AddRange(new object[] {
            "",
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
            "PA ",
            "PB ",
            "PR ",
            "PE ",
            "PI ",
            "RJ",
            "RN ",
            "RS ",
            "RO ",
            "RR ",
            "SC ",
            "SP ",
            "SE ",
            "TO"});
            this.cb_CadCEstado.Location = new System.Drawing.Point(487, 232);
            this.cb_CadCEstado.Name = "cb_CadCEstado";
            this.cb_CadCEstado.Size = new System.Drawing.Size(75, 33);
            this.cb_CadCEstado.TabIndex = 20;
            // 
            // lb_CadCCEP
            // 
            this.lb_CadCCEP.AutoSize = true;
            this.lb_CadCCEP.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CadCCEP.Location = new System.Drawing.Point(9, 140);
            this.lb_CadCCEP.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_CadCCEP.Name = "lb_CadCCEP";
            this.lb_CadCCEP.Size = new System.Drawing.Size(47, 22);
            this.lb_CadCCEP.TabIndex = 19;
            this.lb_CadCCEP.Text = "CEP:";
            // 
            // lb_CadCEstado
            // 
            this.lb_CadCEstado.AutoSize = true;
            this.lb_CadCEstado.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CadCEstado.Location = new System.Drawing.Point(483, 205);
            this.lb_CadCEstado.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_CadCEstado.Name = "lb_CadCEstado";
            this.lb_CadCEstado.Size = new System.Drawing.Size(70, 22);
            this.lb_CadCEstado.TabIndex = 16;
            this.lb_CadCEstado.Text = "Estado:";
            // 
            // tb_CadCCidade
            // 
            this.tb_CadCCidade.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_CadCCidade.Location = new System.Drawing.Point(278, 232);
            this.tb_CadCCidade.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tb_CadCCidade.Name = "tb_CadCCidade";
            this.tb_CadCCidade.Size = new System.Drawing.Size(200, 33);
            this.tb_CadCCidade.TabIndex = 8;
            // 
            // lb_CadCCidade
            // 
            this.lb_CadCCidade.AutoSize = true;
            this.lb_CadCCidade.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CadCCidade.Location = new System.Drawing.Point(274, 205);
            this.lb_CadCCidade.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_CadCCidade.Name = "lb_CadCCidade";
            this.lb_CadCCidade.Size = new System.Drawing.Size(73, 22);
            this.lb_CadCCidade.TabIndex = 14;
            this.lb_CadCCidade.Text = "Cidade:";
            // 
            // tb_CadCBairro
            // 
            this.tb_CadCBairro.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_CadCBairro.Location = new System.Drawing.Point(13, 232);
            this.tb_CadCBairro.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tb_CadCBairro.Name = "tb_CadCBairro";
            this.tb_CadCBairro.Size = new System.Drawing.Size(253, 33);
            this.tb_CadCBairro.TabIndex = 7;
            // 
            // lb_CadCBairro
            // 
            this.lb_CadCBairro.AutoSize = true;
            this.lb_CadCBairro.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CadCBairro.Location = new System.Drawing.Point(9, 205);
            this.lb_CadCBairro.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_CadCBairro.Name = "lb_CadCBairro";
            this.lb_CadCBairro.Size = new System.Drawing.Size(65, 22);
            this.lb_CadCBairro.TabIndex = 12;
            this.lb_CadCBairro.Text = "Bairro:";
            // 
            // tb_CadCNumero
            // 
            this.tb_CadCNumero.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_CadCNumero.Location = new System.Drawing.Point(462, 167);
            this.tb_CadCNumero.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tb_CadCNumero.Name = "tb_CadCNumero";
            this.tb_CadCNumero.Size = new System.Drawing.Size(100, 33);
            this.tb_CadCNumero.TabIndex = 6;
            this.tb_CadCNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lb_CadCNumero
            // 
            this.lb_CadCNumero.AutoSize = true;
            this.lb_CadCNumero.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CadCNumero.Location = new System.Drawing.Point(458, 140);
            this.lb_CadCNumero.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_CadCNumero.Name = "lb_CadCNumero";
            this.lb_CadCNumero.Size = new System.Drawing.Size(83, 22);
            this.lb_CadCNumero.TabIndex = 10;
            this.lb_CadCNumero.Text = "Número:";
            // 
            // mtb_CadCTelefone
            // 
            this.mtb_CadCTelefone.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtb_CadCTelefone.Location = new System.Drawing.Point(200, 102);
            this.mtb_CadCTelefone.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.mtb_CadCTelefone.Mask = "(00) 0000-0000";
            this.mtb_CadCTelefone.Name = "mtb_CadCTelefone";
            this.mtb_CadCTelefone.Size = new System.Drawing.Size(175, 33);
            this.mtb_CadCTelefone.TabIndex = 2;
            this.mtb_CadCTelefone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lb_CadCTelefone
            // 
            this.lb_CadCTelefone.AutoSize = true;
            this.lb_CadCTelefone.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CadCTelefone.Location = new System.Drawing.Point(196, 75);
            this.lb_CadCTelefone.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_CadCTelefone.Name = "lb_CadCTelefone";
            this.lb_CadCTelefone.Size = new System.Drawing.Size(87, 22);
            this.lb_CadCTelefone.TabIndex = 8;
            this.lb_CadCTelefone.Text = "Telefone:";
            // 
            // mtb_CadCCEP
            // 
            this.mtb_CadCCEP.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtb_CadCCEP.Location = new System.Drawing.Point(13, 167);
            this.mtb_CadCCEP.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.mtb_CadCCEP.Mask = "00000-000";
            this.mtb_CadCCEP.Name = "mtb_CadCCEP";
            this.mtb_CadCCEP.Size = new System.Drawing.Size(125, 33);
            this.mtb_CadCCEP.TabIndex = 4;
            this.mtb_CadCCEP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cb_CadCCPF
            // 
            this.cb_CadCCPF.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cb_CadCCPF.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_CadCCPF.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_CadCCPF.FormattingEnabled = true;
            this.cb_CadCCPF.Items.AddRange(new object[] {
            ""});
            this.cb_CadCCPF.Location = new System.Drawing.Point(13, 102);
            this.cb_CadCCPF.Name = "cb_CadCCPF";
            this.cb_CadCCPF.Size = new System.Drawing.Size(175, 33);
            this.cb_CadCCPF.TabIndex = 1;
            this.cb_CadCCPF.SelectedIndexChanged += new System.EventHandler(this.cb_CadCCPF_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bt_CadCSair);
            this.panel2.Controls.Add(this.bt_CadCConsultar);
            this.panel2.Controls.Add(this.bt_CadCAtualizar);
            this.panel2.Controls.Add(this.bt_CadCCadastrar);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(175, 337);
            this.panel2.TabIndex = 2;
            // 
            // bt_CadCSair
            // 
            this.bt_CadCSair.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_CadCSair.Location = new System.Drawing.Point(12, 233);
            this.bt_CadCSair.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bt_CadCSair.Name = "bt_CadCSair";
            this.bt_CadCSair.Size = new System.Drawing.Size(150, 50);
            this.bt_CadCSair.TabIndex = 3;
            this.bt_CadCSair.Text = "Sair";
            this.bt_CadCSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_CadCSair.UseVisualStyleBackColor = true;
            this.bt_CadCSair.Click += new System.EventHandler(this.bt_CadCSair_Click);
            // 
            // bt_CadCConsultar
            // 
            this.bt_CadCConsultar.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_CadCConsultar.Location = new System.Drawing.Point(12, 173);
            this.bt_CadCConsultar.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bt_CadCConsultar.Name = "bt_CadCConsultar";
            this.bt_CadCConsultar.Size = new System.Drawing.Size(150, 50);
            this.bt_CadCConsultar.TabIndex = 2;
            this.bt_CadCConsultar.Text = "Consultar";
            this.bt_CadCConsultar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_CadCConsultar.UseVisualStyleBackColor = true;
            this.bt_CadCConsultar.Click += new System.EventHandler(this.bt_CadCConsultar_Click);
            // 
            // bt_CadCAtualizar
            // 
            this.bt_CadCAtualizar.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_CadCAtualizar.Location = new System.Drawing.Point(12, 113);
            this.bt_CadCAtualizar.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bt_CadCAtualizar.Name = "bt_CadCAtualizar";
            this.bt_CadCAtualizar.Size = new System.Drawing.Size(150, 50);
            this.bt_CadCAtualizar.TabIndex = 1;
            this.bt_CadCAtualizar.Text = "Atualizar";
            this.bt_CadCAtualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_CadCAtualizar.UseVisualStyleBackColor = true;
            this.bt_CadCAtualizar.Click += new System.EventHandler(this.bt_CadCAtualizar_Click);
            // 
            // bt_CadCCadastrar
            // 
            this.bt_CadCCadastrar.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_CadCCadastrar.Location = new System.Drawing.Point(12, 53);
            this.bt_CadCCadastrar.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bt_CadCCadastrar.Name = "bt_CadCCadastrar";
            this.bt_CadCCadastrar.Size = new System.Drawing.Size(150, 50);
            this.bt_CadCCadastrar.TabIndex = 0;
            this.bt_CadCCadastrar.Text = "Cadastrar";
            this.bt_CadCCadastrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_CadCCadastrar.UseVisualStyleBackColor = true;
            this.bt_CadCCadastrar.Click += new System.EventHandler(this.bt_CadCCadastrar_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.bt_CadCExcluir);
            this.panel3.Controls.Add(this.bt_CadCCancelar);
            this.panel3.Controls.Add(this.bt_CadCConfirmar);
            this.panel3.Controls.Add(this.bt_CadCVeiculos);
            this.panel3.Location = new System.Drawing.Point(201, 293);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(571, 56);
            this.panel3.TabIndex = 1;
            // 
            // bt_CadCExcluir
            // 
            this.bt_CadCExcluir.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_CadCExcluir.Image = global::Projeto_Estacionamento.Properties.Resources.trash40x40;
            this.bt_CadCExcluir.Location = new System.Drawing.Point(104, 3);
            this.bt_CadCExcluir.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bt_CadCExcluir.Name = "bt_CadCExcluir";
            this.bt_CadCExcluir.Size = new System.Drawing.Size(175, 50);
            this.bt_CadCExcluir.TabIndex = 3;
            this.bt_CadCExcluir.Text = "Excluir";
            this.bt_CadCExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_CadCExcluir.UseVisualStyleBackColor = true;
            this.bt_CadCExcluir.Click += new System.EventHandler(this.bt_CadCExcluir_Click);
            // 
            // bt_CadCCancelar
            // 
            this.bt_CadCCancelar.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_CadCCancelar.Image = ((System.Drawing.Image)(resources.GetObject("bt_CadCCancelar.Image")));
            this.bt_CadCCancelar.Location = new System.Drawing.Point(104, 3);
            this.bt_CadCCancelar.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bt_CadCCancelar.Name = "bt_CadCCancelar";
            this.bt_CadCCancelar.Size = new System.Drawing.Size(175, 50);
            this.bt_CadCCancelar.TabIndex = 1;
            this.bt_CadCCancelar.Text = "Cancelar";
            this.bt_CadCCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_CadCCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_CadCCancelar.UseVisualStyleBackColor = true;
            this.bt_CadCCancelar.Click += new System.EventHandler(this.bt_CadCCancelar_Click);
            // 
            // bt_CadCConfirmar
            // 
            this.bt_CadCConfirmar.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_CadCConfirmar.Image = global::Projeto_Estacionamento.Properties.Resources.check40x40;
            this.bt_CadCConfirmar.Location = new System.Drawing.Point(291, 3);
            this.bt_CadCConfirmar.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bt_CadCConfirmar.Name = "bt_CadCConfirmar";
            this.bt_CadCConfirmar.Size = new System.Drawing.Size(175, 50);
            this.bt_CadCConfirmar.TabIndex = 0;
            this.bt_CadCConfirmar.Text = "Confirmar";
            this.bt_CadCConfirmar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_CadCConfirmar.UseVisualStyleBackColor = true;
            this.bt_CadCConfirmar.Click += new System.EventHandler(this.bt_CadCConfirmar_Click);
            // 
            // bt_CadCVeiculos
            // 
            this.bt_CadCVeiculos.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_CadCVeiculos.Image = global::Projeto_Estacionamento.Properties.Resources.veiculo40x40;
            this.bt_CadCVeiculos.Location = new System.Drawing.Point(291, 3);
            this.bt_CadCVeiculos.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bt_CadCVeiculos.Name = "bt_CadCVeiculos";
            this.bt_CadCVeiculos.Size = new System.Drawing.Size(175, 50);
            this.bt_CadCVeiculos.TabIndex = 2;
            this.bt_CadCVeiculos.Text = "Veículos";
            this.bt_CadCVeiculos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_CadCVeiculos.UseVisualStyleBackColor = true;
            this.bt_CadCVeiculos.Click += new System.EventHandler(this.bt_CadCVeiculos_Click);
            // 
            // panel_CadCConsultar
            // 
            this.panel_CadCConsultar.Controls.Add(this.bt_CadCPesquisar);
            this.panel_CadCConsultar.Controls.Add(this.dg_CadCConsulta);
            this.panel_CadCConsultar.Controls.Add(this.tb_CadCPesquisa);
            this.panel_CadCConsultar.Location = new System.Drawing.Point(201, 12);
            this.panel_CadCConsultar.Name = "panel_CadCConsultar";
            this.panel_CadCConsultar.Size = new System.Drawing.Size(571, 275);
            this.panel_CadCConsultar.TabIndex = 0;
            // 
            // bt_CadCPesquisar
            // 
            this.bt_CadCPesquisar.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_CadCPesquisar.Image = global::Projeto_Estacionamento.Properties.Resources.lupa25x25;
            this.bt_CadCPesquisar.Location = new System.Drawing.Point(532, 5);
            this.bt_CadCPesquisar.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bt_CadCPesquisar.Name = "bt_CadCPesquisar";
            this.bt_CadCPesquisar.Size = new System.Drawing.Size(33, 33);
            this.bt_CadCPesquisar.TabIndex = 1;
            this.bt_CadCPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_CadCPesquisar.UseVisualStyleBackColor = true;
            this.bt_CadCPesquisar.Click += new System.EventHandler(this.bt_CadCPesquisar_Click);
            // 
            // dg_CadCConsulta
            // 
            this.dg_CadCConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_CadCConsulta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nome,
            this.cpf,
            this.telefone,
            this.celular,
            this.cep,
            this.endereco,
            this.numero,
            this.bairro,
            this.cidade,
            this.estado});
            this.dg_CadCConsulta.Location = new System.Drawing.Point(3, 46);
            this.dg_CadCConsulta.MultiSelect = false;
            this.dg_CadCConsulta.Name = "dg_CadCConsulta";
            this.dg_CadCConsulta.ReadOnly = true;
            this.dg_CadCConsulta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_CadCConsulta.Size = new System.Drawing.Size(565, 226);
            this.dg_CadCConsulta.TabIndex = 2;
            // 
            // nome
            // 
            this.nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            this.nome.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.nome.Width = 86;
            // 
            // cpf
            // 
            this.cpf.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cpf.HeaderText = "CPF";
            this.cpf.Name = "cpf";
            this.cpf.ReadOnly = true;
            this.cpf.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cpf.Width = 67;
            // 
            // telefone
            // 
            this.telefone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.telefone.HeaderText = "Telefone";
            this.telefone.Name = "telefone";
            this.telefone.ReadOnly = true;
            this.telefone.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.telefone.Width = 108;
            // 
            // celular
            // 
            this.celular.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.celular.HeaderText = "Celular";
            this.celular.Name = "celular";
            this.celular.ReadOnly = true;
            this.celular.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.celular.Width = 95;
            // 
            // cep
            // 
            this.cep.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cep.HeaderText = "CEP";
            this.cep.Name = "cep";
            this.cep.ReadOnly = true;
            this.cep.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cep.Width = 68;
            // 
            // endereco
            // 
            this.endereco.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.endereco.HeaderText = "Endereço";
            this.endereco.Name = "endereco";
            this.endereco.ReadOnly = true;
            this.endereco.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.endereco.Width = 114;
            // 
            // numero
            // 
            this.numero.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.numero.HeaderText = "Número";
            this.numero.Name = "numero";
            this.numero.ReadOnly = true;
            this.numero.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.numero.Width = 104;
            // 
            // bairro
            // 
            this.bairro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.bairro.HeaderText = "Bairro";
            this.bairro.Name = "bairro";
            this.bairro.ReadOnly = true;
            this.bairro.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.bairro.Width = 86;
            // 
            // cidade
            // 
            this.cidade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cidade.HeaderText = "Cidade";
            this.cidade.Name = "cidade";
            this.cidade.ReadOnly = true;
            this.cidade.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cidade.Width = 94;
            // 
            // estado
            // 
            this.estado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            this.estado.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.estado.Width = 91;
            // 
            // tb_CadCPesquisa
            // 
            this.tb_CadCPesquisa.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_CadCPesquisa.Location = new System.Drawing.Point(3, 5);
            this.tb_CadCPesquisa.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tb_CadCPesquisa.Name = "tb_CadCPesquisa";
            this.tb_CadCPesquisa.Size = new System.Drawing.Size(517, 33);
            this.tb_CadCPesquisa.TabIndex = 0;
            this.tb_CadCPesquisa.Enter += new System.EventHandler(this.tb_CadCPesquisa_Enter);
            this.tb_CadCPesquisa.Leave += new System.EventHandler(this.tb_CadCPesquisa_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Location = new System.Drawing.Point(193, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2, 337);
            this.panel1.TabIndex = 21;
            // 
            // CadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel_CadCCliente);
            this.Controls.Add(this.panel_CadCConsultar);
            this.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "CadastroCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.CadastroCliente_Load);
            this.panel_CadCCliente.ResumeLayout(false);
            this.panel_CadCCliente.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel_CadCConsultar.ResumeLayout(false);
            this.panel_CadCConsultar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_CadCConsulta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lb_CadCNome;
        private System.Windows.Forms.Label lb_CadCCPF;
        private System.Windows.Forms.Label lb_CadCCelular;
        private System.Windows.Forms.Label lb_CadCEndereco;
        private System.Windows.Forms.TextBox tb_CadCNome;
        private System.Windows.Forms.MaskedTextBox mtb_CadCCPF;
        private System.Windows.Forms.MaskedTextBox mtb_CadCCelular;
        private System.Windows.Forms.TextBox tb_CadCEndereco;
        private System.Windows.Forms.Button bt_CadCConfirmar;
        private System.Windows.Forms.Panel panel_CadCCliente;
        private System.Windows.Forms.Label lb_CadCEstado;
        private System.Windows.Forms.TextBox tb_CadCCidade;
        private System.Windows.Forms.Label lb_CadCCidade;
        private System.Windows.Forms.TextBox tb_CadCBairro;
        private System.Windows.Forms.Label lb_CadCBairro;
        private System.Windows.Forms.Label lb_CadCNumero;
        private System.Windows.Forms.MaskedTextBox mtb_CadCTelefone;
        private System.Windows.Forms.Label lb_CadCTelefone;
        private System.Windows.Forms.Button bt_CadCCancelar;
        private System.Windows.Forms.Label lb_CadCCEP;
        private System.Windows.Forms.MaskedTextBox mtb_CadCCEP;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bt_CadCCadastrar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button bt_CadCConsultar;
        private System.Windows.Forms.Button bt_CadCAtualizar;
        private System.Windows.Forms.Button bt_CadCExcluir;
        private System.Windows.Forms.Panel panel_CadCConsultar;
        private System.Windows.Forms.Button bt_CadCPesquisar;
        private System.Windows.Forms.DataGridView dg_CadCConsulta;
        private System.Windows.Forms.TextBox tb_CadCPesquisa;
        private System.Windows.Forms.Button bt_CadCVeiculos;
        private System.Windows.Forms.TextBox tb_CadCNumero;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_CadCSair;
        private System.Windows.Forms.ComboBox cb_CadCCPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn celular;
        private System.Windows.Forms.DataGridViewTextBoxColumn cep;
        private System.Windows.Forms.DataGridViewTextBoxColumn endereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn bairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.ComboBox cb_CadCEstado;
    }
}