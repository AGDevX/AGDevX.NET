using System;

namespace AGDevX.Exceptions;

/// <summary>
/// Exception to throw if a required Claim is missing from a ClaimsPrincipal
/// </summary>
public sealed class MissingRequiredClaimException : CodedException
{
    public override string Code => "MISSING_REQUIRED_CLAIM_EXCEPTION";

    public MissingRequiredClaimException()
    {
    }

    public MissingRequiredClaimException(string message) : base(message)
    {
    }

    public MissingRequiredClaimException(string message, Exception innerException) : base(message, innerException)
    {
    }
}