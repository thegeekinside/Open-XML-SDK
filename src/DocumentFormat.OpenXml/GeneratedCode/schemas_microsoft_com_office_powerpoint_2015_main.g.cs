﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Framework.Metadata;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation.Schema;
using System;
using System.Collections.Generic;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Office2016.Presentation
{
    /// <summary>
    /// <para>Defines the DesignElement Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p16:designElem.</para>
    /// </summary>
    [SchemaAttr("p16:designElem")]
    public partial class DesignElement : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the DesignElement class.
        /// </summary>
        public DesignElement() : base()
        {
        }

        /// <summary>
        /// <para>val, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>
        [SchemaAttr("val")]
        public BooleanValue? Val
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("p16:designElem");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddElement<DesignElement>()
                .AddAttribute("val", a => a.Val);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DesignElement>(deep);
    }
}