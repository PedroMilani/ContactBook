using Business;
using DAL;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactWebAPI.Controllers
{
    [Route("api/Contato")]
    public class ContatoController : Controller
    {

        public ContatoController()
        {

        }
        [HttpGet("Obter")]
        public IActionResult ObterTodosContatos()
        {
            ContatoBusiness contatoBusiness = new ContatoBusiness();
            return Ok(contatoBusiness.ObterTodosContatos());
        }
        [HttpGet("PesquisarNome/{nome}")]
        public IActionResult PesquisarContato(string nome)
        {
            ContatoBusiness contatoBusiness = new ContatoBusiness();
            return Ok(contatoBusiness.PesquisarContato(nome));
        }
        [HttpGet("PesquisarEndereco/{endereco}")]
        public IActionResult PesquisarContatoEnd(string endereco)
        {
            ContatoBusiness contatoBusiness = new ContatoBusiness();
            return Ok(contatoBusiness.PesquisarContatoEnd(endereco));
        }

        [HttpPost("Criar")]
        public IActionResult CriarContato([FromBody] ContatoDTO contato)
        {
            ContatoBusiness contatoBusiness = new ContatoBusiness();
            string msgErro = contatoBusiness.AdicionarContato(contato);
            if (!string.IsNullOrEmpty(msgErro))
            {
                return Ok(new
                {
                    Status = "Erro",
                    Mensagem = msgErro
                });
            }
            return Ok();
        }
        [HttpDelete("Deletar/{id}")]
        public IActionResult DeletarContato(int id)
        {
            ContatoBusiness contatoBusiness = new ContatoBusiness();
            return Ok(contatoBusiness.DeletarContato(id));
        }
        [HttpPatch("Update/{id}")]
        public IActionResult UpdateContato([FromBody] ContatoDTO contatoDTO, int id)
        {
            ContatoBusiness contatoBusiness = new ContatoBusiness();
            return Ok(contatoBusiness.UpdateContato(contatoDTO, id));
        }
    }
}