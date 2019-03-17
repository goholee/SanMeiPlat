using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SanMeiPlat.CourseTypes.Dto
{
    [AutoMapFrom(typeof(CourseTypes))]
    public class CourseTypeListDto : FullAuditedEntity
    {
        /// <summary>
        /// 课程种类名称
        /// </summary>
        [Required]
        [MaxLength(SanMeiPlatConsts.MaxCourseLength)]
        public string CourseTypeName { get; set; }

    }
}
