using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioCelular.Entities
{
    class Smartphone
    {
        public string Modelo { get; private set; }
        public long Numero { get; private set; }
        public int Memoria { get; private set; }

        private readonly IAplicativos _aplicativos;

        public Smartphone(string modelo, long numero, int memoria, IAplicativos aplicativos)
        {
            Modelo = modelo;
            Numero = numero;
            Memoria = memoria;
            _aplicativos = aplicativos;
        }

        public void ImprimirDados()
        {
            Console.WriteLine("Modelo: " + Modelo.ToUpper() + "\n"
                + "Número: " + Numero + "\n"
                + "Memória em GB: " + Memoria);
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacoes()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public void App(string nomeApp)
        {
            _aplicativos.InstalarAplicativos(nomeApp);
        }
    }
}
