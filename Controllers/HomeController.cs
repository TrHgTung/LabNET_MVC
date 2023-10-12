using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Tung.Models;

namespace Tung.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStoreRepository _repo;
        public int PageSize = 2; // hien thi 2 sp moi trang

        public HomeController(IStoreRepository repo)
        {
            _repo = repo;
        }

        public IActionResult Index()
        {
            return View(_repo.Products);
        }

        public IActionResult Pagnition(int productPage =1)
        {
            return View(_repo.Products
                .OrderBy(p => p.Id)
                .Skip((productPage-1) * PageSize)
                .Take(PageSize)
                );
        }



    }
}