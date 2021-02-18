using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class DataResult<C> : Result, IDataResult<C>
    {
        public DataResult(C data,bool success ,string message):base(success,message)
        {
            Data = data;
        }
        public DataResult(C data,bool success):base(success)
        {
            Data = data;
        }
        public C Data { get; }
    }
}
