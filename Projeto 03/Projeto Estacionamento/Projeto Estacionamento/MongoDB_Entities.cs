using System;
using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;



namespace Projeto_Estacionamento
{
    public class ClientesDocument
    {
        [BsonId()]

        public string cpf { get; set; }
        

        [BsonElement("nome")]

        [BsonRequired()]

        public string nome { get; set; }



        [BsonElement("telefone")]

        public string telefone { get; set; }


        [BsonElement("celular")]

        public string celular { get; set; }


        [BsonElement("cep")]

        [BsonRequired()]

        public string cep { get; set; }


        [BsonElement("endereco")]

        [BsonRequired()]

        public string endereco { get; set; }


        [BsonElement("numero")]

        [BsonRequired()]

        public int numero { get; set; }


        [BsonElement("bairro")]

        [BsonRequired()]

        public string bairro { get; set; }


        [BsonElement("cidade")]

        [BsonRequired()]

        public string cidade { get; set; }


        [BsonElement("estado")]

        [BsonRequired()]

        public string estado { get; set; }

        [BsonElement("veiculos")]

        public BsonArray veiculos { get; set; }
    }

    public class VeiculosDocument
    {
        [BsonId()]

        public string placa { get; set; }


        [BsonElement("marca")]

        [BsonRequired()]

        public string marca { get; set; }



        [BsonElement("modelo")]

        [BsonRequired()]

        public string modelo { get; set; }
    }

    public class EntradaSaidaDocument
    {
        [BsonId()]

        public ObjectId id { get; set; }


        [BsonElement("cpf")]

        [BsonRequired()]

        public string cpf { get; set; }



        [BsonElement("placa")]

        [BsonRequired()]

        public string placa { get; set; }


        [BsonElement("acao")]

        [BsonRequired()]

        public string acao { get; set; }


        [BsonElement("hora")]

        [BsonRequired()]

        public TimeSpan hora { get; set; }


        [BsonElement("data")]

        [BsonRequired()]

        public DateTime data { get; set; }
    }
}