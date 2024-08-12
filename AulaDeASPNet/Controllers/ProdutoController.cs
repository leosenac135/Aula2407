using AulaDeASPNet.Data;
using AulaDeASPNet.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Build.FileSystem;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace AulaDeASPNet.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly AulaContext _context;
       

        public IActionResult CadastroProduto()
        {
            return View();
        }
        
        public ProdutoController(AulaContext context) 
        {
          _context = context;
        
        }
        public async Task<IActionResult> BuscarProdutos()
        {
            return View(await _context.Produtos.ToListAsync());
        }

        public async Task<IActionResult> DetalhesProdutos(int id)
        {
            return View(await _context.Produtos.FindAsync(id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CadastroProduto([Bind("Id,Nome,VidaUtil,Garantia,Preços")] Produto produto)
        {
            if (ModelState.IsValid)
            {
                _context.Add(produto);
                await _context.SaveChangesAsync();
                return RedirectToAction("BuscarProdutos");
            }
            return View(produto);
        }


    }



  



}
