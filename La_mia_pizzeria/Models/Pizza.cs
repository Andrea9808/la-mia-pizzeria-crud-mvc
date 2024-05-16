﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace La_mia_pizzeria.Models
{
    [Table("pizza")]
    public class Pizza
    {
        [Key] public int Id { get; set; }

        
        [Column("pizza_name")]
        [Required(ErrorMessage = "Il campo è obbligatorio")]
        [StringLength(25, ErrorMessage = "Il nome non può avere più di 25 caratteri")]
        public string _name { get; set; }

        
        [Column("pizza_description")]
        [Required(ErrorMessage = "Il campo è obbligatorio")]
        [StringLength(100, ErrorMessage = "La descrizione non può avere più di 100 caratteri")]
        public string _description { get; set; }

        [Column("pizza_img")]
        [Required(ErrorMessage = "Il campo è obbligatorio")]
        public string _img { get; set; }

        
        [Column("pizza_price")]
        [Required(ErrorMessage = "Il campo è obbligatorio")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Il prezzo deve essere maggiore di zero.")]
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
