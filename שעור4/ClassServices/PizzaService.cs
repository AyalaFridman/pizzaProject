using ClassModels;
using ClassInterface;
namespace ClassServices
{
    public class PizzaService:IPizza
    {
        public DateTime Date { get; set; }
        protected List<Pizza> Pizzaes { get; set; }
        static int id = 3;
        public PizzaService()
        {
            this.Date=DateTime.Now;
            Pizzaes = new List<Pizza>()
            {
                new Pizza() { Name = "italkit", Gluten=false, Id=1, Price=55 },
                new Pizza() { Name = "muztarela", Gluten=true, Id=2, Price=45 },
                new Pizza() { Name = "orginal", Gluten=true, Id=3, Price=50 }
            };
        }
        public List<Pizza> Get()
        {
            System.Console.WriteLine( "pizza: "+this.Date);
            return Pizzaes;
        }
        public Pizza? GetById(int id)
        {
            foreach (var pizza in Pizzaes)
            {
                if (pizza.Id == id)
                {
                    return pizza;
                }
            }
            return null;
        }
        public Pizza? UpDate(int id,string name,int price,bool gluten)
        {
            foreach (var pizza in Pizzaes)
            {
                if (pizza.Id == id)
                {
                    pizza.Name = name;
                    pizza.Price = price;    
                    pizza.Gluten = gluten;
                    return pizza;
                }
            }
            return null;
        }
        public List<Pizza> AddPizza(Pizza p)
        {
            id++;
            p.Id= id;
            Pizzaes.Add(p);
            return Pizzaes;
        }
        public List<Pizza>? Delete(int id)
        {
            foreach (var pizza in Pizzaes)
            {
                if (pizza.Id == id)
                {
                    Pizzaes.Remove(pizza);
                    return Pizzaes;
                }
            }
            return null;
        }

    }
}
