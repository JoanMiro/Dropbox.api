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
    /// <para>Enabled/disabled network control.</para>
    /// </summary>
    public class NetworkControlChangePolicyDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<NetworkControlChangePolicyDetails> Encoder = new NetworkControlChangePolicyDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<NetworkControlChangePolicyDetails> Decoder = new NetworkControlChangePolicyDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see
        /// cref="NetworkControlChangePolicyDetails" /> class.</para>
        /// </summary>
        /// <param name="newValue">New network control policy.</param>
        /// <param name="previousValue">Previous network control policy. Might be missing due
        /// to historical data gap.</param>
        public NetworkControlChangePolicyDetails(NetworkControlPolicy newValue,
                                                 NetworkControlPolicy previousValue = null)
        {
            if (newValue == null)
            {
                throw new sys.ArgumentNullException("newValue");
            }

            this.NewValue = newValue;
            this.PreviousValue = previousValue;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see
        /// cref="NetworkControlChangePolicyDetails" /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public NetworkControlChangePolicyDetails()
        {
        }

        /// <summary>
        /// <para>New network control policy.</para>
        /// </summary>
        public NetworkControlPolicy NewValue { get; protected set; }

        /// <summary>
        /// <para>Previous network control policy. Might be missing due to historical data
        /// gap.</para>
        /// </summary>
        public NetworkControlPolicy PreviousValue { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="NetworkControlChangePolicyDetails" />.</para>
        /// </summary>
        private class NetworkControlChangePolicyDetailsEncoder : enc.StructEncoder<NetworkControlChangePolicyDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(NetworkControlChangePolicyDetails value, enc.IJsonWriter writer)
            {
                WriteProperty("new_value", value.NewValue, writer, global::Dropbox.Api.TeamLog.NetworkControlPolicy.Encoder);
                if (value.PreviousValue != null)
                {
                    WriteProperty("previous_value", value.PreviousValue, writer, global::Dropbox.Api.TeamLog.NetworkControlPolicy.Encoder);
                }
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="NetworkControlChangePolicyDetails" />.</para>
        /// </summary>
        private class NetworkControlChangePolicyDetailsDecoder : enc.StructDecoder<NetworkControlChangePolicyDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see
            /// cref="NetworkControlChangePolicyDetails" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override NetworkControlChangePolicyDetails Create()
            {
                return new NetworkControlChangePolicyDetails();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(NetworkControlChangePolicyDetails value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "new_value":
                        value.NewValue = global::Dropbox.Api.TeamLog.NetworkControlPolicy.Decoder.Decode(reader);
                        break;
                    case "previous_value":
                        value.PreviousValue = global::Dropbox.Api.TeamLog.NetworkControlPolicy.Decoder.Decode(reader);
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
