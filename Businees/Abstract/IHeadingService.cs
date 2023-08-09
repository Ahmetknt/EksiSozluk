using Core.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businees.Abstract
{
    public interface IHeadingService
    {
        IDataResult<List<Heading>> GetAll();
        IDataResult<Heading> GetById(int headingId);
        IResult Add(Heading heading);
        IResult Update(Heading heading);
        IResult Delete(Heading heading);
    }
}
