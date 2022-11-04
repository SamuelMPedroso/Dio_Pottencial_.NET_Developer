using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesafioPaymentAPI.Entities;

namespace DesafioPaymentAPI.Entities
{
    public class Venda
    {
        public int Id { get; set; }
        public int IdVendedor { get; set; }
        public string CPF { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public DateTime DataPedido { get; set; }
        public string Item { get; set; }
        public EnumStatusVenda Status { get; set; }
    }
}