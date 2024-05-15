namespace La_mia_pizzeria.Models
{
    public class Pizza
    {
        public string _name { get; set; }
        public string _description { get; set; }
        public string _img { get; set; }
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
