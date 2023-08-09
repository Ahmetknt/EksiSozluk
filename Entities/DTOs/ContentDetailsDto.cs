using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class ContentDetailsDto : IDto
    {
        public int ContentId { get; set; }
        public string ContentText { get; set; }
        public string UserName { get; set; }
        public DateTime ContentDate { get; set; }

    }
}
