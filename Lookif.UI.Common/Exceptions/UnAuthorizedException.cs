using System;

namespace Lookif.UI.Common.Exceptions;

public class UnAuthorizedException : Exception
{
    public UnAuthorizedException(string message)
    {
        Message = message;
    }
    public string Message { get; set; }
    //ToDo Set error status
}
