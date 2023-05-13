using System;

namespace AGDevX.DateTimes;

public static class DateTimeExtensions
{
    /// <summary>
    /// Specifies the Kind of the DateTime
    /// </summary>
    /// <param name="value">DateTime object for which to specify the Kind (required)</param>
    /// <param name="kind">The DateTimeKind to specify (required)</param>
    /// <returns>DateTime as the specified Kind</returns>
    public static DateTime SpecifyKind(this DateTime value, DateTimeKind kind) => DateTime.SpecifyKind(value, kind);
}