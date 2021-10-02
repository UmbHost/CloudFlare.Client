using System.Threading;
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
            var requestUri = $"{SettingsEndpoints.Base}/{zoneId}/{SettingsEndpoints.DevelopmentMode}";
            return await Connection.PatchAsync<DevelopmentMode, NewDevelopmentMode>(requestUri, newDevelopmentModeSetting, cancellationToken).ConfigureAwait(false);
        }

        /// <inheritdoc />
        public async Task<CloudFlareResult<AlwaysOnline>> GetAlwaysOnlineSettingAsync(string zoneId, CancellationToken cancellationToken = default)
        {
            var requestUri = $"{SettingsEndpoints.Base}/{zoneId}/{SettingsEndpoints.Settings}/{SettingsEndpoints.AlwaysOnline}";
            return await Connection.GetAsync<AlwaysOnline>(requestUri, cancellationToken).ConfigureAwait(false);
        }
    }
}