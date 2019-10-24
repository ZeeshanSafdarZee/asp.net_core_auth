using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryManagement.CustomAttributes
{
    public class ValidEmailDomainAttribute : ValidationAttribute
    {
        private readonly string allowDomain;
        public ValidEmailDomainAttribute(string allowedDomain)
        {
            this.allowDomain = allowedDomain;
        }

        public override bool IsValid(object value)
        {
            string[] arr = value.ToString().Split("@");
            return arr[1].ToUpper() == allowDomain.ToUpper();
        }
    }
}
