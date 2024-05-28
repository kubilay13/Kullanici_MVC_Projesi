using Microsoft.Extensions.Hosting.Internal;
using Kullanıcı_MVC_Projesi.Controllers;
using System.ComponentModel.DataAnnotations;

namespace Kullanıcı_MVC_Projesi.Models
{
    public class Candidate
    {
        [Required(ErrorMessage ="Mail İs required")]
        public  string? Email { get; set; }
        [Required(ErrorMessage = "FirstName İs required")]
        public string? FirstName { get; set; }
        [Required(ErrorMessage = "lastName İs required")]
        public string? LastName { get; set;}
        public string? FullName => $"{FirstName} {LastName?.ToUpper()}";
        public int? Age { get; set; }
     
        public int? TcKimlikNo { get; set; }
        public string? SelectedCourse { get; set; }
        public DateTime? ApplyAt { get; set; }

        public Candidate() 
        {
          ApplyAt = DateTime.Now;
        }
     

    }
}
