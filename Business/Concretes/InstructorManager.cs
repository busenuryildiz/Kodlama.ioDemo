using AutoMapper;
using Business.Abstracts;
using Business.Constants;
using Business.Dtos.Requests.Instructors;
using Business.Dtos.Responses.Instructors;
using Core.DataAccess.Paging;
using Core.Utilities.Results;
using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class InstructorManager:IInstructorService
    {
        IInstructorDal _instructorDal;
        IMapper _mapper;

        public InstructorManager(IInstructorDal instructorDal, IMapper mapper)
        {
            _instructorDal = instructorDal;
            _mapper = mapper;
        }
        public async Task<CreatedInstructorResponse> Add(CreateInstructorRequest createInstructorRequest)
        {
            Instructor instructor = _mapper.Map<Instructor>(createInstructorRequest);
            Instructor createdInstructor = await _instructorDal.AddAsync(instructor);
            CreatedInstructorResponse createdInstructorResponse = _mapper.Map<CreatedInstructorResponse>(createdInstructor);
            return createdInstructorResponse;
        }

        public async Task<IPaginate<GetListInstructorResponse>> GetListAsync()
        {
            var instructorList = await _instructorDal.GetListAsync();
            var mappedList = _mapper.Map<Paginate<GetListInstructorResponse>>(instructorList);
            return mappedList;
        }

        public async Task<CreatedInstructorResponse> Update(Instructor instructor)
        {
            var updatedInstructor = await _instructorDal.UpdateAsync(instructor);
            var mappedInstructor = _mapper.Map<CreatedInstructorResponse>(updatedInstructor);
            return mappedInstructor;
        }

        public async Task<IResult> Delete(Instructor instructor)
        {
            await _instructorDal.DeleteAsync(instructor, true);
            return new SuccessResult(Messages.InstructorDeleted);
        }

        public async Task<CreatedInstructorResponse> GetAsync(Guid id)
        {
            var getInstructor = await _instructorDal.GetAsync(g => g.Id == id);
            var mappedInstructor = _mapper.Map<CreatedInstructorResponse>(getInstructor);
            return mappedInstructor;
        }
    }
}
