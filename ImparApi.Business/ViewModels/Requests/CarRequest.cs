using ImparApi.Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImparApi.Business.ViewModels.Requests
{
    public class CarRequest
    {
        public PhotoRequest Photo { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
    }
}
