using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using CloudFlare.Client.Api.Parameters.Endpoints;
using CloudFlare.Client.Api.Result;
using CloudFlare.Client.Api.Zones.Settings;
using CloudFlare.Client.Contexts;
using Newtonsoft.Json.Linq;

namespace CloudFlare.Client.Client.Zones
{
    public class Settings : ApiContextBase<IConnection>, ISettings
    {
        public Settings(IConnection connection) : base(connection)
        {
        }

        /// <inheritdoc />
        public async Task<CloudFlareResult<DevelopmentMode>> GetDevelopmentModeAsync(string zoneId, CancellationToken cancellationToken = default)
        {
            var requestUri = $"{SettingsEndpoints.Base}/{zoneId}/{SettingsEndpoints.Settings}/{ZoneEndpoints.DevelopmentMode}";
            return await Connection.GetAsync<DevelopmentMode>(requestUri, cancellationToken).ConfigureAwait(false);
        }

        /// <inheritdoc />
        public async Task<CloudFlareResult<DevelopmentMode>> ToggleDevelopmentModeAsync(string zoneId, NewDevelopmentMode newDevelopmentModeSetting, CancellationToken cancellationToken = default)
        {
            var requestUri = $"{SettingsEndpoints.Base}/{zoneId}/{SettingsEndpoints.Settings}/{SettingsEndpoints.DevelopmentMode}";
            return await Connection.PatchAsync<DevelopmentMode, NewDevelopmentMode>(requestUri, newDevelopmentModeSetting, cancellationToken).ConfigureAwait(false);
        }

        /// <inheritdoc />
        public async Task<CloudFlareResult<EarlyHints>> GetEarlyHintsAsync(string zoneId, CancellationToken cancellationToken = default)
        {
            var requestUri = $"{SettingsEndpoints.Base}/{zoneId}/{SettingsEndpoints.Settings}/{SettingsEndpoints.EarlyHints}";
            return await Connection.GetAsync<EarlyHints>(requestUri, cancellationToken).ConfigureAwait(false);
        }

        /// <inheritdoc />
        public async Task<CloudFlareResult<EarlyHints>> ToggleEarlyHintsAsync(string zoneId, NewEarlyHints newEarlyHints, CancellationToken cancellationToken = default)
        {
            var requestUri = $"{SettingsEndpoints.Base}/{zoneId}/{SettingsEndpoints.Settings}/{SettingsEndpoints.EarlyHints}";
            return await Connection.PatchAsync<EarlyHints, NewEarlyHints>(requestUri, newEarlyHints, cancellationToken).ConfigureAwait(false);
        }

        /// <inheritdoc />
        public async Task<CloudFlareResult<AlwaysOnline>> GetAlwaysOnlineAsync(string zoneId, CancellationToken cancellationToken = default)
        {
            var requestUri = $"{SettingsEndpoints.Base}/{zoneId}/{SettingsEndpoints.Settings}/{SettingsEndpoints.AlwaysOnline}";
            return await Connection.GetAsync<AlwaysOnline>(requestUri, cancellationToken).ConfigureAwait(false);
        }

        /// <inheritdoc />
        public async Task<CloudFlareResult<AlwaysOnline>> ToggleAlwaysOnlineAsync(string zoneId, NewAlwaysOnline newAlwaysOnline, CancellationToken cancellationToken = default)
        {
            var requestUri = $"{SettingsEndpoints.Base}/{zoneId}/{SettingsEndpoints.Settings}/{SettingsEndpoints.AlwaysOnline}";
            return await Connection.PatchAsync<AlwaysOnline, NewAlwaysOnline>(requestUri, newAlwaysOnline, cancellationToken).ConfigureAwait(false);
        }

