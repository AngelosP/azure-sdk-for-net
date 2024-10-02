// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DeviceUpdate.Models
{
    /// <summary> The current provisioning state. </summary>
    public readonly partial struct DeviceUpdatePrivateEndpointConnectionProvisioningState : IEquatable<DeviceUpdatePrivateEndpointConnectionProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DeviceUpdatePrivateEndpointConnectionProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DeviceUpdatePrivateEndpointConnectionProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SucceededValue = "Succeeded";
        private const string CreatingValue = "Creating";
        private const string DeletingValue = "Deleting";
        private const string FailedValue = "Failed";

        /// <summary> Succeeded. </summary>
        public static DeviceUpdatePrivateEndpointConnectionProvisioningState Succeeded { get; } = new DeviceUpdatePrivateEndpointConnectionProvisioningState(SucceededValue);
        /// <summary> Creating. </summary>
        public static DeviceUpdatePrivateEndpointConnectionProvisioningState Creating { get; } = new DeviceUpdatePrivateEndpointConnectionProvisioningState(CreatingValue);
        /// <summary> Deleting. </summary>
        public static DeviceUpdatePrivateEndpointConnectionProvisioningState Deleting { get; } = new DeviceUpdatePrivateEndpointConnectionProvisioningState(DeletingValue);
        /// <summary> Failed. </summary>
        public static DeviceUpdatePrivateEndpointConnectionProvisioningState Failed { get; } = new DeviceUpdatePrivateEndpointConnectionProvisioningState(FailedValue);
        /// <summary> Determines if two <see cref="DeviceUpdatePrivateEndpointConnectionProvisioningState"/> values are the same. </summary>
        public static bool operator ==(DeviceUpdatePrivateEndpointConnectionProvisioningState left, DeviceUpdatePrivateEndpointConnectionProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DeviceUpdatePrivateEndpointConnectionProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(DeviceUpdatePrivateEndpointConnectionProvisioningState left, DeviceUpdatePrivateEndpointConnectionProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="DeviceUpdatePrivateEndpointConnectionProvisioningState"/>. </summary>
        public static implicit operator DeviceUpdatePrivateEndpointConnectionProvisioningState(string value) => new DeviceUpdatePrivateEndpointConnectionProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DeviceUpdatePrivateEndpointConnectionProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DeviceUpdatePrivateEndpointConnectionProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
