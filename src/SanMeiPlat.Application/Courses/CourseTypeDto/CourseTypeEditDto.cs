using Abp.AutoMapper;
using System;
using System.ComponentModel.DataAnnotations;

namespace SanMeiPlat.CourseTypeDto
{
    [AutoMapTo(typeof(CourseTypes.CourseTypes))]
    public class CourseTypeEditDto
    {
        /// <summary>
        /// 课程种类名称
        /// </summary>
        [Required]
        [MaxLength(SanMeiPlatConsts.MaxCourseLength)]
        public string CourseTypeName { get; set; }

        public DateTime CreationTime { get; set; }
    }
}