        /// <inheritdoc />
        public async Task<CloudFlareResult<OpportunisticEncryption>> GetOpportunisticEncryptionAsync(string zoneId, CancellationToken cancellationToken = default)
        {
            var requestUri = $"{SettingsEndpoints.Base}/{zoneId}/{SettingsEndpoints.Settings}/{SettingsEndpoints.OpportunisticEncryption}";
            return await Connection.GetAsync<OpportunisticEncryption>(requestUri, cancellationToken).ConfigureAwait(false);
        }

        /// <inheritdoc />
        public async Task<CloudFlareResult<OpportunisticEncryption>> ToggleOpportunisticEncryptionAsync(string zoneId, NewOpportunisticEncryption newOpportunisticEncryption, CancellationToken cancellationToken = default)
        {
            var requestUri = $"{SettingsEndpoints.Base}/{zoneId}/{SettingsEndpoints.Settings}/{SettingsEndpoints.OpportunisticEncryption}";
            return await Connection.PatchAsync<OpportunisticEncryption, NewOpportunisticEncryption>(requestUri, newOpportunisticEncryption, cancellationToken).ConfigureAwait(false);
        }

        /// <inheritdoc />
        public async Task<CloudFlareResult<OpportunisticOnion>> GetOpportunisticOnionAsync(string zoneId, CancellationToken cancellationToken = default)
        {
            var requestUri = $"{SettingsEndpoints.Base}/{zoneId}/{SettingsEndpoints.Settings}/{SettingsEndpoints.OpportunisticOnion}";
            return await Connection.GetAsync<OpportunisticOnion>(requestUri, cancellationToken).ConfigureAwait(false);
        }

        /// <inheritdoc />
        public async Task<CloudFlareResult<OpportunisticOnion>> ToggleOpportunisticOnionAsync(string zoneId, NewOpportunisticOnion newOpportunisticOnion, CancellationToken cancellationToken = default)
        {
            var requestUri = $"{SettingsEndpoints.Base}/{zoneId}/{SettingsEndpoints.Settings}/{SettingsEndpoints.OpportunisticOnion}";
            return await Connection.PatchAsync<OpportunisticOnion, NewOpportunisticOnion>(requestUri, newOpportunisticOnion, cancellationToken).ConfigureAwait(false);
        }

        /// <inheritdoc />
        public async Task<CloudFlareResult<AlwaysUseHttps>> GetAlwaysUseHttpsAsync(string zoneId, CancellationToken cancellationToken = default)
        {
            var requestUri = $"{SettingsEndpoints.Base}/{zoneId}/{SettingsEndpoints.Settings}/{SettingsEndpoints.AlwaysUseHttps}";
            return await Connection.GetAsync<AlwaysUseHttps>(requestUri, cancellationToken).ConfigureAwait(false);
        }

        /// <inheritdoc />
        public async Task<CloudFlareResult<AlwaysUseHttps>> ToggleAlwaysUseHttpsAsync(string zoneId, NewAlwaysUseHttps newAlwaysUseHttps, CancellationToken cancellationToken = default)
        {
            var requestUri = $"{SettingsEndpoints.Base}/{zoneId}/{SettingsEndpoints.Settings}/{SettingsEndpoints.AlwaysUseHttps}";
            return await Connection.PatchAsync<AlwaysUseHttps, NewAlwaysUseHttps>(requestUri, newAlwaysUseHttps, cancellationToken).ConfigureAwait(false);
        }

        /// <inheritdoc />
        public async Task<CloudFlareResult<BrowserCacheTtl>> GetBrowserCacheTtlAsync(string zoneId, CancellationToken cancellationToken = default)
        {
            var requestUri = $"{SettingsEndpoints.Base}/{zoneId}/{SettingsEndpoints.Settings}/{SettingsEndpoints.BrowserCacheTtl}";
            return await Connection.GetAsync<BrowserCacheTtl>(requestUri, cancellationToken).ConfigureAwait(false);
        }

