using System;

namespace AGDevX.Exceptions;

/// <summary>
/// Exception to throw during application start up if an error occurs during the application startup process
/// </summary>
public sealed class ApplicationStartupException : CodedException
{
    public override string Code => "APPLICATION_STARTUP_EXCEPTION";

    public ApplicationStartupException()
    {
    }

    public ApplicationStartupException(string message) : base(message)
    {
    }

    public ApplicationStartupException(string message, Exception innerException) : base(message, innerException)
    {
    }
}