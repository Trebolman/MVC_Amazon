using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
    }
}
