using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SanMeiPlat.Controllers;
using SanMeiPlat.CourseTypes;
using SanMeiPlat.CourseTypes.Dto;

namespace SanMeiPlat.Web.Mvc.Controllers
{
    public class CourseTypesController : SanMeiPlatControllerBase
    {
        private readonly ICourseTypeAppService _courseTypeAppService;

        public CourseTypesController(ICourseTypeAppService courseTypeAppService)
        {
            _courseTypeAppService = courseTypeAppService;
        }

        public async Task<IActionResult> Index(GetCourseTypeInput input)
        {
            var dtos = await _courseTypeAppService.GetPagedCourseTypeAsync(input);
            return View(dtos);
        }
    }
}