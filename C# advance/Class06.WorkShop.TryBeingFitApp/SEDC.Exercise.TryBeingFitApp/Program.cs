using SEDC.Exercise.TryBeingFit.Domain;
using SEDC.Exercise.TryBeingFit.Domain.Core.Entities;
using SEDC.Exercise.TryBeingFit.Domain.Core.Enums;
using SEDC.Exercise.TryBeingFit.Services.Services;
using System;

namespace SEDC.Exercise.TryBeingFitApp
{
    class Program
    {
        //zasto se static???
        public static UIService _uiService = new UIService();
        public static UserService<StandardUser> _standardUserSrvc = new UserService<StandardUser>();
        public static UserService<PremiumUser> _premiumUserSrvc = new UserService<PremiumUser>();
        public static UserService<TrainerUser> _trainerUserSrvc = new UserService<TrainerUser>();
        public static User _currentUser;

        public static void Seed()
        {
            _standardUserSrvc.Register(new StandardUser() { FirstName = "Bob", LastName = "Bobsky", Username = "bobob1", Password = "bobbest1" });
            _premiumUserSrvc.Register(new PremiumUser() { FirstName = "Jill", LastName = "Wayne", Username = "jillw", Password = "jillsuper26" });
            _trainerUserSrvc.Register(new TrainerUser() { FirstName = "John", LastName = "Johnsky", Username = "johnjj", Password = "johny55" });
        }
        static void Main(string[] args)
        {
            Seed();
            while (true)
            {
                Console.Clear();
                int loginChoice = _uiService.LogInMenu();
                Console.Clear();
                if (loginChoice == 1)
                {
                    int roleChoice = _uiService.RoleMenu();
                    UserRole role = (UserRole)roleChoice;
                    Console.Clear();
                    Console.WriteLine("Enter username: ");
                    string username = Console.ReadLine();
                    Console.WriteLine("Enter a password: ");
                    string password = Console.ReadLine();
                    switch (role)
                    {
                        case UserRole.Standard:
                            _currentUser = _standardUserSrvc.LogIn(username, password);
                            break;
                        case UserRole.Premium:
                            _currentUser = _premiumUserSrvc.LogIn(username, password);
                            break;
                        case UserRole.Trainer:
                            _currentUser = _trainerUserSrvc.LogIn(username, password);
                            break;
                    }

                    if (_currentUser == null) continue;
                    break;

                }
                else if (loginChoice == 2)
                {
                    StandardUser newUser = new StandardUser();
                    Console.WriteLine("Enter first name: ");
                    newUser.FirstName = Console.ReadLine();
                    Console.WriteLine("Enter last name: ");
                    newUser.LastName = Console.ReadLine();
                    Console.WriteLine("Enter username: ");
                    newUser.Username = Console.ReadLine();
                    Console.WriteLine("Enter password: ");
                    newUser.Password = Console.ReadLine();
                    User user = _standardUserSrvc.Register(newUser);
                    if (user == null) continue;
                }
            }
            Console.Clear();
            _uiService.Welcome(_currentUser);

            Console.ReadLine();


        }
    }
}
