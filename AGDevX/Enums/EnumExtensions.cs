using System;
using System.Linq;

namespace AGDevX.Enums;

public static class EnumExtensions
{
    /// <summary>
    /// Determines if an Emum exists in a list of Enums
    /// </summary>
    /// <param name="enumeration">Emum to check for (required)</param>
    /// <param name="enums">List of Enums to check against (required)</param>
    /// <returns>True if the Enum exists in the list of Enums. Otherwise, false.</returns>
    public static bool IsOneOf(this Enum enumeration, params Enum[] enums)
    {
        return enums.Contains(enumeration);
    }
}