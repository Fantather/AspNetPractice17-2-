using Microsoft.AspNetCore.Identity;

namespace AspNetPractice17_2_.Models
{
    public class User : IdentityUser
    {
        public int Year { get; set; }
    }
}
