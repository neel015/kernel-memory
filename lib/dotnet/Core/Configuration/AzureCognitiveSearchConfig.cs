﻿// Copyright (c) Microsoft. All rights reserved.

namespace Microsoft.SemanticKernel.SemanticMemory.Core.Configuration;

public class AzureCognitiveSearchConfig
{
    public string Endpoint { get; set; } = string.Empty;
    public string APIKey { get; set; } = string.Empty;
}