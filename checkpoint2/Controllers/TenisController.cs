using Checkpoint2.Models;
using Microsoft.AspNetCore.Mvc;

namespace Checkpoint2.Controllers
{
    public class TenisController : Controller
    {
        private static IList<Tenis> _lista = new List<Tenis>();
        private static int _id = 0;

        [HttpPost]
        public IActionResult Remover(int id)
        {
            _lista.Remove(_lista.First(v => v.Id == id));
            TempData["msg"] = "Tenis excluido com sucesso!";
            return RedirectToAction("Index");
        }
        public IActionResult Index()
        {
            return View(_lista);
        }


        [HttpGet]
        public IActionResult Editar(int id)
        {
            var tenis = _lista.First(v => v.Id == id);
            return View(tenis);
        }

        [HttpPost]
        public IActionResult Editar(Tenis tenis)
        {
            var index = _lista.ToList().FindIndex(v => v.Id == tenis.Id);
            _lista[index] = tenis;
            TempData["msg"] = "Tenis Atualizado com sucesso!";
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Tenis tenis)
        {
            tenis.Id = ++_id;
            _lista.Add(tenis);
            TempData["mensagem"] = tenis.Modelo+ " cadastrado com sucesso!";
            return RedirectToAction("Cadastrar");
        }

    }
}
