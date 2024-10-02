using Microsoft.AspNetCore.Identity;

namespace RnD.PostgreSQLCoreSample.Identity
{
    public class ApplicationRole : IdentityRole<string>
    {
        public ApplicationRole() { }

        public bool IsActive { get; set; }
    }
}
