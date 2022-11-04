using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore;
using DesafioPaymentAPI.Entities;
using DesafioPaymentAPI.Context;

namespace DesafioPaymentAPI.Context
{
    public class VendasContext : DbContext
    {
        public VendasContext(DbContextOptions<VendasContext> options) : base(options)
        {

        }
        public DbSet<Venda> Vendas { get; set; }
    }
}