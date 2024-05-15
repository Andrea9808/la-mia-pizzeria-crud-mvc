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
                List<Pizza> pizze = GetPizzasFromDatabase();

                //foreach (var pizza in pizze)
                //{
                    //db.Pizzas.Add(pizza);
                //}

                //db.SaveChanges();
                return View("Index", pizze);
            }
        }

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

        private List<Pizza> GetPizzasFromDatabase()
        {
            using (PizzaContext db = new PizzaContext())
            {
                return db.Pizzas.ToList();
            }
        }
        private List<Pizza> GetPizzas()
        {
            List<Pizza> pizze = new List<Pizza>
            {
                //new Pizza("Margherita", "Pomodoro e Mozzarella", "https://tse2.mm.bing.net/th?id=OIP.ngyqhigAn1u1JdHglgT9qQHaF8&pid=Api&P=0&h=180", 5.00m),
                //new Pizza("Quattro Stagioni", "Pomodoro, Mozzarella, Funghi, Carciofi, Prosciutto Cotto", "https://tse4.mm.bing.net/th?id=OIP.-WRAk4xOUdcb9XgC3DnelgHaFG&pid=Api&P=0&h=180", 7.50m),
                //new Pizza("Diavola", "Pomodoro, Mozzarella, Salame Piccante", "https://www.tastybits.de/wp-content/uploads/2023/01/feurig-scharfe-pizza-diavolo-selber-backen.jpg", 6.50m),
                //new Pizza("Capricciosa", "Pomodoro, Mozzarella, Funghi, Carciofi, Prosciutto Cotto, Olive", "https://www.melarossa.it/wp-content/uploads/2021/02/pizza-capricciosa-ingredienti.jpg?x71872", 8.00m),
                //new Pizza("Prosciutto e Funghi", "Pomodoro, Mozzarella, Prosciutto Cotto, Funghi", "https://tse3.mm.bing.net/th?id=OIP.j_z4MDZ9XVpk2gb0i6xBBwHaEO&pid=Api&P=0&h=180", 6.50m),
                //new Pizza("Quattro Formaggi", "Mozzarella, Gorgonzola, Fontina, Grana Padano", "https://tse3.mm.bing.net/th?id=OIP.b8wlZ8lQD6U25pBZRB_oOgHaE8&pid=Api&P=0&h=180", 8.00m),
                ///new Pizza("Rustica", "Pomodoro, Mozzarella, Salsiccia, Patate, Rosmarino", "https://tse2.mm.bing.net/th?id=OIP.w_QoeH4-rcp9kuwWMVI67QHaFj&pid=Api&P=0&h=180", 7.50m),
                //new Pizza("Tonno e Cipolla", "Pomodoro, Mozzarella, Tonno, Cipolla", "https://tse2.mm.bing.net/th?id=OIP.BxKPPeXp9Ik6baCwRkbUagHaEK&pid=Api&P=0&h=180", 7.00m),
                //new Pizza("Vegetariana", "Pomodoro, Mozzarella, Verdure Grigliate", "https://tse1.mm.bing.net/th?id=OIP.cRd2t4oPlY8Ny30gKs6QyQHaE9&pid=Api&P=0&h=180", 7.50m)
            };

            return pizze;
        }
    }
}