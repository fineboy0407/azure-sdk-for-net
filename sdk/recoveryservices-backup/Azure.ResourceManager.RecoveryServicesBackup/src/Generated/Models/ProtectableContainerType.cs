// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary>
    /// Type of the container. The value of this property for
    /// 1. Compute Azure VM is Microsoft.Compute/virtualMachines
    /// 2. Classic Compute Azure VM is Microsoft.ClassicCompute/virtualMachines
    /// </summary>
    internal enum ProtectableContainerType
    {
        /// <summary> Unknown. </summary>
        Unknown,
        /// <summary> Invalid. </summary>
        Invalid,
        /// <summary> IaasVMContainer. </summary>
        IaasVmContainer,
        /// <summary> IaasVMServiceContainer. </summary>
        IaasVmServiceContainer,
        /// <summary> DPMContainer. </summary>
        DpmContainer,
        /// <summary> AzureBackupServerContainer. </summary>
        AzureBackupServerContainer,
        /// <summary> MABContainer. </summary>
        MabContainer,
        /// <summary> Cluster. </summary>
        Cluster,
        /// <summary> AzureSqlContainer. </summary>
        AzureSqlContainer,
        /// <summary> Windows. </summary>
        Windows,
        /// <summary> VCenter. </summary>
        VCenter,
        /// <summary> VMAppContainer. </summary>
        VmAppContainer,
        /// <summary> SQLAGWorkLoadContainer. </summary>
        SqlAGWorkLoadContainer,
        /// <summary> StorageContainer. </summary>
        StorageContainer,
        /// <summary> GenericContainer. </summary>
        GenericContainer,
        /// <summary> Microsoft.ClassicCompute/virtualMachines. </summary>
        MicrosoftClassicComputeVirtualMachines,
        /// <summary> Microsoft.Compute/virtualMachines. </summary>
        MicrosoftComputeVirtualMachines,
        /// <summary> AzureWorkloadContainer. </summary>
        AzureWorkloadContainer
    }
}
