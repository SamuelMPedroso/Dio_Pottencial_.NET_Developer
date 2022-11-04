using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioCelular.Entities
{
    class Motorola : IAplicativos
    {
        public void InstalarAplicativos(string nomeApp)
        {
            Console.WriteLine("O aplicativo " + nomeApp + " da PlayStore foi instalado com sucesso!");
        }
    }
}
