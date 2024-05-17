using La_mia_pizzeria.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace La_mia_pizzeria.Controllers
{
    public class PizzaController : Controller
    {
        public IActionResult Index()
        {
            using (PizzaContext db = new PizzaContext())
            {
                //List<Pizza> pizze = GetPizzas();

                //prende le pizze direttamente dal db
                List<Pizza> pizze = PizzaManager.GetPizzasFromDatabase();

                //foreach (var pizza in pizze)
                //{
                    //db.Pizzas.Add(pizza);
                //}

                //db.SaveChanges();
                return View("Index", pizze);
            }
        }

        //SHOW
        public IActionResult Show(int id)
        {

            using (PizzaContext db = new PizzaContext())
            {
                var pizza = db.Pizzas.Find(id);

                if (pizza == null)
                {
                    return View("Error");
                }
                return View(pizza);
            }

        }

        //CREATE
        public IActionResult Create()
        {
            return View("Create");
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Pizza data)
        {
            if (!ModelState.IsValid)
            {
                return View("Create", data);
            }

            PizzaManager.InsertPizza(data);

            return RedirectToAction("Index");
        }

        //UPDATE
        public IActionResult Update(int id)
        {
            using (PizzaContext db = new PizzaContext())
            {
                var pizza = db.Pizzas.Find(id);

                if(pizza == null)
                {
                    return View("Error");
                }
                else
                {
                    return View(pizza);
                }
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(int id, Pizza data) 
        {
            if (!ModelState.IsValid)
            {
                return View("Update", data);
            }

            if(PizzaManager.UpdatePizza(id, data._name, data._description, data._img, data._price))
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View("Error");
            }
        }

        //DELETE

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            if(PizzaManager.DeletePizza(id))
            {
                return RedirectToAction("Index");
            }
            else 
            { 
                return View("Error"); 
            }
        }

    }
}