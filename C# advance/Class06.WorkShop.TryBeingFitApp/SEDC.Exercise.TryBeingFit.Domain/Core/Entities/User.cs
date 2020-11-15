using SEDC.Exercise.TryBeingFit.Domain.Core.Entities;
using SEDC.Exercise.TryBeingFit.Domain.Core.Enums;
using SEDC.Exercise.TryBeingFit.Domain.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Exercise.TryBeingFit.Domain
{
    public abstract class User : BaseEntity, IUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public UserRole Role { get; set; }
    }
}
