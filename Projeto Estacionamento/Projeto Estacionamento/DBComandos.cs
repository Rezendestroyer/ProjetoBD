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
using MongoDB.Bson.Serialization;

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
        IMongoCollection<EntradaSaidaDocument> entradasSaidas;

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
                entradasSaidas = database.GetCollection<EntradaSaidaDocument>("entradasSaidas");
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

        public bool atualizarCliente(Cliente cliente)
        {
            try
            {
                connectMongoDB();

                ClientesDocument doc = consultarCliente(cliente.getCpf());

                if (doc != null)
                {
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

                    clientes.ReplaceOne(x => x.cpf.Equals(cliente.getCpf()), doc);
                }

                return true;
            }
            catch (Exception excep)
            {
                MessageBox.Show("Não foi possível realizar o cadastro do cliente!\n" +
                    "Verifique se todos os campos foram preenchidos corretamente.\n\n" +
                    "Erro: " + excep, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
        }

        public List<ClientesDocument> consultarClientes()
        {
            connectMongoDB();

            return clientes.Find(Builders<ClientesDocument>.Filter.Empty).ToList();
        }

        public ClientesDocument consultarCliente(string cpf)
        {
            connectMongoDB();

            Expression<Func<ClientesDocument, bool>> filter =
                     x => x.cpf.Equals(cpf);

            return clientes.Find(filter).First();
        }

        //Cadastra o Veiculo com os dados recolhidos na Função CadastroVeiculo
        public bool cadastrarVeiculo(Veiculo veiculo)
        {
            try
            {
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
            }
            catch
            {
                MessageBox.Show("Não foi possível realizar o cadastro do veículo!\n" +
                    "Verifique se todos os campos foram preenchidos corretamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
        }

        public bool atualizarVeiculo(Veiculo veiculo)
        {
            try
            {
                BsonArray docs = consultarVeiculos(veiculo.getCpf());

                BsonArray newDocs = new BsonArray();

                foreach (BsonDocument doc in docs)
                {
                    VeiculosDocument veiculoDoc = BsonSerializer.Deserialize<VeiculosDocument>(doc);

                    if (veiculoDoc.placa == veiculo.getPlaca())
                    {
                        veiculoDoc.marca = veiculo.getMarca();
                        veiculoDoc.modelo = veiculo.getModelo();
                    }

                    newDocs.Add(veiculoDoc.ToBsonDocument());
                }

                var update = Builders<ClientesDocument>.Update.Set(o => o.veiculos, newDocs);

                clientes.UpdateOne(x => x.cpf.Equals(veiculo.getCpf()), update);

                return true;
            }
            catch
            {
                MessageBox.Show("Não foi possível realizar o cadastro do veículo!\n" +
                    "Verifique se todos os campos foram preenchidos corretamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
        }

        public bool excluirVeiculo(Veiculo veiculo)
        {
            try
            {
                BsonArray docs = consultarVeiculos(veiculo.getCpf());

                BsonArray newDocs = new BsonArray();

                foreach (BsonDocument doc in docs)
                {
                    VeiculosDocument veiculoDoc = BsonSerializer.Deserialize<VeiculosDocument>(doc);

                    if (veiculoDoc.placa != veiculo.getPlaca())
                    {
                        newDocs.Add(veiculoDoc.ToBsonDocument());
                    }                    
                }

                var update = Builders<ClientesDocument>.Update.Set(o => o.veiculos, newDocs);

                clientes.UpdateOne(x => x.cpf.Equals(veiculo.getCpf()), update);

                return true;
            }
            catch
            {
                MessageBox.Show("Não foi possível realizar o cadastro do veículo!\n" +
                    "Verifique se todos os campos foram preenchidos corretamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
        }

        public BsonArray consultarVeiculos(string cpf)
        {
            connectMongoDB();

            Expression<Func<ClientesDocument, bool>> filter =
                     x => x.cpf.Equals(cpf);

            ClientesDocument docCliente = clientes.Find(filter).First();

            return docCliente.veiculos.AsBsonArray;
        }

        public VeiculosDocument consultarVeiculo(string cpf, string placa)
        {
            connectMongoDB();

            Expression<Func<ClientesDocument, bool>> filter =
                     x => x.cpf.Equals(cpf);

            BsonArray docs= clientes.Find(filter).First().veiculos.AsBsonArray;

            foreach (BsonDocument doc in docs)
            {
                VeiculosDocument veiculoDoc = BsonSerializer.Deserialize<VeiculosDocument>(doc);

                if (veiculoDoc.placa == placa)
                {
                    return veiculoDoc;
                }
            }

            return null;
        }

        public bool cadastrarEntradaSaida(EntradaSaida entradaSaida)
        {
            try
            {
                connectMongoDB();

                EntradaSaidaDocument doc = new EntradaSaidaDocument();

                doc.cpf = entradaSaida.getCpf();

                doc.placa = entradaSaida.getPlaca();

                doc.acao = entradaSaida.getAcao();

                doc.hora = entradaSaida.getDataHora().TimeOfDay;

                doc.data = entradaSaida.getDataHora().Date;
               
                entradasSaidas.InsertOne(doc);

                return true;
            }
            catch
            {
                MessageBox.Show("Não foi possível realizar o cadastro do cliente!\n" +
                    "Verifique se todos os campos foram preenchidos corretamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
        }

        public List<EntradaSaidaDocument> consultarEntradasSaidas()
        {
            connectMongoDB();

            return entradasSaidas.Find(Builders<EntradaSaidaDocument>.Filter.Empty).ToList();
        }
    }
}
