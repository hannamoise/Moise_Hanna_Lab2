using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Policy;

namespace Moise_Hanna_Lab2.Models
{
    public class Author
    { 
            public int ID { get; set; } // ID-ul autorului
            public string FirstName { get; set; } // Prenumele autorului
            public string LastName { get; set; } // Numele autorului

            // Proprietatea de navigare pentru cărți
            public ICollection<Book> Books { get; set; }
            public string FullName => $"{FirstName} {LastName}";
    }
}
