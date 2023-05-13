using System;

namespace AGDevX.Exceptions;

/// <summary>
/// Exception to throw if the ClaimsPrincipal is attempting to access a resource or perform a function that it is not allowed to
/// </summary>
public sealed class NotAuthorizedException : CodedException
{
    public override string Code => "NOT_AUTHORIZED_EXCEPTION";

    public NotAuthorizedException()
    {
    }

    public NotAuthorizedException(string message) : base(message)
    {
    }

    public NotAuthorizedException(string message, Exception innerException) : base(message, innerException)
    {
    }
}