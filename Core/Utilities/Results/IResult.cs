using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
   public  interface IResult
    {
        bool Success { get; } //sadece get=okuma yapar. // basarılı? başarısız?
        string Message { get; } // olumlu-olumsuz bilgi verir. 
            
    }
}
