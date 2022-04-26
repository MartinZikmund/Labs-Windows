// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Text;

namespace CommunityToolkit.Labs.Core.SourceGenerators.Metadata;

// Can't use record as not supported in YamlDotNet yet, https://github.com/aaubry/YamlDotNet/issues/571
public class DocsFrontMatter 
{
    public string? Title { get; set; }
    public string? Author { get; set; }
    public string? Description { get; set; }
    public string? Keywords { get; set; }
}

public sealed class ToolkitFrontMatter : DocsFrontMatter
{
    public ToolkitSampleCategory Category { get; set; }
    public ToolkitSampleSubcategory Subcategory { get; set; }
    public string? FilePath { get; set; }
}