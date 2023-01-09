using System.Transactions;

namespace La_Mia_Pizzeria_1.Models
{
    public class Pizza
    {
        //Proprietà Pizza
        public int Id { get; set; }
        public string Image { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }

        //Costruttore Pizza
        public Pizza(int id,string image, string name, string description,float price)
        {
            Id = id;
            Image = image;
            Name = name;
            Description = description;
            Price = price;
        }

    }
}
