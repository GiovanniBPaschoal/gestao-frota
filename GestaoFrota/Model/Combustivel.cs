using System;
using System.Collections.Generic;
using System.Text;

namespace GestaoFrota.Model
{
    internal class Combustivel
    {
        private long id;
        private string nome;
        private Decimal valor;

        public long Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public decimal Valor { get => valor; set => valor = value; }
    }
}
