using Businees.Abstract;
using Core.Utilities.Business;
using Core.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.BusineesAspects.Autofac;
using Core.Aspects.Autofac.Validation;
using Businees.ValidationRules.FluentValidation;

namespace Businees.Concrete
{
    public class HeadingManager : IHeadingService
    {
        IHeadingDal _headingDal;

        public HeadingManager(IHeadingDal headingDal)
        {
            _headingDal = headingDal;
        }
        public IResult Add(Heading heading)
        {
            IResult result = BusinessRules.Run(HeadingNameIsNotEqual(heading.HeadingName));
            if (result != null)
            {
                return result;
            }

            _headingDal.Add(heading);
            return new SuccessResult("Başlık Eklendi.");
        }

        public IResult Delete(Heading heading)
        {
            _headingDal.Delete(heading);
            return new SuccessResult("Başlık Silindi.");
        }

        public IDataResult<List<Heading>> GetAll()
        {
            return new SuccessDataResult<List<Heading>>(_headingDal.GetAll(), "Başlıklar listelendi.");
        }

        public IDataResult<Heading> GetById(int headingId)
        {
            return new SuccessDataResult<Heading>(_headingDal.Get(h => h.Id == headingId));
        }

        public IResult Update(Heading heading)
        {
            _headingDal.Update(heading);
            return new SuccessResult("Başlık Güncellendi.");
        }


        private IResult HeadingNameIsNotEqual(string headingName)
        {

            var result = _headingDal.GetAll(p => p.HeadingName == headingName).Count;

            if (result != 0)
            {
                return new ErrorResult("Aynı isimden bir başlık daha eklenemez.");
            }
            return new SuccessResult();


        }
    }
}
