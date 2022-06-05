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
    /// <para>Couldn't create report: Views of old links.</para>
    /// </summary>
    public class OutdatedLinkViewReportFailedDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<OutdatedLinkViewReportFailedDetails> Encoder = new OutdatedLinkViewReportFailedDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<OutdatedLinkViewReportFailedDetails> Decoder = new OutdatedLinkViewReportFailedDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see
        /// cref="OutdatedLinkViewReportFailedDetails" /> class.</para>
        /// </summary>
        /// <param name="failureReason">Failure reason.</param>
        public OutdatedLinkViewReportFailedDetails(global::Dropbox.Api.Team.TeamReportFailureReason failureReason)
        {
            if (failureReason == null)
            {
                throw new sys.ArgumentNullException("failureReason");
            }

            this.FailureReason = failureReason;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see
        /// cref="OutdatedLinkViewReportFailedDetails" /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public OutdatedLinkViewReportFailedDetails()
        {
        }

        /// <summary>
        /// <para>Failure reason.</para>
        /// </summary>
        public global::Dropbox.Api.Team.TeamReportFailureReason FailureReason { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="OutdatedLinkViewReportFailedDetails" />.</para>
        /// </summary>
        private class OutdatedLinkViewReportFailedDetailsEncoder : enc.StructEncoder<OutdatedLinkViewReportFailedDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(OutdatedLinkViewReportFailedDetails value, enc.IJsonWriter writer)
            {
                WriteProperty("failure_reason", value.FailureReason, writer, global::Dropbox.Api.Team.TeamReportFailureReason.Encoder);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="OutdatedLinkViewReportFailedDetails" />.</para>
        /// </summary>
        private class OutdatedLinkViewReportFailedDetailsDecoder : enc.StructDecoder<OutdatedLinkViewReportFailedDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see
            /// cref="OutdatedLinkViewReportFailedDetails" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override OutdatedLinkViewReportFailedDetails Create()
            {
                return new OutdatedLinkViewReportFailedDetails();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(OutdatedLinkViewReportFailedDetails value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "failure_reason":
                        value.FailureReason = global::Dropbox.Api.Team.TeamReportFailureReason.Decoder.Decode(reader);
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
