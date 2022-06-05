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
    /// <para>Automatically canceled team merge request.</para>
    /// </summary>
    public class TeamMergeRequestAutoCanceledDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<TeamMergeRequestAutoCanceledDetails> Encoder = new TeamMergeRequestAutoCanceledDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<TeamMergeRequestAutoCanceledDetails> Decoder = new TeamMergeRequestAutoCanceledDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see
        /// cref="TeamMergeRequestAutoCanceledDetails" /> class.</para>
        /// </summary>
        /// <param name="details">The cancellation reason.</param>
        public TeamMergeRequestAutoCanceledDetails(string details = null)
        {
            this.Details = details;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see
        /// cref="TeamMergeRequestAutoCanceledDetails" /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public TeamMergeRequestAutoCanceledDetails()
        {
        }

        /// <summary>
        /// <para>The cancellation reason.</para>
        /// </summary>
        public string Details { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="TeamMergeRequestAutoCanceledDetails" />.</para>
        /// </summary>
        private class TeamMergeRequestAutoCanceledDetailsEncoder : enc.StructEncoder<TeamMergeRequestAutoCanceledDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(TeamMergeRequestAutoCanceledDetails value, enc.IJsonWriter writer)
            {
                if (value.Details != null)
                {
                    WriteProperty("details", value.Details, writer, enc.StringEncoder.Instance);
                }
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="TeamMergeRequestAutoCanceledDetails" />.</para>
        /// </summary>
        private class TeamMergeRequestAutoCanceledDetailsDecoder : enc.StructDecoder<TeamMergeRequestAutoCanceledDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see
            /// cref="TeamMergeRequestAutoCanceledDetails" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override TeamMergeRequestAutoCanceledDetails Create()
            {
                return new TeamMergeRequestAutoCanceledDetails();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(TeamMergeRequestAutoCanceledDetails value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "details":
                        value.Details = enc.StringDecoder.Instance.Decode(reader);
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