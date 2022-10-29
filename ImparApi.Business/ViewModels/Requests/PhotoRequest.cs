﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImparApi.Business.ViewModels.Requests
{
    public class PhotoRequest
    {
        [Required]
        public string Base64 { get; set; }
    }
}
