using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Estacionamento
{
    public class EntradaSaida
    {
        private string cpf;
        private string placa;
        private string acao;
        private DateTime dataHora;

        public EntradaSaida()
        {
            cpf = "";
            placa = "";
            acao = "";
            dataHora = DateTime.Now;
        }

        public EntradaSaida(string cpf, string placa, string acao, DateTime dataHora)
        {
            this.cpf = cpf;
            this.placa = placa;
            this.acao = acao;
            this.dataHora = dataHora;
        }

        public void setCpf(string cpf)
        {
            this.cpf = cpf;
        }

        public string getCpf()
        {
            return cpf;
        }

        public void setPlaca(string placa)
        {
            this.placa = placa;
        }

        public string getPlaca()
        {
            return placa;
        }

        public void setAcao(string acao)
        {
            this.acao = acao;
        }

        public string getAcao()
        {
            return acao;
        }

        public void setDataHora(DateTime dataHora)
        {
            this.dataHora = dataHora;
        }

        public DateTime getDataHora()
        {
            return dataHora;
        }
    }
}
