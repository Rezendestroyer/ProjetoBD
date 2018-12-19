using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;

namespace Projeto_Estacionamento
{
    public partial class CadastroVeiculo : Form
    {
        public CadastroVeiculo(string cpf)
        {
            InitializeComponent();
            this.cpf = cpf;
            cadastrar();
        }

        DBComandos comandos = new DBComandos();

        string cpf = "";
        private string pesquisaIDLE = "Pesquisar...";
        private string status = "Cadastrar";

        private void bt_CadVConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                Veiculo veiculo = getValues();

                if (status.Equals("Cadastrar") && veiculo != null)
                {
                    if (comandos.cadastrarVeiculo(veiculo))
                    {
                        MessageBox.Show(" Veículo cadastrado com sucesso!");
                        clear();
                    }
                }
                else if (status.Equals("Atualizar") && veiculo != null)
                {
                    if (comandos.atualizarVeiculo(veiculo))
                    {
                        MessageBox.Show(" Veículo atualizado com sucesso!");
                        clear();
                    }
                }
                else
                {
                    MessageBox.Show("Não foi possível realizar o cadastro do veículo!\n" +
                    "Verifique se todos os campos foram preenchidos corretamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception excep)
            {
                MessageBox.Show("Não foi possível realizar o cadastro do veículo!\n" +
                    "Verifique se todos os campos foram preenchidos corretamente.\n\n" +
                    "Erro: " + excep, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bt_CadVCancelar_Click(object sender, EventArgs e)
        {

        }

        private void bt_CadVExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (dg_CadVConsulta.SelectedCells[2].Value != null)
                {
                    if (MessageBox.Show("Tem certeza de que deseja excluir este registro?", "Excluir registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                       

                        MessageBox.Show("Registro excluido com sucesso!");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, selecione uma linha válida da tabela.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception excep)
            {
                MessageBox.Show("Não foi possível realizar a exclusão!\n\nErro: " + excep, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bt_CadVCadastrar_Click_1(object sender, EventArgs e)
        {
            cadastrar();
        }

        private void bt_CadVAtualizar_Click(object sender, EventArgs e)
        {
            atualizar();
        }

        private void bt_CadVConsultar_Click(object sender, EventArgs e)
        {
            consultar();

            BsonArray  docs = comandos.consultarVeiculos(cpf);
            
            dg_CadVConsulta.Rows.Clear();

            foreach (BsonDocument doc in docs)
            {
                VeiculosDocument veiculo = BsonSerializer.Deserialize<VeiculosDocument>(doc);

                dg_CadVConsulta.Rows.Add(veiculo.marca, veiculo.modelo, veiculo.placa);
            }
        }

        private void bt_CadVSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_CadCPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (Exception excep)
            {
                MessageBox.Show("Não foi possível realizar a pesquisa no banco de dados!\n\nErro : " + excep, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tb_CadVPesquisa_Enter(object sender, EventArgs e)
        {
            if (tb_CadVPesquisa.Text.Equals(pesquisaIDLE)) tb_CadVPesquisa.Text = "";
        }

        private void tb_CadVPesquisa_Leave(object sender, EventArgs e)
        {
            if (tb_CadVPesquisa.Text.Equals("")) tb_CadVPesquisa.Text = pesquisaIDLE;
        }

        private void cb_CadVPlaca_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_CadVPlaca.SelectedIndex == 0 && status.Equals("Atualizar"))
            {
                clear();
                disableFields();
            }
            else if (status.Equals("Atualizar"))
            {
                enableFields();
                setValues();
            }
        }

        private void clear()
        {
            tb_CadVMarca.Text = tb_CadVModelo.Text = mtb_CadVPlaca.Text = "";
            cb_CadVPlaca.SelectedIndex = 0;
            tb_CadVPesquisa.Text = pesquisaIDLE;
        }

        private void enableFields()
        {
            tb_CadVMarca.Enabled = tb_CadVModelo.Enabled = true;
        }

        private void disableFields()
        {
            tb_CadVMarca.Enabled = tb_CadVModelo.Enabled = false;
        }

        private void cadastrar()
        {
            clear();

            tb_CadVMarca.Enabled = tb_CadVModelo.Enabled = true;

            panel_CadVVeiculo.Visible = true;
            panel_CadVConsultar.Visible = false;

            mtb_CadVPlaca.Visible = true;
            cb_CadVPlaca.Visible = false;

            bt_CadVConfirmar.Visible = bt_CadVCancelar.Visible = true;
            bt_CadVExcluir.Visible = false;

            status = "Cadastrar";
        }

        private void atualizar()
        {
            clear();

            tb_CadVMarca.Enabled = tb_CadVModelo.Enabled = false;

            panel_CadVVeiculo.Visible = true;
            panel_CadVConsultar.Visible = false;

            mtb_CadVPlaca.Visible = false;
            cb_CadVPlaca.Visible = true;

            bt_CadVConfirmar.Visible = bt_CadVCancelar.Visible = true;
            bt_CadVExcluir.Visible = false;

            status = "Atualizar";

            try
            {
                cb_CadVPlaca.Items.Clear();
                cb_CadVPlaca.Items.Add("");

                BsonArray docs = comandos.consultarVeiculos(cpf);

                foreach (BsonDocument doc in docs)
                {
                    VeiculosDocument veiculo = BsonSerializer.Deserialize<VeiculosDocument>(doc);

                    cb_CadVPlaca.Items.Add(veiculo.placa);
                }
            }
            catch (Exception excep)
            {
                MessageBox.Show("Não foi possível obter os valores do banco de dados!\n\nErro: " + excep, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void consultar()
        {
            clear();

            panel_CadVVeiculo.Visible = false;
            panel_CadVConsultar.Visible = true;

            bt_CadVConfirmar.Visible = bt_CadVCancelar.Visible = false;
            bt_CadVExcluir.Visible = true;
        }

        private Veiculo getValues()
        {
            if (!(tb_CadVMarca.Text.Equals("") || tb_CadVModelo.Text.Equals("")))
            {
                if (status.Equals("Cadastrar") && mtb_CadVPlaca.MaskFull)
                {
                    return new Veiculo(cpf, tb_CadVMarca.Text, tb_CadVModelo.Text, mtb_CadVPlaca.Text);
                }
                else if (status.Equals("Atualizar") && cb_CadVPlaca.SelectedIndex != 0)
                {
                    return new Veiculo(cpf, tb_CadVMarca.Text, tb_CadVModelo.Text, cb_CadVPlaca.SelectedItem.ToString());
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }

        private void setValues()
        {
            try
            {
                VeiculosDocument doc = comandos.consultarVeiculo(cpf, cb_CadVPlaca.SelectedItem.ToString());
                
                tb_CadVMarca.Text = doc.marca;
                tb_CadVModelo.Text = doc.modelo;
            }
            catch (Exception excep)
            {
                MessageBox.Show("Não foi possível obter os valores do banco de dados!\n\nErro: " + excep, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
