using Abp.AutoMapper;
using Abp.Runtime.Validation;
using SanMeiPlat.Dto;

namespace SanMeiPlat.CourseTypes.Dto
{
    [AutoMapFrom(typeof(CourseTypes))]
    public class GetCourseTypeInput : PagedAndSortedInputDto, IShouldNormalize
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