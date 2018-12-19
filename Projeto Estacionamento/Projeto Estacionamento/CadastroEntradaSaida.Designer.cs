namespace Projeto_Estacionamento
{
    partial class CadastroEntradaSaida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroEntradaSaida));
            this.lb_EntSaidCliente = new System.Windows.Forms.Label();
            this.lb_EntSaidPlaca = new System.Windows.Forms.Label();
            this.lb_EntSaidHora = new System.Windows.Forms.Label();
            this.cb_EntSaidCliente = new System.Windows.Forms.ComboBox();
            this.cb_EntSaidPlaca = new System.Windows.Forms.ComboBox();
            this.lb_EntSaidData = new System.Windows.Forms.Label();
            this.panel_EntSaidCliente = new System.Windows.Forms.Panel();
            this.tb_EntSaidCliente = new System.Windows.Forms.TextBox();
            this.gb_EntSaidAcao = new System.Windows.Forms.GroupBox();
            this.rb_EntSaidSaida = new System.Windows.Forms.RadioButton();
            this.rb_EntSaidEntrada = new System.Windows.Forms.RadioButton();
            this.dt_EntSaidHora = new System.Windows.Forms.DateTimePicker();
            this.dt_EntSaidData = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bt_EntSaidSair = new System.Windows.Forms.Button();
            this.bt_EntSaidConsultar = new System.Windows.Forms.Button();
            this.bt_EntSaidCadastrar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bt_EntSaidCancelar = new System.Windows.Forms.Button();
            this.bt_EntSaidConfirmar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_EntSaidConsultar = new System.Windows.Forms.Panel();
            this.bt_EntSaidPesquisar = new System.Windows.Forms.Button();
            this.dg_EntSaidConsulta = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tb_EntSaidPesquisa = new System.Windows.Forms.TextBox();
            this.panel_EntSaidCliente.SuspendLayout();
            this.gb_EntSaidAcao.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel_EntSaidConsultar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_EntSaidConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_EntSaidCliente
            // 
            this.lb_EntSaidCliente.AutoSize = true;
            this.lb_EntSaidCliente.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_EntSaidCliente.Location = new System.Drawing.Point(13, 29);
            this.lb_EntSaidCliente.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_EntSaidCliente.Name = "lb_EntSaidCliente";
            this.lb_EntSaidCliente.Size = new System.Drawing.Size(73, 22);
            this.lb_EntSaidCliente.TabIndex = 1;
            this.lb_EntSaidCliente.Text = "Cliente:";
            // 
            // lb_EntSaidPlaca
            // 
            this.lb_EntSaidPlaca.AutoSize = true;
            this.lb_EntSaidPlaca.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_EntSaidPlaca.Location = new System.Drawing.Point(305, 94);
            this.lb_EntSaidPlaca.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_EntSaidPlaca.Name = "lb_EntSaidPlaca";
            this.lb_EntSaidPlaca.Size = new System.Drawing.Size(59, 22);
            this.lb_EntSaidPlaca.TabIndex = 2;
            this.lb_EntSaidPlaca.Text = "Placa:";
            // 
            // lb_EntSaidHora
            // 
            this.lb_EntSaidHora.AutoSize = true;
            this.lb_EntSaidHora.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_EntSaidHora.Location = new System.Drawing.Point(151, 94);
            this.lb_EntSaidHora.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_EntSaidHora.Name = "lb_EntSaidHora";
            this.lb_EntSaidHora.Size = new System.Drawing.Size(55, 22);
            this.lb_EntSaidHora.TabIndex = 4;
            this.lb_EntSaidHora.Text = "Hora:";
            // 
            // cb_EntSaidCliente
            // 
            this.cb_EntSaidCliente.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_EntSaidCliente.FormattingEnabled = true;
            this.cb_EntSaidCliente.Items.AddRange(new object[] {
            ""});
            this.cb_EntSaidCliente.Location = new System.Drawing.Point(17, 56);
            this.cb_EntSaidCliente.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cb_EntSaidCliente.Name = "cb_EntSaidCliente";
            this.cb_EntSaidCliente.Size = new System.Drawing.Size(175, 33);
            this.cb_EntSaidCliente.TabIndex = 0;
            this.cb_EntSaidCliente.SelectedIndexChanged += new System.EventHandler(this.cb_EntSaidCliente_SelectedIndexChanged);
            // 
            // cb_EntSaidPlaca
            // 
            this.cb_EntSaidPlaca.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_EntSaidPlaca.FormattingEnabled = true;
            this.cb_EntSaidPlaca.Items.AddRange(new object[] {
            ""});
            this.cb_EntSaidPlaca.Location = new System.Drawing.Point(309, 121);
            this.cb_EntSaidPlaca.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cb_EntSaidPlaca.Name = "cb_EntSaidPlaca";
            this.cb_EntSaidPlaca.Size = new System.Drawing.Size(175, 33);
            this.cb_EntSaidPlaca.TabIndex = 4;
            this.cb_EntSaidPlaca.SelectedIndexChanged += new System.EventHandler(this.cb_EntSaidPlaca_SelectedIndexChanged);
            // 
            // lb_EntSaidData
            // 
            this.lb_EntSaidData.AutoSize = true;
            this.lb_EntSaidData.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_EntSaidData.Location = new System.Drawing.Point(151, 159);
            this.lb_EntSaidData.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_EntSaidData.Name = "lb_EntSaidData";
            this.lb_EntSaidData.Size = new System.Drawing.Size(53, 22);
            this.lb_EntSaidData.TabIndex = 10;
            this.lb_EntSaidData.Text = "Data:";
            // 
            // panel_EntSaidCliente
            // 
            this.panel_EntSaidCliente.Controls.Add(this.tb_EntSaidCliente);
            this.panel_EntSaidCliente.Controls.Add(this.gb_EntSaidAcao);
            this.panel_EntSaidCliente.Controls.Add(this.lb_EntSaidHora);
            this.panel_EntSaidCliente.Controls.Add(this.cb_EntSaidCliente);
            this.panel_EntSaidCliente.Controls.Add(this.lb_EntSaidData);
            this.panel_EntSaidCliente.Controls.Add(this.lb_EntSaidCliente);
            this.panel_EntSaidCliente.Controls.Add(this.cb_EntSaidPlaca);
            this.panel_EntSaidCliente.Controls.Add(this.lb_EntSaidPlaca);
            this.panel_EntSaidCliente.Controls.Add(this.dt_EntSaidHora);
            this.panel_EntSaidCliente.Controls.Add(this.dt_EntSaidData);
            this.panel_EntSaidCliente.Location = new System.Drawing.Point(201, 12);
            this.panel_EntSaidCliente.Name = "panel_EntSaidCliente";
            this.panel_EntSaidCliente.Size = new System.Drawing.Size(496, 250);
            this.panel_EntSaidCliente.TabIndex = 1;
            // 
            // tb_EntSaidCliente
            // 
            this.tb_EntSaidCliente.Location = new System.Drawing.Point(201, 56);
            this.tb_EntSaidCliente.Name = "tb_EntSaidCliente";
            this.tb_EntSaidCliente.ReadOnly = true;
            this.tb_EntSaidCliente.Size = new System.Drawing.Size(283, 33);
            this.tb_EntSaidCliente.TabIndex = 1;
            // 
            // gb_EntSaidAcao
            // 
            this.gb_EntSaidAcao.Controls.Add(this.rb_EntSaidSaida);
            this.gb_EntSaidAcao.Controls.Add(this.rb_EntSaidEntrada);
            this.gb_EntSaidAcao.Location = new System.Drawing.Point(17, 94);
            this.gb_EntSaidAcao.Name = "gb_EntSaidAcao";
            this.gb_EntSaidAcao.Size = new System.Drawing.Size(125, 125);
            this.gb_EntSaidAcao.TabIndex = 2;
            this.gb_EntSaidAcao.TabStop = false;
            this.gb_EntSaidAcao.Text = "Ação";
            // 
            // rb_EntSaidSaida
            // 
            this.rb_EntSaidSaida.AutoSize = true;
            this.rb_EntSaidSaida.Location = new System.Drawing.Point(6, 65);
            this.rb_EntSaidSaida.Name = "rb_EntSaidSaida";
            this.rb_EntSaidSaida.Size = new System.Drawing.Size(74, 26);
            this.rb_EntSaidSaida.TabIndex = 3;
            this.rb_EntSaidSaida.TabStop = true;
            this.rb_EntSaidSaida.Text = "Saída";
            this.rb_EntSaidSaida.UseVisualStyleBackColor = true;
            // 
            // rb_EntSaidEntrada
            // 
            this.rb_EntSaidEntrada.AutoSize = true;
            this.rb_EntSaidEntrada.Location = new System.Drawing.Point(6, 33);
            this.rb_EntSaidEntrada.Name = "rb_EntSaidEntrada";
            this.rb_EntSaidEntrada.Size = new System.Drawing.Size(93, 26);
            this.rb_EntSaidEntrada.TabIndex = 2;
            this.rb_EntSaidEntrada.TabStop = true;
            this.rb_EntSaidEntrada.Text = "Entrada";
            this.rb_EntSaidEntrada.UseVisualStyleBackColor = true;
            // 
            // dt_EntSaidHora
            // 
            this.dt_EntSaidHora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dt_EntSaidHora.Location = new System.Drawing.Point(155, 121);
            this.dt_EntSaidHora.Name = "dt_EntSaidHora";
            this.dt_EntSaidHora.Size = new System.Drawing.Size(142, 33);
            this.dt_EntSaidHora.TabIndex = 3;
            // 
            // dt_EntSaidData
            // 
            this.dt_EntSaidData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_EntSaidData.Location = new System.Drawing.Point(155, 186);
            this.dt_EntSaidData.Name = "dt_EntSaidData";
            this.dt_EntSaidData.Size = new System.Drawing.Size(142, 33);
            this.dt_EntSaidData.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bt_EntSaidSair);
            this.panel2.Controls.Add(this.bt_EntSaidConsultar);
            this.panel2.Controls.Add(this.bt_EntSaidCadastrar);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(175, 312);
            this.panel2.TabIndex = 3;
            // 
            // bt_EntSaidSair
            // 
            this.bt_EntSaidSair.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_EntSaidSair.Location = new System.Drawing.Point(12, 191);
            this.bt_EntSaidSair.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bt_EntSaidSair.Name = "bt_EntSaidSair";
            this.bt_EntSaidSair.Size = new System.Drawing.Size(150, 50);
            this.bt_EntSaidSair.TabIndex = 3;
            this.bt_EntSaidSair.Text = "Sair";
            this.bt_EntSaidSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_EntSaidSair.UseVisualStyleBackColor = true;
            this.bt_EntSaidSair.Click += new System.EventHandler(this.bt_EntSaidSair_Click);
            // 
            // bt_EntSaidConsultar
            // 
            this.bt_EntSaidConsultar.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_EntSaidConsultar.Location = new System.Drawing.Point(12, 131);
            this.bt_EntSaidConsultar.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bt_EntSaidConsultar.Name = "bt_EntSaidConsultar";
            this.bt_EntSaidConsultar.Size = new System.Drawing.Size(150, 50);
            this.bt_EntSaidConsultar.TabIndex = 2;
            this.bt_EntSaidConsultar.Text = "Consultar";
            this.bt_EntSaidConsultar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_EntSaidConsultar.UseVisualStyleBackColor = true;
            this.bt_EntSaidConsultar.Click += new System.EventHandler(this.bt_EntSaidConsultar_Click);
            // 
            // bt_EntSaidCadastrar
            // 
            this.bt_EntSaidCadastrar.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_EntSaidCadastrar.Location = new System.Drawing.Point(12, 71);
            this.bt_EntSaidCadastrar.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bt_EntSaidCadastrar.Name = "bt_EntSaidCadastrar";
            this.bt_EntSaidCadastrar.Size = new System.Drawing.Size(150, 50);
            this.bt_EntSaidCadastrar.TabIndex = 1;
            this.bt_EntSaidCadastrar.Text = "Cadastrar";
            this.bt_EntSaidCadastrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_EntSaidCadastrar.UseVisualStyleBackColor = true;
            this.bt_EntSaidCadastrar.Click += new System.EventHandler(this.bt_EntSaidCadastrar_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.bt_EntSaidCancelar);
            this.panel3.Controls.Add(this.bt_EntSaidConfirmar);
            this.panel3.Location = new System.Drawing.Point(201, 268);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(496, 56);
            this.panel3.TabIndex = 2;
            // 
            // bt_EntSaidCancelar
            // 
            this.bt_EntSaidCancelar.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_EntSaidCancelar.Image = ((System.Drawing.Image)(resources.GetObject("bt_EntSaidCancelar.Image")));
            this.bt_EntSaidCancelar.Location = new System.Drawing.Point(67, 3);
            this.bt_EntSaidCancelar.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bt_EntSaidCancelar.Name = "bt_EntSaidCancelar";
            this.bt_EntSaidCancelar.Size = new System.Drawing.Size(175, 50);
            this.bt_EntSaidCancelar.TabIndex = 2;
            this.bt_EntSaidCancelar.Text = "Cancelar";
            this.bt_EntSaidCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_EntSaidCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_EntSaidCancelar.UseVisualStyleBackColor = true;
            this.bt_EntSaidCancelar.Click += new System.EventHandler(this.bt_EntSaidCancelar_Click);
            // 
            // bt_EntSaidConfirmar
            // 
            this.bt_EntSaidConfirmar.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_EntSaidConfirmar.Image = global::Projeto_Estacionamento.Properties.Resources.check40x40;
            this.bt_EntSaidConfirmar.Location = new System.Drawing.Point(254, 3);
            this.bt_EntSaidConfirmar.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bt_EntSaidConfirmar.Name = "bt_EntSaidConfirmar";
            this.bt_EntSaidConfirmar.Size = new System.Drawing.Size(175, 50);
            this.bt_EntSaidConfirmar.TabIndex = 1;
            this.bt_EntSaidConfirmar.Text = "Confirmar";
            this.bt_EntSaidConfirmar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_EntSaidConfirmar.UseVisualStyleBackColor = true;
            this.bt_EntSaidConfirmar.Click += new System.EventHandler(this.bt_EntSaidConfirmar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Location = new System.Drawing.Point(193, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2, 312);
            this.panel1.TabIndex = 13;
            // 
            // panel_EntSaidConsultar
            // 
            this.panel_EntSaidConsultar.Controls.Add(this.bt_EntSaidPesquisar);
            this.panel_EntSaidConsultar.Controls.Add(this.dg_EntSaidConsulta);
            this.panel_EntSaidConsultar.Controls.Add(this.tb_EntSaidPesquisa);
            this.panel_EntSaidConsultar.Location = new System.Drawing.Point(201, 12);
            this.panel_EntSaidConsultar.Name = "panel_EntSaidConsultar";
            this.panel_EntSaidConsultar.Size = new System.Drawing.Size(496, 250);
            this.panel_EntSaidConsultar.TabIndex = 1;
            // 
            // bt_EntSaidPesquisar
            // 
            this.bt_EntSaidPesquisar.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_EntSaidPesquisar.Image = global::Projeto_Estacionamento.Properties.Resources.lupa25x25;
            this.bt_EntSaidPesquisar.Location = new System.Drawing.Point(460, 5);
            this.bt_EntSaidPesquisar.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bt_EntSaidPesquisar.Name = "bt_EntSaidPesquisar";
            this.bt_EntSaidPesquisar.Size = new System.Drawing.Size(33, 33);
            this.bt_EntSaidPesquisar.TabIndex = 1;
            this.bt_EntSaidPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_EntSaidPesquisar.UseVisualStyleBackColor = true;
            this.bt_EntSaidPesquisar.Click += new System.EventHandler(this.bt_EntSaidPesquisar_Click);
            // 
            // dg_EntSaidConsulta
            // 
            this.dg_EntSaidConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_EntSaidConsulta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.cpf,
            this.placa,
            this.acao,
            this.hora,
            this.data});
            this.dg_EntSaidConsulta.Location = new System.Drawing.Point(3, 46);
            this.dg_EntSaidConsulta.MultiSelect = false;
            this.dg_EntSaidConsulta.Name = "dg_EntSaidConsulta";
            this.dg_EntSaidConsulta.ReadOnly = true;
            this.dg_EntSaidConsulta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_EntSaidConsulta.Size = new System.Drawing.Size(490, 201);
            this.dg_EntSaidConsulta.TabIndex = 2;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
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
            // placa
            // 
            this.placa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.placa.HeaderText = "Placa";
            this.placa.Name = "placa";
            this.placa.ReadOnly = true;
            this.placa.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.placa.Width = 80;
            // 
            // acao
            // 
            this.acao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.acao.HeaderText = "Ação";
            this.acao.Name = "acao";
            this.acao.ReadOnly = true;
            this.acao.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.acao.Width = 77;
            // 
            // hora
            // 
            this.hora.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.hora.HeaderText = "Hora";
            this.hora.Name = "hora";
            this.hora.ReadOnly = true;
            this.hora.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.hora.Width = 76;
            // 
            // data
            // 
            this.data.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.data.HeaderText = "Data";
            this.data.Name = "data";
            this.data.ReadOnly = true;
            this.data.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.data.Width = 74;
            // 
            // tb_EntSaidPesquisa
            // 
            this.tb_EntSaidPesquisa.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_EntSaidPesquisa.Location = new System.Drawing.Point(3, 5);
            this.tb_EntSaidPesquisa.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tb_EntSaidPesquisa.Name = "tb_EntSaidPesquisa";
            this.tb_EntSaidPesquisa.Size = new System.Drawing.Size(445, 33);
            this.tb_EntSaidPesquisa.TabIndex = 0;
            this.tb_EntSaidPesquisa.Enter += new System.EventHandler(this.tb_EntSaidPesquisa_Enter);
            this.tb_EntSaidPesquisa.Leave += new System.EventHandler(this.tb_EntSaidPesquisa_Leave);
            // 
            // EntradasSaidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 336);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel_EntSaidConsultar);
            this.Controls.Add(this.panel_EntSaidCliente);
            this.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "EntradasSaidas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entradas e Saidas";
            this.Load += new System.EventHandler(this.EntradasSaidas_Load);
            this.panel_EntSaidCliente.ResumeLayout(false);
            this.panel_EntSaidCliente.PerformLayout();
            this.gb_EntSaidAcao.ResumeLayout(false);
            this.gb_EntSaidAcao.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel_EntSaidConsultar.ResumeLayout(false);
            this.panel_EntSaidConsultar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_EntSaidConsulta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lb_EntSaidCliente;
        private System.Windows.Forms.Label lb_EntSaidPlaca;
        private System.Windows.Forms.Label lb_EntSaidHora;
        private System.Windows.Forms.ComboBox cb_EntSaidCliente;
        private System.Windows.Forms.ComboBox cb_EntSaidPlaca;
        private System.Windows.Forms.Label lb_EntSaidData;
        private System.Windows.Forms.Panel panel_EntSaidCliente;
        private System.Windows.Forms.GroupBox gb_EntSaidAcao;
        private System.Windows.Forms.RadioButton rb_EntSaidSaida;
        private System.Windows.Forms.RadioButton rb_EntSaidEntrada;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bt_EntSaidConsultar;
        private System.Windows.Forms.Button bt_EntSaidCadastrar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button bt_EntSaidCancelar;
        private System.Windows.Forms.Button bt_EntSaidConfirmar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_EntSaidSair;
        private System.Windows.Forms.DateTimePicker dt_EntSaidHora;
        private System.Windows.Forms.DateTimePicker dt_EntSaidData;
        private System.Windows.Forms.TextBox tb_EntSaidCliente;
        private System.Windows.Forms.Panel panel_EntSaidConsultar;
        private System.Windows.Forms.Button bt_EntSaidPesquisar;
        private System.Windows.Forms.DataGridView dg_EntSaidConsulta;
        private System.Windows.Forms.TextBox tb_EntSaidPesquisa;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn placa;
        private System.Windows.Forms.DataGridViewTextBoxColumn acao;
        private System.Windows.Forms.DataGridViewTextBoxColumn hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
    }
}