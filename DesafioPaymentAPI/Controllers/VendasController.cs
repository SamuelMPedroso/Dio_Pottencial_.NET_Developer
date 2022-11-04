using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesafioPaymentAPI.Entities;
using DesafioPaymentAPI.Context;
using Microsoft.AspNetCore.Mvc;

namespace DesafioPaymentAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VendasController : ControllerBase
    {
        private readonly VendasContext _context;

        public VendasController(VendasContext context)
        {
            _context = context;
        }

        [HttpGet("{id}")]
        public IActionResult ObterPorId(int id)
        {
            var venda = _context.Vendas.Find(id);
            if (venda == null)
                return NotFound();

            return Ok(venda);
        }

        [HttpGet("ObterPorIdVendedor")]
        public IActionResult ObterPorIdVendedor(int IdVendedor)
        {
            var venda = _context.Vendas.Find(IdVendedor);
            if (venda == null)
                return NotFound();

            return Ok(venda);
        }

        [HttpGet("ObterPorCPF")]
        public IActionResult ObterPorCPF(string cpf)
        {
            var venda = _context.Vendas.Where(x => x.CPF.Contains(cpf));
            return Ok(venda);
        }

        [HttpGet("ObterPorNome")]
        public IActionResult ObterPorNome(string nome)
        {
            var venda = _context.Vendas.Where(x => x.Nome.Contains(nome));
            return Ok(venda);
        }

        [HttpGet("ObterPorEmail")]
        public IActionResult ObterPorEmail(string email)
        {
            var venda = _context.Vendas.Where(x => x.Email.Contains(email));
            return Ok(venda);
        }

        [HttpGet("ObterPorTelefone")]
        public IActionResult ObterPorTelefone(string telefone)
        {
            var venda = _context.Vendas.Where(x => x.Telefone.Contains(telefone));
            return Ok(venda);
        }

        [HttpGet("ObterPorData")]
        public IActionResult ObterPorData(DateTime data)
        {
            var venda = _context.Vendas.Where(x => x.DataPedido.Date == data.Date);
            return Ok(venda);
        }

        [HttpGet("ObterPorItem")]
        public IActionResult ObterPorItem(string item)
        {
            var venda = _context.Vendas.Where(x => x.Item.Contains(item));
            return Ok(venda);
        }

        [HttpGet("ObterPorStatus")]
        public IActionResult ObterPorStatus(EnumStatusVenda status)
        {
            var venda = _context.Vendas.Where(x => x.Status == status);
            return Ok(venda);
        }

        [HttpPost]
        public IActionResult Criar(Venda venda)
        {
            if(venda.DataPedido == DateTime.MinValue)
                return BadRequest( new { Erro = "A data da venda não pode ser vazia" });

            _context.Add(venda);
            _context.SaveChanges();
            return CreatedAtAction(nameof(ObterPorId), new { id = venda.Id }, venda);
        }

        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, Venda venda)
        {
            var vendaBanco = _context.Vendas.Find(id);

            if (vendaBanco == null)
                return NotFound();

            if (venda.DataPedido == DateTime.MinValue)
                return BadRequest(new { Erro = "A data da venda não pode ser vazia" });

            vendaBanco.IdVendedor = venda.IdVendedor;
            vendaBanco.CPF = venda.CPF;
            vendaBanco.Nome = venda.Nome;
            vendaBanco.Email = venda.Email;
            vendaBanco.Telefone = venda.Telefone;
            vendaBanco.DataPedido = venda.DataPedido;
            vendaBanco.Item = venda.Item;
            vendaBanco.Status = venda.Status;

            _context.Vendas.Update(vendaBanco);
            _context.SaveChanges();

            return Ok(vendaBanco);
        }

        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            var vendaBanco = _context.Vendas.Find(id);

            if (vendaBanco == null)
                return NotFound();

            _context.Vendas.Remove(vendaBanco);
            _context.SaveChanges();

            return NoContent();
        }
    }
}