using Core.DataAccess;
using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities.Concrete;


namespace DataAccess.Abstract
{
   public interface IUserDal: IEntityRepository<User>
    {
        List<OperationClaim> GetClaims(User user);
    }
}
