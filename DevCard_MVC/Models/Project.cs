using System.Collections.Generic;
namespace DevCard_MVC.Models
{
    public class Project
    {
        public Project()
        {
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image {  get; set; }
        public string Client { get; set; }

        public Project(long id, string name, string description,string image ,string client)
        {
            Id = id;
            Name = name;
            Description = description;
            Image = image;
            Client = client;
        }
    }

}
