using System;
using System.Text;
using System.Globalization;
using System.Collections.Generic;
using DesafioHospedagemHotel.Entities;

namespace DesafioHospedagemHotel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            List<Pessoa> hospedes = new List<Pessoa>();
            Console.Write("Entre com a quantidade de hóspedes que irão realizar a reserva: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Hóspede #{i}: ");
                Console.Write("Entre com o primeiro nome: ");
                string nome = Console.ReadLine();
                Console.Write("Entre com o sobrenome: ");
                string sobrenome = Console.ReadLine();
                hospedes.Add(new Pessoa(nome, sobrenome));
            }

            Console.Write("Entre com o tipo de suíte (Normal ou Premium)? ");
            string tipoSuite = Console.ReadLine();
            Console.Write("Entre com a capacidade da suíte: ");
            int capacidade = int.Parse(Console.ReadLine());
            Console.Write("Entre com o valor da diária: ");
            double valorDiaria = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Suite suite = new Suite(tipoSuite, capacidade, valorDiaria);

            Console.Write("Entre com a quantidade de dias de reserva: ");
            int diasReservados = int.Parse(Console.ReadLine());
            Reserva reserva = new Reserva(diasReservados);
            reserva.CadastrarSuite(suite);
            reserva.CadastrarHospedes(hospedes);

            Console.Clear();
            Console.WriteLine("Quantidade de hóspedes: " + reserva.ObterQuantidadeHospedes() + "\n"
                + "Valor da diária por hóspede: R$" + " " + reserva.CalcularValorDiaria().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Lista de hóspede(s): ");
            int count = 1;
            foreach (var hosp in hospedes)
            {
                Console.WriteLine($"Nome do hóspede {count}: " + hosp);
                count++;
            }
        }
    }
}
