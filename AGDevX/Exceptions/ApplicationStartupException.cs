using System;

namespace AGDevX.Exceptions;

/// <summary>
/// Exception to throw during application start up if an error occurs during the application startup process
/// </summary>
public sealed class ApplicationStartupException : CodedApplicationException
{
    public override string Code { get; set; } = "APPLICATION_STARTUP_EXCEPTION";

    public ApplicationStartupException()
    {
    }

    public ApplicationStartupException(string message) : base(message)
    {
    }

    public ApplicationStartupException(string message, string code) : base(message, code)
    {
        Code = code;
    }

    public ApplicationStartupException(string message, Exception innerException) : base(message, innerException)
    {
    }

    public ApplicationStartupException(string message, string code, Exception innerException) : base(message, code, innerException)
    {
        Code = code;
    }
}