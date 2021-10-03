﻿using System.Threading;
using System.Threading.Tasks;
using CloudFlare.Client.Api.Parameters.Endpoints;
using CloudFlare.Client.Api.Result;
using CloudFlare.Client.Api.Zones.Settings;
using CloudFlare.Client.Contexts;

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
            var requestUri = $"{SettingsEndpoints.Base}/{zoneId}/{SettingsEndpoints.Settings}/{SettingsEndpoints.Settings}/{SettingsEndpoints.Minify}";
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
    }
}