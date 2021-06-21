using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebPage.Models.Repository
{
    public interface ILessonRepository
    {
        IEnumerable<Lesson> AllLessons { get; }
        IEnumerable<Lesson> LessonsOfTheWeek { get; }
        Lesson GetLessonById(int id);
    }
}
