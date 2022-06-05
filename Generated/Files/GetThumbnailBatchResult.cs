// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Files
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>The get thumbnail batch result object</para>
    /// </summary>
    public class GetThumbnailBatchResult
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<GetThumbnailBatchResult> Encoder = new GetThumbnailBatchResultEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<GetThumbnailBatchResult> Decoder = new GetThumbnailBatchResultDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="GetThumbnailBatchResult" />
        /// class.</para>
        /// </summary>
        /// <param name="entries">List of files and their thumbnails.</param>
        public GetThumbnailBatchResult(col.IEnumerable<GetThumbnailBatchResultEntry> entries)
        {
            var entriesList = enc.Util.ToList(entries);

            if (entries == null)
            {
                throw new sys.ArgumentNullException("entries");
            }

            this.Entries = entriesList;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="GetThumbnailBatchResult" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public GetThumbnailBatchResult()
        {
        }

        /// <summary>
        /// <para>List of files and their thumbnails.</para>
        /// </summary>
        public col.IList<GetThumbnailBatchResultEntry> Entries { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="GetThumbnailBatchResult" />.</para>
        /// </summary>
        private class GetThumbnailBatchResultEncoder : enc.StructEncoder<GetThumbnailBatchResult>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(GetThumbnailBatchResult value, enc.IJsonWriter writer)
            {
                WriteListProperty("entries", value.Entries, writer, global::Dropbox.Api.Files.GetThumbnailBatchResultEntry.Encoder);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="GetThumbnailBatchResult" />.</para>
        /// </summary>
        private class GetThumbnailBatchResultDecoder : enc.StructDecoder<GetThumbnailBatchResult>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="GetThumbnailBatchResult"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override GetThumbnailBatchResult Create()
            {
                return new GetThumbnailBatchResult();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(GetThumbnailBatchResult value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "entries":
                        value.Entries = ReadList<GetThumbnailBatchResultEntry>(reader, global::Dropbox.Api.Files.GetThumbnailBatchResultEntry.Decoder);
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
