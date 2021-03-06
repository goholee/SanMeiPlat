﻿using Abp.Runtime.Validation;
using SanMeiPlat.Dto;

namespace SanMeiPlat.Courses.Dto
{
    public class GetCourseInput : PagedAndSortedInputDto, IShouldNormalize
    {
        public string FilterText { get; set; }

        public void Normalize()
        {
            if (string.IsNullOrEmpty(Sorting))
            {
                Sorting = "Id";
            }
        }
    }
}
