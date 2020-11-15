using SEDC.Exercise.TryBeingFit.Domain;
using SEDC.Exercise.TryBeingFit.Domain.Core.Db;
using SEDC.Exercise.TryBeingFit.Services.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.Exercise.TryBeingFit.Services.Services
{
    public class UserService<T> where T : User
    {
        private LocalDb<T> _db;
        public UserService()
        {
            _db = new LocalDb<T>();
        }

        public T LogIn(string username, string password)
        {
            T user = _db.GetAll()
                    .SingleOrDefault(x => x.Username == username && x.Password == password);
            if(user == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[Error] Username or password did not match...");
                Console.ResetColor();
                //("[Error] Username or password did not match..", Color)
                //Console.ReadLine();
                return null;
            }

            return user;

        }

        public T Register(T user)
        {
            if(ValidationHelper.ValidatePassword(user.Password) == null
                || ValidationHelper.ValidateUserName(user.Username) == null
                || ValidationHelper.ValidateString(user.LastName) == null 
                || ValidationHelper.ValidateString(user.FirstName) == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error. Invalid info!");
                Console.ResetColor();
                // ("Error. Invalid info!", color)
            }

            int id = _db.Insert(user);

            return _db.GetById(id);
        }



    }
}
