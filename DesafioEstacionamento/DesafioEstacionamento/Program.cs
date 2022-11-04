using System;
using System.Globalization;
using DesafioEstacionamento.Models;

namespace DesafioEstacionamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bem-vindo ao sistema do MAX estacionamento!" + "\n" + "Digite o preço inicial: ");
            decimal precoInicial = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite o preço por hora: ");
            decimal precoPorHora = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Estacionamento es = new Estacionamento(precoInicial, precoPorHora);

            string opcao = string.Empty;
            bool exibirMenu = true;

            while (exibirMenu)
            {
                Console.Clear();
                Console.WriteLine("Escolha uma das opções abaixo: ");
                Console.WriteLine("1 - Cadastrar veículo");
                Console.WriteLine("2 - Remover veículo");
                Console.WriteLine("3 - Listar veículos");
                Console.WriteLine("4 - Encerrar");

                switch (Console.ReadLine())
                {
                    case "1":
                        es.AdicionarVeiculo();
                        break;
                    case "2":
                        es.RemoverVeiculo();
                        break;
                    case "3":
                        es.ListarVeiculo();
                        break;
                    case "4":
                        exibirMenu = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadLine();
            }
            Console.WriteLine("Programa encerrado!");
        }
    }
}
