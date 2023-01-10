﻿using La_Mia_Pizzeria_1.Database;
using La_Mia_Pizzeria_1.Models;
using Microsoft.AspNetCore.Mvc;


namespace La_Mia_Pizzeria_1.Controllers
{
    public class PizzaController : Controller
    {


        public IActionResult Index()
        {
            using (PizzeriaContext db = new PizzeriaContext())
            {
                List<Pizza> listaDellePizza = db.Pizzas.ToList<Pizza>();
                return View("Index", listaDellePizza);
            }

        }

        public IActionResult Details(int id)
        {

            
            bool FunzioneDiRicercaPostById(Pizza pizza)
            {
                return pizza.Id == id;
            }
            

            using (PizzeriaContext db = new PizzeriaContext())
            {
             /*   // LINQ: syntax methos
                Pizza pizzaTrovato = db.Pizzas
                    .Where(SingolaPizzaNelDb => SingolaPizzaNelDb.Id == id)
                    .FirstOrDefault(); */

                // LINQ: query syntax
                 Pizza pizzaTrovato =
                     (from p in db.Pizzas
                      where p.Id == id
                      select p).FirstOrDefault<Pizza>();

               /* // SQL QUERY
                 Pizza pizzaTrovato =
                     db.Pizzas.FromSql($"SELECT * FROM Posts WHERE Id = {id}")
                     .FirstOrDefault<Pizza>(); */

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
                db.Pizzas.Add(formData);
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }

    }
}
