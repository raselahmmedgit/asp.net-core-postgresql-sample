using Microsoft.AspNetCore.Identity;

namespace RnD.PostgreSQLCoreSample.Identity
{
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser() { }

        public int Age { get; set; }
    }

}
