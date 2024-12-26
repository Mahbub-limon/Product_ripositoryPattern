using Microsoft.AspNetCore.Mvc;
using ripositoryPatternPolli.Data;
using ripositoryPatternPolli.Interfaces.Manager;
using ripositoryPatternPolli.Manager;
using ripositoryPatternPolli.Models;

namespace ripositoryPatternPolli.Controllers
{
    public class ProductController : Controller
    {

        private ApplicationDbContext _dbContext;
        private IProductManager _productManager;
        private string mg;

        public ProductController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
            _productManager = new ProductManager(_dbContext);
        }



        public IActionResult Index()
        {
            var products = _productManager.GetAll();
            return View(products);
        }


        
        public IActionResult Create()  //get actionMethod
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
           bool isSaved = _productManager.Add(product);
            if (isSaved)
            {
                return RedirectToAction("Index");

            }

            else {

                mg = "Product save failed";
            
            }

            ViewBag.Mgs = mg;
            return View();
        }

        public ActionResult Edit(int id)
        {
            var product = _productManager.GetById(id);
            if (product == null) 
            {
                return NotFound();

            }
            return View(product);
        }

        [HttpPost]
        public ActionResult Edit(Product product)
        {
            bool isUpadated = _productManager.Update(product);  

            if(isUpadated)
            {
                return RedirectToAction("Index");
            }

            return View(product);
        }


        public ActionResult Details(int id)
        {
            var product = _productManager.GetById(id);

            if (product == null) 
            {
                return NotFound();
            }

            return View(product);

        }

        public ActionResult Delete(int id)
        {

            var product = _productManager.GetById(id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        [HttpPost]

        public ActionResult Delete (Product product)
        {
            bool isDeleted = _productManager.Delete(product);
            if (isDeleted)
            {
                return RedirectToAction("Index");
            }
            return View(product);
        }

    }
}
