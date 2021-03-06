using System;
using System.Collections.Generic;
using System.Text;
using Autofac.Core;
using Core.Entities;
using Core.Entities.Concrete;

namespace Core.Utilities.Security.JWT
{
    public interface ITokenHelper
    {
        AccessToken CreateToken(User user, List<OperationClaim> operationClaims);
    }
}
