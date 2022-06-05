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
    /// <para>Created team activity report.</para>
    /// </summary>
    public class TeamActivityCreateReportDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<TeamActivityCreateReportDetails> Encoder = new TeamActivityCreateReportDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<TeamActivityCreateReportDetails> Decoder = new TeamActivityCreateReportDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="TeamActivityCreateReportDetails"
        /// /> class.</para>
        /// </summary>
        /// <param name="startDate">Report start date.</param>
        /// <param name="endDate">Report end date.</param>
        public TeamActivityCreateReportDetails(sys.DateTime startDate,
                                               sys.DateTime endDate)
        {
            this.StartDate = startDate;
            this.EndDate = endDate;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="TeamActivityCreateReportDetails"
        /// /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public TeamActivityCreateReportDetails()
        {
        }

        /// <summary>
        /// <para>Report start date.</para>
        /// </summary>
        public sys.DateTime StartDate { get; protected set; }

        /// <summary>
        /// <para>Report end date.</para>
        /// </summary>
        public sys.DateTime EndDate { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="TeamActivityCreateReportDetails" />.</para>
        /// </summary>
        private class TeamActivityCreateReportDetailsEncoder : enc.StructEncoder<TeamActivityCreateReportDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(TeamActivityCreateReportDetails value, enc.IJsonWriter writer)
            {
                WriteProperty("start_date", value.StartDate, writer, enc.DateTimeEncoder.Instance);
                WriteProperty("end_date", value.EndDate, writer, enc.DateTimeEncoder.Instance);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="TeamActivityCreateReportDetails" />.</para>
        /// </summary>
        private class TeamActivityCreateReportDetailsDecoder : enc.StructDecoder<TeamActivityCreateReportDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="TeamActivityCreateReportDetails"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override TeamActivityCreateReportDetails Create()
            {
                return new TeamActivityCreateReportDetails();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(TeamActivityCreateReportDetails value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "start_date":
                        value.StartDate = enc.DateTimeDecoder.Instance.Decode(reader);
                        break;
                    case "end_date":
                        value.EndDate = enc.DateTimeDecoder.Instance.Decode(reader);
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
