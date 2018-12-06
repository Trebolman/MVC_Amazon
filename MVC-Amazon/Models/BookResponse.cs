using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Amazon.Models
{
    public class BookResponse
    {
        [Required(ErrorMessage = "Porfavor ingresa un ISBN")]
        public string ISBN { get; set; }
        [Required(ErrorMessage = "Porfavor ingresa un titulo")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Porfavor ingresa un Author")]
        public string Author { get; set; }
        [Required(ErrorMessage = "Porfavor ingresa un Precio")]
        // ? indica que puede recibir nulos
        public decimal? Price { get; set; }
        [Required(ErrorMessage = "Porfavor ingresa un Nro de Paginas")]
        public int? NroPages { get; set; }
    }
}
