using System;

namespace AGDevX.Exceptions;

/// <summary>
/// Base exception from which to inherit for coded null argument exceptions.
/// This inherits from ArgumentNullException and adds the concept of a "Code" that can provide additional context into the origin of the exception.
/// </summary>
public class CodedArgumentNullException : ArgumentNullException
{
    public virtual string Code { get; set; } = "CODED_ARGUMENT_NULL_EXCEPTION";

    public CodedArgumentNullException()
    {
    }

    public CodedArgumentNullException(string argumentName) : base(argumentName)
    {
    }

    public CodedArgumentNullException(string argumentName, string code) : base(argumentName)
    {
        Code = code;
    }

    public CodedArgumentNullException(string message, Exception innerException) : base(message, innerException)
    {
    }

    public CodedArgumentNullException(string argumentName, string code, Exception innerException) : base(argumentName, innerException)
    {
        Code = code;
    }
}