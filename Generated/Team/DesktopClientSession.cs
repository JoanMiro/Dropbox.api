// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Team
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>Information about linked Dropbox desktop client sessions.</para>
    /// </summary>
    /// <seealso cref="Global::Dropbox.Api.Team.DeviceSession" />
    public class DesktopClientSession : DeviceSession
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<DesktopClientSession> Encoder = new DesktopClientSessionEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<DesktopClientSession> Decoder = new DesktopClientSessionDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="DesktopClientSession" />
        /// class.</para>
        /// </summary>
        /// <param name="sessionId">The session id.</param>
        /// <param name="hostName">Name of the hosting desktop.</param>
        /// <param name="clientType">The Dropbox desktop client type.</param>
        /// <param name="clientVersion">The Dropbox client version.</param>
        /// <param name="platform">Information on the hosting platform.</param>
        /// <param name="isDeleteOnUnlinkSupported">Whether it's possible to delete all of the
        /// account files upon unlinking.</param>
        /// <param name="ipAddress">The IP address of the last activity from this
        /// session.</param>
        /// <param name="country">The country from which the last activity from this session
        /// was made.</param>
        /// <param name="created">The time this session was created.</param>
        /// <param name="updated">The time of the last activity from this session.</param>
        public DesktopClientSession(string sessionId,
                                    string hostName,
                                    DesktopPlatform clientType,
                                    string clientVersion,
                                    string platform,
                                    bool isDeleteOnUnlinkSupported,
                                    string ipAddress = null,
                                    string country = null,
                                    sys.DateTime? created = null,
                                    sys.DateTime? updated = null)
            : base(sessionId, ipAddress, country, created, updated)
        {
            if (hostName == null)
            {
                throw new sys.ArgumentNullException("hostName");
            }

            if (clientType == null)
            {
                throw new sys.ArgumentNullException("clientType");
            }

            if (clientVersion == null)
            {
                throw new sys.ArgumentNullException("clientVersion");
            }

            if (platform == null)
            {
                throw new sys.ArgumentNullException("platform");
            }

            this.HostName = hostName;
            this.ClientType = clientType;
            this.ClientVersion = clientVersion;
            this.Platform = platform;
            this.IsDeleteOnUnlinkSupported = isDeleteOnUnlinkSupported;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="DesktopClientSession" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public DesktopClientSession()
        {
        }

        /// <summary>
        /// <para>Name of the hosting desktop.</para>
        /// </summary>
        public string HostName { get; protected set; }

        /// <summary>
        /// <para>The Dropbox desktop client type.</para>
        /// </summary>
        public DesktopPlatform ClientType { get; protected set; }

        /// <summary>
        /// <para>The Dropbox client version.</para>
        /// </summary>
        public string ClientVersion { get; protected set; }

        /// <summary>
        /// <para>Information on the hosting platform.</para>
        /// </summary>
        public string Platform { get; protected set; }

        /// <summary>
        /// <para>Whether it's possible to delete all of the account files upon
        /// unlinking.</para>
        /// </summary>
        public bool IsDeleteOnUnlinkSupported { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="DesktopClientSession" />.</para>
        /// </summary>
        private class DesktopClientSessionEncoder : enc.StructEncoder<DesktopClientSession>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(DesktopClientSession value, enc.IJsonWriter writer)
            {
                WriteProperty("session_id", value.SessionId, writer, enc.StringEncoder.Instance);
                WriteProperty("host_name", value.HostName, writer, enc.StringEncoder.Instance);
                WriteProperty("client_type", value.ClientType, writer, global::Dropbox.Api.Team.DesktopPlatform.Encoder);
                WriteProperty("client_version", value.ClientVersion, writer, enc.StringEncoder.Instance);
                WriteProperty("platform", value.Platform, writer, enc.StringEncoder.Instance);
                WriteProperty("is_delete_on_unlink_supported", value.IsDeleteOnUnlinkSupported, writer, enc.BooleanEncoder.Instance);
                if (value.IpAddress != null)
                {
                    WriteProperty("ip_address", value.IpAddress, writer, enc.StringEncoder.Instance);
                }
                if (value.Country != null)
                {
                    WriteProperty("country", value.Country, writer, enc.StringEncoder.Instance);
                }
                if (value.Created != null)
                {
                    WriteProperty("created", value.Created.Value, writer, enc.DateTimeEncoder.Instance);
                }
                if (value.Updated != null)
                {
                    WriteProperty("updated", value.Updated.Value, writer, enc.DateTimeEncoder.Instance);
                }
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="DesktopClientSession" />.</para>
        /// </summary>
        private class DesktopClientSessionDecoder : enc.StructDecoder<DesktopClientSession>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="DesktopClientSession" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override DesktopClientSession Create()
            {
                return new DesktopClientSession();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(DesktopClientSession value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "session_id":
                        value.SessionId = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "host_name":
                        value.HostName = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "client_type":
                        value.ClientType = global::Dropbox.Api.Team.DesktopPlatform.Decoder.Decode(reader);
                        break;
                    case "client_version":
                        value.ClientVersion = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "platform":
                        value.Platform = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "is_delete_on_unlink_supported":
                        value.IsDeleteOnUnlinkSupported = enc.BooleanDecoder.Instance.Decode(reader);
                        break;
                    case "ip_address":
                        value.IpAddress = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "country":
                        value.Country = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "created":
                        value.Created = enc.DateTimeDecoder.Instance.Decode(reader);
                        break;
                    case "updated":
                        value.Updated = enc.DateTimeDecoder.Instance.Decode(reader);
                        break;
                    default:
                        reader.Skip();
                        break;
                }
            }
        }

        #endregion
    }
}
