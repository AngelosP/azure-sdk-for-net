// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Pipeline reference type. </summary>
    public readonly partial struct PipelineReferenceType : IEquatable<PipelineReferenceType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="PipelineReferenceType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public PipelineReferenceType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PipelineReferenceValue = "PipelineReference";

        /// <summary> PipelineReference. </summary>
        public static PipelineReferenceType PipelineReference { get; } = new PipelineReferenceType(PipelineReferenceValue);
        /// <summary> Determines if two <see cref="PipelineReferenceType"/> values are the same. </summary>
        public static bool operator ==(PipelineReferenceType left, PipelineReferenceType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PipelineReferenceType"/> values are not the same. </summary>
        public static bool operator !=(PipelineReferenceType left, PipelineReferenceType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="PipelineReferenceType"/>. </summary>
        public static implicit operator PipelineReferenceType(string value) => new PipelineReferenceType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PipelineReferenceType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PipelineReferenceType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
