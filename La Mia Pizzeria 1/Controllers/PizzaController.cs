using Microsoft.AspNetCore.Mvc;
using NetCore_01.Database;
using NetCore_01.Models;

namespace NetCore_01.Controllers
{
    public class PizzaController : Controller
    {


        public IActionResult Index()
        {
            using (PizzeriaContext db = new PizzeriaContext())
            {
                List<Pizza> listaDellePizza = db.Pizza.ToList<Pizza>();
                return View("Index", listaDellePizza);
            }

        }

        public IActionResult Details(int id)
        {

            /*
            bool FunzioneDiRicercaPostById(Post post)
            {
                return post.Id == id;
            }
            */

            using (PizzeriaContext db = new PizzeriaContext())
            {
                // LINQ: syntax methos
                Pizza pizzaTrovato = db.Pizza
                    .Where(SingolaPizzaNelDb => SingolaPizzaNelDb.Id == id)
                    .FirstOrDefault();

                // LINQ: query syntax
                /* Post postTrovato =
                     (from p in db.Posts
                      where p.Id == id
                      select p).FirstOrDefault<Post>();*/

                // SQL QUERY
                /* Post postTrovato =
                     db.Posts.FromSql($"SELECT * FROM Posts WHERE Id = {id}")
                     .FirstOrDefault<Post>(); */

                if (pizzaTrovato != null)
                {
                    return View(pizzaTrovato);
                }

                return NotFound("la pizza con l'id cercato non esiste!");

            }

        }

        [HttpGet]
        public IActionResult Create()
        {
            return View("Create");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Pizza formData)
        {
            if (!ModelState.IsValid)
            {
                return View("Create", formData);
            }

            using (PizzeriaContext db = new PizzeriaContext())
            {
                db.Pizza.Add(formData);
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }

    }
}
