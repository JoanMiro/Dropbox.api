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
    /// <para>Removed Binder section.</para>
    /// </summary>
    public class BinderRemoveSectionDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<BinderRemoveSectionDetails> Encoder = new BinderRemoveSectionDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<BinderRemoveSectionDetails> Decoder = new BinderRemoveSectionDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="BinderRemoveSectionDetails" />
        /// class.</para>
        /// </summary>
        /// <param name="eventUuid">Event unique identifier.</param>
        /// <param name="docTitle">Title of the Binder doc.</param>
        /// <param name="binderItemName">Name of the Binder page/section.</param>
        public BinderRemoveSectionDetails(string eventUuid,
                                          string docTitle,
                                          string binderItemName)
        {
            if (eventUuid == null)
            {
                throw new sys.ArgumentNullException("eventUuid");
            }

            if (docTitle == null)
            {
                throw new sys.ArgumentNullException("docTitle");
            }

            if (binderItemName == null)
            {
                throw new sys.ArgumentNullException("binderItemName");
            }

            this.EventUuid = eventUuid;
            this.DocTitle = docTitle;
            this.BinderItemName = binderItemName;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="BinderRemoveSectionDetails" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public BinderRemoveSectionDetails()
        {
        }

        /// <summary>
        /// <para>Event unique identifier.</para>
        /// </summary>
        public string EventUuid { get; protected set; }

        /// <summary>
        /// <para>Title of the Binder doc.</para>
        /// </summary>
        public string DocTitle { get; protected set; }

        /// <summary>
        /// <para>Name of the Binder page/section.</para>
        /// </summary>
        public string BinderItemName { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="BinderRemoveSectionDetails" />.</para>
        /// </summary>
        private class BinderRemoveSectionDetailsEncoder : enc.StructEncoder<BinderRemoveSectionDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(BinderRemoveSectionDetails value, enc.IJsonWriter writer)
            {
                WriteProperty("event_uuid", value.EventUuid, writer, enc.StringEncoder.Instance);
                WriteProperty("doc_title", value.DocTitle, writer, enc.StringEncoder.Instance);
                WriteProperty("binder_item_name", value.BinderItemName, writer, enc.StringEncoder.Instance);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="BinderRemoveSectionDetails" />.</para>
        /// </summary>
        private class BinderRemoveSectionDetailsDecoder : enc.StructDecoder<BinderRemoveSectionDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="BinderRemoveSectionDetails"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override BinderRemoveSectionDetails Create()
            {
                return new BinderRemoveSectionDetails();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(BinderRemoveSectionDetails value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "event_uuid":
                        value.EventUuid = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "doc_title":
                        value.DocTitle = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "binder_item_name":
                        value.BinderItemName = enc.StringDecoder.Instance.Decode(reader);
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
