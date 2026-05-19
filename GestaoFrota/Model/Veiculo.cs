using System;
using System.Collections.Generic;
using System.Text;

namespace GestaoFrota.Model
{
    internal class Veiculo
    {
        private string placa;
        private string fabricante;
        private string modelo;
        private string cor;
        private int ano;
        private Abastecimento abastecimento;
        public string Placa { get => placa; set => placa = value; }
        public string Fabricante { get => fabricante; set => fabricante = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public string Cor { get => cor; set => cor = value; }
        public int Ano { get => ano; set => ano = value; }


        public double MediaConsumo()
        {
            double litro = Convert.ToDouble(abastecimento.Litros);
            double km = Convert.ToDouble(abastecimento.Km);
            double media = litro / km;
            return media;
        }

        public List<Abastecimento> ListaAbastecimento() 
        {

            return null;
        }
    }
}