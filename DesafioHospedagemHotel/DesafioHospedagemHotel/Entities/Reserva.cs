using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace DesafioHospedagemHotel.Entities
{
    class Reserva
    {
        public int DiasReservados { get; set; }
        public Suite Suite { get; set; }
        public List<Pessoa> Hospedes { get; set; }

        public Reserva()
        {
        }
        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public Reserva(int diasReservados, Suite suite)
        {
            DiasReservados = diasReservados;
            Suite = suite;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            if (hospedes.Count <= Suite.Capacidade)
                Hospedes = hospedes;
            else
                throw new ArgumentException("Quantidade de hóspedes maior que a capacidade da suíte!");
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count;
        }

        public double CalcularValorDiaria()
        {
            double valorTotal = (double)DiasReservados * Suite.ValorDiaria;
            double desconto = valorTotal * 0.10;
            if (DiasReservados >= 10)
                return valorTotal - desconto;
            else
                return valorTotal;
        }
    }
}
