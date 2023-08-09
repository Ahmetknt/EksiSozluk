using Businees.Abstract;
using Core.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businees.Concrete
{
    public class PageAboutManager : IPageAboutService
    {
        IPageAboutDal _pageAboutDal;

        public PageAboutManager(IPageAboutDal pageAboutDal)
        {
            _pageAboutDal = pageAboutDal;
        }
        public IResult Add(PageAbout pageAbout)
        {
            _pageAboutDal.Add(pageAbout);
            return new SuccessResult("Hakkımda eklendi.");
        }

        public IResult Delete(PageAbout pageAbout)
        {
            _pageAboutDal.Delete(pageAbout);
            return new SuccessResult("Hakkımda silindi");
        }

        public IDataResult<List<PageAbout>> GetAll()
        {
            return new SuccessDataResult<List<PageAbout>>(_pageAboutDal.GetAll(), "Hakkımda listelendi.");
        }

        public IDataResult<PageAbout> GetById(int pageAboutId)
        {
            return new SuccessDataResult<PageAbout>(_pageAboutDal.Get(p => p.Id == pageAboutId));
        }

        public IResult Update(PageAbout pageAbout)
        {
            _pageAboutDal.Update(pageAbout);
            return new SuccessResult("Hakkımda Güncellendi.");
        }
    }
}
