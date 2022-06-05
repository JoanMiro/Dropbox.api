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
    /// <para>Set/removed limit on number of mobile devices member can link to team Dropbox
    /// account.</para>
    /// </summary>
    public class DeviceApprovalsChangeMobilePolicyDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<DeviceApprovalsChangeMobilePolicyDetails> Encoder = new DeviceApprovalsChangeMobilePolicyDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<DeviceApprovalsChangeMobilePolicyDetails> Decoder = new DeviceApprovalsChangeMobilePolicyDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see
        /// cref="DeviceApprovalsChangeMobilePolicyDetails" /> class.</para>
        /// </summary>
        /// <param name="newValue">New mobile device approvals policy. Might be missing due to
        /// historical data gap.</param>
        /// <param name="previousValue">Previous mobile device approvals policy. Might be
        /// missing due to historical data gap.</param>
        public DeviceApprovalsChangeMobilePolicyDetails(DeviceApprovalsPolicy newValue = null,
                                                        DeviceApprovalsPolicy previousValue = null)
        {
            this.NewValue = newValue;
            this.PreviousValue = previousValue;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see
        /// cref="DeviceApprovalsChangeMobilePolicyDetails" /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public DeviceApprovalsChangeMobilePolicyDetails()
        {
        }

        /// <summary>
        /// <para>New mobile device approvals policy. Might be missing due to historical data
        /// gap.</para>
        /// </summary>
        public DeviceApprovalsPolicy NewValue { get; protected set; }

        /// <summary>
        /// <para>Previous mobile device approvals policy. Might be missing due to historical
        /// data gap.</para>
        /// </summary>
        public DeviceApprovalsPolicy PreviousValue { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="DeviceApprovalsChangeMobilePolicyDetails" />.</para>
        /// </summary>
        private class DeviceApprovalsChangeMobilePolicyDetailsEncoder : enc.StructEncoder<DeviceApprovalsChangeMobilePolicyDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(DeviceApprovalsChangeMobilePolicyDetails value, enc.IJsonWriter writer)
            {
                if (value.NewValue != null)
                {
                    WriteProperty("new_value", value.NewValue, writer, global::Dropbox.Api.TeamLog.DeviceApprovalsPolicy.Encoder);
                }
                if (value.PreviousValue != null)
                {
                    WriteProperty("previous_value", value.PreviousValue, writer, global::Dropbox.Api.TeamLog.DeviceApprovalsPolicy.Encoder);
                }
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="DeviceApprovalsChangeMobilePolicyDetails" />.</para>
        /// </summary>
        private class DeviceApprovalsChangeMobilePolicyDetailsDecoder : enc.StructDecoder<DeviceApprovalsChangeMobilePolicyDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see
            /// cref="DeviceApprovalsChangeMobilePolicyDetails" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override DeviceApprovalsChangeMobilePolicyDetails Create()
            {
                return new DeviceApprovalsChangeMobilePolicyDetails();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(DeviceApprovalsChangeMobilePolicyDetails value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "new_value":
                        value.NewValue = global::Dropbox.Api.TeamLog.DeviceApprovalsPolicy.Decoder.Decode(reader);
                        break;
                    case "previous_value":
                        value.PreviousValue = global::Dropbox.Api.TeamLog.DeviceApprovalsPolicy.Decoder.Decode(reader);
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
