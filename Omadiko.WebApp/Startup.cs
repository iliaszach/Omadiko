using Microsoft.Owin;
using Omadiko.WebApp.Models.AccountViewModels;
using Owin;

[assembly: OwinStartupAttribute(typeof(Omadiko.WebApp.Startup))]
namespace Omadiko.WebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);

            //From this method we will be calling our createRolesandUsers() method to create a default user role and user.
            //We will check for Roles already created or not.
            //If Roles, like Admin, is not created, then we will create a new Role as “Admin” and we will create a default user and set the user role as Admin.
            //We will be using this user as super user where the user can create new roles from our MVC application. 
            CreateRolesandUsers.createRolesandUsers();
        }
    }
}
