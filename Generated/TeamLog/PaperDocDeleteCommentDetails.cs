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
    /// <para>Deleted Paper doc comment.</para>
    /// </summary>
    public class PaperDocDeleteCommentDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<PaperDocDeleteCommentDetails> Encoder = new PaperDocDeleteCommentDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<PaperDocDeleteCommentDetails> Decoder = new PaperDocDeleteCommentDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="PaperDocDeleteCommentDetails" />
        /// class.</para>
        /// </summary>
        /// <param name="eventUuid">Event unique identifier.</param>
        /// <param name="commentText">Comment text. Might be missing due to historical data
        /// gap.</param>
        public PaperDocDeleteCommentDetails(string eventUuid,
                                            string commentText = null)
        {
            if (eventUuid == null)
            {
                throw new sys.ArgumentNullException("eventUuid");
            }

            this.EventUuid = eventUuid;
            this.CommentText = commentText;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="PaperDocDeleteCommentDetails" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public PaperDocDeleteCommentDetails()
        {
        }

        /// <summary>
        /// <para>Event unique identifier.</para>
        /// </summary>
        public string EventUuid { get; protected set; }

        /// <summary>
        /// <para>Comment text. Might be missing due to historical data gap.</para>
        /// </summary>
        public string CommentText { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="PaperDocDeleteCommentDetails" />.</para>
        /// </summary>
        private class PaperDocDeleteCommentDetailsEncoder : enc.StructEncoder<PaperDocDeleteCommentDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(PaperDocDeleteCommentDetails value, enc.IJsonWriter writer)
            {
                WriteProperty("event_uuid", value.EventUuid, writer, enc.StringEncoder.Instance);
                if (value.CommentText != null)
                {
                    WriteProperty("comment_text", value.CommentText, writer, enc.StringEncoder.Instance);
                }
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="PaperDocDeleteCommentDetails" />.</para>
        /// </summary>
        private class PaperDocDeleteCommentDetailsDecoder : enc.StructDecoder<PaperDocDeleteCommentDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="PaperDocDeleteCommentDetails"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override PaperDocDeleteCommentDetails Create()
            {
                return new PaperDocDeleteCommentDetails();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(PaperDocDeleteCommentDetails value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "event_uuid":
                        value.EventUuid = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "comment_text":
                        value.CommentText = enc.StringDecoder.Instance.Decode(reader);
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
