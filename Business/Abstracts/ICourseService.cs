using Core.Utilities.Results;
using Entities.Concretes;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface ICourseService 
    {
        IDataResult<List<Course>> GetAll();

        IDataResult<Course> GetById(int Id);

        IResult Add(Course course);

        IResult Update(Course course);

        IResult Delete(Course course);
        IDataResult<List<CourseDetailDto>> GetCourseDetails();

    }
}
