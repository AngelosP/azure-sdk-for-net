// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.GuestConfiguration.Models
{
    /// <summary> Kind of the guest configuration. For example:DSC. </summary>
    public readonly partial struct GuestConfigurationKind : IEquatable<GuestConfigurationKind>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="GuestConfigurationKind"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public GuestConfigurationKind(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DscValue = "DSC";

        /// <summary> DSC. </summary>
        public static GuestConfigurationKind Dsc { get; } = new GuestConfigurationKind(DscValue);
        /// <summary> Determines if two <see cref="GuestConfigurationKind"/> values are the same. </summary>
        public static bool operator ==(GuestConfigurationKind left, GuestConfigurationKind right) => left.Equals(right);
        /// <summary> Determines if two <see cref="GuestConfigurationKind"/> values are not the same. </summary>
        public static bool operator !=(GuestConfigurationKind left, GuestConfigurationKind right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="GuestConfigurationKind"/>. </summary>
        public static implicit operator GuestConfigurationKind(string value) => new GuestConfigurationKind(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is GuestConfigurationKind other && Equals(other);
        /// <inheritdoc />
        public bool Equals(GuestConfigurationKind other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
