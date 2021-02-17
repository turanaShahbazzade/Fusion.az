using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fusion.az.Helpers
{
    public class AzIdentityErrorDescriber:IdentityErrorDescriber
    {
        public override IdentityError PasswordRequiresUpper()
        {
       
            return new IdentityError
            {
                Code=nameof(PasswordRequiresUpper),
                Description="Passwordda ən az bir böyük hərf olmalıdır",

            };
        }
    }
}
