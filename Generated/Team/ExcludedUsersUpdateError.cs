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
    /// <para>Excluded users update error.</para>
    /// </summary>
    public class ExcludedUsersUpdateError
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<ExcludedUsersUpdateError> Encoder = new ExcludedUsersUpdateErrorEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<ExcludedUsersUpdateError> Decoder = new ExcludedUsersUpdateErrorDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="ExcludedUsersUpdateError" />
        /// class.</para>
        /// </summary>
        public ExcludedUsersUpdateError()
        {
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is UsersNotInTeam</para>
        /// </summary>
        public bool IsUsersNotInTeam
        {
            get
            {
                return this is UsersNotInTeam;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a UsersNotInTeam, or <c>null</c>.</para>
        /// </summary>
        public UsersNotInTeam AsUsersNotInTeam
        {
            get
            {
                return this as UsersNotInTeam;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is TooManyUsers</para>
        /// </summary>
        public bool IsTooManyUsers
        {
            get
            {
                return this is TooManyUsers;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a TooManyUsers, or <c>null</c>.</para>
        /// </summary>
        public TooManyUsers AsTooManyUsers
        {
            get
            {
                return this as TooManyUsers;
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
        /// <para>Encoder for  <see cref="ExcludedUsersUpdateError" />.</para>
        /// </summary>
        private class ExcludedUsersUpdateErrorEncoder : enc.StructEncoder<ExcludedUsersUpdateError>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(ExcludedUsersUpdateError value, enc.IJsonWriter writer)
            {
                if (value is UsersNotInTeam)
                {
                    WriteProperty(".tag", "users_not_in_team", writer, enc.StringEncoder.Instance);
                    UsersNotInTeam.Encoder.EncodeFields((UsersNotInTeam)value, writer);
                    return;
                }
                if (value is TooManyUsers)
                {
                    WriteProperty(".tag", "too_many_users", writer, enc.StringEncoder.Instance);
                    TooManyUsers.Encoder.EncodeFields((TooManyUsers)value, writer);
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
        /// <para>Decoder for  <see cref="ExcludedUsersUpdateError" />.</para>
        /// </summary>
        private class ExcludedUsersUpdateErrorDecoder : enc.UnionDecoder<ExcludedUsersUpdateError>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="ExcludedUsersUpdateError"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override ExcludedUsersUpdateError Create()
            {
                return new ExcludedUsersUpdateError();
            }

            /// <summary>
            /// <para>Decode based on given tag.</para>
            /// </summary>
            /// <param name="tag">The tag.</param>
            /// <param name="reader">The json reader.</param>
            /// <returns>The decoded object.</returns>
            protected override ExcludedUsersUpdateError Decode(string tag, enc.IJsonReader reader)
            {
                switch (tag)
                {
                    case "users_not_in_team":
                        return UsersNotInTeam.Decoder.DecodeFields(reader);
                    case "too_many_users":
                        return TooManyUsers.Decoder.DecodeFields(reader);
                    default:
                        return Other.Decoder.DecodeFields(reader);
                }
            }
        }

        #endregion

        /// <summary>
        /// <para>At least one of the users is not part of your team.</para>
        /// </summary>
        public sealed class UsersNotInTeam : ExcludedUsersUpdateError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<UsersNotInTeam> Encoder = new UsersNotInTeamEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<UsersNotInTeam> Decoder = new UsersNotInTeamDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="UsersNotInTeam" />
            /// class.</para>
            /// </summary>
            private UsersNotInTeam()
            {
            }

            /// <summary>
            /// <para>A singleton instance of UsersNotInTeam</para>
            /// </summary>
            public static readonly UsersNotInTeam Instance = new UsersNotInTeam();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="UsersNotInTeam" />.</para>
            /// </summary>
            private class UsersNotInTeamEncoder : enc.StructEncoder<UsersNotInTeam>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(UsersNotInTeam value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="UsersNotInTeam" />.</para>
            /// </summary>
            private class UsersNotInTeamDecoder : enc.StructDecoder<UsersNotInTeam>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="UsersNotInTeam" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override UsersNotInTeam Create()
                {
                    return UsersNotInTeam.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>A maximum of 1000 users for each of addition/removal can be supplied.</para>
        /// </summary>
        public sealed class TooManyUsers : ExcludedUsersUpdateError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<TooManyUsers> Encoder = new TooManyUsersEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<TooManyUsers> Decoder = new TooManyUsersDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="TooManyUsers" />
            /// class.</para>
            /// </summary>
            private TooManyUsers()
            {
            }

            /// <summary>
            /// <para>A singleton instance of TooManyUsers</para>
            /// </summary>
            public static readonly TooManyUsers Instance = new TooManyUsers();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="TooManyUsers" />.</para>
            /// </summary>
            private class TooManyUsersEncoder : enc.StructEncoder<TooManyUsers>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(TooManyUsers value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="TooManyUsers" />.</para>
            /// </summary>
            private class TooManyUsersDecoder : enc.StructDecoder<TooManyUsers>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="TooManyUsers" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override TooManyUsers Create()
                {
                    return TooManyUsers.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The other object</para>
        /// </summary>
        public sealed class Other : ExcludedUsersUpdateError
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
