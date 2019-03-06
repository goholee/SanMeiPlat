using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace SanMeiPlat.Courses.Dto
{
    [AutoMapFrom(typeof(Courses))]
    public class CourseListDto : FullAuditedEntityDto
    {
        /// <summary>
        /// 课程类型
        /// </summary>

        public CourseTypes.CourseTypes CourseType { get; set; }

        /// <summary>
        /// 课程期数
        /// </summary>
        public int CourseNum { get; set; }

        /// <summary>
        /// 课程名称
        /// </summary>

        public string CourseName { get; set; }

        /// <summary>
        /// 授课讲师
        /// </summary>

        public string CourseTeacher { get; set; }

        /// <summary>
        /// 授课地点
        /// </summary>

        public string CourseAddress { get; set; }

        /// <summary>
        /// 开课时间
        /// </summary>

        public string CourseStartDate { get; set; }

        /// <summary>
        /// 课程报名老师，课程联系人
        /// </summary>

        public string CourseContact { get; set; }

        /// <summary>
        /// 课程报名电话，课程联系人电话
        /// </summary>

        public string CourseContactNumber { get; set; }

    }
}
