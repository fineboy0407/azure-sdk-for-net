// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.RecoveryServices;

namespace Azure.ResourceManager.RecoveryServices.Models
{
    /// <summary> The response model for a list of Vaults. </summary>
    internal partial class VaultList
    {
        /// <summary> Initializes a new instance of VaultList. </summary>
        internal VaultList()
        {
            Value = new ChangeTrackingList<VaultData>();
        }

        /// <summary> Initializes a new instance of VaultList. </summary>
        /// <param name="value"></param>
        /// <param name="nextLink"></param>
        internal VaultList(IReadOnlyList<VaultData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Gets the value. </summary>
        public IReadOnlyList<VaultData> Value { get; }
        /// <summary> Gets the next link. </summary>
        public string NextLink { get; }
    }
}
