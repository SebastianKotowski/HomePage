using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebPage.Models.Repository;
using WebPage.ViewModels;

namespace WebPage.Controllers
{
    public class LessonController : Controller
    {
        private readonly ILessonRepository lessonRepository;
        private readonly ICategoryRepository categoryRepository;
        public LessonController(ILessonRepository lessonRepository, ICategoryRepository categoryRepository)
        {
            this.lessonRepository = lessonRepository;
            this.categoryRepository = categoryRepository;
        }

        public ViewResult List()
        {
            var lessonListViewModel = new LessonListViewModel();
            lessonListViewModel.Lessons = lessonRepository.AllLessons.ToList();
            lessonListViewModel.CurrentCategory = ".NET";

            return View(lessonListViewModel);
        }
    }
}
