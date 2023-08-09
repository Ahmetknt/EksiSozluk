using Core.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.DTOs;

namespace Businees.Abstract
{
    public interface IContentService
    {
        IDataResult<List<Content>> GetAll();
        IDataResult<Content> GetById(int contentId);
        IDataResult<List<ContentDetailsDto>> GetContentDetails();
        IResult Add(Content content);
        IResult Update(Content content);
        IResult Delete(Content content);
    }
}
