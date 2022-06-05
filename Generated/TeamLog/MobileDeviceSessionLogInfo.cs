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
    /// <para>Information about linked Dropbox mobile client sessions</para>
    /// </summary>
    /// <seealso cref="Global::Dropbox.Api.TeamLog.DeviceSessionLogInfo" />
    public class MobileDeviceSessionLogInfo : DeviceSessionLogInfo
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<MobileDeviceSessionLogInfo> Encoder = new MobileDeviceSessionLogInfoEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<MobileDeviceSessionLogInfo> Decoder = new MobileDeviceSessionLogInfoDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="MobileDeviceSessionLogInfo" />
        /// class.</para>
        /// </summary>
        /// <param name="deviceName">The device name.</param>
        /// <param name="clientType">The mobile application type.</param>
        /// <param name="ipAddress">The IP address of the last activity from this session.
        /// Might be missing due to historical data gap.</param>
        /// <param name="created">The time this session was created. Might be missing due to
        /// historical data gap.</param>
        /// <param name="updated">The time of the last activity from this session. Might be
        /// missing due to historical data gap.</param>
        /// <param name="sessionInfo">Mobile session unique id. Might be missing due to
        /// historical data gap.</param>
        /// <param name="clientVersion">The Dropbox client version.</param>
        /// <param name="osVersion">The hosting OS version.</param>
        /// <param name="lastCarrier">last carrier used by the device.</param>
        public MobileDeviceSessionLogInfo(string deviceName,
                                          global::Dropbox.Api.Team.MobileClientPlatform clientType,
                                          string ipAddress = null,
                                          sys.DateTime? created = null,
                                          sys.DateTime? updated = null,
                                          MobileSessionLogInfo sessionInfo = null,
                                          string clientVersion = null,
                                          string osVersion = null,
                                          string lastCarrier = null)
            : base(ipAddress, created, updated)
        {
            if (deviceName == null)
            {
                throw new sys.ArgumentNullException("deviceName");
            }

            if (clientType == null)
            {
                throw new sys.ArgumentNullException("clientType");
            }

            this.DeviceName = deviceName;
            this.ClientType = clientType;
            this.SessionInfo = sessionInfo;
            this.ClientVersion = clientVersion;
            this.OsVersion = osVersion;
            this.LastCarrier = lastCarrier;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="MobileDeviceSessionLogInfo" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public MobileDeviceSessionLogInfo()
        {
        }

        /// <summary>
        /// <para>The device name.</para>
        /// </summary>
        public string DeviceName { get; protected set; }

        /// <summary>
        /// <para>The mobile application type.</para>
        /// </summary>
        public global::Dropbox.Api.Team.MobileClientPlatform ClientType { get; protected set; }

        /// <summary>
        /// <para>Mobile session unique id. Might be missing due to historical data gap.</para>
        /// </summary>
        public MobileSessionLogInfo SessionInfo { get; protected set; }

        /// <summary>
        /// <para>The Dropbox client version.</para>
        /// </summary>
        public string ClientVersion { get; protected set; }

        /// <summary>
        /// <para>The hosting OS version.</para>
        /// </summary>
        public string OsVersion { get; protected set; }

        /// <summary>
        /// <para>last carrier used by the device.</para>
        /// </summary>
        public string LastCarrier { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="MobileDeviceSessionLogInfo" />.</para>
        /// </summary>
        private class MobileDeviceSessionLogInfoEncoder : enc.StructEncoder<MobileDeviceSessionLogInfo>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(MobileDeviceSessionLogInfo value, enc.IJsonWriter writer)
            {
                WriteProperty("device_name", value.DeviceName, writer, enc.StringEncoder.Instance);
                WriteProperty("client_type", value.ClientType, writer, global::Dropbox.Api.Team.MobileClientPlatform.Encoder);
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
                    WriteProperty("session_info", value.SessionInfo, writer, global::Dropbox.Api.TeamLog.MobileSessionLogInfo.Encoder);
                }
                if (value.ClientVersion != null)
                {
                    WriteProperty("client_version", value.ClientVersion, writer, enc.StringEncoder.Instance);
                }
                if (value.OsVersion != null)
                {
                    WriteProperty("os_version", value.OsVersion, writer, enc.StringEncoder.Instance);
                }
                if (value.LastCarrier != null)
                {
                    WriteProperty("last_carrier", value.LastCarrier, writer, enc.StringEncoder.Instance);
                }
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="MobileDeviceSessionLogInfo" />.</para>
        /// </summary>
        private class MobileDeviceSessionLogInfoDecoder : enc.StructDecoder<MobileDeviceSessionLogInfo>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="MobileDeviceSessionLogInfo"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override MobileDeviceSessionLogInfo Create()
            {
                return new MobileDeviceSessionLogInfo();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(MobileDeviceSessionLogInfo value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "device_name":
                        value.DeviceName = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "client_type":
                        value.ClientType = global::Dropbox.Api.Team.MobileClientPlatform.Decoder.Decode(reader);
                        break;
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
                        value.SessionInfo = global::Dropbox.Api.TeamLog.MobileSessionLogInfo.Decoder.Decode(reader);
                        break;
                    case "client_version":
                        value.ClientVersion = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "os_version":
                        value.OsVersion = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "last_carrier":
                        value.LastCarrier = enc.StringDecoder.Instance.Decode(reader);
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
