using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace ProductoEnum.Models
{
    public enum CategoryType
    { 
    
      Electronicos=10,
      Alimenticios=20,
      Moda=30,
      Belleza=40,
      Automotriz=50,
      Libros=60,
      caballos=70,
    }

    public class Product
    {
        [Key]
       public int ProductId { get; set; }
        [Display(Name = "nombre del producto")]
        [Required(ErrorMessage ="Debe ingresar el nombre del producto")]
        public string Name { get; set; }
        [Display(Name = "Cateegoria del producto")]
        [Required(ErrorMessage = "Debe ingresar la categoríá del producto")]
        public CategoryType Category { get; set; }
    }
}