        /// <inheritdoc />
        public async Task<CloudFlareResult<BrowserCacheTtl>> ToggleBrowserCacheTtlAsync(string zoneId, NewBrowserCacheTtl newBrowserCacheTtl, CancellationToken cancellationToken = default)
        {
            var requestUri = $"{SettingsEndpoints.Base}/{zoneId}/{SettingsEndpoints.Settings}/{SettingsEndpoints.BrowserCacheTtl}";
            return await Connection.PatchAsync<BrowserCacheTtl, NewBrowserCacheTtl>(requestUri, newBrowserCacheTtl, cancellationToken).ConfigureAwait(false);
        }

        /// <inheritdoc />
        public async Task<CloudFlareResult<BrowserCheck>> GetBrowserCheckAsync(string zoneId, CancellationToken cancellationToken = default)
        {
            var requestUri = $"{SettingsEndpoints.Base}/{zoneId}/{SettingsEndpoints.Settings}/{SettingsEndpoints.BrowserCheck}";
            return await Connection.GetAsync<BrowserCheck>(requestUri, cancellationToken).ConfigureAwait(false);
        }

        /// <inheritdoc />
        public async Task<CloudFlareResult<BrowserCheck>> ToggleBrowserCheckAsync(string zoneId, NewBrowserCheck newBrowserCheck, CancellationToken cancellationToken = default)
        {
            var requestUri = $"{SettingsEndpoints.Base}/{zoneId}/{SettingsEndpoints.Settings}/{SettingsEndpoints.BrowserCheck}";
            return await Connection.PatchAsync<BrowserCheck, NewBrowserCheck>(requestUri, newBrowserCheck, cancellationToken).ConfigureAwait(false);
        }

        /// <inheritdoc />
        public async Task<CloudFlareResult<CacheLevel>> GetCacheLevelAsync(string zoneId, CancellationToken cancellationToken = default)
        {
            var requestUri = $"{SettingsEndpoints.Base}/{zoneId}/{SettingsEndpoints.Settings}/{SettingsEndpoints.CacheLevel}";
            return await Connection.GetAsync<CacheLevel>(requestUri, cancellationToken).ConfigureAwait(false);
        }

        /// <inheritdoc />
        public async Task<CloudFlareResult<CacheLevel>> ToggleCacheLevelAsync(string zoneId, NewCacheLevel newCacheLevel, CancellationToken cancellationToken = default)
        {
            var requestUri = $"{SettingsEndpoints.Base}/{zoneId}/{SettingsEndpoints.Settings}/{SettingsEndpoints.CacheLevel}";
            return await Connection.PatchAsync<CacheLevel, NewCacheLevel>(requestUri, newCacheLevel, cancellationToken).ConfigureAwait(false);
        }

        /// <inheritdoc />
        public async Task<CloudFlareResult<EmailObfuscation>> GetEmailObfuscationAsync(string zoneId, CancellationToken cancellationToken = default)
        {
            var requestUri = $"{SettingsEndpoints.Base}/{zoneId}/{SettingsEndpoints.Settings}/{SettingsEndpoints.EmailObfuscation}";
            return await Connection.GetAsync<EmailObfuscation>(requestUri, cancellationToken).ConfigureAwait(false);
        }

        /// <inheritdoc />
        public async Task<CloudFlareResult<EmailObfuscation>> ToggleEmailObfuscationAsync(string zoneId, NewEmailObfuscation newEmailObfuscation, CancellationToken cancellationToken = default)
        {
            var requestUri = $"{SettingsEndpoints.Base}/{zoneId}/{SettingsEndpoints.Settings}/{SettingsEndpoints.EmailObfuscation}";
            return await Connection.PatchAsync<EmailObfuscation, NewEmailObfuscation>(requestUri, newEmailObfuscation, cancellationToken).ConfigureAwait(false);
        }

