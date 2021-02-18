using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
   public class ErrorDataResult<C>: DataResult<C>
    {
        
            public ErrorDataResult(C data, string message) : base(data, false, message)
            {

            }
            public ErrorDataResult(C data) : base(data, false)
            {

            }
            public ErrorDataResult(string message) : base(default, false, message)
            {

            }
            public ErrorDataResult() : base(default, false)
            {

            }
        }
}
