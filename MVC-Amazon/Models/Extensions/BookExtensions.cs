using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Amazon.Models.Extensions
{
    public static class BookExtensions
    {
        //Metodo que calculara el precio total de los libros que ingresaré
        //el signo de interrogacion significa que puede retornar nulo
        public static decimal? TotalPriceExtension(this IEnumerable<BookResponse> books)
            //cuando encuentre un BookResponse, agrego el metodo TotalPriceExtension
            //a todos los enumerables que tengan libros dentro, les agregará el metodo de extension
        {
            //return books.Sum(b => b?.Price ?? 0); //un metodo sum de linq
            return books.Sum(book => book?.Price??0); // tambien se puede escribir asi
            decimal ?total = 0; //la variable total puede ser nulo
            foreach(var book in books)
            {
                total += book.Price;
            }
            return total;
        }
    }
}
