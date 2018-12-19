namespace Projeto_Estacionamento
{
    partial class CadastroVeiculo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroVeiculo));
            this.lb_CadVMarca = new System.Windows.Forms.Label();
            this.lb_CadVModelo = new System.Windows.Forms.Label();
            this.lb_CadVPlaca = new System.Windows.Forms.Label();
            this.tb_CadVMarca = new System.Windows.Forms.TextBox();
            this.tb_CadVModelo = new System.Windows.Forms.TextBox();
            this.mtb_CadVPlaca = new System.Windows.Forms.MaskedTextBox();
            this.panel_CadVVeiculo = new System.Windows.Forms.Panel();
            this.cb_CadVPlaca = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bt_CadVSair = new System.Windows.Forms.Button();
            this.bt_CadVConsultar = new System.Windows.Forms.Button();
            this.bt_CadVAtualizar = new System.Windows.Forms.Button();
            this.bt_CadVCadastrar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bt_CadVCancelar = new System.Windows.Forms.Button();
            this.bt_CadVConfirmar = new System.Windows.Forms.Button();
            this.bt_CadVExcluir = new System.Windows.Forms.Button();
            this.panel_CadVConsultar = new System.Windows.Forms.Panel();
            this.bt_CadCPesquisar = new System.Windows.Forms.Button();
            this.tb_CadVPesquisa = new System.Windows.Forms.TextBox();
            this.dg_CadVConsulta = new System.Windows.Forms.DataGridView();
            this.marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_CadVVeiculo.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel_CadVConsultar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_CadVConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_CadVMarca
            // 
            this.lb_CadVMarca.AutoSize = true;
            this.lb_CadVMarca.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CadVMarca.Location = new System.Drawing.Point(179, 30);
            this.lb_CadVMarca.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_CadVMarca.Name = "lb_CadVMarca";
            this.lb_CadVMarca.Size = new System.Drawing.Size(63, 22);
            this.lb_CadVMarca.TabIndex = 1;
            this.lb_CadVMarca.Text = "Marca";
            // 
            // lb_CadVModelo
            // 
            this.lb_CadVModelo.AutoSize = true;
            this.lb_CadVModelo.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CadVModelo.Location = new System.Drawing.Point(173, 95);
            this.lb_CadVModelo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_CadVModelo.Name = "lb_CadVModelo";
            this.lb_CadVModelo.Size = new System.Drawing.Size(75, 22);
            this.lb_CadVModelo.TabIndex = 2;
            this.lb_CadVModelo.Text = "Modelo";
            // 
            // lb_CadVPlaca
            // 
            this.lb_CadVPlaca.AutoSize = true;
            this.lb_CadVPlaca.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CadVPlaca.Location = new System.Drawing.Point(183, 160);
            this.lb_CadVPlaca.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_CadVPlaca.Name = "lb_CadVPlaca";
            this.lb_CadVPlaca.Size = new System.Drawing.Size(55, 22);
            this.lb_CadVPlaca.TabIndex = 3;
            this.lb_CadVPlaca.Text = "Placa";
            // 
            // tb_CadVMarca
            // 
            this.tb_CadVMarca.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_CadVMarca.Location = new System.Drawing.Point(76, 57);
            this.tb_CadVMarca.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tb_CadVMarca.Name = "tb_CadVMarca";
            this.tb_CadVMarca.Size = new System.Drawing.Size(268, 33);
            this.tb_CadVMarca.TabIndex = 0;
            this.tb_CadVMarca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_CadVModelo
            // 
            this.tb_CadVModelo.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_CadVModelo.Location = new System.Drawing.Point(76, 122);
            this.tb_CadVModelo.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tb_CadVModelo.Name = "tb_CadVModelo";
            this.tb_CadVModelo.Size = new System.Drawing.Size(268, 33);
            this.tb_CadVModelo.TabIndex = 1;
            this.tb_CadVModelo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mtb_CadVPlaca
            // 
            this.mtb_CadVPlaca.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtb_CadVPlaca.Location = new System.Drawing.Point(121, 187);
            this.mtb_CadVPlaca.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.mtb_CadVPlaca.Mask = "AAA-0000";
            this.mtb_CadVPlaca.Name = "mtb_CadVPlaca";
            this.mtb_CadVPlaca.Size = new System.Drawing.Size(178, 33);
            this.mtb_CadVPlaca.TabIndex = 6;
            this.mtb_CadVPlaca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel_CadVVeiculo
            // 
            this.panel_CadVVeiculo.Controls.Add(this.tb_CadVModelo);
            this.panel_CadVVeiculo.Controls.Add(this.lb_CadVMarca);
            this.panel_CadVVeiculo.Controls.Add(this.lb_CadVPlaca);
            this.panel_CadVVeiculo.Controls.Add(this.tb_CadVMarca);
            this.panel_CadVVeiculo.Controls.Add(this.lb_CadVModelo);
            this.panel_CadVVeiculo.Controls.Add(this.cb_CadVPlaca);
            this.panel_CadVVeiculo.Controls.Add(this.mtb_CadVPlaca);
            this.panel_CadVVeiculo.Location = new System.Drawing.Point(201, 12);
            this.panel_CadVVeiculo.Name = "panel_CadVVeiculo";
            this.panel_CadVVeiculo.Size = new System.Drawing.Size(421, 251);
            this.panel_CadVVeiculo.TabIndex = 0;
            // 
            // cb_CadVPlaca
            // 
            this.cb_CadVPlaca.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cb_CadVPlaca.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_CadVPlaca.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_CadVPlaca.FormattingEnabled = true;
            this.cb_CadVPlaca.Items.AddRange(new object[] {
            ""});
            this.cb_CadVPlaca.Location = new System.Drawing.Point(121, 187);
            this.cb_CadVPlaca.Name = "cb_CadVPlaca";
            this.cb_CadVPlaca.Size = new System.Drawing.Size(178, 33);
            this.cb_CadVPlaca.TabIndex = 2;
            this.cb_CadVPlaca.SelectedIndexChanged += new System.EventHandler(this.cb_CadVPlaca_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bt_CadVSair);
            this.panel2.Controls.Add(this.bt_CadVConsultar);
            this.panel2.Controls.Add(this.bt_CadVAtualizar);
            this.panel2.Controls.Add(this.bt_CadVCadastrar);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(175, 312);
            this.panel2.TabIndex = 2;
            // 
            // bt_CadVSair
            // 
            this.bt_CadVSair.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_CadVSair.Location = new System.Drawing.Point(12, 221);
            this.bt_CadVSair.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bt_CadVSair.Name = "bt_CadVSair";
            this.bt_CadVSair.Size = new System.Drawing.Size(150, 50);
            this.bt_CadVSair.TabIndex = 3;
            this.bt_CadVSair.Text = "Sair";
            this.bt_CadVSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_CadVSair.UseVisualStyleBackColor = true;
            this.bt_CadVSair.Click += new System.EventHandler(this.bt_CadVSair_Click);
            // 
            // bt_CadVConsultar
            // 
            this.bt_CadVConsultar.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_CadVConsultar.Location = new System.Drawing.Point(12, 161);
            this.bt_CadVConsultar.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bt_CadVConsultar.Name = "bt_CadVConsultar";
            this.bt_CadVConsultar.Size = new System.Drawing.Size(150, 50);
            this.bt_CadVConsultar.TabIndex = 2;
            this.bt_CadVConsultar.Text = "Consultar";
            this.bt_CadVConsultar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_CadVConsultar.UseVisualStyleBackColor = true;
            this.bt_CadVConsultar.Click += new System.EventHandler(this.bt_CadVConsultar_Click);
            // 
            // bt_CadVAtualizar
            // 
            this.bt_CadVAtualizar.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_CadVAtualizar.Location = new System.Drawing.Point(12, 101);
            this.bt_CadVAtualizar.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bt_CadVAtualizar.Name = "bt_CadVAtualizar";
            this.bt_CadVAtualizar.Size = new System.Drawing.Size(150, 50);
            this.bt_CadVAtualizar.TabIndex = 1;
            this.bt_CadVAtualizar.Text = "Atualizar";
            this.bt_CadVAtualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_CadVAtualizar.UseVisualStyleBackColor = true;
            this.bt_CadVAtualizar.Click += new System.EventHandler(this.bt_CadVAtualizar_Click);
            // 
            // bt_CadVCadastrar
            // 
            this.bt_CadVCadastrar.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_CadVCadastrar.Location = new System.Drawing.Point(12, 41);
            this.bt_CadVCadastrar.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bt_CadVCadastrar.Name = "bt_CadVCadastrar";
            this.bt_CadVCadastrar.Size = new System.Drawing.Size(150, 50);
            this.bt_CadVCadastrar.TabIndex = 0;
            this.bt_CadVCadastrar.Text = "Cadastrar";
            this.bt_CadVCadastrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_CadVCadastrar.UseVisualStyleBackColor = true;
            this.bt_CadVCadastrar.Click += new System.EventHandler(this.bt_CadVCadastrar_Click_1);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.bt_CadVCancelar);
            this.panel3.Controls.Add(this.bt_CadVExcluir);
            this.panel3.Controls.Add(this.bt_CadVConfirmar);
            this.panel3.Location = new System.Drawing.Point(201, 268);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(421, 56);
            this.panel3.TabIndex = 1;
            // 
            // bt_CadVCancelar
            // 
            this.bt_CadVCancelar.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_CadVCancelar.Image = ((System.Drawing.Image)(resources.GetObject("bt_CadVCancelar.Image")));
            this.bt_CadVCancelar.Location = new System.Drawing.Point(29, 3);
            this.bt_CadVCancelar.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bt_CadVCancelar.Name = "bt_CadVCancelar";
            this.bt_CadVCancelar.Size = new System.Drawing.Size(175, 50);
            this.bt_CadVCancelar.TabIndex = 1;
            this.bt_CadVCancelar.Text = "Cancelar";
            this.bt_CadVCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_CadVCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_CadVCancelar.UseVisualStyleBackColor = true;
            this.bt_CadVCancelar.Click += new System.EventHandler(this.bt_CadVCancelar_Click);
            // 
            // bt_CadVConfirmar
            // 
            this.bt_CadVConfirmar.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_CadVConfirmar.Image = global::Projeto_Estacionamento.Properties.Resources.check40x40;
            this.bt_CadVConfirmar.Location = new System.Drawing.Point(216, 3);
            this.bt_CadVConfirmar.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bt_CadVConfirmar.Name = "bt_CadVConfirmar";
            this.bt_CadVConfirmar.Size = new System.Drawing.Size(175, 50);
            this.bt_CadVConfirmar.TabIndex = 0;
            this.bt_CadVConfirmar.Text = "Confirmar";
            this.bt_CadVConfirmar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_CadVConfirmar.UseVisualStyleBackColor = true;
            this.bt_CadVConfirmar.Click += new System.EventHandler(this.bt_CadVConfirmar_Click);
            // 
            // bt_CadVExcluir
            // 
            this.bt_CadVExcluir.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_CadVExcluir.Image = global::Projeto_Estacionamento.Properties.Resources.trash40x40;
            this.bt_CadVExcluir.Location = new System.Drawing.Point(123, 3);
            this.bt_CadVExcluir.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bt_CadVExcluir.Name = "bt_CadVExcluir";
            this.bt_CadVExcluir.Size = new System.Drawing.Size(175, 50);
            this.bt_CadVExcluir.TabIndex = 2;
            this.bt_CadVExcluir.Text = "Excluir";
            this.bt_CadVExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_CadVExcluir.UseVisualStyleBackColor = true;
            this.bt_CadVExcluir.Click += new System.EventHandler(this.bt_CadVExcluir_Click);
            // 
            // panel_CadVConsultar
            // 
            this.panel_CadVConsultar.Controls.Add(this.bt_CadCPesquisar);
            this.panel_CadVConsultar.Controls.Add(this.tb_CadVPesquisa);
            this.panel_CadVConsultar.Controls.Add(this.dg_CadVConsulta);
            this.panel_CadVConsultar.Location = new System.Drawing.Point(201, 12);
            this.panel_CadVConsultar.Name = "panel_CadVConsultar";
            this.panel_CadVConsultar.Size = new System.Drawing.Size(421, 251);
            this.panel_CadVConsultar.TabIndex = 0;
            // 
            // bt_CadCPesquisar
            // 
            this.bt_CadCPesquisar.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_CadCPesquisar.Image = global::Projeto_Estacionamento.Properties.Resources.lupa25x25;
            this.bt_CadCPesquisar.Location = new System.Drawing.Point(385, 5);
            this.bt_CadCPesquisar.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bt_CadCPesquisar.Name = "bt_CadCPesquisar";
            this.bt_CadCPesquisar.Size = new System.Drawing.Size(33, 33);
            this.bt_CadCPesquisar.TabIndex = 1;
            this.bt_CadCPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_CadCPesquisar.UseVisualStyleBackColor = true;
            this.bt_CadCPesquisar.Click += new System.EventHandler(this.bt_CadCPesquisar_Click);
            // 
            // tb_CadVPesquisa
            // 
            this.tb_CadVPesquisa.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_CadVPesquisa.Location = new System.Drawing.Point(3, 5);
            this.tb_CadVPesquisa.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tb_CadVPesquisa.Name = "tb_CadVPesquisa";
            this.tb_CadVPesquisa.Size = new System.Drawing.Size(370, 33);
            this.tb_CadVPesquisa.TabIndex = 0;
            this.tb_CadVPesquisa.Enter += new System.EventHandler(this.tb_CadVPesquisa_Enter);
            this.tb_CadVPesquisa.Leave += new System.EventHandler(this.tb_CadVPesquisa_Leave);
            // 
            // dg_CadVConsulta
            // 
            this.dg_CadVConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_CadVConsulta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.marca,
            this.modelo,
            this.placa});
            this.dg_CadVConsulta.Location = new System.Drawing.Point(3, 46);
            this.dg_CadVConsulta.MultiSelect = false;
            this.dg_CadVConsulta.Name = "dg_CadVConsulta";
            this.dg_CadVConsulta.ReadOnly = true;
            this.dg_CadVConsulta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_CadVConsulta.Size = new System.Drawing.Size(415, 202);
            this.dg_CadVConsulta.TabIndex = 2;
            // 
            // marca
            // 
            this.marca.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.marca.HeaderText = "Marca";
            this.marca.Name = "marca";
            this.marca.ReadOnly = true;
            this.marca.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.marca.Width = 88;
            // 
            // modelo
            // 
            this.modelo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.modelo.HeaderText = "Modelo";
            this.modelo.Name = "modelo";
            this.modelo.ReadOnly = true;
            this.modelo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Location = new System.Drawing.Point(193, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2, 312);
            this.panel1.TabIndex = 18;
            // 
            // CadastroVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 336);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel_CadVVeiculo);
            this.Controls.Add(this.panel_CadVConsultar);
            this.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "CadastroVeiculo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Veículo";
            this.panel_CadVVeiculo.ResumeLayout(false);
            this.panel_CadVVeiculo.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel_CadVConsultar.ResumeLayout(false);
            this.panel_CadVConsultar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_CadVConsulta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lb_CadVMarca;
        private System.Windows.Forms.Label lb_CadVModelo;
        private System.Windows.Forms.Label lb_CadVPlaca;
        private System.Windows.Forms.TextBox tb_CadVMarca;
        private System.Windows.Forms.TextBox tb_CadVModelo;
        private System.Windows.Forms.MaskedTextBox mtb_CadVPlaca;
        private System.Windows.Forms.Panel panel_CadVVeiculo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button bt_CadVExcluir;
        private System.Windows.Forms.Button bt_CadVCancelar;
        private System.Windows.Forms.Button bt_CadVConfirmar;
        private System.Windows.Forms.Button bt_CadVConsultar;
        private System.Windows.Forms.Button bt_CadVAtualizar;
        private System.Windows.Forms.Button bt_CadVCadastrar;
        private System.Windows.Forms.Panel panel_CadVConsultar;
        private System.Windows.Forms.DataGridView dg_CadVConsulta;
        private System.Windows.Forms.Button bt_CadCPesquisar;
        private System.Windows.Forms.TextBox tb_CadVPesquisa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_CadVSair;
        private System.Windows.Forms.ComboBox cb_CadVPlaca;
        private System.Windows.Forms.DataGridViewTextBoxColumn marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn placa;
    }
}