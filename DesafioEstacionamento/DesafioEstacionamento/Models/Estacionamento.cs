using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace DesafioEstacionamento.Models
{
    class Estacionamento
    {
        private decimal _precoInicial { get; set; }
        private decimal _precoPorHora { get; set; }
        private List<string> _veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            _precoInicial = precoInicial;
           _precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            var placa = Console.ReadLine();
            _veiculos.Add(placa);
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            var placa = Console.ReadLine();
            if (_veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                decimal horasEstacionado = decimal.Parse(Console.ReadLine());
                decimal valorTotal = _precoInicial + _precoPorHora * horasEstacionado;
                _veiculos.Remove(placa);
                Console.WriteLine("O veículo " + placa + "foi removido e o preço total foi de: " + valorTotal.ToString("C2", CultureInfo.InvariantCulture));
            }
            else
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
        }

        public void ListarVeiculo()
        {
            if (_veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                foreach (var veiculos in _veiculos)
                    Console.WriteLine(veiculos.ToUpper());
            }
            else
                Console.WriteLine("Não há veículos estacionados.");
        }
    }
}
