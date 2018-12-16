using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Estacionamento
{
    public class Cliente
    {
        private string nome;
        private string cpf;
        private string telefone;
        private string celular;
        private string cep;
        private string endereco;
        private string numero;
        private string bairro;
        private string cidade;
        private string estado;

        public Cliente()
        {
            nome = "";
            cpf = "";
            telefone = "";
            celular = "";
            cep = "";
            endereco = "";
            numero = "";
            bairro = "";
            cidade = "";
            estado = "";
        }

        public Cliente(string nome, string cpf, string telefone, string celular, string cep, string endereco, string numero, string bairro, string cidade, string estado)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.telefone = telefone;
            this.celular = celular;
            this.cep = cep;
            this.endereco = endereco;
            this.numero = numero;
            this.bairro = bairro;
            this.cidade = cidade;
            this.estado = estado;
        }

        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public string getNome()
        {
            return nome;
        }

        public void setCpf(string cpf)
        {
            this.cpf = cpf;
        }

        public string getCpf()
        {
            return cpf;
        }

        public void setTelefone(string telefone)
        {
            this.telefone = telefone;
        }

        public string getTelefone()
        {
            return telefone;
        }

        public void setCelular(string celular)
        {
            this.celular = celular;
        }

        public string getCelular()
        {
            return celular;
        }

        public void setCep(string cep)
        {
            this.cep = cep;
        }

        public string getCep()
        {
            return cep;
        }

        public void setEndereco(string endereco)
        {
            this.endereco = endereco;
        }

        public string getEndereco()
        {
            return endereco;
        }

        public void setNumero(string numero)
        {
            this.numero = numero;
        }

        public string getNumero()
        {
            return numero;
        }

        public void setBairro(string bairro)
        {
            this.bairro = bairro;
        }

        public string getBairro()
        {
            return bairro;
        }

        public void setCidade(string cidade)
        {
            this.cidade = cidade;
        }

        public string getCidade()
        {
            return cidade;
        }

        public void setEstado(string estado)
        {
            this.estado = estado;
        }

        public string getEstado()
        {
            return estado;
        }

    }

}
