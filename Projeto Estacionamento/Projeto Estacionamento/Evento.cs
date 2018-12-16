using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Estacionamento
{
    public class Evento
    {
        private string cliente;
        private string placa;
        private string acao;
        private string hora;
        private string data;

        public Evento()
        {
            cliente = "";
            placa = "";
            acao = "";
            hora = "";
            data = "";
        }

        public Evento(string cliente, string placa, string acao, string hora, string data)
        {
            this.cliente = cliente;
            this.placa = placa;
            this.acao = acao;
            this.hora = hora;
            this.data = data;
        }

        public void setCliente(string cliente)
        {
            this.cliente = cliente;
        }

        public string getCliente()
        {
            return cliente;
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

        public void setHora(string hora)
        {
            this.hora = hora;
        }

        public string getHora()
        {
            return hora; 
        }

        public void setData(string data)
        {
            this.data = data;
        }

        public string getData()
        {
            return data;
        }
    }
}
