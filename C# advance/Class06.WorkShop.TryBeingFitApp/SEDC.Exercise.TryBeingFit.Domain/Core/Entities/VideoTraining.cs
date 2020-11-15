using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Exercise.TryBeingFit.Domain.Core.Entities
{
    public class VideoTraining : Training
    {
        public string Link { get; set; }
        public int Rating { get; set; }

        public string CheckRating()
        {
            if (Rating == 1) return "Bad";
            if (Rating < 3) return "Okay";
            if (Rating > 3) return "Good";

            return "";
        }
    }
}
