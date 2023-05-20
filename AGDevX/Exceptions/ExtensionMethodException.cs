using System;

namespace AGDevX.Exceptions;

/// <summary>
/// Exception to throw if an error occurs during the execution of an extension method when no other more-specific exceptions are available
/// </summary>
public sealed class ExtensionMethodException : CodedApplicationException
{
    public override string Code { get; set; } = "EXTENSION_METHOD_EXCEPTION";

    public ExtensionMethodException()
    {
    }

    public ExtensionMethodException(string message) : base(message)
    {
    }

    public ExtensionMethodException(string message, string code) : base(message, code)
    {
        Code = code;
    }

    public ExtensionMethodException(string message, Exception innerException) : base(message, innerException)
    {
    }

    public ExtensionMethodException(string message, string code, Exception innerException) : base(message, code, innerException)
    {
        Code = code;
    }
}