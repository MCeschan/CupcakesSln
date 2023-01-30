using CupcakesSln.Data;
using CupcakesSln.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CupcakesSln.Controllers
{
    public class CupcakeController : Controller
    {
        private readonly CupcakeContext context;

        public CupcakeController(CupcakeContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var cupcakes = context.Cupcakes.ToList();

            
            return View(cupcakes);
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            var cupcake = context.Cupcakes.Find(id);
            if (cupcake == null)
            {
                return NotFound();
            }
            return View(cupcake);
        }

        [HttpGet]
        public IActionResult Create()
        {
            Cupcake cupcake = new Cupcake();
            return View("Create", cupcake);
        }

        [HttpPost]
        public IActionResult Create(Cupcake cupcake)
        {
            if (ModelState.IsValid)
            {
                context.Cupcakes.Add(cupcake);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
           
            return View(cupcake);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var cupcake = context.Cupcakes.Find(id);
            if (cupcake == null)
            {
                return NotFound();
            }
   
            return View(cupcake);
        }

        [HttpPost]
        public ActionResult Edit(Cupcake cupcake)
        {
            if (ModelState.IsValid)
            {
                context.Entry(cupcake).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            else return View(cupcake);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var cupcake = context.Cupcakes.Find(id);
            if (cupcake == null)
            {
                return NotFound();
            }
            else
            {
                return View("Delete", cupcake);
            }
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var cupcake = context.Cupcakes.Find(id);
            if (cupcake == null)
            {
                return NotFound();
            }
            else
            {
                context.Cupcakes.Remove(cupcake);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
        }


       
    }
}
