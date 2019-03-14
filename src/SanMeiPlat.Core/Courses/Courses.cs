using System;
using System.Collections.Generic;
using System.Text;
using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;

namespace SanMeiPlat.Courses
{
    public class Courses:FullAuditedEntity
    {
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
        [MaxLength(SanMeiPlatConsts.MaxCourseLength)]
        public string CourseName { get; set; }

        /// <summary>
        /// 授课讲师
        /// </summary>
        [MaxLength(SanMeiPlatConsts.MaxNameLength)]
        public string CourseTeacher { get; set; }

        /// <summary>
        /// 授课地点
        /// </summary>
        [MaxLength(SanMeiPlatConsts.MaxAddressLength)]
        public string CourseAddress { get; set; }

        /// <summary>
        /// 开课时间
        /// </summary>
        [MaxLength(SanMeiPlatConsts.MaxDateLength)]
        public string CourseStartDate { get; set; }

        /// <summary>
        /// 课程报名老师，课程联系人
        /// </summary>
        [MaxLength(SanMeiPlatConsts.MaxNameLength)]
        public string CourseContact { get; set; }

        /// <summary>
        /// 课程报名电话，课程联系人电话
        /// </summary>
        [MaxLength(SanMeiPlatConsts.MaxPhoneLength)]
        public string CourseContactNumber { get; set; }



    }
}
