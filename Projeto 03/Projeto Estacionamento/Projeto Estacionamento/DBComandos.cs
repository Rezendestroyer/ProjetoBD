using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using MongoDB.Driver;
using System.Windows.Forms;
using System.Linq.Expressions;
using MongoDB.Bson;

namespace Projeto_Estacionamento
{
    public class DBComandos
    {
        private static String serverName = "localhost"; //LocalHost
        private static String databaseName = "dbestacionamento"; //Nome do Database 
        private String connectionString = null; //Criando uma string para controle de conexao
        IMongoDatabase database = null;
        IMongoClient client = null;
        IMongoCollection<ClientesDocument> clientes;

        public DBComandos()
        {
            connectionString = String.Format("mongodb://{0}", serverName);            
        }

        private void connectMongoDB()
        {
            try
            {
                client = new MongoClient(connectionString);
                database = client.GetDatabase(databaseName);
                clientes = database.GetCollection<ClientesDocument>("clientes");
            }
            catch (NpgsqlException)
            {
                MessageBox.Show("Não foi possivel conectar ao banco de dados!", "Erro na conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Cadastra o Cliente com os dados recolhidos na Função CadastroCliente
        public bool cadastrarCliente(Cliente cliente)
        {
            try
            {
                connectMongoDB();

                ClientesDocument doc = new ClientesDocument();

                doc.cpf = cliente.getCpf();

                doc.nome = cliente.getNome();

                doc.telefone = cliente.getTelefone();

                doc.celular = cliente.getCelular();

                doc.cep = cliente.getCep();

                doc.endereco = cliente.getEndereco();

                doc.numero = Convert.ToInt16(cliente.getNumero());

                doc.bairro = cliente.getBairro();

                doc.cidade = cliente.getCidade();

                doc.estado = cliente.getEstado();

            doc.veiculos = new BsonArray();

                clientes.InsertOne(doc);

                return true;
            }
            catch
            {
                MessageBox.Show("Não foi possível realizar o cadastro do cliente!\n" +
                    "Verifique se todos os campos foram preenchidos corretamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
        }

        public List<ClientesDocument> consultarCliente()
        {
            connectMongoDB();

            return clientes.Find(Builders<ClientesDocument>.Filter.Empty).ToList();
        }

        //Cadastra o Veiculo com os dados recolhidos na Função CadastroVeiculo
        public bool cadastrarVeiculo(Veiculo veiculo)
        {
            /*try
            {*/
            VeiculosDocument doc = new VeiculosDocument
            {
                placa = veiculo.getPlaca(),
                marca = veiculo.getMarca(),
                modelo = veiculo.getModelo()
            };

            connectMongoDB();

                Expression<Func<ClientesDocument, bool>> filter =
                     x => x.cpf.Equals(veiculo.getCpf());

                var update = Builders<ClientesDocument>.Update.Push("veiculos", doc.ToBsonDocument());

                clientes.UpdateOne(filter, update);
                                
                return true;
            /*}
            catch
            {
                MessageBox.Show("Não foi possível realizar o cadastro do veículo!\n" +
                    "Verifique se todos os campos foram preenchidos corretamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }*/
        }

        public BsonArray consultarVeiculo(string cpf)
        {
            connectMongoDB();

            Expression<Func<ClientesDocument, bool>> filter =
                     x => x.cpf.Equals(cpf);

            ClientesDocument docCliente = clientes.Find(filter).First();

            return docCliente.veiculos;
        }

        public bool atualizarCliente(Cliente cliente)
        {
            /*try
            {
                connectPostgres();

                command = new NpgsqlCommand("UPDATE estacionamento.tb_cliente " +
                    "SET nome = @NOME, telefone = @TELEFONE, celular = @CELULAR, " +
                    "cep = @CEP, endereco = @ENDERECO, numero = @NUMERO, bairro = @BAIRRO, cidade = @CIDADE, estado = @ESTADO " +
                    "WHERE cpf = @CPF;", connection);

                command.Parameters.Add("@NOME", NpgsqlTypes.NpgsqlDbType.Varchar);
                command.Parameters["@NOME"].Value = cliente.getNome();

                command.Parameters.Add("@TELEFONE", NpgsqlTypes.NpgsqlDbType.Varchar);
                command.Parameters["@TELEFONE"].Value = cliente.getTelefone();

                command.Parameters.Add("@CELULAR", NpgsqlTypes.NpgsqlDbType.Varchar);
                command.Parameters["@CELULAR"].Value = cliente.getCelular();

                command.Parameters.Add("@CEP", NpgsqlTypes.NpgsqlDbType.Varchar);
                command.Parameters["@CEP"].Value = cliente.getCep();

                command.Parameters.Add("@ENDERECO", NpgsqlTypes.NpgsqlDbType.Varchar);
                command.Parameters["@ENDERECO"].Value = cliente.getEndereco();

                command.Parameters.Add("@NUMERO", NpgsqlTypes.NpgsqlDbType.Integer);
                command.Parameters["@NUMERO"].Value = Convert.ToInt16(cliente.getNumero());

                command.Parameters.Add("@BAIRRO", NpgsqlTypes.NpgsqlDbType.Varchar);
                command.Parameters["@BAIRRO"].Value = cliente.getBairro();

                command.Parameters.Add("@CIDADE", NpgsqlTypes.NpgsqlDbType.Varchar);
                command.Parameters["@CIDADE"].Value = cliente.getCidade();

                command.Parameters.Add("@ESTADO", NpgsqlTypes.NpgsqlDbType.Varchar);
                command.Parameters["@ESTADO"].Value = cliente.getEstado();

                command.Parameters.Add("@CPF", NpgsqlTypes.NpgsqlDbType.Varchar);
                command.Parameters["@CPF"].Value = cliente.getCpf();

                command.ExecuteNonQuery();

                if (connection != null)
                {
                    connection.Close();
                }

                return true;
            }
            catch (Exception excep)
            {
                MessageBox.Show("Não foi possível realizar o cadastro do cliente!\n" +
                    "Verifique se todos os campos foram preenchidos corretamente.\n\n" +
                    "Erro: " + excep, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }*/
            return false;
        }

        public bool atualizarVeiculo(Veiculo veiculo)
        {
            /*try
            {
                connectPostgres();

                command = new NpgsqlCommand("UPDATE estacionamento.tb_veiculo SET cpf = @CPF, marca = @MARCA, modelo = @MODELO WHERE placa = @PLACA;", connection);

                command.Parameters.Add("@CPF", NpgsqlTypes.NpgsqlDbType.Varchar);
                command.Parameters["@CPF"].Value = veiculo.getCpf();

                command.Parameters.Add("@MARCA", NpgsqlTypes.NpgsqlDbType.Varchar);
                command.Parameters["@MARCA"].Value = veiculo.getMarca();

                command.Parameters.Add("@MODELO", NpgsqlTypes.NpgsqlDbType.Varchar);
                command.Parameters["@MODELO"].Value = veiculo.getModelo();

                command.Parameters.Add("@PLACA", NpgsqlTypes.NpgsqlDbType.Varchar);
                command.Parameters["@PLACA"].Value = veiculo.getPlaca();

                command.ExecuteNonQuery();

                if (connection != null)
                {
                    connection.Close();
                }

                return true;
            }
            catch
            {
                MessageBox.Show("Não foi possível realizar o cadastro do veículo!\n" +
                    "Verifique se todos os campos foram preenchidos corretamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }*/

            return false;
        }        
    }
}
