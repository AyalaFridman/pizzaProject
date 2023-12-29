using ClassModels;
namespace ClassInterface
{
    public interface IWorker
    {
        public DateTime Date { get; set; }
        public List<Worker> AddWorker(Worker w);
        public List<Worker> Get();
        public List<Worker>? Delete(int id);
    }
}
