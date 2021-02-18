using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public interface IDataResult<C>:IResult //hangi tipi döndürecegini söyle.
    {
        // success ve mesaage IResultan gelir.
        C Data { get; }
    }
}
