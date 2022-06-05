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
    /// <para>The type of classification (currently only PII)</para>
    /// </summary>
    public class ClassificationType
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<ClassificationType> Encoder = new ClassificationTypeEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<ClassificationType> Decoder = new ClassificationTypeDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="ClassificationType" />
        /// class.</para>
        /// </summary>
        public ClassificationType()
        {
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Pii</para>
        /// </summary>
        public bool IsPii
        {
            get
            {
                return this is Pii;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Pii, or <c>null</c>.</para>
        /// </summary>
        public Pii AsPii
        {
            get
            {
                return this as Pii;
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
        /// <para>Encoder for  <see cref="ClassificationType" />.</para>
        /// </summary>
        private class ClassificationTypeEncoder : enc.StructEncoder<ClassificationType>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(ClassificationType value, enc.IJsonWriter writer)
            {
                if (value is Pii)
                {
                    WriteProperty(".tag", "pii", writer, enc.StringEncoder.Instance);
                    Pii.Encoder.EncodeFields((Pii)value, writer);
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
        /// <para>Decoder for  <see cref="ClassificationType" />.</para>
        /// </summary>
        private class ClassificationTypeDecoder : enc.UnionDecoder<ClassificationType>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="ClassificationType" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override ClassificationType Create()
            {
                return new ClassificationType();
            }

            /// <summary>
            /// <para>Decode based on given tag.</para>
            /// </summary>
            /// <param name="tag">The tag.</param>
            /// <param name="reader">The json reader.</param>
            /// <returns>The decoded object.</returns>
            protected override ClassificationType Decode(string tag, enc.IJsonReader reader)
            {
                switch (tag)
                {
                    case "pii":
                        return Pii.Decoder.DecodeFields(reader);
                    default:
                        return Other.Decoder.DecodeFields(reader);
                }
            }
        }

        #endregion

        /// <summary>
        /// <para>The pii object</para>
        /// </summary>
        public sealed class Pii : ClassificationType
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Pii> Encoder = new PiiEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Pii> Decoder = new PiiDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Pii" /> class.</para>
            /// </summary>
            private Pii()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Pii</para>
            /// </summary>
            public static readonly Pii Instance = new Pii();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Pii" />.</para>
            /// </summary>
            private class PiiEncoder : enc.StructEncoder<Pii>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Pii value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Pii" />.</para>
            /// </summary>
            private class PiiDecoder : enc.StructDecoder<Pii>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Pii" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Pii Create()
                {
                    return Pii.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The other object</para>
        /// </summary>
        public sealed class Other : ClassificationType
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
