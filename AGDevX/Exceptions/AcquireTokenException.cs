using System;

namespace AGDevX.Exceptions;

/// <summary>
/// Exception to throw if an error occurs while acquiring a token from an authorization server
/// </summary>
public sealed class AcquireTokenException : CodedException
{
    public override string Code => "ACQUIRE_TOKEN_EXCEPTION";

    public AcquireTokenException()
    {
    }

    public AcquireTokenException(string message) : base(message)
    {
    }

    public AcquireTokenException(string message, Exception innerException) : base(message, innerException)
    {
    }
}