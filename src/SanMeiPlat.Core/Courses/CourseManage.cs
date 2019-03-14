using System;
using Abp.Domain.Repositories;
using Abp.Domain.Services;

namespace SanMeiPlat.Courses
{
    /// <summary>
    /// 联系人业务管理
    /// </summary>
    public class CourseManage : IDomainService
    {
        private readonly IRepository<Courses, int> _courseRepository;

        public CourseManage(IRepository<Courses, int> courseRepository)
        {
            _courseRepository = courseRepository;
        }

        //TODO:编写领域业务代码


        /// <summary>
        ///     初始化
        /// </summary>
        private void Init()
        {

        }

    }
}
