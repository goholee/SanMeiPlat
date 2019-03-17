using Abp.Application.Services;
using Abp.Application.Services.Dto;
using SanMeiPlat.CourseTypes.Dto;
using System.Threading.Tasks;

namespace SanMeiPlat.CourseTypes
{
    public interface ICourseTypeAppService:IApplicationService
    {
        /// <summary>
        /// 获取课程类型  支持分页
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task<PagedResultDto<CourseTypeListDto>> GetPagedCourseTypeAsync(GetCourseTypeInput input);
        
        /// <summary>
        /// 根据ID获取课程分类
        /// </summary>
        /// <returns></returns>
        Task<CourseTypeListDto> GetCourseTypeByIdAsync(NullableIdDto input);

        /// <summary>
        /// 新增或更新课程分类
        /// </summary>
        /// <returns></returns>
        Task CreateOrUpdateCourseTypeAsync(CreateOrUpdateCourseTypeInput input);

        /// <summary>
        /// 删除课程分类
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task DeleteCourseTypeAsync(EntityDto input);


    }
}
