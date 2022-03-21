using Microsoft.AspNetCore.Mvc;

namespace MVCIntro.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _repo;
        public ProductController(IProductRepository repo)
        {
            _repo = repo;
        }

        //Get controller
        public IActionResult Index()
        {
            var products = _repo.GetAllProducts();
            return View(products);
        }

        public IActionResult ViewProduct (int id)
        {
            var product = _repo.GetProduct(id);
            return View(product);
        }
    }
}
