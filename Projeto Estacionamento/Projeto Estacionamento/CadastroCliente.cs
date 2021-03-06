﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;
using Npgsql;

namespace Projeto_Estacionamento
{
    public partial class CadastroCliente : Form
    {
        public CadastroCliente()
        {
            InitializeComponent();
        }

        private void CadastroCliente_Load(object sender, EventArgs e)
        {
            cadastrar();
        }

        DBComandos comandos = new DBComandos();

        private NpgsqlConnection connection;
        private NpgsqlCommand command;
        private NpgsqlDataReader result;

        private string pesquisaIDLE = "Pesquisar...";
        private string status = "Cadastrar";

        private void bt_CadCConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente cliente = getValues();

                if (status.Equals("Cadastrar") && cliente != null)
                {
                    if (comandos.cadastrarCliente(cliente))
                    {
                        MessageBox.Show("Cliente cadastrado com sucesso!");
                        clear();
                    }
                }
                else if (status.Equals("Atualizar") && cliente != null)
                {
                    if (comandos.atualizarCliente(cliente))
                    {
                        MessageBox.Show("Cliente atualizado com sucesso!");
                        clear();
                    }
                }
                else
                {
                    MessageBox.Show("Não foi possível realizar o cadastro do cliente!\n" +
                    "Verifique se todos os campos foram preenchidos corretamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception excep)
            {
                MessageBox.Show("Não foi possível realizar o cadastro do cliente!\n" +
                    "Verifique se todos os campos foram preenchidos corretamente.\n\n" +
                    "Erro: " + excep, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bt_CadCCancelar_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void bt_CadCVeiculos_Click(object sender, EventArgs e)
        {
            if (dg_CadCConsulta.SelectedCells[1].Value != null)
            {
                this.Hide();
                CadastroVeiculo menu = new CadastroVeiculo(dg_CadCConsulta.SelectedCells[1].Value.ToString());
                menu.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Por favor, selecione uma linha válida da tabela.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void bt_CadCExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (dg_CadCConsulta.SelectedCells[1].Value != null)
                {
                    if (MessageBox.Show("Tem certeza de que deseja excluir este registro?", "Excluir registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        /*connectPostgres();

                        command = new NpgsqlCommand("DELETE FROM estacionamento.tb_cliente WHERE cpf = '"
                            + dg_CadCConsulta.SelectedCells[1].Value.ToString() + "';", connection);

                        command.ExecuteNonQuery();

                        MessageBox.Show("Registro excluido com sucesso!");

                        connection.Close();

                        connectPostgres();

                        command = new NpgsqlCommand("SELECT * FROM estacionamento.tb_cliente;", connection);

                        result = command.ExecuteReader();

                        viewRecords();

                        connection.Close();*/
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

        private void bt_CadCPesquisar_Click(object sender, EventArgs e)
        {
            /*connectPostgres();

            command = new NpgsqlCommand("SELECT * FROM estacionamento.tb_cliente WHERE (nome ~* @DADO OR cpf ~* @DADO OR telefone ~* @DADO OR celular ~* @DADO) ORDER BY nome;", connection);

            command.Parameters.Add("@DADO", NpgsqlTypes.NpgsqlDbType.Varchar);
            command.Parameters["@DADO"].Value = tb_CadCPesquisa.Text;

            result = command.ExecuteReader();

            viewRecords();

            connection.Close();*/
        }

        private void tb_CadCPesquisa_Enter(object sender, EventArgs e)
        {
            if (tb_CadCPesquisa.Text.Equals(pesquisaIDLE)) tb_CadCPesquisa.Text = "";
        }

        private void tb_CadCPesquisa_Leave(object sender, EventArgs e)
        {
            if (tb_CadCPesquisa.Text.Equals("")) tb_CadCPesquisa.Text = pesquisaIDLE;
        }

        private void bt_CadCCadastrar_Click(object sender, EventArgs e)
        {
            cadastrar();
            status = "Cadastrar";
            enableFields();
        }

        private void bt_CadCAtualizar_Click(object sender, EventArgs e)
        {
            atualizar();
            status = "Atualizar";
            disableFields();
        }

        private void bt_CadCConsultar_Click(object sender, EventArgs e)
        {
            consultar();

            List<ClientesDocument> docs = comandos.consultarClientes();

            dg_CadCConsulta.Rows.Clear();

            docs.ForEach(doc =>
            {                
                dg_CadCConsulta.Rows.Add(doc.nome, doc.cpf, doc.telefone, doc.celular, doc.cep, doc.endereco, doc.numero, doc.bairro, doc.cidade, doc.estado);
            });
        }
                
        private void bt_CadCSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cb_CadCCPF_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_CadCCPF.SelectedIndex == 0 && status.Equals("Atualizar"))
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
            cb_CadCCPF.SelectedIndex = 0;
            tb_CadCNome.Text = mtb_CadCCPF.Text = mtb_CadCTelefone.Text = mtb_CadCCelular.Text = "";
            mtb_CadCCEP.Text = tb_CadCEndereco.Text = tb_CadCNumero.Text = tb_CadCBairro.Text = tb_CadCCidade.Text = "";
            cb_CadCEstado.SelectedIndex = 0;

            tb_CadCPesquisa.Text = pesquisaIDLE;
        }

        private void enableFields()
        {
            tb_CadCNome.Enabled = mtb_CadCTelefone.Enabled = mtb_CadCCelular.Enabled = true;
            mtb_CadCCEP.Enabled = tb_CadCEndereco.Enabled = tb_CadCNumero.Enabled = tb_CadCBairro.Enabled = tb_CadCCidade.Enabled = true;
            cb_CadCEstado.Enabled = true;
        }

        private void disableFields()
        {
            tb_CadCNome.Enabled = mtb_CadCTelefone.Enabled = mtb_CadCCelular.Enabled = false;
            mtb_CadCCEP.Enabled = tb_CadCEndereco.Enabled = tb_CadCNumero.Enabled = tb_CadCBairro.Enabled = tb_CadCCidade.Enabled = false;
            cb_CadCEstado.Enabled = false;
        }

        private void cadastrar()
        {
            panel_CadCCliente.Visible = true;
            panel_CadCConsultar.Visible = false;
            bt_CadCVeiculos.Visible = bt_CadCExcluir.Visible = false;
            bt_CadCConfirmar.Visible = bt_CadCCancelar.Visible = true;
            cb_CadCCPF.Visible = false;
            mtb_CadCCPF.Visible = true;

            clear();
        }

        private void atualizar()
        {
            panel_CadCCliente.Visible = true;
            panel_CadCConsultar.Visible = false;
            bt_CadCVeiculos.Visible = bt_CadCExcluir.Visible = false;
            bt_CadCConfirmar.Visible = bt_CadCCancelar.Visible = true;
            cb_CadCCPF.Visible = true;
            mtb_CadCCPF.Visible = false;

            try
            {
                List<ClientesDocument> docs = comandos.consultarClientes();

                cb_CadCCPF.Items.Clear();
                cb_CadCCPF.Items.Add("");

                docs.ForEach(doc =>
                {
                    cb_CadCCPF.Items.Add(doc.cpf);
                });
            }
            catch (Exception excep)
            {
                MessageBox.Show("Não foi possível obter os valores do banco de dados!\n\nErro : " + excep, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            clear();
        }

        private void consultar()
        {
            clear();

            panel_CadCCliente.Visible = false;
            panel_CadCConsultar.Visible = true;
            bt_CadCVeiculos.Visible = bt_CadCExcluir.Visible = true;
            bt_CadCConfirmar.Visible = bt_CadCCancelar.Visible = false;
        }

        private Cliente getValues()
        {
            if (!(
                tb_CadCNome.Text.Equals("") ||
                tb_CadCEndereco.Text.Equals("") ||
                tb_CadCNumero.Text.Equals("") ||
                tb_CadCBairro.Text.Equals("") ||
                tb_CadCCidade.Text.Equals("")
                ))
            {
                if (status.Equals("Cadastrar") && mtb_CadCCPF.MaskFull)
                {
                    return new Cliente(tb_CadCNome.Text, mtb_CadCCPF.Text, mtb_CadCTelefone.Text, mtb_CadCCelular.Text,
                            mtb_CadCCEP.Text, tb_CadCEndereco.Text, tb_CadCNumero.Text, tb_CadCBairro.Text, tb_CadCCidade.Text, cb_CadCEstado.SelectedItem.ToString());
                }
                else if (status.Equals("Atualizar") && cb_CadCCPF.SelectedIndex != 0)
                {
                    return new Cliente(tb_CadCNome.Text, cb_CadCCPF.SelectedItem.ToString(), mtb_CadCTelefone.Text, mtb_CadCCelular.Text,
                            mtb_CadCCEP.Text, tb_CadCEndereco.Text, tb_CadCNumero.Text, tb_CadCBairro.Text, tb_CadCCidade.Text, cb_CadCEstado.SelectedItem.ToString());
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
                ClientesDocument doc = comandos.consultarCliente(cb_CadCCPF.SelectedItem.ToString());

                tb_CadCNome.Text = doc.nome;
                mtb_CadCTelefone.Text = doc.telefone;
                mtb_CadCCelular.Text = doc.celular;
                mtb_CadCCEP.Text = doc.cep;
                tb_CadCEndereco.Text = doc.endereco;
                tb_CadCNumero.Text = doc.numero.ToString();
                tb_CadCBairro.Text = doc.bairro;
                tb_CadCCidade.Text = doc.cidade;
                cb_CadCEstado.SelectedItem = doc.estado;
            }
            catch (Exception excep)
            {
                MessageBox.Show("Não foi possível obter os valores do banco de dados!\n\nErro : " + excep, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
