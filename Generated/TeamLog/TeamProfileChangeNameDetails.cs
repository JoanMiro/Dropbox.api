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
    /// <para>Changed team name.</para>
    /// </summary>
    public class TeamProfileChangeNameDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<TeamProfileChangeNameDetails> Encoder = new TeamProfileChangeNameDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<TeamProfileChangeNameDetails> Decoder = new TeamProfileChangeNameDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="TeamProfileChangeNameDetails" />
        /// class.</para>
        /// </summary>
        /// <param name="newValue">New team name.</param>
        /// <param name="previousValue">Previous teams name. Might be missing due to historical
        /// data gap.</param>
        public TeamProfileChangeNameDetails(TeamName newValue,
                                            TeamName previousValue = null)
        {
            if (newValue == null)
            {
                throw new sys.ArgumentNullException("newValue");
            }

            this.NewValue = newValue;
            this.PreviousValue = previousValue;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="TeamProfileChangeNameDetails" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public TeamProfileChangeNameDetails()
        {
        }

        /// <summary>
        /// <para>New team name.</para>
        /// </summary>
        public TeamName NewValue { get; protected set; }

        /// <summary>
        /// <para>Previous teams name. Might be missing due to historical data gap.</para>
        /// </summary>
        public TeamName PreviousValue { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="TeamProfileChangeNameDetails" />.</para>
        /// </summary>
        private class TeamProfileChangeNameDetailsEncoder : enc.StructEncoder<TeamProfileChangeNameDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(TeamProfileChangeNameDetails value, enc.IJsonWriter writer)
            {
                WriteProperty("new_value", value.NewValue, writer, global::Dropbox.Api.TeamLog.TeamName.Encoder);
                if (value.PreviousValue != null)
                {
                    WriteProperty("previous_value", value.PreviousValue, writer, global::Dropbox.Api.TeamLog.TeamName.Encoder);
                }
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="TeamProfileChangeNameDetails" />.</para>
        /// </summary>
        private class TeamProfileChangeNameDetailsDecoder : enc.StructDecoder<TeamProfileChangeNameDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="TeamProfileChangeNameDetails"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override TeamProfileChangeNameDetails Create()
            {
                return new TeamProfileChangeNameDetails();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(TeamProfileChangeNameDetails value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "new_value":
                        value.NewValue = global::Dropbox.Api.TeamLog.TeamName.Decoder.Decode(reader);
                        break;
                    case "previous_value":
                        value.PreviousValue = global::Dropbox.Api.TeamLog.TeamName.Decoder.Decode(reader);
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
