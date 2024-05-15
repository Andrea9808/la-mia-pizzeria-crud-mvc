using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace La_mia_pizzeria.Models
{
    [Table("pizza")]
    public class Pizza
    {
        [Key] public int Id { get; set; }

        [Column("pizza_name")]
        public string _name { get; set; }

        [Column("pizza_description")]
        public string _description { get; set; }

        [Column("pizza_img")]
        public string _img { get; set; }

        [Column("pizza_price")]
        public decimal _price { get; set; }

        public Pizza() { }

        public Pizza(string name, string description, string img, decimal price)
        {
            _name = name;
            _description = description;
            _img = img;
            _price = price;
        }
    }
}