        /// <inheritdoc />
        public async Task<CloudFlareResult<HotlinkProtection>> GetHotlinkProtectionAsync(string zoneId, CancellationToken cancellationToken = default)
        {
            var requestUri = $"{SettingsEndpoints.Base}/{zoneId}/{SettingsEndpoints.Settings}/{SettingsEndpoints.HotlinkProtection}";
            return await Connection.GetAsync<HotlinkProtection>(requestUri, cancellationToken).ConfigureAwait(false);
        }

        /// <inheritdoc />
        public async Task<CloudFlareResult<HotlinkProtection>> ToggleHotlinkProtectionAsync(string zoneId, NewHotlinkProtection newHotlinkProtection, CancellationToken cancellationToken = default)
        {
            var requestUri = $"{SettingsEndpoints.Base}/{zoneId}/{SettingsEndpoints.Settings}/{SettingsEndpoints.HotlinkProtection}";
            return await Connection.PatchAsync<HotlinkProtection, NewHotlinkProtection>(requestUri, newHotlinkProtection, cancellationToken).ConfigureAwait(false);
        }

        /// <inheritdoc />
        public async Task<CloudFlareResult<IpGeolocation>> GetIpGeolocationAsync(string zoneId, CancellationToken cancellationToken = default)
        {
            var requestUri = $"{SettingsEndpoints.Base}/{zoneId}/{SettingsEndpoints.Settings}/{SettingsEndpoints.IpGeolocation}";
            return await Connection.GetAsync<IpGeolocation>(requestUri, cancellationToken).ConfigureAwait(false);
        }

        /// <inheritdoc />
        public async Task<CloudFlareResult<IpGeolocation>> ToggleIpGeolocationAsync(string zoneId, NewIpGeolocation newIpGeolocation, CancellationToken cancellationToken = default)
        {
            var requestUri = $"{SettingsEndpoints.Base}/{zoneId}/{SettingsEndpoints.Settings}/{SettingsEndpoints.IpGeolocation}";
            return await Connection.PatchAsync<IpGeolocation, NewIpGeolocation>(requestUri, newIpGeolocation, cancellationToken).ConfigureAwait(false);
        }

        /// <inheritdoc />
        public async Task<CloudFlareResult<Minify>> GetMinifyAsync(string zoneId, CancellationToken cancellationToken = default)
        {
            var requestUri = $"{SettingsEndpoints.Base}/{zoneId}/{SettingsEndpoints.Settings}/{SettingsEndpoints.Minify}";
            return await Connection.GetAsync<Minify>(requestUri, cancellationToken).ConfigureAwait(false);
        }

        /// <inheritdoc />
        public async Task<CloudFlareResult<Minify>> ToggleMinifyAsync(string zoneId, NewMinify newMinfy, CancellationToken cancellationToken = default)
        {
            var requestUri = $"{SettingsEndpoints.Base}/{zoneId}/{SettingsEndpoints.Settings}/{SettingsEndpoints.Minify}";
            return await Connection.PatchAsync<Minify, NewMinify>(requestUri, newMinfy, cancellationToken).ConfigureAwait(false);
        }

        /// <inheritdoc />
        public async Task<CloudFlareResult<Mirage>> GetMirageAsync(string zoneId, CancellationToken cancellationToken = default)
        {
            var requestUri = $"{SettingsEndpoints.Base}/{zoneId}/{SettingsEndpoints.Settings}/{SettingsEndpoints.Mirage}";
            return await Connection.GetAsync<Mirage>(requestUri, cancellationToken).ConfigureAwait(false);
        }

        /// <inheritdoc />
        public async Task<CloudFlareResult<Mirage>> ToggleMirageAsync(string zoneId, NewMirage newMirage, CancellationToken cancellationToken = default)
        {
            var requestUri = $"{SettingsEndpoints.Base}/{zoneId}/{SettingsEndpoints.Settings}/{SettingsEndpoints.Mirage}";
            return await Connection.PatchAsync<Mirage, NewMirage>(requestUri, newMirage, cancellationToken).ConfigureAwait(false);
        }

