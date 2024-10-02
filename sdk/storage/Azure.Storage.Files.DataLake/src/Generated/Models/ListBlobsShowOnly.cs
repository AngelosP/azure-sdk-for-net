// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Storage.Files.DataLake.Models
{
    /// <summary> The ListBlobsShowOnly. </summary>
    internal readonly partial struct ListBlobsShowOnly : IEquatable<ListBlobsShowOnly>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ListBlobsShowOnly"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ListBlobsShowOnly(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DeletedValue = "deleted";

        /// <summary> deleted. </summary>
        public static ListBlobsShowOnly Deleted { get; } = new ListBlobsShowOnly(DeletedValue);
        /// <summary> Determines if two <see cref="ListBlobsShowOnly"/> values are the same. </summary>
        public static bool operator ==(ListBlobsShowOnly left, ListBlobsShowOnly right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ListBlobsShowOnly"/> values are not the same. </summary>
        public static bool operator !=(ListBlobsShowOnly left, ListBlobsShowOnly right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ListBlobsShowOnly"/>. </summary>
        public static implicit operator ListBlobsShowOnly(string value) => new ListBlobsShowOnly(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ListBlobsShowOnly other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ListBlobsShowOnly other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
