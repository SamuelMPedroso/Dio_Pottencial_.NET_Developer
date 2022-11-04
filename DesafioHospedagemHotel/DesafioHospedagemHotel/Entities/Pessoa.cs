using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioHospedagemHotel.Entities
{
    class Pessoa
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }

        public Pessoa()
        {
        }
        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }
        public override string ToString()
        {
            string nomeCompleto = Nome.ToUpper() + " " + Sobrenome.ToUpper();
            return nomeCompleto;
        }

        internal int ToUpper()
        {
            throw new NotImplementedException();
        }
    }
}
