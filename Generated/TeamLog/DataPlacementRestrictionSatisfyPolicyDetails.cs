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
    /// <para>Completed restrictions on data center locations where team data resides.</para>
    /// </summary>
    public class DataPlacementRestrictionSatisfyPolicyDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<DataPlacementRestrictionSatisfyPolicyDetails> Encoder = new DataPlacementRestrictionSatisfyPolicyDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<DataPlacementRestrictionSatisfyPolicyDetails> Decoder = new DataPlacementRestrictionSatisfyPolicyDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see
        /// cref="DataPlacementRestrictionSatisfyPolicyDetails" /> class.</para>
        /// </summary>
        /// <param name="placementRestriction">Placement restriction.</param>
        public DataPlacementRestrictionSatisfyPolicyDetails(PlacementRestriction placementRestriction)
        {
            if (placementRestriction == null)
            {
                throw new sys.ArgumentNullException("placementRestriction");
            }

            this.PlacementRestriction = placementRestriction;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see
        /// cref="DataPlacementRestrictionSatisfyPolicyDetails" /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public DataPlacementRestrictionSatisfyPolicyDetails()
        {
        }

        /// <summary>
        /// <para>Placement restriction.</para>
        /// </summary>
        public PlacementRestriction PlacementRestriction { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="DataPlacementRestrictionSatisfyPolicyDetails"
        /// />.</para>
        /// </summary>
        private class DataPlacementRestrictionSatisfyPolicyDetailsEncoder : enc.StructEncoder<DataPlacementRestrictionSatisfyPolicyDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(DataPlacementRestrictionSatisfyPolicyDetails value, enc.IJsonWriter writer)
            {
                WriteProperty("placement_restriction", value.PlacementRestriction, writer, global::Dropbox.Api.TeamLog.PlacementRestriction.Encoder);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="DataPlacementRestrictionSatisfyPolicyDetails"
        /// />.</para>
        /// </summary>
        private class DataPlacementRestrictionSatisfyPolicyDetailsDecoder : enc.StructDecoder<DataPlacementRestrictionSatisfyPolicyDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see
            /// cref="DataPlacementRestrictionSatisfyPolicyDetails" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override DataPlacementRestrictionSatisfyPolicyDetails Create()
            {
                return new DataPlacementRestrictionSatisfyPolicyDetails();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(DataPlacementRestrictionSatisfyPolicyDetails value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "placement_restriction":
                        value.PlacementRestriction = global::Dropbox.Api.TeamLog.PlacementRestriction.Decoder.Decode(reader);
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
