using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SanMeiPlat.Controllers;
using SanMeiPlat.Courses;
using SanMeiPlat.Courses.Dto;

namespace SanMeiPlat.Web.Mvc.Controllers
{
    public class CoursesController : SanMeiPlatControllerBase
    {
        private readonly ICourseAppService _courseAppService;

        public CoursesController(ICourseAppService courseAppService)
        {
            _courseAppService = courseAppService;
        }

        public async Task<IActionResult> Index(GetCourseInput input)
        {
            var dtos = await _courseAppService.GetPagedCourseAsync(input);
            return View(dtos);
        }

    }
}