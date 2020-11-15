using SEDC.Exercise.TryBeingFit.Domain.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Exercise.TryBeingFit.Domain.Core.Interfaces
{
    public interface IPremiumUser
    {
        LiveTraining LiveTraining { get; set; }
    }
}
