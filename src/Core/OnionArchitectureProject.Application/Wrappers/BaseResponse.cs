﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OnionArchitectureProject.Application.Wrappers
{
    public class BaseResponse
    {
        public Guid Id { get; set; }
        public bool Success { get; set; }
        public string Message { get; set; }
    }
}
