using System;
using DesafioCelular.Entities;

namespace DesafioCelular
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe aos dados do seu telefone MOTOROLA: ");
            Console.WriteLine("Digite na mesma linha o modelo, número, quantidade de memória (64 ou 128) e o app que deseja baixar em seu celular: ");
            string[] motorola = Console.ReadLine().Split(',');
            string modeloMotorola = motorola[0];
            long numeroMotorola = long.Parse(motorola[1]);
            int memoriaMotorola = int.Parse(motorola[2]);
            string appMotorola = motorola[3];
            Console.WriteLine("Informe aos dados do seu telefone IPHONE: ");
            Console.WriteLine("Digite na mesma linha o modelo, número, quantidade de memória (64 ou 128) e o app que deseja baixar em seu celular: ");
            string[] iphone = Console.ReadLine().Split(',');
            string modeloIphone = iphone[0];
            long numeroIphone = long.Parse(iphone[1]);
            int memoriaIphone = int.Parse(iphone[2]);
            string appIphone = iphone[3];

            Console.Clear();
            Smartphone celularMotorola = new Smartphone(modeloMotorola, numeroMotorola, memoriaMotorola, new Motorola());
            celularMotorola.ImprimirDados();
            celularMotorola.ReceberLigacoes();
            celularMotorola.App(appMotorola);
            Console.WriteLine();
            Smartphone celularIphone = new Smartphone(modeloIphone, numeroIphone, memoriaIphone, new Iphone());
            celularIphone.ImprimirDados();
            celularIphone.Ligar();
            celularIphone.App(appIphone);
        }
    }
}
