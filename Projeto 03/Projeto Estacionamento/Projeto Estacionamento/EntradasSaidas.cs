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
    public partial class EntradasSaidas : Form
    {
        public EntradasSaidas()
        {
            InitializeComponent();
        }

        DBComandos comandos = new DBComandos();

        private string pesquisaIDLE = "Pesquisar...";

        private void bt_EntSaidSalvar_Click(object sender, EventArgs e)
        {
            /*Evento evento = new Evento(Convert.ToString(cb_EntSaidCliente.Text), Convert.ToString(cb_EntSaidPlaca.Text), tb_EntSaidAcao.Text, mtb_EntSaidHora.Text, mtb_EntSaidData.Text);
            comandos.cadastrarEvento(evento);

            MessageBox.Show(" Evento cadastrado com Sucesso! ");
            tb_EntSaidAcao.Text = "";
            mtb_EntSaidHora.Text = "";
            mtb_EntSaidData.Text = "";

            this.Close();*/
        }

        private void EntradasSaidas_Load(object sender, EventArgs e)
        {
            cadastrar();
            /*cb_EntSaidCliente.Items.Clear();
            cb_EntSaidPlaca.Items.Clear();

            NpgsqlConnection npgsqlConnection = new NpgsqlConnection(connectionString);
            npgsqlConnection.Open();
            String cmdSelecionarClientes = "SELECT nome FROM bdest.tb_clientes ORDER BY nome";
            String cmdSelecionarVeiculos = "SELECT placa FROM bdest.tb_veiculos ORDER BY placa";
            NpgsqlCommand sc = new NpgsqlCommand(cmdSelecionarClientes, npgsqlConnection);
            NpgsqlCommand sv = new NpgsqlCommand(cmdSelecionarVeiculos, npgsqlConnection);
            NpgsqlDataReader reader1;
            NpgsqlDataReader reader2; 

            reader1 = sc.ExecuteReader();
            DataTable dt1 = new DataTable();
            dt1.Columns.Add("nome", typeof(string));
            dt1.Load(reader1);

            cb_EntSaidCliente.ValueMember = "nome";
            cb_EntSaidCliente.DataSource = dt1;

            reader2 = sv.ExecuteReader();
            DataTable dt2 = new DataTable();
            dt2.Columns.Add("placa", typeof(string));
            dt2.Load(reader2);

            cb_EntSaidPlaca.ValueMember = "placa";
            cb_EntSaidPlaca.DataSource = dt2;

            if (npgsqlConnection != null)
            {
                npgsqlConnection.Close();
            }*/
        }

        private void bt_EntSaidConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cb_EntSaidCliente.SelectedIndex != 0 && cb_EntSaidPlaca.SelectedIndex != 0)
                {
                    EntradaSaida entradaSaida = new EntradaSaida(cb_EntSaidCliente.SelectedItem.ToString(), cb_EntSaidPlaca.SelectedItem.ToString(), null, Convert.ToDateTime(dt_EntSaidData.Value.Date + dt_EntSaidHora.Value.TimeOfDay));

                    foreach (RadioButton rb in gb_EntSaidAcao.Controls.OfType<RadioButton>())
                    {
                        if (rb.Checked)
                        {
                            entradaSaida.setAcao(rb.Text);
                            break;
                        }
                    }

                    if (comandos.cadastrarEntradaSaida(entradaSaida))
                    {
                        MessageBox.Show("Cadastro realizado com sucesso!");
                        clear();
                    }
                }
                else
                {
                    MessageBox.Show("Não foi possível realizar o cadastro!\n" +
                    "Verifique se todos os campos foram preenchidos corretamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception excep)
            {
                MessageBox.Show("Não foi possível realizar o cadastro!\n" +
                    "Verifique se todos os campos foram preenchidos corretamente.\n\nErro: " + excep, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bt_EntSaidCancelar_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void bt_EntSaidExcluir_Click(object sender, EventArgs e)
        {

        }

        private void bt_EntSaidCadastrar_Click(object sender, EventArgs e)
        {
            cadastrar();
        }

        private void bt_EntSaidConsultar_Click(object sender, EventArgs e)
        {
            consultar();

            connectPostgres();

            command = new NpgsqlCommand("SELECT * FROM estacionamento.tb_entradasaida ORDER BY cpf;", connection);

            result = command.ExecuteReader();

            viewRecords();

            connection.Close();
        }

        private void bt_EntSaidSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_EntSaidPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                connectPostgres();

                command = new NpgsqlCommand("SELECT * FROM estacionamento.tb_entradasaida WHERE (cpf ~* @DADO OR placa ~* @DADO) ORDER BY cpf;", connection);

                command.Parameters.Add("@DADO", NpgsqlTypes.NpgsqlDbType.Varchar);
                command.Parameters["@DADO"].Value = tb_EntSaidPesquisa.Text;

                result = command.ExecuteReader();

                viewRecords();

                connection.Close();
            }
            catch (Exception excep)
            {
                MessageBox.Show("Não foi possível realizar a pesquisa no banco de dados!\n\nErro : " + excep, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cb_EntSaidCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_EntSaidCliente.SelectedIndex == 0)
            {
                clear();
                cb_EntSaidPlaca.Enabled = false;
            }
            else
            {
                cb_EntSaidPlaca.Enabled = true;

                try
                {
                    connectPostgres();

                    command = new NpgsqlCommand("SELECT c.nome, v.placa FROM estacionamento.tb_cliente c, estacionamento.tb_veiculo v " +
                        "WHERE c.cpf = @CPF AND v.cpf = c.cpf;", connection);

                    command.Parameters.Add("@CPF", NpgsqlTypes.NpgsqlDbType.Varchar);
                    command.Parameters["@CPF"].Value = cb_EntSaidCliente.SelectedItem.ToString();
                                        
                    result = command.ExecuteReader();

                    cb_EntSaidPlaca.Items.Clear();
                    cb_EntSaidPlaca.Items.Add("");

                    while (result.Read())
                    {
                        tb_EntSaidCliente.Text = result[0].ToString();
                        cb_EntSaidPlaca.Items.Add(result[1].ToString());
                    }

                    connection.Close();
                }
                catch (Exception excep)
                {
                    MessageBox.Show("Não foi possível obter os registros das placas do banco de dados!\n\nErro : " + excep, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cb_EntSaidPlaca_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void tb_EntSaidPesquisa_Enter(object sender, EventArgs e)
        {
            if (tb_EntSaidPesquisa.Text.Equals(pesquisaIDLE)) tb_EntSaidPesquisa.Text = "";
        }

        private void tb_EntSaidPesquisa_Leave(object sender, EventArgs e)
        {
            if (tb_EntSaidPesquisa.Text.Equals("")) tb_EntSaidPesquisa.Text = pesquisaIDLE;
        }

        private void clear()
        {
            tb_EntSaidCliente.Text = "";
            dt_EntSaidHora.Value = dt_EntSaidData.Value = DateTime.Now;
            cb_EntSaidCliente.SelectedIndex = 0;
            cb_EntSaidPlaca.SelectedIndex = 0;
            rb_EntSaidEntrada.Select();

            tb_EntSaidPesquisa.Text = pesquisaIDLE;
        }

        private void cadastrar()
        {            
            clear();

            panel_EntSaidCliente.Visible = true;
            panel_EntSaidConsultar.Visible = false;

            bt_EntSaidConfirmar.Visible = bt_EntSaidCancelar.Visible = true;

            try
            {
                connectPostgres();

                command = new NpgsqlCommand("SELECT cpf FROM estacionamento.tb_cliente;", connection);

                result = command.ExecuteReader();

                cb_EntSaidCliente.Items.Clear();
                cb_EntSaidCliente.Items.Add("");

                while (result.Read())
                {
                    cb_EntSaidCliente.Items.Add(result[0].ToString());
                }

                connection.Close();
            }
            catch (Exception excep)
            {
                MessageBox.Show("Não foi possível obter os valores do banco de dados!\n\nErro : " + excep, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void consultar()
        {
            clear();

            panel_EntSaidCliente.Visible = false;
            panel_EntSaidConsultar.Visible = true;

            bt_EntSaidConfirmar.Visible = bt_EntSaidCancelar.Visible = false;


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
                MessageBox.Show("Não foi possivel conectar ao banco de dados!\n\nErro : " + excep, "Erro na conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void viewRecords()
        {
            try
            {
                dg_EntSaidConsulta.Rows.Clear();

                while (result.Read())
                {
                    dg_EntSaidConsulta.Rows.Add(result[0], result[1], result[2], result[3], 
                        String.Format("{0:HH:mm:ss}", DateTime.Parse(result[4].ToString())), String.Format("{0:dd/MM/yyyy}", DateTime.Parse(result[5].ToString())));
                }
            }
            catch (Exception excep)
            {
                MessageBox.Show("Não foi possível obter os valores do banco de dados!\n\nErro : " + excep, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }        
    }
}
