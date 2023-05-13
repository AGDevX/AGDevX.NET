using System;

namespace AGDevX.Exceptions;

/// <summary>
/// Exception to throw if an error occurs during the execution of an extension method when no other more-specific exceptions are available
/// </summary>
public sealed class ExtensionMethodException : CodedException
{
    public override string Code => "EXTENSION_METHOD_EXCEPTION";

    public ExtensionMethodException()
    {
    }

    public ExtensionMethodException(string message) : base(message)
    {
    }

    public ExtensionMethodException(string message, Exception innerException) : base(message, innerException)
    {
    }
}