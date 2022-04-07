using DersBlogSitesi.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DersBlogSitesi.Controllers
{
    public class DerslerController : Controller
    {
        public IActionResult Index()
        {
            var lessons = new List<Lesson>
            {
                new Lesson
                {
                    ID=1,LessonName="HTML",Category="FRONTENT"
                },
                 new Lesson
                {
                    ID=2,LessonName="HTML2",Category="FRONTENT1"
                }, new Lesson
                {
                    ID=3,LessonName="HTML3",Category="FRONTENT2"
                }, new Lesson
                {
                    ID=4,LessonName="HTML4",Category="FRONTENT3"
                }, new Lesson
                {
                    ID=5,LessonName="HTML5",Category="FRONTENT4"
                }, new Lesson
                {
                    ID=6,LessonName="HTML6",Category="FRONTENT5"
                }, new Lesson
                {
                    ID=7,LessonName="HTML7",Category="FRONTENT6"
                }

            };
            return View(lessons);
        }
    }
}
