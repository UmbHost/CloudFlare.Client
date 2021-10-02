﻿using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using CloudFlare.Client.Api.Display;
using CloudFlare.Client.Api.Parameters;
using CloudFlare.Client.Api.Parameters.Endpoints;
using CloudFlare.Client.Api.Result;
using CloudFlare.Client.Api.Zones;
using CloudFlare.Client.Api.Zones.Settings;
using CloudFlare.Client.Contexts;
using CloudFlare.Client.Helpers;

namespace CloudFlare.Client.Client.Zones
{
    public class Zones : ApiContextBase<IConnection>, IZones
    {
        public ICustomHostnames CustomHostnames { get; }
        public IDnsRecords DnsRecords { get; }

        public Zones(IConnection connection) : base(connection)
        {
            CustomHostnames = new CustomHostnames(connection);
            DnsRecords = new DnsRecords(connection);
        }

        /// <inheritdoc />
        public async Task<CloudFlareResult<Zone>> AddAsync(NewZone newZone, CancellationToken cancellationToken = default)
        {
            var requestUri = $"{ZoneEndpoints.Base}";
            return await Connection.PostAsync<Zone, NewZone>(requestUri, newZone, cancellationToken).ConfigureAwait(false);
        }

        /// <inheritdoc />
        public async Task<CloudFlareResult<Zone>> CheckActivationAsync(string zoneId, CancellationToken cancellationToken = default)
        {
            var requestUri = $"{ZoneEndpoints.Base}/{zoneId}/{ZoneEndpoints.ActivationCheck}";
            return await Connection.PutAsync<Zone, object>(requestUri, string.Empty, cancellationToken).ConfigureAwait(false);
        }

        /// <inheritdoc />
        public async Task<CloudFlareResult<Zone>> DeleteAsync(string zoneId, CancellationToken cancellationToken = default)
        {
            var requestUri = $"{ZoneEndpoints.Base}/{zoneId}";
            return await Connection.DeleteAsync<Zone>(requestUri, cancellationToken).ConfigureAwait(false);
        }

        /// <inheritdoc />
        public async Task<CloudFlareResult<IReadOnlyList<Zone>>> GetAsync(ZoneFilter filter = null, DisplayOptions displayOptions = null, CancellationToken cancellationToken = default)
        {
            var builder = new ParameterBuilderHelper()
                .InsertValue(Filtering.AccountId, filter?.AccountId)
                .InsertValue(Filtering.AccountName, filter?.AccountName)
                .InsertValue(Filtering.Name, filter?.Name)
                .InsertValue(Filtering.Status, filter?.Status)
                .InsertValue(Filtering.Match, filter?.Match)
                .InsertValue(Filtering.Page, displayOptions?.Page)
                .InsertValue(Filtering.PerPage, displayOptions?.PerPage)
                .InsertValue(Filtering.Order, displayOptions?.Order);

            var requestUri = $"{ZoneEndpoints.Base}";
            if (builder.ParameterCollection.HasKeys())
            {
                requestUri = $"{requestUri}/?{builder.ParameterCollection}";
            }

            return await Connection.GetAsync<IReadOnlyList<Zone>>(requestUri, cancellationToken).ConfigureAwait(false);
        }

        /// <inheritdoc />
        public async Task<CloudFlareResult<Zone>> GetDetailsAsync(string zoneId, CancellationToken cancellationToken = default)
        {
            var requestUri = $"{ZoneEndpoints.Base}/{zoneId}";
            return await Connection.GetAsync<Zone>(requestUri, cancellationToken).ConfigureAwait(false);
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

        /// <inheritdoc />
        public async Task<CloudFlareResult<Zone>> PurgeAllFilesAsync(string zoneId, bool purgeEverything, CancellationToken cancellationToken = default)
        {
            var content = new Dictionary<string, bool> { { Outgoing.PurgeEverything, purgeEverything } };

            var requestUri = $"{ZoneEndpoints.Base}/{zoneId}/{ZoneEndpoints.PurgeCache}";
            return await Connection.PostAsync<Zone, Dictionary<string, bool>>(requestUri, content, cancellationToken).ConfigureAwait(false);
        }

        /// <inheritdoc />
        public async Task<CloudFlareResult<Zone>> UpdateAsync(string zoneId, ModifiedZone modifiedZone, CancellationToken cancellationToken = default)
        {
            var requestUri = $"{ZoneEndpoints.Base}/{zoneId}";
            return await Connection.PatchAsync<Zone, ModifiedZone>(requestUri, modifiedZone, cancellationToken).ConfigureAwait(false);
        }
    }
}