// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Advisor.Models
{
    /// <summary> The Category. </summary>
    public readonly partial struct Category : IEquatable<Category>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="Category"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public Category(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string HighAvailabilityValue = "HighAvailability";
        private const string SecurityValue = "Security";
        private const string PerformanceValue = "Performance";
        private const string CostValue = "Cost";
        private const string OperationalExcellenceValue = "OperationalExcellence";

        /// <summary> HighAvailability. </summary>
        public static Category HighAvailability { get; } = new Category(HighAvailabilityValue);
        /// <summary> Security. </summary>
        public static Category Security { get; } = new Category(SecurityValue);
        /// <summary> Performance. </summary>
        public static Category Performance { get; } = new Category(PerformanceValue);
        /// <summary> Cost. </summary>
        public static Category Cost { get; } = new Category(CostValue);
        /// <summary> OperationalExcellence. </summary>
        public static Category OperationalExcellence { get; } = new Category(OperationalExcellenceValue);
        /// <summary> Determines if two <see cref="Category"/> values are the same. </summary>
        public static bool operator ==(Category left, Category right) => left.Equals(right);
        /// <summary> Determines if two <see cref="Category"/> values are not the same. </summary>
        public static bool operator !=(Category left, Category right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="Category"/>. </summary>
        public static implicit operator Category(string value) => new Category(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is Category other && Equals(other);
        /// <inheritdoc />
        public bool Equals(Category other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
