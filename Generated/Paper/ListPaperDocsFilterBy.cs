// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Paper
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>The list paper docs filter by object</para>
    /// </summary>
    public class ListPaperDocsFilterBy
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<ListPaperDocsFilterBy> Encoder = new ListPaperDocsFilterByEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<ListPaperDocsFilterBy> Decoder = new ListPaperDocsFilterByDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="ListPaperDocsFilterBy" />
        /// class.</para>
        /// </summary>
        public ListPaperDocsFilterBy()
        {
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is DocsAccessed</para>
        /// </summary>
        public bool IsDocsAccessed
        {
            get
            {
                return this is DocsAccessed;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a DocsAccessed, or <c>null</c>.</para>
        /// </summary>
        public DocsAccessed AsDocsAccessed
        {
            get
            {
                return this as DocsAccessed;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is DocsCreated</para>
        /// </summary>
        public bool IsDocsCreated
        {
            get
            {
                return this is DocsCreated;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a DocsCreated, or <c>null</c>.</para>
        /// </summary>
        public DocsCreated AsDocsCreated
        {
            get
            {
                return this as DocsCreated;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Other</para>
        /// </summary>
        public bool IsOther
        {
            get
            {
                return this is Other;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Other, or <c>null</c>.</para>
        /// </summary>
        public Other AsOther
        {
            get
            {
                return this as Other;
            }
        }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="ListPaperDocsFilterBy" />.</para>
        /// </summary>
        private class ListPaperDocsFilterByEncoder : enc.StructEncoder<ListPaperDocsFilterBy>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(ListPaperDocsFilterBy value, enc.IJsonWriter writer)
            {
                if (value is DocsAccessed)
                {
                    WriteProperty(".tag", "docs_accessed", writer, enc.StringEncoder.Instance);
                    DocsAccessed.Encoder.EncodeFields((DocsAccessed)value, writer);
                    return;
                }
                if (value is DocsCreated)
                {
                    WriteProperty(".tag", "docs_created", writer, enc.StringEncoder.Instance);
                    DocsCreated.Encoder.EncodeFields((DocsCreated)value, writer);
                    return;
                }
                if (value is Other)
                {
                    WriteProperty(".tag", "other", writer, enc.StringEncoder.Instance);
                    Other.Encoder.EncodeFields((Other)value, writer);
                    return;
                }
                throw new sys.InvalidOperationException();
            }
        }

        #endregion

        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="ListPaperDocsFilterBy" />.</para>
        /// </summary>
        private class ListPaperDocsFilterByDecoder : enc.UnionDecoder<ListPaperDocsFilterBy>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="ListPaperDocsFilterBy"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override ListPaperDocsFilterBy Create()
            {
                return new ListPaperDocsFilterBy();
            }

            /// <summary>
            /// <para>Decode based on given tag.</para>
            /// </summary>
            /// <param name="tag">The tag.</param>
            /// <param name="reader">The json reader.</param>
            /// <returns>The decoded object.</returns>
            protected override ListPaperDocsFilterBy Decode(string tag, enc.IJsonReader reader)
            {
                switch (tag)
                {
                    case "docs_accessed":
                        return DocsAccessed.Decoder.DecodeFields(reader);
                    case "docs_created":
                        return DocsCreated.Decoder.DecodeFields(reader);
                    default:
                        return Other.Decoder.DecodeFields(reader);
                }
            }
        }

        #endregion

        /// <summary>
        /// <para>Fetches all Paper doc IDs that the user has ever accessed.</para>
        /// </summary>
        public sealed class DocsAccessed : ListPaperDocsFilterBy
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<DocsAccessed> Encoder = new DocsAccessedEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<DocsAccessed> Decoder = new DocsAccessedDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="DocsAccessed" />
            /// class.</para>
            /// </summary>
            private DocsAccessed()
            {
            }

            /// <summary>
            /// <para>A singleton instance of DocsAccessed</para>
            /// </summary>
            public static readonly DocsAccessed Instance = new DocsAccessed();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="DocsAccessed" />.</para>
            /// </summary>
            private class DocsAccessedEncoder : enc.StructEncoder<DocsAccessed>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(DocsAccessed value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="DocsAccessed" />.</para>
            /// </summary>
            private class DocsAccessedDecoder : enc.StructDecoder<DocsAccessed>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="DocsAccessed" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override DocsAccessed Create()
                {
                    return DocsAccessed.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>Fetches only the Paper doc IDs that the user has created.</para>
        /// </summary>
        public sealed class DocsCreated : ListPaperDocsFilterBy
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<DocsCreated> Encoder = new DocsCreatedEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<DocsCreated> Decoder = new DocsCreatedDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="DocsCreated" />
            /// class.</para>
            /// </summary>
            private DocsCreated()
            {
            }

            /// <summary>
            /// <para>A singleton instance of DocsCreated</para>
            /// </summary>
            public static readonly DocsCreated Instance = new DocsCreated();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="DocsCreated" />.</para>
            /// </summary>
            private class DocsCreatedEncoder : enc.StructEncoder<DocsCreated>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(DocsCreated value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="DocsCreated" />.</para>
            /// </summary>
            private class DocsCreatedDecoder : enc.StructDecoder<DocsCreated>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="DocsCreated" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override DocsCreated Create()
                {
                    return DocsCreated.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The other object</para>
        /// </summary>
        public sealed class Other : ListPaperDocsFilterBy
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Other> Encoder = new OtherEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Other> Decoder = new OtherDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Other" /> class.</para>
            /// </summary>
            private Other()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Other</para>
            /// </summary>
            public static readonly Other Instance = new Other();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Other" />.</para>
            /// </summary>
            private class OtherEncoder : enc.StructEncoder<Other>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Other value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Other" />.</para>
            /// </summary>
            private class OtherDecoder : enc.StructDecoder<Other>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Other" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Other Create()
                {
                    return Other.Instance;
                }

            }

            #endregion
        }
    }
}
