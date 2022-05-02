using DatabaseImageProject.Models.Abstract;
using DatabaseImageProject.Models.Concrete;
using DatabaseImageProject.Models.Concrete.DAL;
using DatabaseImageProject.Models.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
namespace DatabaseImageProject.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;
        public ProductController(IProductRepository productsRepository)
        {
            _productRepository = productsRepository;
        }
        public IActionResult Index()
        {
            return View(_productRepository.GetAll());
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product product, IFormFile file)
        {
            if(file != null && (file.ContentType == "image/png" || file.ContentType == "image/jpeg"))
            {
                string imageExtension = Path.GetExtension(file.FileName);
                string imageName = Guid.NewGuid() + imageExtension;
                string path = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot/images/{imageName}");
                var stream = new FileStream(path, FileMode.Create);
                file.CopyTo(stream);
                product.ProductImage = $"/images/{imageName}";
            }
            _productRepository.Add(product);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            return View(_productRepository.GetSingle(id));
        }

        [HttpPost]
        public IActionResult Edit(IFormFile file, Product product)
        {
            ///EDİTTE FOTOĞRAF KAYBOLUYOR.
            if (file != null && product.ProductImage == null && (file.ContentType == "image/png" || file.ContentType == "image/jpeg"))
            {
                string imageExtension = Path.GetExtension(file.FileName);
                string imageName = Guid.NewGuid() + imageExtension;
                string path = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot/images/{imageName}");
                var stream = new FileStream(path, FileMode.Create);
                file.CopyTo(stream);
                product.ProductImage = $"/images/{imageName}";
            }
            _productRepository.Update(product);
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            return View(_productRepository.GetSingle(id));
        }

        public IActionResult Delete(int id)
        {
            return View(_productRepository.GetSingle(id));
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(Product product)
        {
            _productRepository.Delete(product);
            Task.Delay(1500).Wait();
            return RedirectToAction("Index");
        }
    }
}
