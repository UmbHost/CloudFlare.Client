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
        public async Task<CloudFlareResult<DevelopmentModeSetting>> GetDevelopmentModeSettingAsync(string zoneId, CancellationToken cancellationToken = default)
        {
            var requestUri = $"{ZoneEndpoints.Base}/{zoneId}/{ZoneEndpoints.Settings}/{ZoneEndpoints.DevelopmentMode}";
            return await Connection.GetAsync<DevelopmentModeSetting>(requestUri, cancellationToken).ConfigureAwait(false);
        }

        /// <inheritdoc />
        public async Task<CloudFlareResult<DevelopmentModeSetting>> ToggleDevelopmentModeSettingAsync(string zoneId, NewDevelopmentModeSetting newDevelopmentModeSetting, CancellationToken cancellationToken = default)
        {
            var requestUri = $"{ZoneEndpoints.Base}/{zoneId}/{ZoneEndpoints.DevelopmentMode}";
            return await Connection.PatchAsync<DevelopmentModeSetting, NewDevelopmentModeSetting>(requestUri, newDevelopmentModeSetting, cancellationToken).ConfigureAwait(false);
        }
    }
}