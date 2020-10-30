﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SKINET_API.Errors
{
    public class ApiValidationErrorsResponse : ApiResponse
    {
        public ApiValidationErrorsResponse() : base(400)
        {

        }
        public IEnumerable<string> Errors { get; set; }
    }
}
