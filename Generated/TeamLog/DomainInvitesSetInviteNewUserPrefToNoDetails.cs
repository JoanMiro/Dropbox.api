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
    /// <para>Disabled "Automatically invite new users".</para>
    /// </summary>
    public class DomainInvitesSetInviteNewUserPrefToNoDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<DomainInvitesSetInviteNewUserPrefToNoDetails> Encoder = new DomainInvitesSetInviteNewUserPrefToNoDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<DomainInvitesSetInviteNewUserPrefToNoDetails> Decoder = new DomainInvitesSetInviteNewUserPrefToNoDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see
        /// cref="DomainInvitesSetInviteNewUserPrefToNoDetails" /> class.</para>
        /// </summary>
        public DomainInvitesSetInviteNewUserPrefToNoDetails()
        {
        }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="DomainInvitesSetInviteNewUserPrefToNoDetails"
        /// />.</para>
        /// </summary>
        private class DomainInvitesSetInviteNewUserPrefToNoDetailsEncoder : enc.StructEncoder<DomainInvitesSetInviteNewUserPrefToNoDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(DomainInvitesSetInviteNewUserPrefToNoDetails value, enc.IJsonWriter writer)
            {
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="DomainInvitesSetInviteNewUserPrefToNoDetails"
        /// />.</para>
        /// </summary>
        private class DomainInvitesSetInviteNewUserPrefToNoDetailsDecoder : enc.StructDecoder<DomainInvitesSetInviteNewUserPrefToNoDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see
            /// cref="DomainInvitesSetInviteNewUserPrefToNoDetails" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override DomainInvitesSetInviteNewUserPrefToNoDetails Create()
            {
                return new DomainInvitesSetInviteNewUserPrefToNoDetails();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(DomainInvitesSetInviteNewUserPrefToNoDetails value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    default:
                        reader.Skip();
                        break;
                }
            }
        }

        #endregion
    }
}