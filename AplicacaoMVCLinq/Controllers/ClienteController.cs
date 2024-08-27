using AplicacaoMVCLinq.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace AplicacaoMVCLinq.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index() { return View(); }
        public IActionResult GetClientes()
        {
            Cliente c1 = new Cliente(1, "Alice", "alice@example.com", "1234-5678", new DateOnly(2000, 12, 06));
            Cliente c2 = new Cliente(2, "Bob", "bob@example.com", "2345-6789", new DateOnly(2001, 10, 06));
            Cliente c3 = new Cliente(3, "Charlie", "charlie@example.com", "3456-7890", new DateOnly(2000, 12, 06));
            Cliente c4 = new Cliente(4, "David", "david@example.com", "4567-8901", new DateOnly(2000, 12, 01));
            Cliente c5 = new Cliente(5, "Eve", "eve@example.com", "5678-9012", new DateOnly(2000, 12, 06));


            List<Cliente> ListaCliente = new List<Cliente>();
            //Adicionar os objetos Alunos na lista
            ListaCliente.Add(c1);
            ListaCliente.Add(c2);
            ListaCliente.Add(c3);
            ListaCliente.Add(c4);
            ListaCliente.Add(c5);

            return View(ListaCliente);

        }


    }
}