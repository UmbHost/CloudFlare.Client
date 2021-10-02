using System.Threading;
using System.Threading.Tasks;
using CloudFlare.Client.Api.Result;
using CloudFlare.Client.Api.Zones.Settings;

namespace CloudFlare.Client.Client.Zones
{
    public interface ISettings
    {
        /// <summary>
        /// Get development mode setting of the specified zone
        /// </summary>
        /// <param name="zoneId">Zone identifier</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns></returns>
        Task<CloudFlareResult<DevelopmentModeSetting>> GetDevelopmentModeAsync(string zoneId,
            CancellationToken cancellationToken = default);

        /// <summary>
        /// Toggle the development mode setting of the specified zone
        /// </summary>
        /// <param name="zoneId">Zone identifier</param>
        /// <param name="newDevelopmentModeSetting">The modified development mode values</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns></returns>
        Task<CloudFlareResult<DevelopmentModeSetting>> ToggleDevelopmentModeAsync(string zoneId,
            NewDevelopmentModeSetting newDevelopmentModeSetting, CancellationToken cancellationToken = default);
    }
}
