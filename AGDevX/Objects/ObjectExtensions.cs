using System.Diagnostics.CodeAnalysis;

namespace AGDevX.Objects;

public static class ObjectExtensions
{
    /// <summary>
    /// Determines if an object is null
    /// </summary>
    /// <param name="obj">Object to check (required)</param>
    /// <returns>True if null, Otherwise, false.</returns>
    public static bool IsNull([NotNullWhen(false)] this object? obj)
    {
        return obj == null;
    }

    /// <summary>
    /// Determines if an object is not null
    /// </summary>
    /// <param name="obj">Object to check (required)</param>
    /// <returns>Returns true if not null. Otherwise, false.</returns>
    public static bool IsNotNull([NotNullWhen(true)] this object? obj)
    {
        return obj != null;
    }
}