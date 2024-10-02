// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> The recommendation action of the machine or rule. </summary>
    public readonly partial struct RecommendationAction : IEquatable<RecommendationAction>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="RecommendationAction"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public RecommendationAction(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string RecommendedValue = "Recommended";
        private const string AddValue = "Add";
        private const string RemoveValue = "Remove";

        /// <summary> Recommended. </summary>
        public static RecommendationAction Recommended { get; } = new RecommendationAction(RecommendedValue);
        /// <summary> Add. </summary>
        public static RecommendationAction Add { get; } = new RecommendationAction(AddValue);
        /// <summary> Remove. </summary>
        public static RecommendationAction Remove { get; } = new RecommendationAction(RemoveValue);
        /// <summary> Determines if two <see cref="RecommendationAction"/> values are the same. </summary>
        public static bool operator ==(RecommendationAction left, RecommendationAction right) => left.Equals(right);
        /// <summary> Determines if two <see cref="RecommendationAction"/> values are not the same. </summary>
        public static bool operator !=(RecommendationAction left, RecommendationAction right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="RecommendationAction"/>. </summary>
        public static implicit operator RecommendationAction(string value) => new RecommendationAction(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is RecommendationAction other && Equals(other);
        /// <inheritdoc />
        public bool Equals(RecommendationAction other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
