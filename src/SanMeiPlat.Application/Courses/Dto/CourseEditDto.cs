using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SanMeiPlat.Courses.Dto
{
    [AutoMapFrom(typeof(Courses))]
    public class CourseEditDto
    {
        public int? Id { get; set; }

        /// <summary>
        /// 课程类型
        /// </summary>
        [Required]
        public CourseTypes.CourseTypes CourseType { get; set; }

        /// <summary>
        /// 课程期数
        /// </summary>
        public int CourseNum { get; set; }

        /// <summary>
        /// 课程名称
        /// </summary>
        [MaxLength(200)]
        public string CourseName { get; set; }

        /// <summary>
        /// 授课讲师
        /// </summary>
        [MaxLength(20)]
        public string CourseTeacher { get; set; }

        /// <summary>
        /// 授课地点
        /// </summary>
        [MaxLength(500)]
        public string CourseAddress { get; set; }

        /// <summary>
        /// 开课时间
        /// </summary>
        [MaxLength(50)]
        public string CourseStartDate { get; set; }

        /// <summary>
        /// 课程报名老师，课程联系人
        /// </summary>
        [MaxLength(20)]
        public string CourseContact { get; set; }

        /// <summary>
        /// 课程报名电话，课程联系人电话
        /// </summary>
        [MaxLength(11)]
        public string CourseContactNumber { get; set; }
    }
}
