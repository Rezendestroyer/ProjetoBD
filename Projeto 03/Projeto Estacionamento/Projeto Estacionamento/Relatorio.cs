using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Projeto_Estacionamento
{
    public partial class Relatorio : Form
    {
        public Relatorio()
        {
            InitializeComponent();
        }

        DBComandos comandos = new DBComandos();

        private NpgsqlConnection connection;
        private NpgsqlCommand command;
        private NpgsqlDataReader result;

        private string pesquisaIDLE = "Pesquisar...";

        private void bt_RelatPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                connectPostgres();

                if (chb_RelatPesquisarData.Checked)
                {
                    if (tb_RelatPesquisa.Text.Equals(pesquisaIDLE))
                    {
                        command = new NpgsqlCommand(
                        "SELECT c.nome, c.telefone, c.celular, v.modelo, v.placa, es.acao, es.data, es.hora FROM estacionamento.tb_entradasaida es " +
                        "INNER JOIN estacionamento.tb_veiculo v ON es.placa = v.placa " +
                        "INNER JOIN estacionamento.tb_cliente c ON es.cpf = c.cpf " +
                        "WHERE es.data = @DATA;", connection);
                    }
                    else
                    {
                        command = new NpgsqlCommand(
                        "SELECT c.nome, c.telefone, c.celular, v.modelo, v.placa, es.acao, es.data, es.hora FROM estacionamento.tb_entradasaida es " +
                        "INNER JOIN estacionamento.tb_veiculo v ON es.placa = v.placa " +
                        "INNER JOIN estacionamento.tb_cliente c ON es.cpf = c.cpf " +
                        "WHERE ((c.cpf ~* @DADO OR c.nome ~* @DADO OR v.modelo ~* @DADO OR v.placa ~* @DADO OR es.acao ~* @DADO) AND es.data = @DATA);", connection);

                        command.Parameters.Add("@DADO", NpgsqlTypes.NpgsqlDbType.Varchar);
                        command.Parameters["@DADO"].Value = tb_RelatPesquisa.Text;
                    }

                    command.Parameters.Add("@DATA", NpgsqlTypes.NpgsqlDbType.Date);
                    command.Parameters["@DATA"].Value = dt_RelatPesquisa.Value;
                }
                else
                {
                    command = new NpgsqlCommand(
                        "SELECT c.nome, c.telefone, c.celular, v.modelo, v.placa, es.acao, es.data, es.hora FROM estacionamento.tb_entradasaida es " +
                        "INNER JOIN estacionamento.tb_veiculo v ON es.placa = v.placa " +
                        "INNER JOIN estacionamento.tb_cliente c ON es.cpf = c.cpf " +
                        "WHERE (c.cpf ~* @DADO OR c.nome ~* @DADO OR v.modelo ~* @DADO OR v.placa ~* @DADO OR es.acao ~* @DADO);", connection);

                    command.Parameters.Add("@DADO", NpgsqlTypes.NpgsqlDbType.Varchar);
                    command.Parameters["@DADO"].Value = tb_RelatPesquisa.Text;
                }

                result = command.ExecuteReader();

                viewRecords();

                connection.Close();

                tb_RelatPesquisa.Text = pesquisaIDLE;
                dt_RelatPesquisa.Value = DateTime.Now;
            }
            catch (Exception excep)
            {
                MessageBox.Show("Não foi possível realizar a pesquisa no banco de dados!\n\nErro : " + excep, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Relatorio_Load(object sender, EventArgs e)
        {
            recarregar();
        }

        private void bt_RelatRecarregar_Click(object sender, EventArgs e)
        {
            recarregar();
        }

        private void bt_RelatSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chb_RelatPesquisarData_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tb_RelatPesquisar_Enter(object sender, EventArgs e)
        {
            if (tb_RelatPesquisa.Text.Equals(pesquisaIDLE)) tb_RelatPesquisa.Text = "";
        }

        private void tb_RelatPesquisar_Leave(object sender, EventArgs e)
        {
            if (tb_RelatPesquisa.Text.Equals("")) tb_RelatPesquisa.Text = pesquisaIDLE;
        }

        private void recarregar()
        {
            tb_RelatPesquisa.Text = pesquisaIDLE;
            dt_RelatPesquisa.Value = DateTime.Now;

            connectPostgres();

            command = new NpgsqlCommand(
                "SELECT c.nome, c.telefone, c.celular, v.modelo, v.placa, es.acao, es.data, es.hora FROM estacionamento.tb_entradasaida es " +
                "INNER JOIN estacionamento.tb_veiculo v ON es.placa = v.placa " +
                "INNER JOIN estacionamento.tb_cliente c ON es.cpf = c.cpf;", connection);

            result = command.ExecuteReader();

            viewRecords();

            connection.Close();
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
                dg_Relatorio.Rows.Clear();

                while (result.Read())
                {
                    dg_Relatorio.Rows.Add(result[0], result[1], result[2], result[3], result[4], result[5], 
                        String.Format("{0:dd/MM/yyyy}", DateTime.Parse(result[6].ToString())), String.Format("{0:HH:mm:ss}", DateTime.Parse(result[7].ToString())));
                }
            }
            catch (Exception excep)
            {
                MessageBox.Show("Não foi possível obter os valores do banco de dados!\n\nErro: " + excep, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
