using Abp.Application.Services;
using Abp.Application.Services.Dto;
using SanMeiPlat.Courses.Dto;
using System.Threading.Tasks;

namespace SanMeiPlat.Courses
{
    public interface ICourseAppService:IApplicationService
    {
        /// <summary>
        /// 获取课程信息,支持分页
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task<PagedResultDto<CourseListDto>> GetPagedCourseAsync(GetCourseInput input);

        /// <summary>
        /// 根据ID获取课程信息
        /// </summary>
        /// <returns></returns>
        Task<CourseListDto> GetCourseByIdAsync(NullableIdDto input);

        /// <summary>
        /// 新增或更新课程信息
        /// </summary>
        /// <returns></returns>
        Task CreateOrUpdateCourseAsync(CreateOrUpdateCourseInput input);

        /// <summary>
        /// 删除课程信息
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task DeleteCourseAsync(EntityDto input);

    }
}
