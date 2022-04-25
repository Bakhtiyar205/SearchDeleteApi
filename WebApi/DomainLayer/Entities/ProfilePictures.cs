using DomainLayer.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Entities
{
    public class ProfilePictures : BaseEntity
    {
        public string Images { get; set; }
        public int ProfileId { get; set; }
        public Profiles Profile { get; set; }
    }
}
