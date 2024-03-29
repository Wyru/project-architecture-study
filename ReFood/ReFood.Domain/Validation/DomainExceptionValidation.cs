﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ReFood.Domain.Validation
{
    public class DomainExceptionValidation : Exception
    {
        protected DomainExceptionValidation(string error) : base(error) { }

        public static void When(bool hasError, string error) {
            if (hasError)
                throw new DomainExceptionValidation(error);
        }
    }
}
