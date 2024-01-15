using Microsoft.AspNetCore.Http;

namespace Cappy.SDK.Exceptions;

public class CappyException : Exception
{
    public HttpResponse Response { get; }

    public CappyException(HttpResponse response)
    {
        Response = response;
    }
}