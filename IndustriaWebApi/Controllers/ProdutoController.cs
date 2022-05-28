using AutoMapper;
using IndustriaWebApi.Data;
using IndustriaWebApi.Models.Dtos;
using IndustriaWebApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace IndustriaWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProdutoController : ControllerBase
    {
        private ProdutoService _service;

        public ProdutoController(IndustriaContext _context, IMapper _mapper)
        {
            _service = new ProdutoService(_context, _mapper);
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_service.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetById([FromQuery] Guid Id)
        {
            ProdutoDto produto = _service.GetById(Id);
            if (produto != null)
            {
                return Ok(produto);
            }
            return NotFound();
        }

        [HttpPost]
        public IActionResult Post([FromBody] ProdutoDto produto)
        {
            _service.Create(produto);
            return CreatedAtAction(nameof(GetById), new { Id = produto.Id }, produto);
        }

        [HttpPut]
        public IActionResult Put([FromBody] ProdutoDto novoProduto)
        {
            if(_service.GetById(novoProduto.Id) == null)
            {
                return NotFound();
            }
            _service.Update(novoProduto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete([FromQuery] Guid Id)
        {
            ProdutoDto produto = _service.GetById(Id);
            if (produto == null)
            {
                return NotFound();
            }
            _service.Remove(produto);
            return Ok();
        }
    }
}
