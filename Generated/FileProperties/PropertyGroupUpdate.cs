// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.FileProperties
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>The property group update object</para>
    /// </summary>
    public class PropertyGroupUpdate
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<PropertyGroupUpdate> Encoder = new PropertyGroupUpdateEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<PropertyGroupUpdate> Decoder = new PropertyGroupUpdateDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="PropertyGroupUpdate" />
        /// class.</para>
        /// </summary>
        /// <param name="templateId">A unique identifier for a property template.</param>
        /// <param name="addOrUpdateFields">Property fields to update. If the property field
        /// already exists, it is updated. If the property field doesn't exist, the property
        /// group is added.</param>
        /// <param name="removeFields">Property fields to remove (by name), provided they
        /// exist.</param>
        public PropertyGroupUpdate(string templateId,
                                   col.IEnumerable<PropertyField> addOrUpdateFields = null,
                                   col.IEnumerable<string> removeFields = null)
        {
            if (templateId == null)
            {
                throw new sys.ArgumentNullException("templateId");
            }
            if (templateId.Length < 1)
            {
                throw new sys.ArgumentOutOfRangeException("templateId", "Length should be at least 1");
            }
            if (!re.Regex.IsMatch(templateId, @"\A(?:(/|ptid:).*)\z"))
            {
                throw new sys.ArgumentOutOfRangeException("templateId", @"Value should match pattern '\A(?:(/|ptid:).*)\z'");
            }

            var addOrUpdateFieldsList = enc.Util.ToList(addOrUpdateFields);

            var removeFieldsList = enc.Util.ToList(removeFields);

            this.TemplateId = templateId;
            this.AddOrUpdateFields = addOrUpdateFieldsList;
            this.RemoveFields = removeFieldsList;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="PropertyGroupUpdate" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public PropertyGroupUpdate()
        {
        }

        /// <summary>
        /// <para>A unique identifier for a property template.</para>
        /// </summary>
        public string TemplateId { get; protected set; }

        /// <summary>
        /// <para>Property fields to update. If the property field already exists, it is
        /// updated. If the property field doesn't exist, the property group is added.</para>
        /// </summary>
        public col.IList<PropertyField> AddOrUpdateFields { get; protected set; }

        /// <summary>
        /// <para>Property fields to remove (by name), provided they exist.</para>
        /// </summary>
        public col.IList<string> RemoveFields { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="PropertyGroupUpdate" />.</para>
        /// </summary>
        private class PropertyGroupUpdateEncoder : enc.StructEncoder<PropertyGroupUpdate>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(PropertyGroupUpdate value, enc.IJsonWriter writer)
            {
                WriteProperty("template_id", value.TemplateId, writer, enc.StringEncoder.Instance);
                if (value.AddOrUpdateFields.Count > 0)
                {
                    WriteListProperty("add_or_update_fields", value.AddOrUpdateFields, writer, global::Dropbox.Api.FileProperties.PropertyField.Encoder);
                }
                if (value.RemoveFields.Count > 0)
                {
                    WriteListProperty("remove_fields", value.RemoveFields, writer, enc.StringEncoder.Instance);
                }
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="PropertyGroupUpdate" />.</para>
        /// </summary>
        private class PropertyGroupUpdateDecoder : enc.StructDecoder<PropertyGroupUpdate>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="PropertyGroupUpdate" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override PropertyGroupUpdate Create()
            {
                return new PropertyGroupUpdate();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(PropertyGroupUpdate value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "template_id":
                        value.TemplateId = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "add_or_update_fields":
                        value.AddOrUpdateFields = ReadList<PropertyField>(reader, global::Dropbox.Api.FileProperties.PropertyField.Decoder);
                        break;
                    case "remove_fields":
                        value.RemoveFields = ReadList<string>(reader, enc.StringDecoder.Instance);
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
