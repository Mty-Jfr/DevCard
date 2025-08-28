namespace DevCard_MVC.Models
{
    public class Service
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public Service(string id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }
}
