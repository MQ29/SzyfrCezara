using Microsoft.AspNetCore.Mvc;
using SzyfrCezara.Models;
using SzyfrCezara.Services;

namespace SzyfrCezara.Controllers
{
    public class CipherController : Controller
    {
        public IActionResult Index()
        {
            var model = new CaesarCipherModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult Cipher(CaesarCipherModel model)
        {
            if (ModelState.IsValid)
            {
                if (model.IsEncrypt)
                    model.Result = CeaserService.Encrypt(model.Text, model.Shift);
                else
                    model.Result = CeaserService.Decrypt(model.Text, model.Shift);
            }
            return View("Index", model);
        }
    }
}


