using Businees.Abstract;
using Core.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Constants;
using Core.Aspects.Autofac.Validation;
using Business.ValidationRules.FluentValidation;
using Business.BusineesAspects.Autofac;

namespace Businees.Concrete
{
    public class ContentManager : IContentService
    {
        IContentDal _contentDal;

        public ContentManager(IContentDal contentDal)
        {
            _contentDal = contentDal;
        }

        [SecuredOperation("content.add,admin")]
        [ValidationAspect(typeof(ContentValidator))]
        public IResult Add(Content content)
        {
            _contentDal.Add(content);
            return new SuccessResult(Messages.ContentAdded);
        }

        public IResult Delete(Content content)
        {
            _contentDal.Delete(content);
            return new SuccessResult(Messages.ContentDeleted);
        }

        public IDataResult<List<Content>> GetAll()
        {
            return new SuccessDataResult<List<Content>>(_contentDal.GetAll(),Messages.ContentListed);
        }

        public IDataResult<Content> GetById(int contentId)
        {
            return new SuccessDataResult<Content>(_contentDal.Get(c => c.Id == contentId));
        }

        public IDataResult<List<ContentDetailsDto>> GetContentDetails()
        {
            return new SuccessDataResult<List<ContentDetailsDto>>(_contentDal.GetContentDetails(), Messages.ContentListed);
        }

        public IResult Update(Content content)
        {
            _contentDal.Update(content);
            return new SuccessResult(Messages.ContentUpdated);
        }
    }
}
