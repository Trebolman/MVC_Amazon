using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVC_Amazon.Models.Extensions;
namespace MVC_Amazon.Models
{
    public class Repository
    {
        // Justamente es static para que pueda ser accedido directamente a ella. 
        public static List<BookResponse> responses = new List<BookResponse>();
        public static IEnumerable<BookResponse> Responses
        {
            get
            {
                return responses;
            }
        }
        public static void AddResponse(BookResponse response)
        {
            responses.Add(response);
        }

        public static List<BookResponse> FillBooks()
        {
            BookResponse book1 = new BookResponse()
            {
                ISBN = "123456789",
                Author = "Giancarlo G",
                NroPages = 210,
                Price = 270,
                Title = "How to Program ASP.NET MVC"
            };
            BookResponse book2 = new BookResponse()
            {
                ISBN = "521648597",
                Author = "Giancarlo G",
                NroPages = 3200,
                Price = 3000,
                Title = "How to Program C#"
            };
            responses.Add(book1);
            responses.Add(book2);
            responses.Add(null);
            return responses;
        }

        //
        public static decimal? TotalPrice()
        {
            return responses.TotalPriceExtension();
        }
    }
}
