using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImparApi.Business.Entities
{
    public class Car
    {
        public int Id { get; set; }
        public int PhotoId { get; set; }
        public Photo Photo { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }

    }
}