        /// <inheritdoc />
        public async Task<CloudFlareResult<Polish>> GetPolishAsync(string zoneId, CancellationToken cancellationToken = default)
        {
            var requestUri = $"{SettingsEndpoints.Base}/{zoneId}/{SettingsEndpoints.Settings}/{SettingsEndpoints.Polish}";
            return await Connection.GetAsync<Polish>(requestUri, cancellationToken).ConfigureAwait(false);
        }

        /// <inheritdoc />
        public async Task<CloudFlareResult<Polish>> TogglePolishAsync(string zoneId, NewPolish newPolish, CancellationToken cancellationToken = default)
        {
            var requestUri = $"{SettingsEndpoints.Base}/{zoneId}/{SettingsEndpoints.Settings}/{SettingsEndpoints.Polish}";
            return await Connection.PatchAsync<Polish, NewPolish>(requestUri, newPolish, cancellationToken).ConfigureAwait(false);
        }

        /// <inheritdoc />
        public async Task<CloudFlareResult<WebP>> GetWebpAsync(string zoneId, CancellationToken cancellationToken = default)
        {
            var requestUri = $"{SettingsEndpoints.Base}/{zoneId}/{SettingsEndpoints.Settings}/{SettingsEndpoints.WebP}";
            return await Connection.GetAsync<WebP>(requestUri, cancellationToken).ConfigureAwait(false);
        }

        /// <inheritdoc />
        public async Task<CloudFlareResult<WebP>> ToggleWebpAsync(string zoneId, NewWebP newWebP, CancellationToken cancellationToken = default)
        {
            var requestUri = $"{SettingsEndpoints.Base}/{zoneId}/{SettingsEndpoints.Settings}/{SettingsEndpoints.WebP}";
            return await Connection.PatchAsync<WebP, NewWebP>(requestUri, newWebP, cancellationToken).ConfigureAwait(false);
        }

        /// <inheritdoc />
        public async Task<CloudFlareResult<Brotli>> GetBrotliAsync(string zoneId, CancellationToken cancellationToken = default)
        {
            var requestUri = $"{SettingsEndpoints.Base}/{zoneId}/{SettingsEndpoints.Settings}/{SettingsEndpoints.Brotli}";
            return await Connection.GetAsync<Brotli>(requestUri, cancellationToken).ConfigureAwait(false);
        }

        /// <inheritdoc />
        public async Task<CloudFlareResult<Brotli>> ToggleBrotliAsync(string zoneId, NewBrotli newBrotli, CancellationToken cancellationToken = default)
        {
            var requestUri = $"{SettingsEndpoints.Base}/{zoneId}/{SettingsEndpoints.Settings}/{SettingsEndpoints.Brotli}";
            return await Connection.PatchAsync<Brotli, NewBrotli>(requestUri, newBrotli, cancellationToken).ConfigureAwait(false);
        }

        /// <inheritdoc />
        public async Task<CloudFlareResult<RocketLoader>> GetRocketLoaderAsync(string zoneId, CancellationToken cancellationToken = default)
        {
            var requestUri = $"{SettingsEndpoints.Base}/{zoneId}/{SettingsEndpoints.Settings}/{SettingsEndpoints.RocketLoader}";
            return await Connection.GetAsync<RocketLoader>(requestUri, cancellationToken).ConfigureAwait(false);
        }

        /// <inheritdoc />
        public async Task<CloudFlareResult<RocketLoader>> ToggleRocketLoaderAsync(string zoneId, NewRocketLoader newRocketLoader, CancellationToken cancellationToken = default)
        {
            var requestUri = $"{SettingsEndpoints.Base}/{zoneId}/{SettingsEndpoints.Settings}/{SettingsEndpoints.RocketLoader}";
            return await Connection.PatchAsync<RocketLoader, NewRocketLoader>(requestUri, newRocketLoader, cancellationToken).ConfigureAwait(false);
        }

