using Business.Abstracts;
using Core.DataAccess.Paging;
using DataAccess.Concretes.EntityFramework;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstracts;
using AutoMapper;
using Business.Constants;
using Business.Dtos.Requests;
using Business.Dtos.Responses;
using Core.Utilities.Results;

namespace Business.Concretes
{
    public class CourseManager : ICourseService

    {
        ICourseDal _courseDal;
        IMapper _mapper;
        
        public CourseManager(ICourseDal courseDal, IMapper mapper)
        {
            _courseDal = courseDal;
            _mapper = mapper;

        }

        public async Task<CreatedCourseResponse> Add(CreateCourseRequest createCourseRequest)
        {
            Course course=_mapper.Map<Course>(createCourseRequest);
            Course createdCourse = await _courseDal.AddAsync(course);
            CreatedCourseResponse createdCourseResponse=_mapper.Map<CreatedCourseResponse>(createdCourse);
            return createdCourseResponse;
        }

        public async Task<IResult> Delete(Course course)
        {
            await _courseDal.DeleteAsync(course, true);
            return new SuccessResult(Messages.CourseDeleted);
        }

        public async Task<CreatedCourseResponse> GetAsync(Guid id)
        {
            var getCourse = await _courseDal.GetAsync(g => g.Id == id);
            var mappedCourse = _mapper.Map<CreatedCourseResponse>(getCourse);
            return mappedCourse;
        }
        
        public async Task<IPaginate<GetListCourseResponse>> GetListAsync()
        {
            var courseList = await _courseDal.GetListAsync();
            var mappedList=_mapper.Map<Paginate<GetListCourseResponse>>(courseList);
            return mappedList;
        }

        public async Task<CreatedCourseResponse> Update(Course course)
        {
            var updatedCourse = await _courseDal.UpdateAsync(course);
            var mappedCourse = _mapper.Map<CreatedCourseResponse>(updatedCourse);
            return mappedCourse;
        }
    }
}
