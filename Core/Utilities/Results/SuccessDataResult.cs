using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccessDataResult<C>:DataResult<C> 
    {
        public SuccessDataResult(C data, string message): base(data,true,message)
        {

        }
        public SuccessDataResult(C data): base(data,true)
        {

        }
        public SuccessDataResult(string message): base(default ,true,message)
        {
                
        }
        public SuccessDataResult(): base(default,true)
        {
                
        }
    }
}
