using System;

namespace AGDevX.Exceptions;

/// <summary>
/// Exception to throw if a required parameter was not provided to an extension method
/// </summary>
public sealed class ExtensionMethodParameterNullException : CodedException
{
    public override string Code => "EXTENSION_METHOD_PARAMETER_NULL_EXCEPTION";

    public ExtensionMethodParameterNullException()
    {
    }

    public ExtensionMethodParameterNullException(string message) : base(message)
    {
    }

    public ExtensionMethodParameterNullException(string message, Exception innerException) : base(message, innerException)
    {
    }
}