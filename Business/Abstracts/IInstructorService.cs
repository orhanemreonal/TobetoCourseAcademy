using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results;
using Entities.Concretes;
using Entities.DTOs;

namespace Business.Abstracts
{
    public interface IInstructorService 
    {
        IDataResult<List<Instructor>> GetAll();

        IDataResult<Instructor> GetById(int Id);

        IResult Add(Instructor instructor);

        IResult Update(Instructor instructor);

        IResult Delete(Instructor instructor);
       



    }
}
