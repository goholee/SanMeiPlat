using System;
using System.Collections.Generic;
using System.Text;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;

namespace SanMeiPlat.CourseTypes
{
    /// <summary>
    /// 课程种类
    /// </summary>
    public class CourseTypes:FullAuditedEntity
    {
        /// <summary>
        /// 课程种类名称
        /// </summary>
        [Required]
        [MaxLength(50)]
        public string CourseTypeName { get; set; }
    }
}
