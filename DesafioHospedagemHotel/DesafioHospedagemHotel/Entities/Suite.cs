using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioHospedagemHotel.Entities
{
    class Suite
    {
        public string TipoSuite { get; set; }
        public int Capacidade { get; set; }
        public double ValorDiaria { get; set; }

        public Suite()
        {
        }
        public Suite(string tipoSuite, int capacidade, double valorDiaria)
        {
            TipoSuite = tipoSuite;
            Capacidade = capacidade;
            ValorDiaria = valorDiaria;
        }
    }
}
