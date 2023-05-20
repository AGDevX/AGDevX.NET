using System;

namespace AGDevX.Exceptions;

/// <summary>
/// Exception to throw if an error occurs while acquiring a token from an authorization server
/// </summary>
public sealed class AcquireTokenException : CodedApplicationException
{
    public override string Code { get; set; } = "ACQUIRE_TOKEN_EXCEPTION";

    public AcquireTokenException()
    {
    }

    public AcquireTokenException(string message) : base(message)
    {
    }

    public AcquireTokenException(string message, string code) : base(message, code)
    {
        Code = code;
    }

    public AcquireTokenException(string message, Exception innerException) : base(message, innerException)
    {
    }

    public AcquireTokenException(string message, string code, Exception innerException) : base(message, code, innerException)
    {
        Code = code;
    }
}