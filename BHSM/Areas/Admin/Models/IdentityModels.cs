using BHSM.Areas.Admin.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using BHSM.Models;
using System.ComponentModel.DataAnnotations;

namespace  BHSM.Areas.Admin.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {

        [Required]
        public string Name { get; set; }
        
        public int? DepartmentListId { get; set; }
        public DepartmentList DepartmentList { get; set; }


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
        public DbSet<CHS_Staff> Staffs { get; set; }

        public DbSet<Department> Departments { get; set; }
        public DbSet<EnqueryTable> EnqueryTables { get; set; }
        public DbSet<AnswerTable> AnswerTables { get; set; }
        public DbSet<ChsRole> ChsRoles { get; set; }
        public DbSet<DepartmentList> DepartmentLists { get; set; }
      


        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}