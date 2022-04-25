using DomainLayer.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Entities
{
    public class Profiles : BaseEntity
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public ICollection<ProfilePictures> ProfilePictures { get; set; }
    }
}
