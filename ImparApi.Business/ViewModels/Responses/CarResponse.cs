using ImparApi.Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImparApi.Business.ViewModels.Responses
{
    public class CarResponse
    {
        public int Id { get; set; }
        public int PhotoId { get; set; }
        public PhotoResponse Photo { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
    }
}
