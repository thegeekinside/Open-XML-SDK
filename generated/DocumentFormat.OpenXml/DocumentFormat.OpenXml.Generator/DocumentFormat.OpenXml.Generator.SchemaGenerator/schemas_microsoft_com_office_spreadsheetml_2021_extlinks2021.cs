﻿// <auto-generated/>

// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#nullable enable

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Framework.Metadata;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation.Schema;
using System;
using System.Collections.Generic;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Office.SpreadSheetML.Y2021.ExtLinks2021
{
    /// <summary>
    /// <para>Defines the ExternalBookAlternateUrls Class.</para>
    /// <para>This class is available in Microsoft365 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xxl21:alternateUrls.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.SpreadSheetML.Y2021.ExtLinks2021.AbsoluteUrlAlternateUrl" /> <c>&lt;xxl21:absoluteUrl></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.SpreadSheetML.Y2021.ExtLinks2021.RelativeUrlAlternateUrl" /> <c>&lt;xxl21:relativeUrl></c></description></item>
    /// </list>
    /// </remark>
    public partial class ExternalBookAlternateUrls : TypedOpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ExternalBookAlternateUrls class.
        /// </summary>
        public ExternalBookAlternateUrls() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ExternalBookAlternateUrls class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ExternalBookAlternateUrls(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ExternalBookAlternateUrls class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ExternalBookAlternateUrls(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ExternalBookAlternateUrls class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ExternalBookAlternateUrls(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>driveId, this property is only available in Microsoft365 and later.</para>
        /// <para>Represents the following attribute in the schema: driveId</para>
        /// </summary>
        public StringValue? DriveId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>itemId, this property is only available in Microsoft365 and later.</para>
        /// <para>Represents the following attribute in the schema: itemId</para>
        /// </summary>
        public StringValue? ItemId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("xxl21:alternateUrls");
            builder.Availability = FileFormatVersions.Microsoft365;
            builder.AddChild<DocumentFormat.OpenXml.Office.SpreadSheetML.Y2021.ExtLinks2021.AbsoluteUrlAlternateUrl>();
            builder.AddChild<DocumentFormat.OpenXml.Office.SpreadSheetML.Y2021.ExtLinks2021.RelativeUrlAlternateUrl>();
            builder.AddElement<ExternalBookAlternateUrls>()
                .AddAttribute("driveId", a => a.DriveId)
                .AddAttribute("itemId", a => a.ItemId);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.SpreadSheetML.Y2021.ExtLinks2021.AbsoluteUrlAlternateUrl), 0, 1, version: FileFormatVersions.Microsoft365),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.SpreadSheetML.Y2021.ExtLinks2021.RelativeUrlAlternateUrl), 0, 1, version: FileFormatVersions.Microsoft365)
            };
        }

        /// <summary>
        /// <para>AbsoluteUrlAlternateUrl.</para>
        /// <para>Represents the following element tag in the schema: xxl21:absoluteUrl.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xxl21 = http://schemas.microsoft.com/office/spreadsheetml/2021/extlinks2021
        /// </remark>
        public DocumentFormat.OpenXml.Office.SpreadSheetML.Y2021.ExtLinks2021.AbsoluteUrlAlternateUrl? AbsoluteUrlAlternateUrl
        {
            get => GetElement<DocumentFormat.OpenXml.Office.SpreadSheetML.Y2021.ExtLinks2021.AbsoluteUrlAlternateUrl>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>RelativeUrlAlternateUrl.</para>
        /// <para>Represents the following element tag in the schema: xxl21:relativeUrl.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xxl21 = http://schemas.microsoft.com/office/spreadsheetml/2021/extlinks2021
        /// </remark>
        public DocumentFormat.OpenXml.Office.SpreadSheetML.Y2021.ExtLinks2021.RelativeUrlAlternateUrl? RelativeUrlAlternateUrl
        {
            get => GetElement<DocumentFormat.OpenXml.Office.SpreadSheetML.Y2021.ExtLinks2021.RelativeUrlAlternateUrl>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ExternalBookAlternateUrls>(deep);
    }

    /// <summary>
    /// <para>Defines the AbsoluteUrlAlternateUrl Class.</para>
    /// <para>This class is available in Microsoft365 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xxl21:absoluteUrl.</para>
    /// </summary>
    public partial class AbsoluteUrlAlternateUrl : OpenXmlAlternateUrlElement
    {
        /// <summary>
        /// Initializes a new instance of the AbsoluteUrlAlternateUrl class.
        /// </summary>
        public AbsoluteUrlAlternateUrl() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("xxl21:absoluteUrl");
            builder.Availability = FileFormatVersions.Microsoft365;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<AbsoluteUrlAlternateUrl>(deep);
    }

    /// <summary>
    /// <para>Defines the RelativeUrlAlternateUrl Class.</para>
    /// <para>This class is available in Microsoft365 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xxl21:relativeUrl.</para>
    /// </summary>
    public partial class RelativeUrlAlternateUrl : OpenXmlAlternateUrlElement
    {
        /// <summary>
        /// Initializes a new instance of the RelativeUrlAlternateUrl class.
        /// </summary>
        public RelativeUrlAlternateUrl() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("xxl21:relativeUrl");
            builder.Availability = FileFormatVersions.Microsoft365;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RelativeUrlAlternateUrl>(deep);
    }

    /// <summary>
    /// <para>Defines the OpenXmlAlternateUrlElement Class.</para>
    /// <para>This class is available in Microsoft365 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    public abstract partial class OpenXmlAlternateUrlElement : TypedOpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the OpenXmlAlternateUrlElement class.
        /// </summary>
        protected OpenXmlAlternateUrlElement() : base()
        {
        }

        /// <summary>
        /// <para>id, this property is only available in Microsoft365 and later.</para>
        /// <para>Represents the following attribute in the schema: r:id</para>
        /// </summary>
        /// <remark>
        /// xmlns:r=http://schemas.openxmlformats.org/officeDocument/2006/relationships
        /// </remark>
        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddElement<OpenXmlAlternateUrlElement>()
                .AddAttribute("r:id", a => a.Id, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                });
        }
    }
}