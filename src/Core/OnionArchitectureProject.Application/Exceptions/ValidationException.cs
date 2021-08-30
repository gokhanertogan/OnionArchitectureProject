using System;
using System.Collections.Generic;
using System.Text;

namespace OnionArchitectureProject.Application.Exceptions
{
    public class ValidationException :Exception
    {
        public ValidationException():this("Validation error occured")
        {

        }
        public ValidationException(string message) :base(message)
        {

        }

        public ValidationException(Exception exp):this(exp.Message)
        {

        }
    }
}
