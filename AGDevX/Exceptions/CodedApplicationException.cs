using System;

namespace AGDevX.Exceptions;

/// <summary>
/// Base exception from which to inherit for coded application-specific exceptions.
/// This inherits from ApplicationException and adds the concept of a "Code" that can provide additional context into the origin of the exception.
/// </summary>
public class CodedApplicationException : ApplicationException
{
    public virtual string Code { get; set; } = "CODED_APPLICATION_EXCEPTION";

    public CodedApplicationException()
    {
    }

    public CodedApplicationException(string message) : base(message)
    {
    }

    public CodedApplicationException(string message, string code) : base(message)
    {
        Code = code;
    }

    public CodedApplicationException(string message, Exception innerException) : base(message, innerException)
    {
    }

    public CodedApplicationException(string message, string code, Exception innerException) : base(message, innerException)
    {
        Code = code;
    }
}