        /// <inheritdoc />
        public async Task<CloudFlareResult<SecurityHeaderHsts>> GetSecurityHeaderHstsAsync(string zoneId, CancellationToken cancellationToken = default)
        {
            var requestUri = $"{SettingsEndpoints.Base}/{zoneId}/{SettingsEndpoints.Settings}/{SettingsEndpoints.SecurityHeaderHsts}";
            return await Connection.GetAsync<SecurityHeaderHsts>(requestUri, cancellationToken).ConfigureAwait(false);
        }

        /// <inheritdoc />
        public async Task<CloudFlareResult<SecurityHeaderHsts>> ToggleSecurityHeaderHstsAsync(string zoneId, NewSecurityHeaderHsts newSecurityHeaderHsts, CancellationToken cancellationToken = default)
        {
            var requestUri = $"{SettingsEndpoints.Base}/{zoneId}/{SettingsEndpoints.Settings}/{SettingsEndpoints.SecurityHeaderHsts}";
            return await Connection.PatchAsync<SecurityHeaderHsts, NewSecurityHeaderHsts>(requestUri, newSecurityHeaderHsts, cancellationToken).ConfigureAwait(false);
        }

        /// <inheritdoc />
        public async Task<CloudFlareResult<AutomaticHttpsRewrites>> GetAutomaticHttpsRewritesAsync(string zoneId, CancellationToken cancellationToken = default)
        {
            var requestUri = $"{SettingsEndpoints.Base}/{zoneId}/{SettingsEndpoints.Settings}/{SettingsEndpoints.AutomaticHttpsRewrites}";
            return await Connection.GetAsync<AutomaticHttpsRewrites>(requestUri, cancellationToken).ConfigureAwait(false);
        }

        /// <inheritdoc />
        public async Task<CloudFlareResult<AutomaticHttpsRewrites>> ToggleAutomaticHttpsRewritesAsync(string zoneId, NewAutomaticHttpsRewrites newAutomaticHttpsRewrites, CancellationToken cancellationToken = default)
        {
            var requestUri = $"{SettingsEndpoints.Base}/{zoneId}/{SettingsEndpoints.Settings}/{SettingsEndpoints.AutomaticHttpsRewrites}";
            return await Connection.PatchAsync<AutomaticHttpsRewrites, NewAutomaticHttpsRewrites>(requestUri, newAutomaticHttpsRewrites, cancellationToken).ConfigureAwait(false);
        }

        /// <inheritdoc />
        public async Task<CloudFlareResult<CustomPurgeCache>> CustomPurgeCacheAsync(string zoneId, NewCustomPurgeCache customPurgeCache, CancellationToken cancellationToken = default)
        {
            var requestUri = $"{SettingsEndpoints.Base}/{zoneId}/{SettingsEndpoints.PurgeCache}";
            return await Connection.PostAsync<CustomPurgeCache, NewCustomPurgeCache>(requestUri, customPurgeCache, cancellationToken).ConfigureAwait(false);
        }

        /// <inheritdoc />
        public async Task<CloudFlareResult<MinimumTlsVersion>> GetMinimumTlsVersionAsync(string zoneId,
            CancellationToken cancellationToken = default)
        {
            var requestUri = $"{SettingsEndpoints.Base}/{zoneId}/{SettingsEndpoints.Settings}/{SettingsEndpoints.MinimumTlsVersion}";
            return await Connection.GetAsync<MinimumTlsVersion>(requestUri, cancellationToken).ConfigureAwait(false);
        }

        /// <inheritdoc />
        public async Task<CloudFlareResult<MinimumTlsVersion>> ToggleMinimumTlsVersionAsync(string zoneId, NewMinimumTlsVersion newMinimumTlsVersion, CancellationToken cancellationToken = default)
        {
            var requestUri = $"{SettingsEndpoints.Base}/{zoneId}/{SettingsEndpoints.Settings}/{SettingsEndpoints.MinimumTlsVersion}";
            return await Connection.PatchAsync<MinimumTlsVersion, NewMinimumTlsVersion>(requestUri, newMinimumTlsVersion, cancellationToken).ConfigureAwait(false);
        }

