using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        //this, diğer constructor u çalıştırır.
        /*iki parametre gönderildiği zaman, Success = success
        kodunu burada this yazarak diğer constructor'da çalıştırırız.*/
        public Result(bool success, string message):this(success)
        {
          //  Success = success;
            Message = message;  
        }
        //tek parametreli constructor 
        public Result(bool success)
        {
            Success = success;
        }

        public bool Success { get; }

        public string Message { get; }

        // !!Get'ler constructor ile set edilebilir.
    }
}
