namespace Cappy.SDK.Modules;

public class CappySdkException : Exception
{
    public new Exception InnerException { get; private set; }
    public new string Message { get; private set; }

    public CappySdkException(string message)
    {
        Message = message;
    }

    public CappySdkException(Exception innerException)
    {
        InnerException = innerException;
    }
}