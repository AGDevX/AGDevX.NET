using System;

namespace AGDevX.Guids;

public static class GuidExtensions
{
    /// <summary>
    /// Determines if a Guid is empty
    /// </summary>
    /// <param name="guid">Guid to check (required)</param>
    /// <returns>True if empty. Otherwise, false.</returns>
    public static bool IsEmpty(this Guid guid)
    {
        return guid == Guid.Empty;
    }

    /// <summary>
    /// Determines if a Guid is not empty
    /// </summary>
    /// <param name="guid">Guid to check (required)</param>
    /// <returns>True if not empty. Otherwise, false.</returns>
    public static bool IsNotEmpty(this Guid guid)
    {
        return guid != Guid.Empty;
    }

    /// <summary>
    /// Determines if a Guid is null
    /// </summary>
    /// <param name="guid">Guid to check (required)</param>
    /// <returns>True if null. Otherwise, false.</returns>
    public static bool IsNull(this Guid? guid)
    {
        return guid == null;
    }

    /// <summary>
    /// Determines if a Guid is not null
    /// </summary>
    /// <param name="guid">Guid to check (required)</param>
    /// <returns>True if not null. Otherwise, false.</returns>
    public static bool IsNotNull(this Guid? guid)
    {
        return guid != null;
    }

    /// <summary>
    /// Determines if a Guid is null or empty
    /// </summary>
    /// <param name="guid">Guid to check (required)</param>
    /// <returns>True if null or empty. Otherwise, false.</returns>
    public static bool IsNullOrEmpty(this Guid? guid)
    {
        return guid == null || (guid.HasValue && guid.Value == Guid.Empty);
    }

    /// <summary>
    /// Determines if a Guid is not null and not empty
    /// </summary>
    /// <param name="guid">Guid to check (required)</param>
    /// <returns>True if not null and not empty. Otherwise, false.</returns>
    public static bool IsNotNullNorEmpty(this Guid? guid)
    {
        return guid != null && guid.HasValue && guid.Value != Guid.Empty;
    }
}