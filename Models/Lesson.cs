using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebPage.Models
{
    public class Lesson
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public int Difficulty { get; set; }
        public string ImageUrl { get; set; }
        public string ImageThumbnailUrl { get; set; }
        public bool IsLessonOfTheWeek { get; set; }
        public bool Available { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
