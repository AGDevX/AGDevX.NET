using System;

namespace AGDevX.Exceptions;

/// <summary>
/// Exception to throw if the ClaimsPrincipal is attempting to access a resource or perform a function that it is not allowed to
/// </summary>
public sealed class NotAuthorizedException : CodedApplicationException
{
    public override string Code { get; set; } = "NOT_AUTHORIZED_EXCEPTION";

    public NotAuthorizedException()
    {
    }

    public NotAuthorizedException(string message) : base(message)
    {
    }

    public NotAuthorizedException(string message, string code) : base(message, code)
    {
        Code = code;
    }

    public NotAuthorizedException(string message, Exception innerException) : base(message, innerException)
    {
    }

    public NotAuthorizedException(string message, string code, Exception innerException) : base(message, code, innerException)
    {
        Code = code;
    }
}