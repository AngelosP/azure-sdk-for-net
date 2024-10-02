// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.HybridCompute.Models
{
    /// <summary> Severity of the provisioning issue. </summary>
    public readonly partial struct HybridComputeProvisioningIssueSeverity : IEquatable<HybridComputeProvisioningIssueSeverity>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="HybridComputeProvisioningIssueSeverity"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public HybridComputeProvisioningIssueSeverity(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string WarningValue = "Warning";
        private const string ErrorValue = "Error";

        /// <summary> Warnings can cause connectivity issues after provisioning succeeds. </summary>
        public static HybridComputeProvisioningIssueSeverity Warning { get; } = new HybridComputeProvisioningIssueSeverity(WarningValue);
        /// <summary> Errors will cause association provisioning to fail. </summary>
        public static HybridComputeProvisioningIssueSeverity Error { get; } = new HybridComputeProvisioningIssueSeverity(ErrorValue);
        /// <summary> Determines if two <see cref="HybridComputeProvisioningIssueSeverity"/> values are the same. </summary>
        public static bool operator ==(HybridComputeProvisioningIssueSeverity left, HybridComputeProvisioningIssueSeverity right) => left.Equals(right);
        /// <summary> Determines if two <see cref="HybridComputeProvisioningIssueSeverity"/> values are not the same. </summary>
        public static bool operator !=(HybridComputeProvisioningIssueSeverity left, HybridComputeProvisioningIssueSeverity right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="HybridComputeProvisioningIssueSeverity"/>. </summary>
        public static implicit operator HybridComputeProvisioningIssueSeverity(string value) => new HybridComputeProvisioningIssueSeverity(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is HybridComputeProvisioningIssueSeverity other && Equals(other);
        /// <inheritdoc />
        public bool Equals(HybridComputeProvisioningIssueSeverity other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
