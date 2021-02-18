using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {




        public Result(bool success,string message): this (success) // hem mesaj hem cıktı verir.
        {
            //conctructordır ve set edilebilir.

            Message = message;
        }
        public Result (bool success)  // mesaj vermeden sadece çıktı verir.
        {
            Success = success;
        }



        public bool Success { get; }

        public string Message { get; }
    }
}
