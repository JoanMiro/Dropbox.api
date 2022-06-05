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
    /// <para>Suggested person to add to team.</para>
    /// </summary>
    public class MemberSuggestDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<MemberSuggestDetails> Encoder = new MemberSuggestDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<MemberSuggestDetails> Decoder = new MemberSuggestDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="MemberSuggestDetails" />
        /// class.</para>
        /// </summary>
        /// <param name="suggestedMembers">suggested users emails.</param>
        public MemberSuggestDetails(col.IEnumerable<string> suggestedMembers)
        {
            var suggestedMembersList = enc.Util.ToList(suggestedMembers);

            if (suggestedMembers == null)
            {
                throw new sys.ArgumentNullException("suggestedMembers");
            }

            this.SuggestedMembers = suggestedMembersList;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="MemberSuggestDetails" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public MemberSuggestDetails()
        {
        }

        /// <summary>
        /// <para>suggested users emails.</para>
        /// </summary>
        public col.IList<string> SuggestedMembers { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="MemberSuggestDetails" />.</para>
        /// </summary>
        private class MemberSuggestDetailsEncoder : enc.StructEncoder<MemberSuggestDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(MemberSuggestDetails value, enc.IJsonWriter writer)
            {
                WriteListProperty("suggested_members", value.SuggestedMembers, writer, enc.StringEncoder.Instance);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="MemberSuggestDetails" />.</para>
        /// </summary>
        private class MemberSuggestDetailsDecoder : enc.StructDecoder<MemberSuggestDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="MemberSuggestDetails" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override MemberSuggestDetails Create()
            {
                return new MemberSuggestDetails();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(MemberSuggestDetails value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "suggested_members":
                        value.SuggestedMembers = ReadList<string>(reader, enc.StringDecoder.Instance);
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
