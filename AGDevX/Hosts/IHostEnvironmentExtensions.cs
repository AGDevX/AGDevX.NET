using AGDevX.IEnumerables;
using Microsoft.Extensions.Hosting;

namespace AGDevX.Hosts;

public static class IHostEnvironmentExtensions
{
    /// <summary>
    /// Determines if an IHostEnvironment is configured for any of the provided environments
    /// </summary>
    /// <param name="iHostEnvironment">IHostEnvironment to check (required)</param>
    /// <param name="environments">Environments to check against (required)</param>
    /// <returns>True if the IHostEnvironment is configured for any of the provided environments. Otherwise, false.</returns>
    public static bool IsOneOf(this IHostEnvironment? iHostEnvironment, params string[] environments)
    {
        if (iHostEnvironment == null || !environments.AnySafe())
        {
            return false;
        }

        return environments!.ContainsIgnoreCase(iHostEnvironment.EnvironmentName);
    }
}