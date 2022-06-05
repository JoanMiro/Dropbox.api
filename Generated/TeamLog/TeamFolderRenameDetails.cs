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
    /// <para>Renamed active/archived team folder.</para>
    /// </summary>
    public class TeamFolderRenameDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<TeamFolderRenameDetails> Encoder = new TeamFolderRenameDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<TeamFolderRenameDetails> Decoder = new TeamFolderRenameDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="TeamFolderRenameDetails" />
        /// class.</para>
        /// </summary>
        /// <param name="previousFolderName">Previous folder name.</param>
        /// <param name="newFolderName">New folder name.</param>
        public TeamFolderRenameDetails(string previousFolderName,
                                       string newFolderName)
        {
            if (previousFolderName == null)
            {
                throw new sys.ArgumentNullException("previousFolderName");
            }

            if (newFolderName == null)
            {
                throw new sys.ArgumentNullException("newFolderName");
            }

            this.PreviousFolderName = previousFolderName;
            this.NewFolderName = newFolderName;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="TeamFolderRenameDetails" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public TeamFolderRenameDetails()
        {
        }

        /// <summary>
        /// <para>Previous folder name.</para>
        /// </summary>
        public string PreviousFolderName { get; protected set; }

        /// <summary>
        /// <para>New folder name.</para>
        /// </summary>
        public string NewFolderName { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="TeamFolderRenameDetails" />.</para>
        /// </summary>
        private class TeamFolderRenameDetailsEncoder : enc.StructEncoder<TeamFolderRenameDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(TeamFolderRenameDetails value, enc.IJsonWriter writer)
            {
                WriteProperty("previous_folder_name", value.PreviousFolderName, writer, enc.StringEncoder.Instance);
                WriteProperty("new_folder_name", value.NewFolderName, writer, enc.StringEncoder.Instance);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="TeamFolderRenameDetails" />.</para>
        /// </summary>
        private class TeamFolderRenameDetailsDecoder : enc.StructDecoder<TeamFolderRenameDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="TeamFolderRenameDetails"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override TeamFolderRenameDetails Create()
            {
                return new TeamFolderRenameDetails();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(TeamFolderRenameDetails value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "previous_folder_name":
                        value.PreviousFolderName = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "new_folder_name":
                        value.NewFolderName = enc.StringDecoder.Instance.Decode(reader);
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
