using Microsoft.AspNetCore.Identity;

namespace WebApp.Areas.Identity.Data
{






    public class ApplicationUser : IdentityUser
    {

        public UserType UserType { get; set; }
        //public string CustomTag { get; set; }

    }


}