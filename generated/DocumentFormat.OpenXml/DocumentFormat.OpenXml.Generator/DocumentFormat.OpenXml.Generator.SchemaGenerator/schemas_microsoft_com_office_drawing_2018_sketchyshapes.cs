﻿// <auto-generated/>

// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#nullable enable

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Framework.Metadata;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation.Schema;
using System;
using System.Collections.Generic;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes
{
    /// <summary>
    /// <para>Defines the LineSketchNoneEmpty Class.</para>
    /// <para>This class is available in Office 2021 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is ask:lineSketchNone.</para>
    /// </summary>
    public partial class LineSketchNoneEmpty : OpenXmlEmptyElement
    {
        /// <summary>
        /// Initializes a new instance of the LineSketchNoneEmpty class.
        /// </summary>
        public LineSketchNoneEmpty() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("ask:lineSketchNone");
            builder.Availability = FileFormatVersions.Office2021;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<LineSketchNoneEmpty>(deep);
    }

    /// <summary>
    /// <para>Defines the LineSketchCurvedEmpty Class.</para>
    /// <para>This class is available in Office 2021 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is ask:lineSketchCurved.</para>
    /// </summary>
    public partial class LineSketchCurvedEmpty : OpenXmlEmptyElement
    {
        /// <summary>
        /// Initializes a new instance of the LineSketchCurvedEmpty class.
        /// </summary>
        public LineSketchCurvedEmpty() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("ask:lineSketchCurved");
            builder.Availability = FileFormatVersions.Office2021;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<LineSketchCurvedEmpty>(deep);
    }

    /// <summary>
    /// <para>Defines the LineSketchFreehandEmpty Class.</para>
    /// <para>This class is available in Office 2021 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is ask:lineSketchFreehand.</para>
    /// </summary>
    public partial class LineSketchFreehandEmpty : OpenXmlEmptyElement
    {
        /// <summary>
        /// Initializes a new instance of the LineSketchFreehandEmpty class.
        /// </summary>
        public LineSketchFreehandEmpty() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("ask:lineSketchFreehand");
            builder.Availability = FileFormatVersions.Office2021;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<LineSketchFreehandEmpty>(deep);
    }

    /// <summary>
    /// <para>Defines the LineSketchScribbleEmpty Class.</para>
    /// <para>This class is available in Office 2021 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is ask:lineSketchScribble.</para>
    /// </summary>
    public partial class LineSketchScribbleEmpty : OpenXmlEmptyElement
    {
        /// <summary>
        /// Initializes a new instance of the LineSketchScribbleEmpty class.
        /// </summary>
        public LineSketchScribbleEmpty() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("ask:lineSketchScribble");
            builder.Availability = FileFormatVersions.Office2021;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<LineSketchScribbleEmpty>(deep);
    }

    /// <summary>
    /// <para>Defines the OpenXmlEmptyElement Class.</para>
    /// <para>This class is available in Office 2021 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    public abstract partial class OpenXmlEmptyElement : TypedOpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the OpenXmlEmptyElement class.
        /// </summary>
        protected OpenXmlEmptyElement() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
        }
    }

    /// <summary>
    /// <para>Defines the LineSketchStyleProperties Class.</para>
    /// <para>This class is available in Office 2021 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is ask:lineSketchStyleProps.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.CustomGeometry" /> <c>&lt;a:custGeom></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.OfficeArtExtensionList" /> <c>&lt;ask:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.PresetGeometry" /> <c>&lt;a:prstGeom></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.LineSketchTypeProperties" /> <c>&lt;ask:type></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.LineSketchSeed" /> <c>&lt;ask:seed></c></description></item>
    /// </list>
    /// </remark>
    public partial class LineSketchStyleProperties : TypedOpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the LineSketchStyleProperties class.
        /// </summary>
        public LineSketchStyleProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the LineSketchStyleProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public LineSketchStyleProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the LineSketchStyleProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public LineSketchStyleProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the LineSketchStyleProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public LineSketchStyleProperties(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>sd, this property is only available in Office 2021 and later.</para>
        /// <para>Represents the following attribute in the schema: sd</para>
        /// </summary>
        public UInt32Value? Sd
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("ask:lineSketchStyleProps");
            builder.Availability = FileFormatVersions.Office2021;
            builder.AddChild<DocumentFormat.OpenXml.Drawing.CustomGeometry>();
            builder.AddChild<DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.OfficeArtExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.PresetGeometry>();
            builder.AddChild<DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.LineSketchTypeProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.LineSketchSeed>();
            builder.AddElement<LineSketchStyleProperties>()
                .AddAttribute("sd", a => a.Sd);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle.Builder(ParticleType.Group, 0, 1)
                {
                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.CustomGeometry), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.PresetGeometry), 1, 1)
                    }
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.LineSketchTypeProperties), 0, 1, version: FileFormatVersions.Office2021),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.LineSketchSeed), 0, 1, version: FileFormatVersions.Office2021),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.OfficeArtExtensionList), 0, 1, version: FileFormatVersions.Office2021)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<LineSketchStyleProperties>(deep);
    }

    /// <summary>
    /// <para>Defines the LineSketchTypeProperties Class.</para>
    /// <para>This class is available in Office 2021 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is ask:type.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.LineSketchNoneEmpty" /> <c>&lt;ask:lineSketchNone></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.LineSketchCurvedEmpty" /> <c>&lt;ask:lineSketchCurved></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.LineSketchFreehandEmpty" /> <c>&lt;ask:lineSketchFreehand></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.LineSketchScribbleEmpty" /> <c>&lt;ask:lineSketchScribble></c></description></item>
    /// </list>
    /// </remark>
    public partial class LineSketchTypeProperties : TypedOpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the LineSketchTypeProperties class.
        /// </summary>
        public LineSketchTypeProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the LineSketchTypeProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public LineSketchTypeProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the LineSketchTypeProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public LineSketchTypeProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the LineSketchTypeProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public LineSketchTypeProperties(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("ask:type");
            builder.Availability = FileFormatVersions.Office2021;
            builder.AddChild<DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.LineSketchNoneEmpty>();
            builder.AddChild<DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.LineSketchCurvedEmpty>();
            builder.AddChild<DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.LineSketchFreehandEmpty>();
            builder.AddChild<DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.LineSketchScribbleEmpty>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle.Builder(ParticleType.Group, 0, 1, version: FileFormatVersions.Office2021)
                {
                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.LineSketchNoneEmpty), 1, 1, version: FileFormatVersions.Office2021),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.LineSketchCurvedEmpty), 1, 1, version: FileFormatVersions.Office2021),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.LineSketchFreehandEmpty), 1, 1, version: FileFormatVersions.Office2021),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.LineSketchScribbleEmpty), 1, 1, version: FileFormatVersions.Office2021)
                    }
                }
            };
        }

        /// <summary>
        /// <para>LineSketchNoneEmpty.</para>
        /// <para>Represents the following element tag in the schema: ask:lineSketchNone.</para>
        /// </summary>
        /// <remark>
        /// xmlns:ask = http://schemas.microsoft.com/office/drawing/2018/sketchyshapes
        /// </remark>
        public DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.LineSketchNoneEmpty? LineSketchNoneEmpty
        {
            get => GetElement<DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.LineSketchNoneEmpty>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>LineSketchCurvedEmpty.</para>
        /// <para>Represents the following element tag in the schema: ask:lineSketchCurved.</para>
        /// </summary>
        /// <remark>
        /// xmlns:ask = http://schemas.microsoft.com/office/drawing/2018/sketchyshapes
        /// </remark>
        public DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.LineSketchCurvedEmpty? LineSketchCurvedEmpty
        {
            get => GetElement<DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.LineSketchCurvedEmpty>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>LineSketchFreehandEmpty.</para>
        /// <para>Represents the following element tag in the schema: ask:lineSketchFreehand.</para>
        /// </summary>
        /// <remark>
        /// xmlns:ask = http://schemas.microsoft.com/office/drawing/2018/sketchyshapes
        /// </remark>
        public DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.LineSketchFreehandEmpty? LineSketchFreehandEmpty
        {
            get => GetElement<DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.LineSketchFreehandEmpty>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>LineSketchScribbleEmpty.</para>
        /// <para>Represents the following element tag in the schema: ask:lineSketchScribble.</para>
        /// </summary>
        /// <remark>
        /// xmlns:ask = http://schemas.microsoft.com/office/drawing/2018/sketchyshapes
        /// </remark>
        public DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.LineSketchScribbleEmpty? LineSketchScribbleEmpty
        {
            get => GetElement<DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.LineSketchScribbleEmpty>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<LineSketchTypeProperties>(deep);
    }

    /// <summary>
    /// <para>Defines the LineSketchSeed Class.</para>
    /// <para>This class is available in Office 2021 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is ask:seed.</para>
    /// </summary>
    public partial class LineSketchSeed : TypedOpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the LineSketchSeed class.
        /// </summary>
        public LineSketchSeed() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the LineSketchSeed class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public LineSketchSeed(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new UInt32Value { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator<UInt32Value>(NumberValidator.Instance);
            builder.SetSchema("ask:seed");
            builder.Availability = FileFormatVersions.Office2021;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<LineSketchSeed>(deep);
    }

    /// <summary>
    /// <para>Defines the OfficeArtExtensionList Class.</para>
    /// <para>This class is available in Office 2021 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is ask:extLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Extension" /> <c>&lt;a:ext></c></description></item>
    /// </list>
    /// </remark>
    public partial class OfficeArtExtensionList : TypedOpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the OfficeArtExtensionList class.
        /// </summary>
        public OfficeArtExtensionList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the OfficeArtExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public OfficeArtExtensionList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the OfficeArtExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public OfficeArtExtensionList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the OfficeArtExtensionList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public OfficeArtExtensionList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("ask:extLst");
            builder.Availability = FileFormatVersions.Office2021;
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Extension>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle.Builder(ParticleType.Group, 1, 1)
                {
                    new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Extension), 0, 0)
                    }
                }
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<OfficeArtExtensionList>(deep);
    }
}