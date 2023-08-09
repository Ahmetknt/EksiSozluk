using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Content : IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int HeadingId { get; set; }
        public string ContentText { get; set; }
        public DateTime ContentDate { get; set; }
    }
}
