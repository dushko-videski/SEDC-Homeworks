using SEDC.Exercise.TryBeingFit.Domain.Core.Enums;


using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Exercise.TryBeingFit.Domain.Core.Entities
{
    public class TrainerUser : User, ITrainerUser
    {
        public int YearsExperience { get; set; }
        public TrainerUser()
        {
            Role = UserRole.Trainer;
        }

        //mora da se implementira od ITrainerUser
        public bool ChangeSchedule() //<----sto treba da pravi ovaa metoda
        {
            //To DO : Provide implementation
            //-----------------------------
            return false;
        }

        //mora da se implementira od BaseEntity
        public override string Print()
        {
            return $"The user {FirstName} {LastName} is {Role}!";
        }
    }
}
