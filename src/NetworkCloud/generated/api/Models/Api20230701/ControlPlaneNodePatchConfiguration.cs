// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20230701
{
    using static Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Extensions;

    /// <summary>
    /// ControlPlaneNodePatchConfiguration represents the properties of the control plane that can be patched for this Kubernetes
    /// cluster.
    /// </summary>
    public partial class ControlPlaneNodePatchConfiguration :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20230701.IControlPlaneNodePatchConfiguration,
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20230701.IControlPlaneNodePatchConfigurationInternal
    {

        /// <summary>Backing field for <see cref="Count" /> property.</summary>
        private long? _count;

        /// <summary>The number of virtual machines that use this configuration.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.PropertyOrigin.Owned)]
        public long? Count { get => this._count; set => this._count = value; }

        /// <summary>Creates an new <see cref="ControlPlaneNodePatchConfiguration" /> instance.</summary>
        public ControlPlaneNodePatchConfiguration()
        {

        }
    }
    /// ControlPlaneNodePatchConfiguration represents the properties of the control plane that can be patched for this Kubernetes
    /// cluster.
    public partial interface IControlPlaneNodePatchConfiguration :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.IJsonSerializable
    {
        /// <summary>The number of virtual machines that use this configuration.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The number of virtual machines that use this configuration.",
        SerializedName = @"count",
        PossibleTypes = new [] { typeof(long) })]
        long? Count { get; set; }

    }
    /// ControlPlaneNodePatchConfiguration represents the properties of the control plane that can be patched for this Kubernetes
    /// cluster.
    internal partial interface IControlPlaneNodePatchConfigurationInternal

    {
        /// <summary>The number of virtual machines that use this configuration.</summary>
        long? Count { get; set; }

    }
}