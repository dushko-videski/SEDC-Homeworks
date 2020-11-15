using SEDC.Exercise.TryBeingFit.Domain.Core.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Exercise.TryBeingFit.Domain.Core.Entities
{
    public class StandardUser : User
    {
        public List<VideoTraining> VideoTrainings { get; set; }

        public StandardUser()
        {
            Role = UserRole.Standard;
        }

        //mora da se implementira od BaseEntity
        public override string Print()
        {
            return $"The user {FirstName} {LastName} is {Role} user!";
        }
    }
}
