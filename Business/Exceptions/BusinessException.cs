﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Exceptions
{
    public class BusinessException : Exception
    {
        public BusinessException()
            : base()
        {

        }

        public BusinessException(string message)
            : base(message)
        {

        }

        public BusinessException(string message, Exception innerException)
            : base(message, innerException)
        {

        }
    }
}
