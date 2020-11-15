using SEDC.Exercise.TryBeingFit.Domain;
using SEDC.Exercise.TryBeingFit.Domain.Core.Enums;
using SEDC.Exercise.TryBeingFit.Services.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.Exercise.TryBeingFit.Services.Services
{
    public class UIService
    {
        public int LogInMenu()
        {
            List<string> menuItems = new List<string>() { "LogIn", "Register" };
            return ChooseMenu(menuItems);

        }

        public int RoleMenu()
        {
            List<string> menuItems = Enum.GetNames(typeof(UserRole)).ToList();
            return ChooseMenu(menuItems);

        }

        public int ChooseMenu<T>(List<T> items)
        {
            while(true)
            {
                Console.WriteLine("Enter a number to choose one of the following: ");
                //printa LogIn i Register:
                for (int i = 0; i < items.Count; i++)
                {
                    Console.WriteLine($"({i + 1}) {items[i]}");
                }
                int choice = ValidationHelper.ValidateNumber(Console.ReadLine(), items.Count);
                if(choice == -1)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Input incorect. Please try again");
                    Console.ResetColor();
                    // ("Input incorect. Please try again", color)
                    continue;
                }

                return choice;
            }
        }

        public void Welcome(User user)
        {
            Console.WriteLine($"Welcome to the fitness application user:  {user.Username}");
            switch (user.Role)
            {
                case UserRole.Standard:
                    Console.WriteLine($"If you enjoy the application, consider our Premium subscription..");
                    break;
                case UserRole.Premium:
                    Console.WriteLine($"");
                    break;
                case UserRole.Trainer:
                    Console.WriteLine($"");
                    break;
                
            }

        }
    }
}
