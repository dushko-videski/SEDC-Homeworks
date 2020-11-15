using System;
using System.Collections.Generic;
using System.Text;
using WebApi.Exceptions;
using WebApi.Fake_Database;
using WebApi.Models;
using System.Linq;


namespace WebApi.Service
{
    public static class AdminService
    {
        public static List<Admin> GetAdmins()
        {
            return DB.Admins;
        }

        public static Admin GetAdminById (int id)
        {
            Admin admin = DB.Admins.Single(user => user.Id == id);
            return admin;
        }

        public static List<Admin> GetAllAdminFriends(Admin oneAdmin)
        {
            try
            {
                if (oneAdmin == null)
                {
                    throw new AdminServiceException("You send me a null", new Exception());
                }
                
                var allAdminFriends = DB.Admins.Single(admin => admin.Equals(oneAdmin));
                Console.WriteLine(allAdminFriends.FullName);
                return allAdminFriends.Frineds;

            }
            catch(AdminServiceException ex)
            {
                throw new AdminServiceException(ex.Message, ex);
            }
            catch (Exception)
            {
                throw new Exception();
            }            
        }
    }
}
