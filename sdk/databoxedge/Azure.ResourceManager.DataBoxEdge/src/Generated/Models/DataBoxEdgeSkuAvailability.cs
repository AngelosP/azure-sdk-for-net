// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    /// <summary> Links to the next set of results. </summary>
    public readonly partial struct DataBoxEdgeSkuAvailability : IEquatable<DataBoxEdgeSkuAvailability>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DataBoxEdgeSkuAvailability"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DataBoxEdgeSkuAvailability(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AvailableValue = "Available";
        private const string UnavailableValue = "Unavailable";

        /// <summary> Available. </summary>
        public static DataBoxEdgeSkuAvailability Available { get; } = new DataBoxEdgeSkuAvailability(AvailableValue);
        /// <summary> Unavailable. </summary>
        public static DataBoxEdgeSkuAvailability Unavailable { get; } = new DataBoxEdgeSkuAvailability(UnavailableValue);
        /// <summary> Determines if two <see cref="DataBoxEdgeSkuAvailability"/> values are the same. </summary>
        public static bool operator ==(DataBoxEdgeSkuAvailability left, DataBoxEdgeSkuAvailability right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DataBoxEdgeSkuAvailability"/> values are not the same. </summary>
        public static bool operator !=(DataBoxEdgeSkuAvailability left, DataBoxEdgeSkuAvailability right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="DataBoxEdgeSkuAvailability"/>. </summary>
        public static implicit operator DataBoxEdgeSkuAvailability(string value) => new DataBoxEdgeSkuAvailability(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DataBoxEdgeSkuAvailability other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DataBoxEdgeSkuAvailability other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
