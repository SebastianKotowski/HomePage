using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebPage.Models;

namespace WebPage.ViewModels
{
    public class LessonListViewModel
    {
        public List<Lesson> Lessons { get; set; }
        public string CurrentCategory { get; set; }
    }
}
