using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RestAPI.Models;

namespace RestAPI.Controllers
{
    [ApiController]
    [Route("/")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public Cliente Get()
        {
            return new Cliente();
        }

        [HttpGet]
        [Route("/about")]
        public string About()
        {
            return "Olá Sobre";
        }


        [HttpGet]
        [Route("/users")]
        public ICollection<Cliente> List()
        {
            var clientes = new List<Cliente>();
            clientes.Add(new Cliente() { Id = 1, Nome = "Danilo" });
            clientes.Add(new Cliente() { Id = 2, Nome = "Danilo2" });
            clientes.Add(new Cliente() { Id = 3, Nome = "Danilo3" });
            clientes.Add(new Cliente() { Id = 4, Nome = "Danilo4" });
            return clientes;
        }

        [HttpGet]
        [Route("/user/{id}")]
        public Cliente Show(int id)
        {
            return new Cliente() { Id = id, Nome = "Danilo" };
        }

        [HttpGet]
        [Route("/user/{id}/edit")]
        public string Edit(int id)
        {
            return $"O ID do cliente é {id}";
        }

        //[HttpDelete]
        //[Route("/user/{id}")]
        //public void Destroy(int id)
        //{
        //    this.HttpContext.Response.StatusCode = 204;
        //    Console.WriteLine("Excluido");
        //}

        [HttpDelete]
        [Route("/user/{id}")]
        public IActionResult Destroy(int id)
        {
            return StatusCode(204);
        }

        [HttpPost]
        [Route("/user")]
        public Cliente Create([FromBody] Cliente user)
        {
            return user;
        }

    }
}
