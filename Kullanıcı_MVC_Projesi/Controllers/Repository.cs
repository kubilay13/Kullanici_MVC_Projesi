using Kullanıcı_MVC_Projesi.Models;
using Microsoft.AspNetCore.Mvc;

namespace Kullanıcı_MVC_Projesi.Controllers
{
    public class Repository
    {
        private static List<Candidate> applications = new();
        public static IEnumerable<Candidate> Applications => applications;

        public static void Add(Candidate candidate)
        {
            applications.Add(candidate);
        }
    }
}
