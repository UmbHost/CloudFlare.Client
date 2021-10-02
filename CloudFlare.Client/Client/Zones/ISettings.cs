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
        Task<CloudFlareResult<DevelopmentMode>> GetDevelopmentModeAsync(string zoneId,
            CancellationToken cancellationToken = default);

        /// <summary>
        /// Toggle the development mode setting of the specified zone
        /// </summary>
        /// <param name="zoneId">Zone identifier</param>
        /// <param name="newDevelopmentModeSetting">The modified development mode values</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns></returns>
        Task<CloudFlareResult<DevelopmentMode>> ToggleDevelopmentModeAsync(string zoneId,
            NewDevelopmentMode newDevelopmentModeSetting, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get the always online setting of the specified zone
        /// </summary>
        /// <param name="zoneId">Zone identifier</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns></returns>
        Task<CloudFlareResult<AlwaysOnline>> GetAlwaysOnlineAsync(string zoneId,
            CancellationToken cancellationToken = default);

        /// <summary>
        /// Toggle the always online setting of the specified zone
        /// </summary>
        /// <param name="zoneId">Zone identifier</param>
        /// <param name="newAlwaysOnline">The modified aways online values</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns></returns>
        Task<CloudFlareResult<AlwaysOnline>> ToggleAlwaysOnlineAsync(string zoneId, NewAlwaysOnline newAlwaysOnline,
            CancellationToken cancellationToken = default);

        /// <summary>
        /// Get the opportunist onion setting of the specified zone
        /// </summary>
        /// <param name="zoneId">Zone identifier</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns></returns>
        Task<CloudFlareResult<OpportunisticOnion>> GetOpportunisticOnionAsync(string zoneId,
            CancellationToken cancellationToken = default);

        /// <summary>
        /// Toggle the opportunist onion setting of the specified zone
        /// </summary>
        /// <param name="zoneId">Zone identifier</param>
        /// <param name="newOpportunisticOnion">The modified opportunist onion values</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns></returns>
        Task<CloudFlareResult<OpportunisticOnion>> ToggleOpportunisticOnionAsync(string zoneId,
            NewOpportunisticOnion newOpportunisticOnion, CancellationToken cancellationToken = default);

        Task<CloudFlareResult<AlwaysUseHttps>> GetAlwaysUseHttpsAsync(string zoneId,
            CancellationToken cancellationToken = default);

        Task<CloudFlareResult<AlwaysUseHttps>> ToggleAlwaysUseHttpsAsync(string zoneId,
            NewAlwaysUseHttps newAlwaysUseHttps, CancellationToken cancellationToken = default);

        Task<CloudFlareResult<BrowserCacheTtl>> GetBrowserCacheTtlAsync(string zoneId,
            CancellationToken cancellationToken = default);

        Task<CloudFlareResult<BrowserCacheTtl>> ToggleBrowserCacheTtlAsync(string zoneId,
            NewBrowserCacheTtl newBrowserCacheTtl, CancellationToken cancellationToken = default);

        Task<CloudFlareResult<BrowserCheck>> GetBrowserCheckAsync(string zoneId,
            CancellationToken cancellationToken = default);

        Task<CloudFlareResult<BrowserCheck>> ToggleBrowserCheckAsync(string zoneId, NewBrowserCheck newBrowserCheck,
            CancellationToken cancellationToken = default);

        Task<CloudFlareResult<CacheLevel>> GetCacheLevelAsync(string zoneId,
            CancellationToken cancellationToken = default);

        Task<CloudFlareResult<CacheLevel>> ToggleCacheLevelAsync(string zoneId, NewCacheLevel newCacheLevel,
            CancellationToken cancellationToken = default);

        Task<CloudFlareResult<EmailObfuscation>> GetEmailObfuscationAsync(string zoneId,
            CancellationToken cancellationToken = default);

        Task<CloudFlareResult<EmailObfuscation>> ToggleEmailObfuscationAsync(string zoneId,
            NewEmailObfuscation newEmailObfuscation, CancellationToken cancellationToken = default);

        Task<CloudFlareResult<HotlinkProtection>> GetHotlinkProtectionAsync(string zoneId,
            CancellationToken cancellationToken = default);

        Task<CloudFlareResult<HotlinkProtection>> ToggleHotlinkProtectionAsync(string zoneId,
            NewHotlinkProtection newHotlinkProtection, CancellationToken cancellationToken = default);

        Task<CloudFlareResult<IpGeolocation>> GetIpGeolocationAsync(string zoneId,
            CancellationToken cancellationToken = default);

        Task<CloudFlareResult<IpGeolocation>> ToggleIpGeolocationAsync(string zoneId, NewIpGeolocation newIpGeolocation,
            CancellationToken cancellationToken = default);

        Task<CloudFlareResult<Minify>> GetMinifyAsync(string zoneId, CancellationToken cancellationToken = default);

        Task<CloudFlareResult<Minify>> ToggleMinifyAsync(string zoneId, NewMinify newMinfy,
            CancellationToken cancellationToken = default);

        Task<CloudFlareResult<Mirage>> GetMirageAsync(string zoneId, CancellationToken cancellationToken = default);

        Task<CloudFlareResult<Mirage>> ToggleMirageAsync(string zoneId, NewMirage newMirage,
            CancellationToken cancellationToken = default);

        Task<CloudFlareResult<Polish>> GetPolishAsync(string zoneId, CancellationToken cancellationToken = default);

        Task<CloudFlareResult<Polish>> TogglePolishAsync(string zoneId, NewPolish newPolish,
            CancellationToken cancellationToken = default);

        Task<CloudFlareResult<WebP>> GetWebpAsync(string zoneId, CancellationToken cancellationToken = default);

        Task<CloudFlareResult<WebP>> ToggleWebpAsync(string zoneId, NewWebP newWebP,
            CancellationToken cancellationToken = default);

        Task<CloudFlareResult<Brotli>> GetBrotliAsync(string zoneId, CancellationToken cancellationToken = default);

        Task<CloudFlareResult<Brotli>> ToggleBrotliAsync(string zoneId, NewBrotli newBrotli,
        CancellationToken cancellationToken = default);

        Task<CloudFlareResult<RocketLoader>> GetRocketLoaderAsync(string zoneId,
            CancellationToken cancellationToken = default);

        Task<CloudFlareResult<RocketLoader>> ToggleRocketLoaderAsync(string zoneId, NewRocketLoader newRocketLoader,
            CancellationToken cancellationToken = default);

        Task<CloudFlareResult<SecurityHeaderHsts>> GetSecurityHeaderHstsAsync(string zoneId,
            CancellationToken cancellationToken = default);

        Task<CloudFlareResult<SecurityHeaderHsts>> ToggleSecurityHeaderHstsAsync(string zoneId,
            NewSecurityHeaderHsts newSecurityHeaderHsts, CancellationToken cancellationToken = default);

        Task<CloudFlareResult<AutomaticHttpsRewrites>> GetAutomaticHttpsRewritesAsync(string zoneId,
            CancellationToken cancellationToken = default);

        Task<CloudFlareResult<AutomaticHttpsRewrites>> ToggleAutomaticHttpsRewritesAsync(string zoneId,
            NewAutomaticHttpsRewrites newAutomaticHttpsRewrites, CancellationToken cancellationToken = default);
    }
}
