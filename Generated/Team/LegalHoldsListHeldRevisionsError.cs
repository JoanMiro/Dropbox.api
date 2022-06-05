// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Team
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>The legal holds list held revisions error object</para>
    /// </summary>
    public class LegalHoldsListHeldRevisionsError
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<LegalHoldsListHeldRevisionsError> Encoder = new LegalHoldsListHeldRevisionsErrorEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<LegalHoldsListHeldRevisionsError> Decoder = new LegalHoldsListHeldRevisionsErrorDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see
        /// cref="LegalHoldsListHeldRevisionsError" /> class.</para>
        /// </summary>
        public LegalHoldsListHeldRevisionsError()
        {
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is TransientError</para>
        /// </summary>
        public bool IsTransientError
        {
            get
            {
                return this is TransientError;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a TransientError, or <c>null</c>.</para>
        /// </summary>
        public TransientError AsTransientError
        {
            get
            {
                return this as TransientError;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is LegalHoldStillEmpty</para>
        /// </summary>
        public bool IsLegalHoldStillEmpty
        {
            get
            {
                return this is LegalHoldStillEmpty;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a LegalHoldStillEmpty, or <c>null</c>.</para>
        /// </summary>
        public LegalHoldStillEmpty AsLegalHoldStillEmpty
        {
            get
            {
                return this as LegalHoldStillEmpty;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is InactiveLegalHold</para>
        /// </summary>
        public bool IsInactiveLegalHold
        {
            get
            {
                return this is InactiveLegalHold;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a InactiveLegalHold, or <c>null</c>.</para>
        /// </summary>
        public InactiveLegalHold AsInactiveLegalHold
        {
            get
            {
                return this as InactiveLegalHold;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is UnknownLegalHoldError</para>
        /// </summary>
        public bool IsUnknownLegalHoldError
        {
            get
            {
                return this is UnknownLegalHoldError;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a UnknownLegalHoldError, or <c>null</c>.</para>
        /// </summary>
        public UnknownLegalHoldError AsUnknownLegalHoldError
        {
            get
            {
                return this as UnknownLegalHoldError;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is
        /// InsufficientPermissions</para>
        /// </summary>
        public bool IsInsufficientPermissions
        {
            get
            {
                return this is InsufficientPermissions;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a InsufficientPermissions, or <c>null</c>.</para>
        /// </summary>
        public InsufficientPermissions AsInsufficientPermissions
        {
            get
            {
                return this as InsufficientPermissions;
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
        /// <para>Encoder for  <see cref="LegalHoldsListHeldRevisionsError" />.</para>
        /// </summary>
        private class LegalHoldsListHeldRevisionsErrorEncoder : enc.StructEncoder<LegalHoldsListHeldRevisionsError>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(LegalHoldsListHeldRevisionsError value, enc.IJsonWriter writer)
            {
                if (value is TransientError)
                {
                    WriteProperty(".tag", "transient_error", writer, enc.StringEncoder.Instance);
                    TransientError.Encoder.EncodeFields((TransientError)value, writer);
                    return;
                }
                if (value is LegalHoldStillEmpty)
                {
                    WriteProperty(".tag", "legal_hold_still_empty", writer, enc.StringEncoder.Instance);
                    LegalHoldStillEmpty.Encoder.EncodeFields((LegalHoldStillEmpty)value, writer);
                    return;
                }
                if (value is InactiveLegalHold)
                {
                    WriteProperty(".tag", "inactive_legal_hold", writer, enc.StringEncoder.Instance);
                    InactiveLegalHold.Encoder.EncodeFields((InactiveLegalHold)value, writer);
                    return;
                }
                if (value is UnknownLegalHoldError)
                {
                    WriteProperty(".tag", "unknown_legal_hold_error", writer, enc.StringEncoder.Instance);
                    UnknownLegalHoldError.Encoder.EncodeFields((UnknownLegalHoldError)value, writer);
                    return;
                }
                if (value is InsufficientPermissions)
                {
                    WriteProperty(".tag", "insufficient_permissions", writer, enc.StringEncoder.Instance);
                    InsufficientPermissions.Encoder.EncodeFields((InsufficientPermissions)value, writer);
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
        /// <para>Decoder for  <see cref="LegalHoldsListHeldRevisionsError" />.</para>
        /// </summary>
        private class LegalHoldsListHeldRevisionsErrorDecoder : enc.UnionDecoder<LegalHoldsListHeldRevisionsError>
        {
            /// <summary>
            /// <para>Create a new instance of type <see
            /// cref="LegalHoldsListHeldRevisionsError" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override LegalHoldsListHeldRevisionsError Create()
            {
                return new LegalHoldsListHeldRevisionsError();
            }

            /// <summary>
            /// <para>Decode based on given tag.</para>
            /// </summary>
            /// <param name="tag">The tag.</param>
            /// <param name="reader">The json reader.</param>
            /// <returns>The decoded object.</returns>
            protected override LegalHoldsListHeldRevisionsError Decode(string tag, enc.IJsonReader reader)
            {
                switch (tag)
                {
                    case "transient_error":
                        return TransientError.Decoder.DecodeFields(reader);
                    case "legal_hold_still_empty":
                        return LegalHoldStillEmpty.Decoder.DecodeFields(reader);
                    case "inactive_legal_hold":
                        return InactiveLegalHold.Decoder.DecodeFields(reader);
                    case "unknown_legal_hold_error":
                        return UnknownLegalHoldError.Decoder.DecodeFields(reader);
                    case "insufficient_permissions":
                        return InsufficientPermissions.Decoder.DecodeFields(reader);
                    case "other":
                        return Other.Decoder.DecodeFields(reader);
                    default:
                        throw new sys.InvalidOperationException();
                }
            }
        }

        #endregion

        /// <summary>
        /// <para>Temporary infrastructure failure, please retry.</para>
        /// </summary>
        public sealed class TransientError : LegalHoldsListHeldRevisionsError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<TransientError> Encoder = new TransientErrorEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<TransientError> Decoder = new TransientErrorDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="TransientError" />
            /// class.</para>
            /// </summary>
            private TransientError()
            {
            }

            /// <summary>
            /// <para>A singleton instance of TransientError</para>
            /// </summary>
            public static readonly TransientError Instance = new TransientError();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="TransientError" />.</para>
            /// </summary>
            private class TransientErrorEncoder : enc.StructEncoder<TransientError>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(TransientError value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="TransientError" />.</para>
            /// </summary>
            private class TransientErrorDecoder : enc.StructDecoder<TransientError>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="TransientError" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override TransientError Create()
                {
                    return TransientError.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The legal hold is not holding any revisions yet.</para>
        /// </summary>
        public sealed class LegalHoldStillEmpty : LegalHoldsListHeldRevisionsError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<LegalHoldStillEmpty> Encoder = new LegalHoldStillEmptyEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<LegalHoldStillEmpty> Decoder = new LegalHoldStillEmptyDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="LegalHoldStillEmpty" />
            /// class.</para>
            /// </summary>
            private LegalHoldStillEmpty()
            {
            }

            /// <summary>
            /// <para>A singleton instance of LegalHoldStillEmpty</para>
            /// </summary>
            public static readonly LegalHoldStillEmpty Instance = new LegalHoldStillEmpty();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="LegalHoldStillEmpty" />.</para>
            /// </summary>
            private class LegalHoldStillEmptyEncoder : enc.StructEncoder<LegalHoldStillEmpty>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(LegalHoldStillEmpty value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="LegalHoldStillEmpty" />.</para>
            /// </summary>
            private class LegalHoldStillEmptyDecoder : enc.StructDecoder<LegalHoldStillEmpty>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="LegalHoldStillEmpty"
                /// />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override LegalHoldStillEmpty Create()
                {
                    return LegalHoldStillEmpty.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>Trying to list revisions for an inactive legal hold.</para>
        /// </summary>
        public sealed class InactiveLegalHold : LegalHoldsListHeldRevisionsError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<InactiveLegalHold> Encoder = new InactiveLegalHoldEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<InactiveLegalHold> Decoder = new InactiveLegalHoldDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="InactiveLegalHold" />
            /// class.</para>
            /// </summary>
            private InactiveLegalHold()
            {
            }

            /// <summary>
            /// <para>A singleton instance of InactiveLegalHold</para>
            /// </summary>
            public static readonly InactiveLegalHold Instance = new InactiveLegalHold();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="InactiveLegalHold" />.</para>
            /// </summary>
            private class InactiveLegalHoldEncoder : enc.StructEncoder<InactiveLegalHold>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(InactiveLegalHold value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="InactiveLegalHold" />.</para>
            /// </summary>
            private class InactiveLegalHoldDecoder : enc.StructDecoder<InactiveLegalHold>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="InactiveLegalHold"
                /// />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override InactiveLegalHold Create()
                {
                    return InactiveLegalHold.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>There has been an unknown legal hold error.</para>
        /// </summary>
        public sealed class UnknownLegalHoldError : LegalHoldsListHeldRevisionsError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<UnknownLegalHoldError> Encoder = new UnknownLegalHoldErrorEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<UnknownLegalHoldError> Decoder = new UnknownLegalHoldErrorDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="UnknownLegalHoldError" />
            /// class.</para>
            /// </summary>
            private UnknownLegalHoldError()
            {
            }

            /// <summary>
            /// <para>A singleton instance of UnknownLegalHoldError</para>
            /// </summary>
            public static readonly UnknownLegalHoldError Instance = new UnknownLegalHoldError();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="UnknownLegalHoldError" />.</para>
            /// </summary>
            private class UnknownLegalHoldErrorEncoder : enc.StructEncoder<UnknownLegalHoldError>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(UnknownLegalHoldError value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="UnknownLegalHoldError" />.</para>
            /// </summary>
            private class UnknownLegalHoldErrorDecoder : enc.StructDecoder<UnknownLegalHoldError>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="UnknownLegalHoldError"
                /// />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override UnknownLegalHoldError Create()
                {
                    return UnknownLegalHoldError.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>You don't have permissions to perform this action.</para>
        /// </summary>
        public sealed class InsufficientPermissions : LegalHoldsListHeldRevisionsError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<InsufficientPermissions> Encoder = new InsufficientPermissionsEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<InsufficientPermissions> Decoder = new InsufficientPermissionsDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="InsufficientPermissions" />
            /// class.</para>
            /// </summary>
            private InsufficientPermissions()
            {
            }

            /// <summary>
            /// <para>A singleton instance of InsufficientPermissions</para>
            /// </summary>
            public static readonly InsufficientPermissions Instance = new InsufficientPermissions();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="InsufficientPermissions" />.</para>
            /// </summary>
            private class InsufficientPermissionsEncoder : enc.StructEncoder<InsufficientPermissions>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(InsufficientPermissions value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="InsufficientPermissions" />.</para>
            /// </summary>
            private class InsufficientPermissionsDecoder : enc.StructDecoder<InsufficientPermissions>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="InsufficientPermissions"
                /// />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override InsufficientPermissions Create()
                {
                    return InsufficientPermissions.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The other object</para>
        /// </summary>
        public sealed class Other : LegalHoldsListHeldRevisionsError
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