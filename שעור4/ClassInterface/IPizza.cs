using ClassModels;
namespace ClassInterface
{
    public interface IPizza
    {
        public DateTime Date { get; set; }
        public List<Pizza> Get();
        public Pizza? GetById(int id);
        public Pizza? UpDate(int id, string name, int price, bool gluten);
        public List<Pizza> AddPizza(Pizza p);
        public List<Pizza>? Delete(int id);
    }
}
