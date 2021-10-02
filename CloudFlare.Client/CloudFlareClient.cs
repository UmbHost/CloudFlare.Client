﻿using System;
using CloudFlare.Client.Api.Authentication;
using CloudFlare.Client.Client.Accounts;
using CloudFlare.Client.Client.Users;
using CloudFlare.Client.Client.Zones;
using CloudFlare.Client.Contexts;

namespace CloudFlare.Client
{
    public class CloudFlareClient : ICloudFlareClient
    {
        protected bool IsDisposed { get; private set; }

        public IAccounts Accounts { get; }
        public IUsers Users { get; }
        public IZones Zones { get; }
        public ISettings Settings { get; }

        private readonly IConnection _connection;

        /// <summary>
        /// Initialize CloudFlare Client
        /// </summary>
        /// <param name="authentication">Authentication which can be ApiKey and Token based</param>
        /// <param name="connectionInfo">Connection info</param>
        public CloudFlareClient(IAuthentication authentication, ConnectionInfo connectionInfo = null)
        {
            IsDisposed = false;

            _connection = new ApiConnection(authentication, connectionInfo ?? new ConnectionInfo());

            Accounts = new Accounts(_connection);
            Users = new Users(_connection);
            Zones = new Zones(_connection);
            Settings = new Settings(_connection);
        }

        /// <summary>
        /// Initialize CloudFlare Client
        /// </summary>
        /// <param name="emailAddress">Email address</param>
        /// <param name="apiKey">CloudFlare API Key</param>
        /// <param name="connectionInfo">Connection info</param>
        public CloudFlareClient(string emailAddress, string apiKey, ConnectionInfo connectionInfo = null) : this(new ApiKeyAuthentication(emailAddress, apiKey), connectionInfo) { }

        /// <summary>
        /// Initialize CloudFlare Client
        /// </summary>
        /// <param name="apiToken">Authentication with api token</param>
        /// <param name="connectionInfo">Connection info</param>
        public CloudFlareClient(string apiToken, ConnectionInfo connectionInfo = null) : this(new ApiTokenAuthentication(apiToken), connectionInfo) { }

        /// <summary>
        /// Destruct CloudFlare Client
        /// </summary>
        ~CloudFlareClient()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {

            if (IsDisposed)
            {
                return;
            }

            if (disposing)
            {
                _connection?.Dispose();
            }

            IsDisposed = true;
        }
    }
}
