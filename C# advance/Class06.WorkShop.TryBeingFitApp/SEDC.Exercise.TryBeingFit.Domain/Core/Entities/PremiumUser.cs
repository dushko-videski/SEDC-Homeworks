using SEDC.Exercise.TryBeingFit.Domain.Core.Enums;
using SEDC.Exercise.TryBeingFit.Domain.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Exercise.TryBeingFit.Domain.Core.Entities
{
    public class PremiumUser : User, IPremiumUser
    {
        public List<VideoTraining>  VideoTrainings { get; set; }

        //mora da se implementira od IPremiumUser
        public LiveTraining LiveTraining { get ; set ; }

        public PremiumUser()
        {
            Role = UserRole.Premium;
        }

        //mora da se implementira od BaseEntity
        public override string Print()
        {
            return $"The user {FirstName} {LastName} is {Role} user!";
        }
    }
}
