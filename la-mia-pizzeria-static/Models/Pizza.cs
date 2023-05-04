﻿using System.ComponentModel.DataAnnotations;
using la_mia_pizzeria_static.Validation;
using Microsoft.AspNetCore.Mvc;

namespace la_mia_pizzeria_static.Models
{
    public class Pizza
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Il campo è obbligatorio")]
        [UpperCaseFirst]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Il campo è obbligatorio")] 
        [MinLength(10, ErrorMessage = "Almeno 10 caratteri")]
        public string Descrizione { get; set; }
        [Url(ErrorMessage = "URL non valido!")]
        public string? Image { get; set; }
        [Required(ErrorMessage = "Il campo è obbligatorio")]
        [Range(3, 30, ErrorMessage = "Il prezzo deve essere compreso tra 3€ & 30€")]
        public double Price { get; set; }

        public Pizza()
        {
            
        }
        public Pizza(string nome, string descrizione, string image, double price)
        {
            Nome = nome;
            Descrizione = descrizione;
            Image = image;
            Price = price;
        }
    }
}
