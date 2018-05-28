using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
   public class VendorObject
    {
        public int VendorId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string ContactNo { get; set; }
        public string EmailId { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string Country { get; set; }
        public Boolean ActiveState { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
