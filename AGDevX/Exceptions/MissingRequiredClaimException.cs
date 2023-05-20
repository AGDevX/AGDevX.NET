using System;

namespace AGDevX.Exceptions;

/// <summary>
/// Exception to throw if a required Claim is missing from a ClaimsPrincipal
/// </summary>
public sealed class MissingRequiredClaimException : CodedApplicationException
{
    public override string Code { get; set; } = "MISSING_REQUIRED_CLAIM_EXCEPTION";

    public MissingRequiredClaimException()
    {
    }

    public MissingRequiredClaimException(string message) : base(message)
    {
    }

    public MissingRequiredClaimException(string message, string code) : base(message, code)
    {
        Code = code;
    }

    public MissingRequiredClaimException(string message, Exception innerException) : base(message, innerException)
    {
    }

    public MissingRequiredClaimException(string message, string code, Exception innerException) : base(message, code, innerException)
    {
        Code = code;
    }
}