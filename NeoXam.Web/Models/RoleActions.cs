using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NeoXam.Web.Models
{
    public class RoleActions
    {
        
            internal void AddUserAndRole()
            {
                // Access the application context and create result variables.
                Models.ApplicationDbContext context = new ApplicationDbContext();
                IdentityResult IdRoleResult;
                IdentityResult IdUserResult;

                // Create a RoleStore object by using the ApplicationDbContext object. 
                // The RoleStore is only allowed to contain IdentityRole objects.
                var roleStore = new RoleStore<IdentityRole>(context);

                // Create a RoleManager object that is only allowed to contain IdentityRole objects.
                // When creating the RoleManager object, you pass in (as a parameter) a new RoleStore object. 
                var roleMgr = new RoleManager<IdentityRole>(roleStore);
            
                // Then, you create the "canEdit" role if it doesn't already exist.
            if (!roleMgr.RoleExists("SuperAdmin"))
            {
                    IdRoleResult = roleMgr.Create(new IdentityRole { Name = "SuperAdmin" });
            }
            if (!roleMgr.RoleExists("Candidate"))
            {
                IdRoleResult = roleMgr.Create(new IdentityRole { Name = "Candidate" });
            }
            if (!roleMgr.RoleExists("Employee"))
            {
                IdRoleResult = roleMgr.Create(new IdentityRole { Name = "Employee" });
            }
            if (!roleMgr.RoleExists("TeamLeader"))
            {
                IdRoleResult = roleMgr.Create(new IdentityRole { Name = "TeamLeader" });
            }
            if (!roleMgr.RoleExists("TeamManager"))
            {
                IdRoleResult = roleMgr.Create(new IdentityRole { Name = "TeamManager" });
            }
            if (!roleMgr.RoleExists("Responsable"))
            {
                IdRoleResult = roleMgr.Create(new IdentityRole { Name = "Responsable" });
            }
            if (!roleMgr.RoleExists("Directeur"))
            {
                IdRoleResult = roleMgr.Create(new IdentityRole { Name = "Directeur" });
            }
            //bennourrabiy69 @live.fr
            // Create a UserManager object based on the UserStore object and the ApplicationDbContext  
            // object. Note that you can create new objects and use them as parameters in
            // a single line of code, rather than using multiple lines of code, as you did
            // for the RoleManager object.
           /* var userMgr = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            var appUser = new ApplicationUser
            {
                UserName = "Test@Test.com",
                Email = "Test@Test.com"
            };
            IdUserResult = userMgr.Create(appUser, "Test123/");
            if (!userMgr.IsInRole(userMgr.FindByEmail("Test@Test.com").Id, "Directeur"))
            {
                IdUserResult = userMgr.AddToRole(userMgr.FindByEmail("Test@Test.com").Id, "Directeur");
            }*/
        }
    }
}
