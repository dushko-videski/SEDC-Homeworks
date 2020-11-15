using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Exercise.TryBeingFit.Domain.Core.Entities
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }

        public abstract string Print();

    }
}
