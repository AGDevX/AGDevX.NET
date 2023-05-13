using System;

namespace AGDevX.Exceptions;

/// <summary>
/// Base exception from which to inherit for application-specific exceptions.
/// This inherits from ApplicationException and adds the concept of a "Code" that can be programmatically checked by other applications if this exception is serialized and returned to another application.
/// </summary>
public class CodedException : ApplicationException
{
    public virtual string Code => "CODED_EXCEPTION";

    public CodedException()
    {
    }

    public CodedException(string message) : base(message)
    {
    }

    public CodedException(string message, Exception innerException) : base(message, innerException)
    {
    }
}