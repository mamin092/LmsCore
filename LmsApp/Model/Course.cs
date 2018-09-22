using System;
using System.Collections.Generic;
using System.Text;
using Common;

namespace Model
{
   public class Course : Entity
    {
        public string Name { get; set; }
        public string ImgUrl { get; set; }
        public string TrainerName { get; set; }
       // public string TrainerId { get; set; }
        public double AverageRating { get; set; }
        public int EnrolledCount { get; set; }
        public double RegularPrice { get; set; }
        public double DiscountPrice { get; set; }
        public bool IsFree { get; set; }
        public string Topic { get; set; }
        public int TotalDurationHour { get; set; }
        public int TotalLectureCount { get; set; }
        public StudentLavel StudentLavel { get; set; }
        public string Language { get; set; }
        public int ViewCount { get; set; }

    }

    public enum StudentLavel
    {
        Beginner = 0,
        Intermediate,
        Expert  

    }
}
