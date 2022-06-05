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
    /// <para>The download arg object</para>
    /// </summary>
    public class DownloadArg
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<DownloadArg> Encoder = new DownloadArgEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<DownloadArg> Decoder = new DownloadArgDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="DownloadArg" /> class.</para>
        /// </summary>
        /// <param name="path">The path of the file to download.</param>
        /// <param name="rev">Please specify revision in <paramref name="path" />
        /// instead.</param>
        public DownloadArg(string path,
                           string rev = null)
        {
            if (path == null)
            {
                throw new sys.ArgumentNullException("path");
            }
            if (!re.Regex.IsMatch(path, @"\A(?:(/(.|[\r\n])*|id:.*)|(rev:[0-9a-f]{9,})|(ns:[0-9]+(/.*)?))\z"))
            {
                throw new sys.ArgumentOutOfRangeException("path", @"Value should match pattern '\A(?:(/(.|[\r\n])*|id:.*)|(rev:[0-9a-f]{9,})|(ns:[0-9]+(/.*)?))\z'");
            }

            if (rev != null)
            {
                if (rev.Length < 9)
                {
                    throw new sys.ArgumentOutOfRangeException("rev", "Length should be at least 9");
                }
                if (!re.Regex.IsMatch(rev, @"\A(?:[0-9a-f]+)\z"))
                {
                    throw new sys.ArgumentOutOfRangeException("rev", @"Value should match pattern '\A(?:[0-9a-f]+)\z'");
                }
            }

            this.Path = path;
            this.Rev = rev;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="DownloadArg" /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public DownloadArg()
        {
        }

        /// <summary>
        /// <para>The path of the file to download.</para>
        /// </summary>
        public string Path { get; protected set; }

        /// <summary>
        /// <para>Please specify revision in <see cref="Path" /> instead.</para>
        /// </summary>
        public string Rev { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="DownloadArg" />.</para>
        /// </summary>
        private class DownloadArgEncoder : enc.StructEncoder<DownloadArg>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(DownloadArg value, enc.IJsonWriter writer)
            {
                WriteProperty("path", value.Path, writer, enc.StringEncoder.Instance);
                if (value.Rev != null)
                {
                    WriteProperty("rev", value.Rev, writer, enc.StringEncoder.Instance);
                }
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="DownloadArg" />.</para>
        /// </summary>
        private class DownloadArgDecoder : enc.StructDecoder<DownloadArg>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="DownloadArg" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override DownloadArg Create()
            {
                return new DownloadArg();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(DownloadArg value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "path":
                        value.Path = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "rev":
                        value.Rev = enc.StringDecoder.Instance.Decode(reader);
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
