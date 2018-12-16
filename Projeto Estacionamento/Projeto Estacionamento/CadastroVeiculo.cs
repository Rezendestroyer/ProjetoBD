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
using Npgsql;

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

        private NpgsqlConnection connection;
        private NpgsqlCommand command;
        private NpgsqlDataReader result;

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
                        connectPostgres();

                        command = new NpgsqlCommand("DELETE FROM estacionamento.tb_veiculo WHERE placa = '"
                            + dg_CadVConsulta.SelectedCells[2].Value.ToString() + "';", connection);

                        command.ExecuteReader();

                        connection.Close();

                        connectPostgres();

                        command = new NpgsqlCommand("SELECT * FROM estacionamento.tb_veiculo;", connection);

                        result = command.ExecuteReader();

                        viewRecords();

                        connection.Close();

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

            VeiculosDocument docs = comandos.consultarVeiculo(cpf);

            dg_CadVConsulta.Rows.Clear();

            

            docs.ForEach(doc =>
            {
                dg_CadVConsulta.Rows.Add(doc);
            });

            consultar();

            connectPostgres();

            command = new NpgsqlCommand("SELECT * FROM estacionamento.tb_veiculo WHERE cpf = @CPF ORDER BY marca;", connection);

            command.Parameters.Add("@CPF", NpgsqlTypes.NpgsqlDbType.Varchar);
            command.Parameters["@CPF"].Value = cpf;

            result = command.ExecuteReader();

            viewRecords();

            connection.Close();
        }

        private void bt_CadVSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_CadCPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                connectPostgres();

                command = new NpgsqlCommand("SELECT * FROM estacionamento.tb_veiculo WHERE (marca ~* @DADO OR modelo ~* @DADO OR placa ~* @DADO AND cpf = @CPF) ORDER BY marca;", connection);

                command.Parameters.Add("@DADO", NpgsqlTypes.NpgsqlDbType.Varchar);
                command.Parameters["@DADO"].Value = tb_CadVPesquisa.Text;

                command.Parameters.Add("@CPF", NpgsqlTypes.NpgsqlDbType.Varchar);
                command.Parameters["@CPF"].Value = cpf;

                result = command.ExecuteReader();

                viewRecords();

                connection.Close();
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
                connectPostgres();

                command = new NpgsqlCommand("SELECT placa FROM estacionamento.tb_veiculo;", connection);

                result = command.ExecuteReader();

                cb_CadVPlaca.Items.Clear();
                cb_CadVPlaca.Items.Add("");

                while (result.Read())
                {
                    cb_CadVPlaca.Items.Add(result[0].ToString());
                }

                connection.Close();
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
                connectPostgres();

                command = new NpgsqlCommand("SELECT * FROM estacionamento.tb_veiculo WHERE placa = @PLACA;", connection);

                command.Parameters.Add("@PLACA", NpgsqlTypes.NpgsqlDbType.Varchar);
                command.Parameters["@PLACA"].Value = cb_CadVPlaca.SelectedItem.ToString();

                result = command.ExecuteReader();

                result.Read();

                Veiculo veiculo = new Veiculo(result[0].ToString(), result[1].ToString(), result[2].ToString(), result[3].ToString());

                tb_CadVMarca.Text = veiculo.getMarca();
                tb_CadVModelo.Text = veiculo.getModelo();
            }
            catch (Exception excep)
            {
                MessageBox.Show("Não foi possível obter os valores do banco de dados!\n\nErro: " + excep, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void connectPostgres()
        {
            try
            {
                connection = new NpgsqlConnection("Server = 127.0.0.1; User Id = postgres; Password = banco; Database = dbestacionamento");
                connection.Open();
            }
            catch (Exception excep)
            {
                MessageBox.Show("Não foi possível conectar ao banco de dados!\n\nErro: " + excep, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void viewRecords()
        {
            try
            {
                dg_CadVConsulta.Rows.Clear();

                while (result.Read())
                {
                    dg_CadVConsulta.Rows.Add(result[1], result[2], result[3]);
                }
            }
            catch (Exception excep)
            {
                MessageBox.Show("Não foi possível obter os valores do banco de dados!\n\nErro: " + excep, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
