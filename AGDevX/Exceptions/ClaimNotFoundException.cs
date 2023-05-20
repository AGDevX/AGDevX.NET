using System;

namespace AGDevX.Exceptions;

/// <summary>
/// Exception to throw if a claim is unable to be retrieved from a ClaimsPrincipal
/// </summary>
public sealed class ClaimNotFoundException : CodedApplicationException
{
    public override string Code { get; set; } = "CLAIM_NOT_FOUND_EXCEPTION";

    public ClaimNotFoundException()
    {
    }

    public ClaimNotFoundException(string message) : base(message)
    {
    }

    public ClaimNotFoundException(string message, string code) : base(message, code)
    {
        Code = code;
    }

    public ClaimNotFoundException(string message, Exception innerException) : base(message, innerException)
    {
    }

    public ClaimNotFoundException(string message, string code, Exception innerException) : base(message, code, innerException)
    {
        Code = code;
    }
}