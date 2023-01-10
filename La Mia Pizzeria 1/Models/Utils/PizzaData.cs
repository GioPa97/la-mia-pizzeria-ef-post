using System.Reflection.Metadata.Ecma335;

namespace La_Mia_Pizzeria_1.Models.Utils
{


    public static class PizzaData
    {
        private static List<Models.Pizza>? pizzas;

        public static List<Models.Pizza> GetPizzas()
        {

            if (pizzas != null)
            {
                return pizzas;
            }

            pizzas = new List<Models.Pizza>();

            Models.Pizza pizza01 = new Models.Pizza(0, "Margherita", "Salsa di pomodoro, mozzarella, basilico fresco", "https://citynews-firenzetoday.stgy.ovh/~media/horizontal-hi/31855285755656/vecchio-mare-2.jpg" + "/100");
            pizzas.Add(pizza01);

            Models.Pizza pizza02 = new Models.Pizza(1, "Diavola", "Salsa di pomodoro, mozzarella, salame piccante", "https://picsum.photos/id/1" + "/100");
            pizzas.Add(pizza02);

            Models.Pizza pizza03 = new Models.Pizza(2, "Prosciutto e funghi", "Salsa di pomodoro, mozzarella, prosciutto cotto, funghi di stagione", "https://picsum.photos/id/1" + "/100");
            pizzas.Add(pizza03);

            Models.Pizza pizza04 = new Models.Pizza(3, "Marinara", "Salsa di pomodoro fresco, origano, olio extravergine d'oliva", "https://picsum.photos/id/1" + "/100");
            pizzas.Add(pizza04);

            Models.Pizza pizza05 = new Models.Pizza(4, "Straciatella e speck", "Salsa di pomodoro, straciatella di burrata, speck trentino", "https://picsum.photos/id/1" + "/100");
            pizzas.Add(pizza05);

            Models.Pizza pizza06 = new Models.Pizza(5, "Bufala", "Salsa di pomodoro, mozzarella di bufala campana, basilico fresco, olio extravergine d'oliva", "https://picsum.photos/id/1" + "/100");
            pizzas.Add(pizza06);






            return pizzas;
        }
        
    }
}

