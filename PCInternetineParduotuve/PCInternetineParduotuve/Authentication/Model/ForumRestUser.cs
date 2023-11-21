using Microsoft.AspNetCore.Identity;

namespace PCInternetineParduotuve.Authentication.Model
{
    public class ForumRestUser : IdentityUser
    {
        public bool ForceRelogin {  get; set; }

    }
}