        /// <inheritdoc />
        public async Task<AllSettings> GetAllZoneSettingsAsync(string zoneId, CancellationToken cancellationToken = default)
        {
            var requestUri = $"{SettingsEndpoints.Base}/{zoneId}/{SettingsEndpoints.Settings}";
            var response = await Connection.GetAsync<JArray>(requestUri, cancellationToken).ConfigureAwait(false);
            return GetZoneSetting(response.Result.Cast<JObject>());
        }

        private static AllSettings GetZoneSetting(IEnumerable<JObject> jsons)
        {
            if (jsons == null)
                throw new ArgumentNullException(nameof(jsons));

            var allSettings = new AllSettings();

            foreach (JObject json in jsons)
            {
                JToken idToken = json["id"];
                if (idToken == null)
                {
                    throw new InvalidOperationException($"The setting does not have an id property.\n{json}");
                }

                string id = idToken.Value<string>();

                switch (id)
                {
                    case "always_online":
                        allSettings.AlwaysOnline = json.ToObject<AlwaysOnline>();
                        break;
                    case "always_use_https":
                        allSettings.AlwaysUseHttps = json.ToObject<AlwaysUseHttps>();
                        break;
                    case "automatic_https_rewrites":
                        allSettings.AutomaticHttpsRewrites = json.ToObject<AutomaticHttpsRewrites>();
                        break;
                    case "brotli":
                        allSettings.Brotli = json.ToObject<Brotli>();
                        break;
                    case "browser_check":
                        allSettings.BrowserCheck = json.ToObject<BrowserCheck>();
                        break;
                    case "email_obfuscation":
                        allSettings.EmailObfuscation = json.ToObject<EmailObfuscation>();
                        break;
                    case "hotlink_protection":
                        allSettings.HotlinkProtection = json.ToObject<HotlinkProtection>();
                        break;
                    case "ip_geolocation":
                        allSettings.IpGeolocation = json.ToObject<IpGeolocation>();
                        break;
                    case "mirage":
                        allSettings.Mirage = json.ToObject<Mirage>();
                        break;
                    case "browser_cache_ttl":
                        allSettings.BrowserCacheTtl = json.ToObject<BrowserCacheTtl>();
                        break;
                    case "cache_level":
                        allSettings.CacheLevel = json.ToObject<CacheLevel>();
                        break;
                    case "polish":
                        allSettings.Polish = json.ToObject<Polish>();
                        break;
                    case "rocket_loader":
                        allSettings.RocketLoader = json.ToObject<RocketLoader>();
                        break;
                    case "development_mode":
                        allSettings.DevelopmentMode = json.ToObject<DevelopmentMode>();
                        break;
                    case "minify":
                        allSettings.Minify = json.ToObject<Minify>();
                        break;
                    case "security_header":
                        allSettings.SecurityHeaderHsts = json.ToObject<SecurityHeaderHsts>();
                        break;
                    case "opportunistic_onion":
                        allSettings.OpportunisticOnion = json.ToObject<OpportunisticOnion>();
                        break;                    
                    case "min_tls_version":
                        allSettings.MinimumTlsVersion = json.ToObject<MinimumTlsVersion>();
                        break;
                    case "webp":
                        allSettings.WebP = json.ToObject<WebP>();
                        break;
                    case "opportunistic_encryption":
                        allSettings.OpportunisticEncryption = json.ToObject<OpportunisticEncryption>();
                        break;
                    case "early_hints":
                        allSettings.EarlyHints = json.ToObject<EarlyHints>();
                        break;
                    default:
                        break;
                }
            }

            return allSettings;
        }
    }
}