using ImparApi.Business.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImparApi.Business.ViewModels.Requests
{
    public class CarRequest
    {
        [Key]
        public int PhotoId { get; set; }

        [Required]
        [MaxLength(255)]
        public string Name { get; set; }

        [Required]
        [MaxLength(255)]
        public string Status { get; set; }
        public PhotoRequest Photo { get; set; }
    }
}
