// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.TeamLog
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>Information on sessions, in legacy format</para>
    /// </summary>
    /// <seealso cref="Global::Dropbox.Api.TeamLog.DeviceSessionLogInfo" />
    public class LegacyDeviceSessionLogInfo : DeviceSessionLogInfo
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<LegacyDeviceSessionLogInfo> Encoder = new LegacyDeviceSessionLogInfoEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<LegacyDeviceSessionLogInfo> Decoder = new LegacyDeviceSessionLogInfoDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="LegacyDeviceSessionLogInfo" />
        /// class.</para>
        /// </summary>
        /// <param name="ipAddress">The IP address of the last activity from this session.
        /// Might be missing due to historical data gap.</param>
        /// <param name="created">The time this session was created. Might be missing due to
        /// historical data gap.</param>
        /// <param name="updated">The time of the last activity from this session. Might be
        /// missing due to historical data gap.</param>
        /// <param name="sessionInfo">Session unique id. Might be missing due to historical
        /// data gap.</param>
        /// <param name="displayName">The device name. Might be missing due to historical data
        /// gap.</param>
        /// <param name="isEmmManaged">Is device managed by emm. Might be missing due to
        /// historical data gap.</param>
        /// <param name="platform">Information on the hosting platform. Might be missing due to
        /// historical data gap.</param>
        /// <param name="macAddress">The mac address of the last activity from this session.
        /// Might be missing due to historical data gap.</param>
        /// <param name="osVersion">The hosting OS version. Might be missing due to historical
        /// data gap.</param>
        /// <param name="deviceType">Information on the hosting device type. Might be missing
        /// due to historical data gap.</param>
        /// <param name="clientVersion">The Dropbox client version. Might be missing due to
        /// historical data gap.</param>
        /// <param name="legacyUniqId">Alternative unique device session id, instead of session
        /// id field. Might be missing due to historical data gap.</param>
        public LegacyDeviceSessionLogInfo(string ipAddress = null,
                                          sys.DateTime? created = null,
                                          sys.DateTime? updated = null,
                                          SessionLogInfo sessionInfo = null,
                                          string displayName = null,
                                          bool? isEmmManaged = null,
                                          string platform = null,
                                          string macAddress = null,
                                          string osVersion = null,
                                          string deviceType = null,
                                          string clientVersion = null,
                                          string legacyUniqId = null)
            : base(ipAddress, created, updated)
        {
            this.SessionInfo = sessionInfo;
            this.DisplayName = displayName;
            this.IsEmmManaged = isEmmManaged;
            this.Platform = platform;
            this.MacAddress = macAddress;
            this.OsVersion = osVersion;
            this.DeviceType = deviceType;
            this.ClientVersion = clientVersion;
            this.LegacyUniqId = legacyUniqId;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="LegacyDeviceSessionLogInfo" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public LegacyDeviceSessionLogInfo()
        {
        }

        /// <summary>
        /// <para>Session unique id. Might be missing due to historical data gap.</para>
        /// </summary>
        public SessionLogInfo SessionInfo { get; protected set; }

        /// <summary>
        /// <para>The device name. Might be missing due to historical data gap.</para>
        /// </summary>
        public string DisplayName { get; protected set; }

        /// <summary>
        /// <para>Is device managed by emm. Might be missing due to historical data gap.</para>
        /// </summary>
        public bool? IsEmmManaged { get; protected set; }

        /// <summary>
        /// <para>Information on the hosting platform. Might be missing due to historical data
        /// gap.</para>
        /// </summary>
        public string Platform { get; protected set; }

        /// <summary>
        /// <para>The mac address of the last activity from this session. Might be missing due
        /// to historical data gap.</para>
        /// </summary>
        public string MacAddress { get; protected set; }

        /// <summary>
        /// <para>The hosting OS version. Might be missing due to historical data gap.</para>
        /// </summary>
        public string OsVersion { get; protected set; }

        /// <summary>
        /// <para>Information on the hosting device type. Might be missing due to historical
        /// data gap.</para>
        /// </summary>
        public string DeviceType { get; protected set; }

        /// <summary>
        /// <para>The Dropbox client version. Might be missing due to historical data
        /// gap.</para>
        /// </summary>
        public string ClientVersion { get; protected set; }

        /// <summary>
        /// <para>Alternative unique device session id, instead of session id field. Might be
        /// missing due to historical data gap.</para>
        /// </summary>
        public string LegacyUniqId { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="LegacyDeviceSessionLogInfo" />.</para>
        /// </summary>
        private class LegacyDeviceSessionLogInfoEncoder : enc.StructEncoder<LegacyDeviceSessionLogInfo>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(LegacyDeviceSessionLogInfo value, enc.IJsonWriter writer)
            {
                if (value.IpAddress != null)
                {
                    WriteProperty("ip_address", value.IpAddress, writer, enc.StringEncoder.Instance);
                }
                if (value.Created != null)
                {
                    WriteProperty("created", value.Created.Value, writer, enc.DateTimeEncoder.Instance);
                }
                if (value.Updated != null)
                {
                    WriteProperty("updated", value.Updated.Value, writer, enc.DateTimeEncoder.Instance);
                }
                if (value.SessionInfo != null)
                {
                    WriteProperty("session_info", value.SessionInfo, writer, global::Dropbox.Api.TeamLog.SessionLogInfo.Encoder);
                }
                if (value.DisplayName != null)
                {
                    WriteProperty("display_name", value.DisplayName, writer, enc.StringEncoder.Instance);
                }
                if (value.IsEmmManaged != null)
                {
                    WriteProperty("is_emm_managed", value.IsEmmManaged.Value, writer, enc.BooleanEncoder.Instance);
                }
                if (value.Platform != null)
                {
                    WriteProperty("platform", value.Platform, writer, enc.StringEncoder.Instance);
                }
                if (value.MacAddress != null)
                {
                    WriteProperty("mac_address", value.MacAddress, writer, enc.StringEncoder.Instance);
                }
                if (value.OsVersion != null)
                {
                    WriteProperty("os_version", value.OsVersion, writer, enc.StringEncoder.Instance);
                }
                if (value.DeviceType != null)
                {
                    WriteProperty("device_type", value.DeviceType, writer, enc.StringEncoder.Instance);
                }
                if (value.ClientVersion != null)
                {
                    WriteProperty("client_version", value.ClientVersion, writer, enc.StringEncoder.Instance);
                }
                if (value.LegacyUniqId != null)
                {
                    WriteProperty("legacy_uniq_id", value.LegacyUniqId, writer, enc.StringEncoder.Instance);
                }
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="LegacyDeviceSessionLogInfo" />.</para>
        /// </summary>
        private class LegacyDeviceSessionLogInfoDecoder : enc.StructDecoder<LegacyDeviceSessionLogInfo>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="LegacyDeviceSessionLogInfo"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override LegacyDeviceSessionLogInfo Create()
            {
                return new LegacyDeviceSessionLogInfo();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(LegacyDeviceSessionLogInfo value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "ip_address":
                        value.IpAddress = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "created":
                        value.Created = enc.DateTimeDecoder.Instance.Decode(reader);
                        break;
                    case "updated":
                        value.Updated = enc.DateTimeDecoder.Instance.Decode(reader);
                        break;
                    case "session_info":
                        value.SessionInfo = global::Dropbox.Api.TeamLog.SessionLogInfo.Decoder.Decode(reader);
                        break;
                    case "display_name":
                        value.DisplayName = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "is_emm_managed":
                        value.IsEmmManaged = enc.BooleanDecoder.Instance.Decode(reader);
                        break;
                    case "platform":
                        value.Platform = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "mac_address":
                        value.MacAddress = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "os_version":
                        value.OsVersion = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "device_type":
                        value.DeviceType = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "client_version":
                        value.ClientVersion = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "legacy_uniq_id":
                        value.LegacyUniqId = enc.StringDecoder.Instance.Decode(reader);
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
