using FakeFacebook.Loger;
using System;
using WebApi.Service;
using WebApi.Exceptions;
using System.Runtime.InteropServices;
using WebApi.Fake_Database;


namespace FakeFacebook
{
    class Program
    {
        static void Main(string[] args)
        {
            var allAdmins = AdminService.GetAdmins();
            allAdmins.ForEach(admin => Console.WriteLine(admin.FullName));
            Console.WriteLine("-----------------------");

            try
            {
                var adminById = AdminService.GetAdminById(7);
                Console.WriteLine(adminById.FullName);
                Console.WriteLine("------------------------");
            }
            catch (Exception ex)
            {
                var logger = new AdminExceptionLogger();
                logger.ExceptionLogger(ex);
                Console.WriteLine(ex.Message);
                Console.WriteLine("-------------------");
            }

            try
            {
                var admin1 = AdminService.GetAdminById(3);
                Console.WriteLine(admin1.FullName);
                var allAdminFrinds = AdminService.GetAllAdminFriends(admin1);
                allAdminFrinds.ForEach(friend => Console.WriteLine(friend.FullName));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("I proceeded to work!");


            Console.ReadLine();
        }
    }
}
