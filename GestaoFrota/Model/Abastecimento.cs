using System;
using System.Collections.Generic;
using System.Text;

namespace GestaoFrota.Model
{
    internal class Abastecimento
    {
        private long id;
        private DateTime data;
        private Decimal litros;
        private Decimal preco_litros;
        private long km;

        public long Id { get => id; set => id = value; }
        public DateTime Data { get => data; set => data = value; }
        public decimal Litros { get => litros; set => litros = value; }
        public decimal Preco_litros { get => preco_litros; set => preco_litros = value; }
        public long Km { get => km; set => km = value; }
    }
}
