namespace Projeto_Estacionamento
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.bt_MenuSair = new System.Windows.Forms.Button();
            this.bt_MenuRelatorio = new System.Windows.Forms.Button();
            this.bt_MenuEntSaidas = new System.Windows.Forms.Button();
            this.bt_MenuCliente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_MenuSair
            // 
            this.bt_MenuSair.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_MenuSair.Image = global::Projeto_Estacionamento.Properties.Resources.sair40x40red_final;
            this.bt_MenuSair.Location = new System.Drawing.Point(192, 195);
            this.bt_MenuSair.Margin = new System.Windows.Forms.Padding(5);
            this.bt_MenuSair.Name = "bt_MenuSair";
            this.bt_MenuSair.Size = new System.Drawing.Size(100, 50);
            this.bt_MenuSair.TabIndex = 8;
            this.bt_MenuSair.Text = "Sair";
            this.bt_MenuSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_MenuSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_MenuSair.UseVisualStyleBackColor = true;
            this.bt_MenuSair.Click += new System.EventHandler(this.bt_MenuSair_Click);
            // 
            // bt_MenuRelatorio
            // 
            this.bt_MenuRelatorio.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_MenuRelatorio.Image = ((System.Drawing.Image)(resources.GetObject("bt_MenuRelatorio.Image")));
            this.bt_MenuRelatorio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_MenuRelatorio.Location = new System.Drawing.Point(140, 135);
            this.bt_MenuRelatorio.Margin = new System.Windows.Forms.Padding(5);
            this.bt_MenuRelatorio.Name = "bt_MenuRelatorio";
            this.bt_MenuRelatorio.Size = new System.Drawing.Size(205, 50);
            this.bt_MenuRelatorio.TabIndex = 4;
            this.bt_MenuRelatorio.Text = "Relatório";
            this.bt_MenuRelatorio.UseVisualStyleBackColor = true;
            this.bt_MenuRelatorio.Click += new System.EventHandler(this.bt_MenuRelatorio_Click);
            // 
            // bt_MenuEntSaidas
            // 
            this.bt_MenuEntSaidas.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_MenuEntSaidas.Image = global::Projeto_Estacionamento.Properties.Resources.entradasaida40x40;
            this.bt_MenuEntSaidas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_MenuEntSaidas.Location = new System.Drawing.Point(140, 75);
            this.bt_MenuEntSaidas.Margin = new System.Windows.Forms.Padding(5);
            this.bt_MenuEntSaidas.Name = "bt_MenuEntSaidas";
            this.bt_MenuEntSaidas.Size = new System.Drawing.Size(205, 50);
            this.bt_MenuEntSaidas.TabIndex = 3;
            this.bt_MenuEntSaidas.Text = "Entradas e Saídas";
            this.bt_MenuEntSaidas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_MenuEntSaidas.UseVisualStyleBackColor = true;
            this.bt_MenuEntSaidas.Click += new System.EventHandler(this.bt_MenuEntSaidas_Click);
            // 
            // bt_MenuCliente
            // 
            this.bt_MenuCliente.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_MenuCliente.Image = ((System.Drawing.Image)(resources.GetObject("bt_MenuCliente.Image")));
            this.bt_MenuCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_MenuCliente.Location = new System.Drawing.Point(140, 15);
            this.bt_MenuCliente.Margin = new System.Windows.Forms.Padding(5);
            this.bt_MenuCliente.Name = "bt_MenuCliente";
            this.bt_MenuCliente.Size = new System.Drawing.Size(205, 50);
            this.bt_MenuCliente.TabIndex = 1;
            this.bt_MenuCliente.Text = "Cliente";
            this.bt_MenuCliente.UseVisualStyleBackColor = true;
            this.bt_MenuCliente.Click += new System.EventHandler(this.bt_MenuCadCliente_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.bt_MenuSair);
            this.Controls.Add(this.bt_MenuRelatorio);
            this.Controls.Add(this.bt_MenuEntSaidas);
            this.Controls.Add(this.bt_MenuCliente);
            this.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Estacionamento";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bt_MenuCliente;
        private System.Windows.Forms.Button bt_MenuEntSaidas;
        private System.Windows.Forms.Button bt_MenuRelatorio;
        private System.Windows.Forms.Button bt_MenuSair;
    }
}