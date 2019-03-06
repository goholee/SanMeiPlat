using Abp;
using Abp.Runtime.Validation;
using SanMeiPlat.Dto;
using System;
using System.Collections.Generic;
using System.Text;

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
