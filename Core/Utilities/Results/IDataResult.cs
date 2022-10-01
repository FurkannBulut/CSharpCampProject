using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //Genel dataların(success,message) döndürüleceği interface.

    /*DataResult aynı zamanda mesaj ve success
    döndürmesi gerektiği için IResult implementasyonu yaptık*/
    public interface IDataResult<T> : IResult
    {
        T Data { get; }
    }
}
