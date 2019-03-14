using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Repositories;
using Abp.Linq.Extensions;
using Abp.UI;
using Microsoft.EntityFrameworkCore;
using SanMeiPlat.Courses.Dto;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;

namespace SanMeiPlat.Courses
{
    /// <summary>
    /// 课程服务实现
    /// </summary>
    public class CourseAppService : SanMeiPlatAppServiceBase, ICourseAppService
    {   
        private readonly IRepository<Courses> _courseRepository;
        //private readonly CourseManage _courseManage;

        public CourseAppService(IRepository<Courses> courseRespository)
        {
            _courseRepository = courseRespository;
        }

        public async Task CreateOrUpdateCourseAsync(CreateOrUpdateCourseInput input)
        {
            if (input.CourseEditDto.Id.HasValue)
            {
                await UpdateCourseAsync(input.CourseEditDto);
            }
            else
            {
                await CreateCourseAsync(input.CourseEditDto);
            }
        }

        public async Task DeleteCourseAsync(EntityDto input)
        {
            var entity = await _courseRepository.GetAsync(input.Id);

            if (entity==null)
            {
                throw new UserFriendlyException("该课程不存在，无法删除");
            }

            await _courseRepository.DeleteAsync(input.Id);
        }

        public async Task<CourseListDto> GetCourseByIdAsync(NullableIdDto input)
        {
            var course = await _courseRepository.GetAsync(input.Id.Value);
            return course.MapTo<CourseListDto>();
        }

        public async Task<PagedResultDto<CourseListDto>> GetPagedCourseAsync(GetCourseInput input)
        {
            var query = _courseRepository.GetAll();

            var courseCount = await query.CountAsync();

            var courses = await query.OrderBy(input.Sorting).PageBy(input).ToListAsync();

            var listDto = new List<CourseListDto>();

            var dtos = courses.MapTo<List<CourseListDto>>();

            return new PagedResultDto<CourseListDto>(courseCount, dtos);


            //foreach (var course in courses)
            //{
            //    var dto = new CourseListDto();
            //    dto.CourseName = course.CourseName;
            //    dto.CourseNum = course.CourseNum;
            //    dto.CourseType = course.CourseType;
            //    dto.CourseStartDate = course.CourseStartDate;
            //    dto.CourseTeacher = course.CourseTeacher;
            //    dto.CourseAddress = course.CourseAddress;
            //    dto.CourseContact = course.CourseContact;
            //    dto.CourseContactNumber = course.CourseContactNumber;
            //}

        }

        protected async Task UpdateCourseAsync(CourseEditDto input)
        {
            var entity = await _courseRepository.GetAsync(input.Id.Value);

            await _courseRepository.UpdateAsync(input.MapTo(entity));
        }

        protected async Task CreateCourseAsync(CourseEditDto input)
        {
            await _courseRepository.InsertAsync(input.MapTo<Courses>());
        }

    }
}
