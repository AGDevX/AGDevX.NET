using System;

namespace AGDevX.Exceptions;

/// <summary>
/// Exception to throw if a claim is unable to be retrieved from a ClaimsPrincipal
/// </summary>
public sealed class ClaimNotFoundException : CodedException
{
    public override string Code => "CLAIM_NOT_FOUND_EXCEPTION";

    public ClaimNotFoundException()
    {
    }

    public ClaimNotFoundException(string message) : base(message)
    {
    }

    public ClaimNotFoundException(string message, Exception innerException) : base(message, innerException)
    {
    }
}