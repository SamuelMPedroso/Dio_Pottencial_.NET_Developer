using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioCelular.Entities
{
    class Iphone : IAplicativos
    {
        public void InstalarAplicativos(string nomeApp)
        {
            Console.WriteLine("O aplicativo " + nomeApp + " da AppleStore foi instalado com sucesso!");
        }
    }
}
