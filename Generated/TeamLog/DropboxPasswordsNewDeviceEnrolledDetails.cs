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
    /// <para>Enrolled new Dropbox Passwords device.</para>
    /// </summary>
    public class DropboxPasswordsNewDeviceEnrolledDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<DropboxPasswordsNewDeviceEnrolledDetails> Encoder = new DropboxPasswordsNewDeviceEnrolledDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<DropboxPasswordsNewDeviceEnrolledDetails> Decoder = new DropboxPasswordsNewDeviceEnrolledDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see
        /// cref="DropboxPasswordsNewDeviceEnrolledDetails" /> class.</para>
        /// </summary>
        /// <param name="isFirstDevice">Whether it's a first device enrolled.</param>
        /// <param name="platform">The platform the device is enrolled.</param>
        public DropboxPasswordsNewDeviceEnrolledDetails(bool isFirstDevice,
                                                        string platform)
        {
            if (platform == null)
            {
                throw new sys.ArgumentNullException("platform");
            }

            this.IsFirstDevice = isFirstDevice;
            this.Platform = platform;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see
        /// cref="DropboxPasswordsNewDeviceEnrolledDetails" /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public DropboxPasswordsNewDeviceEnrolledDetails()
        {
        }

        /// <summary>
        /// <para>Whether it's a first device enrolled.</para>
        /// </summary>
        public bool IsFirstDevice { get; protected set; }

        /// <summary>
        /// <para>The platform the device is enrolled.</para>
        /// </summary>
        public string Platform { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="DropboxPasswordsNewDeviceEnrolledDetails" />.</para>
        /// </summary>
        private class DropboxPasswordsNewDeviceEnrolledDetailsEncoder : enc.StructEncoder<DropboxPasswordsNewDeviceEnrolledDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(DropboxPasswordsNewDeviceEnrolledDetails value, enc.IJsonWriter writer)
            {
                WriteProperty("is_first_device", value.IsFirstDevice, writer, enc.BooleanEncoder.Instance);
                WriteProperty("platform", value.Platform, writer, enc.StringEncoder.Instance);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="DropboxPasswordsNewDeviceEnrolledDetails" />.</para>
        /// </summary>
        private class DropboxPasswordsNewDeviceEnrolledDetailsDecoder : enc.StructDecoder<DropboxPasswordsNewDeviceEnrolledDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see
            /// cref="DropboxPasswordsNewDeviceEnrolledDetails" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override DropboxPasswordsNewDeviceEnrolledDetails Create()
            {
                return new DropboxPasswordsNewDeviceEnrolledDetails();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(DropboxPasswordsNewDeviceEnrolledDetails value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "is_first_device":
                        value.IsFirstDevice = enc.BooleanDecoder.Instance.Decode(reader);
                        break;
                    case "platform":
                        value.Platform = enc.StringDecoder.Instance.Decode(reader);
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
