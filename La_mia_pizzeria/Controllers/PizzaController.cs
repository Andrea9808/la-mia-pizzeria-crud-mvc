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


    }
}