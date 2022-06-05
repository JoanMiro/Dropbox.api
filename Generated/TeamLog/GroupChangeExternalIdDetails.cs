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
    /// <para>Changed external ID for group.</para>
    /// </summary>
    public class GroupChangeExternalIdDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<GroupChangeExternalIdDetails> Encoder = new GroupChangeExternalIdDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<GroupChangeExternalIdDetails> Decoder = new GroupChangeExternalIdDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="GroupChangeExternalIdDetails" />
        /// class.</para>
        /// </summary>
        /// <param name="newValue">Current external id.</param>
        /// <param name="previousValue">Old external id.</param>
        public GroupChangeExternalIdDetails(string newValue,
                                            string previousValue)
        {
            if (newValue == null)
            {
                throw new sys.ArgumentNullException("newValue");
            }

            if (previousValue == null)
            {
                throw new sys.ArgumentNullException("previousValue");
            }

            this.NewValue = newValue;
            this.PreviousValue = previousValue;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="GroupChangeExternalIdDetails" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public GroupChangeExternalIdDetails()
        {
        }

        /// <summary>
        /// <para>Current external id.</para>
        /// </summary>
        public string NewValue { get; protected set; }

        /// <summary>
        /// <para>Old external id.</para>
        /// </summary>
        public string PreviousValue { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="GroupChangeExternalIdDetails" />.</para>
        /// </summary>
        private class GroupChangeExternalIdDetailsEncoder : enc.StructEncoder<GroupChangeExternalIdDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(GroupChangeExternalIdDetails value, enc.IJsonWriter writer)
            {
                WriteProperty("new_value", value.NewValue, writer, enc.StringEncoder.Instance);
                WriteProperty("previous_value", value.PreviousValue, writer, enc.StringEncoder.Instance);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="GroupChangeExternalIdDetails" />.</para>
        /// </summary>
        private class GroupChangeExternalIdDetailsDecoder : enc.StructDecoder<GroupChangeExternalIdDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="GroupChangeExternalIdDetails"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override GroupChangeExternalIdDetails Create()
            {
                return new GroupChangeExternalIdDetails();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(GroupChangeExternalIdDetails value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "new_value":
                        value.NewValue = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "previous_value":
                        value.PreviousValue = enc.StringDecoder.Instance.Decode(reader);
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
