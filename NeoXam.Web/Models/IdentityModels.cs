using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;

namespace NeoXam.Web.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public String LastName { get; set; }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
       
        public ApplicationDbContext()
            : base("ContextNeoXam", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public System.Data.Entity.DbSet<NeoXam.Web.Models.suivi> suivis { get; set; }

        public System.Data.Entity.DbSet<NeoXam.Web.Models.employe> employes { get; set; }

        public System.Data.Entity.DbSet<NeoXam.Web.Models.salaire> salaires { get; set; }

        public System.Data.Entity.DbSet<NeoXam.Web.Models.contrat> contrats { get; set; }



        //public System.Data.Entity.DbSet<NeoXam.Web.Models.ecole> ecoles { get; set; }

        //public System.Data.Entity.DbSet<NeoXam.Web.Models.diplome> diplomes { get; set; }

        //public System.Data.Entity.DbSet<NeoXam.Web.Models.employe> employes { get; set; }
    }
}