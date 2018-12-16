using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Estacionamento
{
    public class Veiculo
    {
        private string cpf;
        private string marca;
        private string modelo;
        private string placa;

        public Veiculo()
        {
            cpf = "";
            marca = "";
            modelo = "";
            placa = "";
        }

        public Veiculo(string cpf, string marca, string modelo, string placa)
        {
            this.cpf = cpf;
            this.marca = marca;
            this.modelo = modelo;
            this.placa = placa;
        }

        public void setCpf(string cpf)
        {
            this.cpf = cpf;
        }

        public string getCpf()
        {
            return cpf;
        }

        public void setMarca(string marca)
        {
            this.marca = marca;
        }

        public string getMarca()
        {
            return marca;
        }

        public void setModelo(string modelo)
        {
            this.modelo = modelo;
        }

        public string getModelo()
        {
            return modelo;
        }

        public void setPlaca(string placa)
        {
            this.placa = placa;
        }

        public string getPlaca()
        {
            return placa;
        }

    }

}
