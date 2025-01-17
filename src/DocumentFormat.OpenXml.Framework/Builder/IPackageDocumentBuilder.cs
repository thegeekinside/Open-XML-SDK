﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#if NET7_0_OR_GREATER

using DocumentFormat.OpenXml.Packaging;

namespace DocumentFormat.OpenXml.Builder;

/// <summary>
/// An interface that exposes ability to create a builder for <typeparamref name="TPackage"/>.
/// </summary>
/// <typeparam name="TPackage">Type of <see cref="OpenXmlPackage"/>.</typeparam>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Design", "CA1000:Do not declare static members on generic types", Justification = "Static abstract interface types")]
public interface IPackageDocumentBuilder<TPackage> where TPackage : OpenXmlPackage, IPackageDocumentBuilder<TPackage>
{
    /// <summary>
    /// Creates a default builder for <typeparamref name="TPackage"/>.
    /// </summary>
    /// <returns>The default builder.</returns>
    static abstract IPackageBuilder<TPackage> CreateDefaultBuilder();

    /// <summary>
    /// Creates a builder that has minimal initialization for <typeparamref name="TPackage"/>.
    /// </summary>
    /// <returns>A minimal builder.</returns>
    static abstract IPackageBuilder<TPackage> CreateBuilder();
}

#endif
