using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebPage.Models.Repository
{
    public class MockLessonRepositorycs : ILessonRepository
    {
        private ICategoryRepository categoryRepository = new MockCategoryRepository();
        public IEnumerable<Lesson> AllLessons => 
            new List<Lesson>
            {
                new Lesson {Id = 1, Name = "Dependency Injection", Difficulty = 3, ShortDescription = "Lesson about dependency injection.", Available = true, Category=categoryRepository.AllCategories.ToList()[0]},
                new Lesson {Id = 2, Name = "some subject 2", Difficulty = 3, ShortDescription = "Lesson about 2.", Available = true, Category=categoryRepository.AllCategories.ToList()[1]},
                new Lesson {Id = 3, Name = "some subject 3", Difficulty = 2, ShortDescription = "Lesson about 3.", Available = true, Category=categoryRepository.AllCategories.ToList()[1], IsLessonOfTheWeek = true},
                new Lesson {Id = 4, Name = "some subject 4", Difficulty = 1, ShortDescription = "Lesson about 4.", Available = true, Category=categoryRepository.AllCategories.ToList()[2]},
                new Lesson {Id = 5, Name = "some subject 5", Difficulty = 1, ShortDescription = "Lesson about 5.", Available = true, Category=categoryRepository.AllCategories.ToList()[2], IsLessonOfTheWeek = true},
            };

        public IEnumerable<Lesson> LessonsOfTheWeek => AllLessons.Where( l => l.IsLessonOfTheWeek);

        public Lesson GetLessonById(int id) => AllLessons.FirstOrDefault(l => l.Id == id);

    }
}
