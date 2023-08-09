using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfContentDal : EfEntityRepositoryBase<Content, EksiSozlukContext>, IContentDal
    {
        public List<ContentDetailsDto> GetContentDetails()
        {
            using (EksiSozlukContext context = new EksiSozlukContext())
            {
                var result = from c in context.Contents
                             join u in context.Users
                             on c.UserId equals u.Id
                             select new ContentDetailsDto { ContentId = c.Id, ContentDate = c.ContentDate, ContentText = c.ContentText, UserName = u.FirstName };
                return result.ToList();
            }

        }
    }
}
