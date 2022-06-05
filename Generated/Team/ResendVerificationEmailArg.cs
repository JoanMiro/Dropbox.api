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
    /// <para>The resend verification email arg object</para>
    /// </summary>
    public class ResendVerificationEmailArg
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<ResendVerificationEmailArg> Encoder = new ResendVerificationEmailArgEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<ResendVerificationEmailArg> Decoder = new ResendVerificationEmailArgDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="ResendVerificationEmailArg" />
        /// class.</para>
        /// </summary>
        /// <param name="emailsToResend">List of users and secondary emails to resend
        /// verification emails to.</param>
        public ResendVerificationEmailArg(col.IEnumerable<UserSecondaryEmailsArg> emailsToResend)
        {
            var emailsToResendList = enc.Util.ToList(emailsToResend);

            if (emailsToResend == null)
            {
                throw new sys.ArgumentNullException("emailsToResend");
            }

            this.EmailsToResend = emailsToResendList;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="ResendVerificationEmailArg" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public ResendVerificationEmailArg()
        {
        }

        /// <summary>
        /// <para>List of users and secondary emails to resend verification emails to.</para>
        /// </summary>
        public col.IList<UserSecondaryEmailsArg> EmailsToResend { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="ResendVerificationEmailArg" />.</para>
        /// </summary>
        private class ResendVerificationEmailArgEncoder : enc.StructEncoder<ResendVerificationEmailArg>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(ResendVerificationEmailArg value, enc.IJsonWriter writer)
            {
                WriteListProperty("emails_to_resend", value.EmailsToResend, writer, global::Dropbox.Api.Team.UserSecondaryEmailsArg.Encoder);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="ResendVerificationEmailArg" />.</para>
        /// </summary>
        private class ResendVerificationEmailArgDecoder : enc.StructDecoder<ResendVerificationEmailArg>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="ResendVerificationEmailArg"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override ResendVerificationEmailArg Create()
            {
                return new ResendVerificationEmailArg();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(ResendVerificationEmailArg value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "emails_to_resend":
                        value.EmailsToResend = ReadList<UserSecondaryEmailsArg>(reader, global::Dropbox.Api.Team.UserSecondaryEmailsArg.Decoder);
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
