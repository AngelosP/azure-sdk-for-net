// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DevCenter.Models
{
    /// <summary> The supported types for a scheduled task. </summary>
    public readonly partial struct DevCenterScheduledType : IEquatable<DevCenterScheduledType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DevCenterScheduledType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DevCenterScheduledType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string StopDevBoxValue = "StopDevBox";

        /// <summary> StopDevBox. </summary>
        public static DevCenterScheduledType StopDevBox { get; } = new DevCenterScheduledType(StopDevBoxValue);
        /// <summary> Determines if two <see cref="DevCenterScheduledType"/> values are the same. </summary>
        public static bool operator ==(DevCenterScheduledType left, DevCenterScheduledType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DevCenterScheduledType"/> values are not the same. </summary>
        public static bool operator !=(DevCenterScheduledType left, DevCenterScheduledType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="DevCenterScheduledType"/>. </summary>
        public static implicit operator DevCenterScheduledType(string value) => new DevCenterScheduledType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DevCenterScheduledType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DevCenterScheduledType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
