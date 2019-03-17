using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Repositories;
using Abp.Linq.Extensions;
using Abp.UI;
using Microsoft.EntityFrameworkCore;
using SanMeiPlat.Courses.Dto;
using SanMeiPlat.CourseTypes.Dto;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;

namespace SanMeiPlat.CourseTypes
{
    public class CourseTypeAppService : SanMeiPlatAppServiceBase, ICourseTypeAppService
    {
        private readonly IRepository<CourseTypes> _courseTypeRepository;

        public CourseTypeAppService(IRepository<CourseTypes> courseTypeRespository)
        {
            _courseTypeRepository = courseTypeRespository;
        }

        public async Task CreateOrUpdateCourseTypeAsync(CreateOrUpdateCourseTypeInput input)
        {
            if (input.CourseTypeEditDto.Id.HasValue)
            {
                await UpdateCourseTypeAsync(input.CourseTypeEditDto);
            }
            else
            {
                await CreateCourseTypeAsync(input.CourseTypeEditDto);
            }
        }

        public async Task DeleteCourseTypeAsync(EntityDto input)
        {
            var entity = await _courseTypeRepository.GetAsync(input.Id);

            if (entity == null)
            {
                throw new UserFriendlyException("该课程不存在，无法删除");
            }

            await _courseTypeRepository.DeleteAsync(input.Id);
        }

        public async Task<CourseTypeListDto> GetCourseTypeByIdAsync(NullableIdDto input)
        {
            var courseType = await _courseTypeRepository.GetAsync(input.Id.Value);
            return courseType.MapTo<CourseTypeListDto>();
        }
        
        public async Task<PagedResultDto<CourseTypeListDto>> GetPagedCourseTypeAsync(GetCourseTypeInput input)
        {
            var query = _courseTypeRepository.GetAll();

            var courseTypeCount = await query.CountAsync();

            var courseTypes = await query.OrderBy(input.Sorting).PageBy(input).ToListAsync();

            var listDto = new List<CourseTypeListDto>();

            var dtos = courseTypes.MapTo<List<CourseTypeListDto>>();

            return new PagedResultDto<CourseTypeListDto>(courseTypeCount, dtos);
        }

        protected async Task UpdateCourseTypeAsync(CourseTypeEditDto input)
        {
            var entity = await _courseTypeRepository.GetAsync(input.Id.Value);

            await _courseTypeRepository.UpdateAsync(input.MapTo(entity));
        }

        protected async Task CreateCourseTypeAsync(CourseTypeEditDto input)
        {
            await _courseTypeRepository.InsertAsync(input.MapTo<CourseTypes>());
        }


    }
}
