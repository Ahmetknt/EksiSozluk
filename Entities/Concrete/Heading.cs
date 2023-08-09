using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Heading : IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string HeadingName { get; set; }
        public DateTime HeadingDate { get; set; }
    }
}
