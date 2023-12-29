using ClassModels;
using ClassInterface;
namespace ClassServices
{
    public class WorkerService:IWorker
    {
        public DateTime Date { get; set; }
        public List<Worker> Workers { get; set; }
        static int id = 1;
        public WorkerService()
        {
            this.Date=DateTime.Now;
            Workers = new List<Worker>(){
            new Worker(){Id=1,Name="moshe"}
            };
        }
        public List<Worker> Get()
        {
            System.Console.WriteLine("worker: "+this.Date);
            return Workers;
        }
        public List<Worker> AddWorker(Worker w)
        {
            id++;
            w.Id=id;
            Workers.Add(w);
            return Workers;
        }
        public List<Worker>? Delete(int id)
        {
            foreach (var w in Workers)
            {
                if (w.Id == id)
                {
                    Workers.Remove(w);
                    return Workers;
                }
            }
            return null;
        }
    }
}
