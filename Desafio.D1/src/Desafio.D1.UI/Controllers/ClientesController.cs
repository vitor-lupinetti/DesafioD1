using Desafio.D1.Application.AppServices.Interfaces;
using Desafio.D1.Application.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio.D1.UI.Controllers
{
    public class ClientesController : Controller
    {

        private readonly IClienteAppService _clienteAppService;
        public ClientesController(IClienteAppService clienteAppService)
        {
            _clienteAppService = clienteAppService;
        }
        // GET: ClientesController
        public async Task<ActionResult> Index()
        {
            var clientes = await _clienteAppService.ObterTodos();
            return View(clientes);
        }

        // GET: ClientesController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ClientesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ClientesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(ClienteViewModel cliente)
        {
            try
            {

                await _clienteAppService.Adicionar(cliente);
            }
            catch (Exception e)
            {

                throw;
            }
            return View();
        }

        // GET: ClientesController/Edit/5
        public async Task<ActionResult> Edit(Guid id)
        {
            var cliente = await _clienteAppService.ObterPorId(id);
            return View(cliente);
        }

        // POST: ClientesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(ClienteUpdateViewModel cliente)
        {
            await _clienteAppService.Atualizar(cliente);
            return RedirectToAction("Index");
        }

        // GET: ClientesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ClientesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
