using SEDC.Exercise.TryBeingFit.Domain.Core.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Exercise.TryBeingFit.Domain.Core.Entities
{
    public abstract class Training
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int Time { get; set; }
        public Difficulty Difficulty { get; set; }

    }
}
