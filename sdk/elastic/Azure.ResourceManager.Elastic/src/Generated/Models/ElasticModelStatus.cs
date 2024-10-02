// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Elastic.Models
{
    /// <summary> The state of monitoring. </summary>
    public readonly partial struct ElasticModelStatus : IEquatable<ElasticModelStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ElasticModelStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ElasticModelStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string InProgressValue = "InProgress";
        private const string ActiveValue = "Active";
        private const string FailedValue = "Failed";
        private const string DeletingValue = "Deleting";

        /// <summary> InProgress. </summary>
        public static ElasticModelStatus InProgress { get; } = new ElasticModelStatus(InProgressValue);
        /// <summary> Active. </summary>
        public static ElasticModelStatus Active { get; } = new ElasticModelStatus(ActiveValue);
        /// <summary> Failed. </summary>
        public static ElasticModelStatus Failed { get; } = new ElasticModelStatus(FailedValue);
        /// <summary> Deleting. </summary>
        public static ElasticModelStatus Deleting { get; } = new ElasticModelStatus(DeletingValue);
        /// <summary> Determines if two <see cref="ElasticModelStatus"/> values are the same. </summary>
        public static bool operator ==(ElasticModelStatus left, ElasticModelStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ElasticModelStatus"/> values are not the same. </summary>
        public static bool operator !=(ElasticModelStatus left, ElasticModelStatus right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ElasticModelStatus"/>. </summary>
        public static implicit operator ElasticModelStatus(string value) => new ElasticModelStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ElasticModelStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ElasticModelStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
