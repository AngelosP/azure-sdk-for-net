// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.TrafficManager.Models
{
    /// <summary> The status of the endpoint. If the endpoint is Enabled, it is probed for endpoint health and is included in the traffic routing method. </summary>
    public readonly partial struct TrafficManagerEndpointStatus : IEquatable<TrafficManagerEndpointStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="TrafficManagerEndpointStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public TrafficManagerEndpointStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EnabledValue = "Enabled";
        private const string DisabledValue = "Disabled";

        /// <summary> Enabled. </summary>
        public static TrafficManagerEndpointStatus Enabled { get; } = new TrafficManagerEndpointStatus(EnabledValue);
        /// <summary> Disabled. </summary>
        public static TrafficManagerEndpointStatus Disabled { get; } = new TrafficManagerEndpointStatus(DisabledValue);
        /// <summary> Determines if two <see cref="TrafficManagerEndpointStatus"/> values are the same. </summary>
        public static bool operator ==(TrafficManagerEndpointStatus left, TrafficManagerEndpointStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="TrafficManagerEndpointStatus"/> values are not the same. </summary>
        public static bool operator !=(TrafficManagerEndpointStatus left, TrafficManagerEndpointStatus right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="TrafficManagerEndpointStatus"/>. </summary>
        public static implicit operator TrafficManagerEndpointStatus(string value) => new TrafficManagerEndpointStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is TrafficManagerEndpointStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(TrafficManagerEndpointStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
