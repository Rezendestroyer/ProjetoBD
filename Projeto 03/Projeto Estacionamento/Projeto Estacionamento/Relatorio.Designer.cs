namespace Projeto_Estacionamento
{
    partial class Relatorio
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
            this.dg_Relatorio = new System.Windows.Forms.DataGridView();
            this.cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.veiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bt_RelatRecarregar = new System.Windows.Forms.Button();
            this.bt_RelatSair = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.chb_RelatPesquisarData = new System.Windows.Forms.CheckBox();
            this.dt_RelatPesquisa = new System.Windows.Forms.DateTimePicker();
            this.bt_RelatPesquisar = new System.Windows.Forms.Button();
            this.tb_RelatPesquisa = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Relatorio)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dg_Relatorio
            // 
            this.dg_Relatorio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Relatorio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cliente,
            this.telefone,
            this.celular,
            this.veiculo,
            this.placa,
            this.acao,
            this.data,
            this.hora});
            this.dg_Relatorio.Location = new System.Drawing.Point(3, 46);
            this.dg_Relatorio.MultiSelect = false;
            this.dg_Relatorio.Name = "dg_Relatorio";
            this.dg_Relatorio.ReadOnly = true;
            this.dg_Relatorio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_Relatorio.Size = new System.Drawing.Size(665, 388);
            this.dg_Relatorio.TabIndex = 4;
            // 
            // cliente
            // 
            this.cliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cliente.HeaderText = "Cliente";
            this.cliente.Name = "cliente";
            this.cliente.ReadOnly = true;
            this.cliente.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cliente.Width = 94;
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
            // veiculo
            // 
            this.veiculo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.veiculo.HeaderText = "Veículo";
            this.veiculo.Name = "veiculo";
            this.veiculo.ReadOnly = true;
            this.veiculo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.veiculo.Width = 98;
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
            // data
            // 
            this.data.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.data.HeaderText = "Data";
            this.data.Name = "data";
            this.data.ReadOnly = true;
            this.data.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.data.Width = 74;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Location = new System.Drawing.Point(193, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2, 437);
            this.panel1.TabIndex = 23;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bt_RelatRecarregar);
            this.panel2.Controls.Add(this.bt_RelatSair);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(175, 437);
            this.panel2.TabIndex = 1;
            // 
            // bt_RelatRecarregar
            // 
            this.bt_RelatRecarregar.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_RelatRecarregar.Location = new System.Drawing.Point(12, 163);
            this.bt_RelatRecarregar.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bt_RelatRecarregar.Name = "bt_RelatRecarregar";
            this.bt_RelatRecarregar.Size = new System.Drawing.Size(150, 50);
            this.bt_RelatRecarregar.TabIndex = 0;
            this.bt_RelatRecarregar.Text = "Recarregar";
            this.bt_RelatRecarregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_RelatRecarregar.UseVisualStyleBackColor = true;
            this.bt_RelatRecarregar.Click += new System.EventHandler(this.bt_RelatRecarregar_Click);
            // 
            // bt_RelatSair
            // 
            this.bt_RelatSair.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_RelatSair.Location = new System.Drawing.Point(12, 223);
            this.bt_RelatSair.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bt_RelatSair.Name = "bt_RelatSair";
            this.bt_RelatSair.Size = new System.Drawing.Size(150, 50);
            this.bt_RelatSair.TabIndex = 1;
            this.bt_RelatSair.Text = "Sair";
            this.bt_RelatSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_RelatSair.UseVisualStyleBackColor = true;
            this.bt_RelatSair.Click += new System.EventHandler(this.bt_RelatSair_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.chb_RelatPesquisarData);
            this.panel3.Controls.Add(this.dt_RelatPesquisa);
            this.panel3.Controls.Add(this.bt_RelatPesquisar);
            this.panel3.Controls.Add(this.tb_RelatPesquisa);
            this.panel3.Controls.Add(this.dg_Relatorio);
            this.panel3.Location = new System.Drawing.Point(201, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(671, 437);
            this.panel3.TabIndex = 0;
            // 
            // chb_RelatPesquisarData
            // 
            this.chb_RelatPesquisarData.AutoSize = true;
            this.chb_RelatPesquisarData.Location = new System.Drawing.Point(611, 15);
            this.chb_RelatPesquisarData.Name = "chb_RelatPesquisarData";
            this.chb_RelatPesquisarData.Size = new System.Drawing.Size(15, 14);
            this.chb_RelatPesquisarData.TabIndex = 2;
            this.chb_RelatPesquisarData.UseVisualStyleBackColor = true;
            this.chb_RelatPesquisarData.CheckedChanged += new System.EventHandler(this.chb_RelatPesquisarData_CheckedChanged);
            // 
            // dt_RelatPesquisa
            // 
            this.dt_RelatPesquisa.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_RelatPesquisa.Location = new System.Drawing.Point(488, 5);
            this.dt_RelatPesquisa.Name = "dt_RelatPesquisa";
            this.dt_RelatPesquisa.Size = new System.Drawing.Size(117, 33);
            this.dt_RelatPesquisa.TabIndex = 1;
            // 
            // bt_RelatPesquisar
            // 
            this.bt_RelatPesquisar.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_RelatPesquisar.Image = global::Projeto_Estacionamento.Properties.Resources.lupa25x25;
            this.bt_RelatPesquisar.Location = new System.Drawing.Point(635, 5);
            this.bt_RelatPesquisar.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bt_RelatPesquisar.Name = "bt_RelatPesquisar";
            this.bt_RelatPesquisar.Size = new System.Drawing.Size(33, 33);
            this.bt_RelatPesquisar.TabIndex = 3;
            this.bt_RelatPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_RelatPesquisar.UseVisualStyleBackColor = true;
            this.bt_RelatPesquisar.Click += new System.EventHandler(this.bt_RelatPesquisar_Click);
            // 
            // tb_RelatPesquisa
            // 
            this.tb_RelatPesquisa.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_RelatPesquisa.Location = new System.Drawing.Point(3, 5);
            this.tb_RelatPesquisa.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tb_RelatPesquisa.Name = "tb_RelatPesquisa";
            this.tb_RelatPesquisa.Size = new System.Drawing.Size(476, 33);
            this.tb_RelatPesquisa.TabIndex = 0;
            this.tb_RelatPesquisa.Enter += new System.EventHandler(this.tb_RelatPesquisar_Enter);
            this.tb_RelatPesquisa.Leave += new System.EventHandler(this.tb_RelatPesquisar_Leave);
            // 
            // Relatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Relatorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório";
            this.Load += new System.EventHandler(this.Relatorio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_Relatorio)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dg_Relatorio;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button bt_RelatSair;
        private System.Windows.Forms.Button bt_RelatPesquisar;
        private System.Windows.Forms.TextBox tb_RelatPesquisa;
        private System.Windows.Forms.CheckBox chb_RelatPesquisarData;
        private System.Windows.Forms.DateTimePicker dt_RelatPesquisa;
        private System.Windows.Forms.Button bt_RelatRecarregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn celular;
        private System.Windows.Forms.DataGridViewTextBoxColumn veiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn placa;
        private System.Windows.Forms.DataGridViewTextBoxColumn acao;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
        private System.Windows.Forms.DataGridViewTextBoxColumn hora;
    }
}