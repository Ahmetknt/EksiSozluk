using Core.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businees.Abstract
{
    public interface IPageAboutService
    {
        IDataResult<List<PageAbout>> GetAll();
        IDataResult<PageAbout> GetById(int pageAboutId);
        IResult Add(PageAbout pageAbout);
        IResult Update(PageAbout pageAbout);
        IResult Delete(PageAbout pageAbout);
    }
}
